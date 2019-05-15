using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
public enum Direction
{
    Up,Down,Stop
};

namespace 电梯调度
{
    public class Elevator
    {
        private Direction direction;
        private int Current_Floor;
        private List<int> Target_Floor;
        private List<Button> Buttons;
        private List<Label> Labels;
        public TextBox textbox1
        {
            get;set;
        }
        public TextBox textbox2
        {
            get;set;
        }
        public Elevator()
        {//初始在一楼,方向向上
            direction = Direction.Stop;
            Current_Floor = 1;
            Target_Floor = new List<int>();
            Target_Floor.Capacity = 20;
            Buttons = new List<Button>();
            Labels = new List<Label>();
        }
        public void Add_Target(int target)
        {//添加目标楼层
            if (Target_Floor.Contains(target))
                return;
            else
            {
                Target_Floor.Add(target);
                Target_Floor.Sort();
            }
        }
        public Direction Get_Direction()
        {
            return direction;
        }
        public int Get_Current_Floor()
        {
            return Current_Floor;
        }
        public void Add_Buttons(Button button)
        {
            Buttons.Add(button);
        }
        public void Add_Label(Label label)
        {
            Labels.Add(label);
        }
        public void dispatch()
        {//让电梯沿当前运行方向处理完所有任务
         //若当前方向上无任务，则反向,若均无任务，则等待
            if (Target_Floor.Count() > 0)
            {//有任务
                if (direction == Direction.Up || direction == Direction.Stop)
                {//电梯上行或无任务
                    if (Target_Floor[Target_Floor.Count() - 1] < Current_Floor)
                    {//最大目标楼层小于当前楼层，即当前运行方向上无任务,改变运行方向
                        direction = Direction.Down;
                        Labels[Current_Floor - 1].Invoke(new Action(() =>
                        {
                            Labels[Current_Floor - 1].BackColor = SystemColors.Desktop;
                        }));

                        Current_Floor -= 1;
                        textbox1.Invoke(new Action(() =>
                        {
                            textbox1.Text = Current_Floor.ToString() + " " + direction.ToString();
                        }));
                        textbox2.Invoke(new Action(() =>
                        {
                            textbox2.Text = Current_Floor.ToString() + " " + direction.ToString();
                        }));
                        Labels[Current_Floor - 1].Invoke(new Action(() =>
                        {
                            Labels[Current_Floor - 1].BackColor = SystemColors.Highlight;
                        }));
                        return;//结束调度
                    }
                    for (int i = 0; i < Target_Floor.Count(); ++i)
                    {//从小到大扫描所有任务
                        if (Current_Floor > Target_Floor[i])
                            continue;//任务不在当前方向上，跳过
                        else if (Current_Floor == Target_Floor[i])
                        {//当前楼层为目标楼层
                            Target_Floor.Remove(Current_Floor);//将任务删除
                            Buttons[Current_Floor - 1].Invoke(new Action(() =>
                              {
                                  Buttons[Current_Floor - 1].BackColor = SystemColors.Control;
                              }));//将电梯中按钮颜色恢复
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                              {
                                  Labels[Current_Floor - 1].BackColor = Color.Red;
                              }));//开门显示为红色
                            break;//调度结束
                        }
                        else
                        {//目标楼层在运行方向上
                         //电梯上行一层，修改楼层显示
                            direction = Direction.Up;//修改电梯状态为上行
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Labels[Current_Floor - 1].BackColor = SystemColors.Desktop;
                            }));

                            Current_Floor += 1;
                            textbox1.Invoke(new Action(() =>
                            {
                                textbox1.Text = Current_Floor.ToString() + " " + direction.ToString();
                            }));
                            textbox2.Invoke(new Action(() =>
                            {
                                textbox2.Text = Current_Floor.ToString() + " " + direction.ToString();
                            }));
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Labels[Current_Floor - 1].BackColor = SystemColors.Highlight;
                            }));
                            break;//调度结束
                        }
                    }
                }
                else if (direction == Direction.Down || direction == Direction.Stop)
                {//电梯下行或无任务
                    if (Target_Floor[0] > Current_Floor)
                    {//最小目标楼层大于当前楼层，即当前运行方向上无任务,改变运行方向
                        direction = Direction.Up;
                        Labels[Current_Floor - 1].Invoke(new Action(() =>
                        {
                            Labels[Current_Floor - 1].BackColor = SystemColors.Desktop;
                        }));

                        Current_Floor += 1;
                        textbox1.Invoke(new Action(() =>
                        {
                            textbox1.Text = Current_Floor.ToString() + " " + direction.ToString();
                        }));
                        textbox2.Invoke(new Action(() =>
                        {
                            textbox2.Text = Current_Floor.ToString() + " " + direction.ToString();
                        }));
                        Labels[Current_Floor - 1].Invoke(new Action(() =>
                        {
                            Labels[Current_Floor - 1].BackColor = SystemColors.Highlight;
                        }));
                        return;//结束调度
                    }
                    for (int i = Target_Floor.Count() - 1; i >= 0; --i)
                    {//从大到小扫描所有任务
                        if (Current_Floor < Target_Floor[i])
                            continue;//任务不在当前方向上，跳过
                        else if (Current_Floor == Target_Floor[i])
                        {//当前楼层为目标楼层
                            Target_Floor.Remove(Current_Floor);//将任务删除
                            Buttons[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Buttons[Current_Floor - 1].BackColor = SystemColors.Control;
                            }));//将电梯中按钮颜色恢复
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Labels[Current_Floor - 1].BackColor = Color.Red;
                            }));//开门显示为红色
                            break;//调度结束
                        }
                        else
                        {//目标楼层在运行方向上
                         //电梯下行一层，修改楼层显示
                            direction = Direction.Down;//修改电梯状态为下行
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Labels[Current_Floor - 1].BackColor = SystemColors.Desktop;
                            }));

                            Current_Floor -= 1;
                            textbox1.Invoke(new Action(() =>
                            {
                                textbox1.Text = Current_Floor.ToString() + " " + direction.ToString();
                            }));
                            textbox2.Invoke(new Action(() =>
                            {
                                textbox2.Text = Current_Floor.ToString() + " " + direction.ToString();
                            }));
                            Labels[Current_Floor - 1].Invoke(new Action(() =>
                            {
                                Labels[Current_Floor - 1].BackColor = SystemColors.Highlight;
                            }));
                            break;//调度结束
                        }
                    }
                }
            }
            else
            {//无任务
                direction = Direction.Stop;
                if (Labels.Count > 0) //防止UI尚未初始化
                {
                    Labels[Current_Floor - 1].Invoke(new Action(() =>
                  {
                      Labels[Current_Floor - 1].BackColor = SystemColors.Highlight;
                  }));//显示当前楼层
                    textbox1.Invoke(new Action(() =>
                    {
                        textbox1.Text = Current_Floor.ToString() + " " + direction.ToString();
                    }));
                    textbox2.Invoke(new Action(() =>
                    {
                        textbox2.Text = Current_Floor.ToString() + " " + direction.ToString();
                    }));
                }
            }
        }
        public Label getLabel(int id)
        {
            if (id > 0 && id < 21)
                return Labels[id - 1];
            else
                return null;
        }
    }
}
