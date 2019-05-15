using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
public struct demand
{//存储在外部输入的需求
    public Direction tar_direction;
    public int tar_floor;
    public demand(Direction d, int f)
    {
        tar_direction = d;
        tar_floor = f;
    }
}
namespace 电梯调度
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static Elevator elevator1 = new Elevator();
        static Elevator elevator2 = new Elevator();
        static Elevator elevator3 = new Elevator();
        static Elevator elevator4 = new Elevator();
        static Elevator elevator5 = new Elevator();
        static Queue<demand> demands = new Queue<demand>();
        [STAThread]
        static void Main()
        { 
            //启动新线程进行调度算法
            Thread thread = new Thread(Elevator_Schedule);
            thread.Start();
            //主线程显示和响应UI界面
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(elevator1,elevator2,elevator3,elevator4,elevator5,demands));
        }

        static void Elevator_Schedule()
        {
            List<Elevator> elevators = new List<Elevator>();
            elevators.Add(elevator1);
            elevators.Add(elevator2);
            elevators.Add(elevator3);
            elevators.Add(elevator4);
            elevators.Add(elevator5);
            while(true)
            {//持续接受指令并操作
                //将楼层的需求分配给各电梯
                int count = 5;//若超过五次仍无法分配任务，则跳过
                while(demands.Count>0 && count>0)
                {//需求队列中有需求
                    for(int i=0;i<5;++i)
                    {
                        if (demands.Count == 0)
                            break;
                        demand d = demands.First();//获取需求队列的第一个元素
                        if(elevators[i].Get_Direction()==Direction.Stop)
                        {//电梯空闲
                            elevators[i].Add_Target(d.tar_floor);
                            demands.Dequeue();
                            continue;
                        }
                        else if (elevators[i].Get_Direction() == d.tar_direction)
                        {//需求方向与电梯运行方向相同
                            if (d.tar_direction == Direction.Up && d.tar_floor > elevators[i].Get_Current_Floor())
                            {//需求在电梯运行方向上，加入电梯任务队列
                                elevators[i].Add_Target(d.tar_floor);
                                demands.Dequeue();//从需求队列中去除
                                continue;
                            }
                            else if (d.tar_direction == Direction.Down && d.tar_floor < elevators[i].Get_Current_Floor())
                            {
                                elevators[i].Add_Target(d.tar_floor);
                                demands.Dequeue();
                                continue;
                            }
                        }
                    }
                    if (demands.Count > 0)
                    { //若所有电梯均忙碌，需求得不到解决，则等待
                        if (demands.Count == 1)
                            //只有一个需求无法解决，则等待
                            break;
                        else
                        {//若队列中还有其他需求，则将无法解决的需求排到队尾
                            demand d = demands.Dequeue();
                            demands.Enqueue(d);
                            count -= 1;
                        }
                    }
                }
                //各电梯执行自己的调度算法
                elevator1.dispatch();
                elevator2.dispatch();
                elevator3.dispatch();
                elevator4.dispatch();
                elevator5.dispatch();
                //等待1s
                Thread.Sleep(1000);
            }
        }
    }
}
