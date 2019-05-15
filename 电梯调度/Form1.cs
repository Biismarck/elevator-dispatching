using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 电梯调度
{
    public partial class Form1 : Form
    {
        Elevator elevator1, elevator2, elevator3, elevator4, elevator5;
        Queue<demand> demands;
        private void button43_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(3);
            button43.BackColor = Color.Yellow;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(4);
            button44.BackColor = Color.Yellow;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(5);
            button45.BackColor = Color.Yellow;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(6);
            button46.BackColor = Color.Yellow;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(7);
            button47.BackColor = Color.Yellow;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(8);
            button48.BackColor = Color.Yellow;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(9);
            button49.BackColor = Color.Yellow;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(10);
            button50.BackColor = Color.Yellow;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(11);
            button51.BackColor = Color.Yellow;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(12);
            button52.BackColor = Color.Yellow;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(13);
            button53.BackColor = Color.Yellow;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(14);
            button54.BackColor = Color.Yellow;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(15);
            button55.BackColor = Color.Yellow;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(16);
            button56.BackColor = Color.Yellow;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(17);
            button57.BackColor = Color.Yellow;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(18);
            button58.BackColor = Color.Yellow;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(19);
            button59.BackColor = Color.Yellow;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(20);
            button60.BackColor = Color.Yellow;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 1);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 2);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 3);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 4);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 5);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 6);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 7);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 8);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 9);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 10);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 11);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 12);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 13);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 14);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 15);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 16);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 17);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 18);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Up, 19);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 2);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 3);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 4);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 5);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 6);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 7);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 8);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 9);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 10);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 11);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 12);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 13);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 14);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 15);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 16);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 17);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 18);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 19);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            demand d = new demand(Direction.Down, 20);
            if (demands.Contains(d))
                return;
            else
            {
                demands.Enqueue(d);
            }
        }

        private void button244_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(1);
            button244.BackColor = Color.Yellow;
        }

        private void button243_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(2);
            button243.BackColor = Color.Yellow;
        }

        private void button241_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(3);
            button241.BackColor = Color.Yellow;
        }

        private void button237_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(4);
            button237.BackColor = Color.Yellow;
        }

        private void button228_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(5);
            button228.BackColor = Color.Yellow;
        }

        private void button242_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(6);
            button242.BackColor = Color.Yellow;
        }

        private void button239_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(7);
            button239.BackColor = Color.Yellow;
        }

        private void button235_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(8);
            button235.BackColor = Color.Yellow;
        }

        private void button233_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(9);
            button233.BackColor = Color.Yellow;
        }

        private void button227_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(10);
            button227.BackColor = Color.Yellow;
        }

        private void button240_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(11);
            button240.BackColor = Color.Yellow;
        }

        private void button236_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(12);
            button236.BackColor = Color.Yellow;
        }

        private void button232_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(13);
            button232.BackColor = Color.Yellow;
        }

        private void button231_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(14);
            button231.BackColor = Color.Yellow;
        }

        private void button226_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(15);
            button226.BackColor = Color.Yellow;
        }

        private void button238_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(16);
            button238.BackColor = Color.Yellow;
        }

        private void button234_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(17);
            button234.BackColor = Color.Yellow;
        }

        private void button230_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(18);
            button230.BackColor = Color.Yellow;
        }

        private void button229_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(19);
            button229.BackColor = Color.Yellow;
        }

        private void button225_Click(object sender, EventArgs e)
        {
            elevator2.Add_Target(20);
            button225.BackColor = Color.Yellow;
        }

        private void button266_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(1);
            button266.BackColor = Color.Yellow;
        }

        private void button265_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(2);
            button265.BackColor = Color.Yellow;
        }

        private void button263_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(3);
            button263.BackColor = Color.Yellow;
        }

        private void button259_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(4);
            button259.BackColor = Color.Yellow;
        }

        private void button250_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(5);
            button250.BackColor = Color.Yellow;
        }

        private void button264_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(6);
            button264.BackColor = Color.Yellow;
        }

        private void button261_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(7);
            button261.BackColor = Color.Yellow;
        }

        private void button257_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(8);
            button257.BackColor = Color.Yellow;
        }

        private void button255_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(9);
            button255.BackColor = Color.Yellow;
        }

        private void button249_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(10);
            button249.BackColor = Color.Yellow;
        }

        private void button262_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(11);
            button262.BackColor = Color.Yellow;
        }

        private void button258_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(12);
            button258.BackColor = Color.Yellow;
        }

        private void button254_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(13);
            button254.BackColor = Color.Yellow;
        }

        private void button253_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(14);
            button253.BackColor = Color.Yellow;
        }

        private void button248_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(15);
            button248.BackColor = Color.Yellow;
        }

        private void button260_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(16);
            button260.BackColor = Color.Yellow;
        }

        private void button256_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(17);
            button256.BackColor = Color.Yellow;
        }

        private void button252_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(18);
            button252.BackColor = Color.Yellow;
        }

        private void button251_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(19);
            button251.BackColor = Color.Yellow;
        }

        private void button247_Click(object sender, EventArgs e)
        {
            elevator3.Add_Target(20);
            button247.BackColor = Color.Yellow;
        }

        private void button288_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(1);
            button288.BackColor = Color.Yellow;
        }

        private void button287_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(2);
            button287.BackColor = Color.Yellow;
        }

        private void button285_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(3);
            button285.BackColor = Color.Yellow;
        }

        private void button281_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(4);
            button281.BackColor = Color.Yellow;
        }

        private void button272_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(5);
            button272.BackColor = Color.Yellow;
        }

        private void button286_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(6);
            button286.BackColor = Color.Yellow;
        }

        private void button283_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(7);
            button283.BackColor = Color.Yellow;
        }

        private void button279_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(8);
            button279.BackColor = Color.Yellow;
        }

        private void button277_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(9);
            button277.BackColor = Color.Yellow;
        }

        private void button271_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(10);
            button271.BackColor = Color.Yellow;
        }

        private void button284_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(11);
            button284.BackColor = Color.Yellow;
        }

        private void button280_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(12);
            button280.BackColor = Color.Yellow;
        }

        private void button276_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(13);
            button276.BackColor = Color.Yellow;
        }

        private void button275_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(14);
            button275.BackColor = Color.Yellow;
        }

        private void button270_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(15);
            button270.BackColor = Color.Yellow;
        }

        private void button282_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(16);
            button282.BackColor = Color.Yellow;
        }

        private void button278_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(17);
            button278.BackColor = Color.Yellow;
        }

        private void button274_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(18);
            button274.BackColor = Color.Yellow;
        }

        private void button273_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(19);
            button273.BackColor = Color.Yellow;
        }

        private void button269_Click(object sender, EventArgs e)
        {
            elevator4.Add_Target(20);
            button269.BackColor = Color.Yellow;
        }

        private void button310_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(1);
            button310.BackColor = Color.Yellow;
        }

        private void button309_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(2);
            button309.BackColor = Color.Yellow;
        }

        private void button307_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(3);
            button307.BackColor = Color.Yellow;
        }

        private void button303_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(4);
            button303.BackColor = Color.Yellow;
        }

        private void button294_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(5);
            button294.BackColor = Color.Yellow;
        }

        private void button308_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(6);
            button308.BackColor = Color.Yellow;
        }

        private void button305_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(7);
            button305.BackColor = Color.Yellow;
        }

        private void button301_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(8);
            button301.BackColor = Color.Yellow;
        }

        private void button299_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(9);
            button299.BackColor = Color.Yellow;
        }

        private void button293_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(10);
            button293.BackColor = Color.Yellow;
        }

        private void button306_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(11);
            button306.BackColor = Color.Yellow;
        }

        private void button302_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(12);
            button302.BackColor = Color.Yellow;
        }

        private void button298_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(13);
            button298.BackColor = Color.Yellow;
        }

        private void button297_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(14);
            button297.BackColor = Color.Yellow;
        }

        private void button292_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(15);
            button292.BackColor = Color.Yellow;
        }

        private void button304_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(16);
            button304.BackColor = Color.Yellow;
        }

        private void button300_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(17);
            button300.BackColor = Color.Yellow;
        }

        private void button296_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(18);
            button296.BackColor = Color.Yellow;
        }

        private void button295_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(19);
            button295.BackColor = Color.Yellow;
        }

        private void button291_Click(object sender, EventArgs e)
        {
            elevator5.Add_Target(20);
            button291.BackColor = Color.Yellow;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("Stop"))
            {
                elevator1.getLabel(elevator1.Get_Current_Floor()).BackColor = Color.Red;
            }
        }

        private void button224_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("Stop"))
            {
                elevator2.getLabel(elevator2.Get_Current_Floor()).BackColor = Color.Red;
            }
        }

        private void button246_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Contains("Stop"))
            {
                elevator3.getLabel(elevator3.Get_Current_Floor()).BackColor = Color.Red;
            }
        }

        private void button268_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Contains("Stop"))
            {
                elevator4.getLabel(elevator4.Get_Current_Floor()).BackColor = Color.Red;
            }
        }

        private void button290_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Contains("Stop"))
            {
                elevator5.getLabel(elevator5.Get_Current_Floor()).BackColor = Color.Red;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("Stop"))
            {
                elevator1.getLabel(elevator1.Get_Current_Floor()).BackColor = SystemColors.Highlight;
            }
        }

        private void button223_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Contains("Stop"))
            {
                elevator2.getLabel(elevator2.Get_Current_Floor()).BackColor = SystemColors.Highlight;
            }
        }

        private void button245_Click(object sender, EventArgs e)
        {
            if (textBox5.Text.Contains("Stop"))
            {
                elevator3.getLabel(elevator3.Get_Current_Floor()).BackColor = SystemColors.Highlight;
            }
        }

        private void button267_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Contains("Stop"))
            {
                elevator4.getLabel(elevator4.Get_Current_Floor()).BackColor = SystemColors.Highlight;
            }
        }

        private void button289_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Contains("Stop"))
            {
                elevator5.getLabel(elevator5.Get_Current_Floor()).BackColor = SystemColors.Highlight;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(2);
            button42.BackColor = Color.Yellow;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            elevator1.Add_Target(1);
            button41.BackColor = Color.Yellow;
        }

        public Form1(Elevator e1,Elevator e2,Elevator e3,Elevator e4,Elevator e5,Queue<demand> d)
        {
            elevator1 = e1;
            elevator2 = e2;
            elevator3 = e3;
            elevator4 = e4;
            elevator5 = e5;
            demands = d;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            elevator1.Add_Buttons(button41);
            elevator1.Add_Buttons(button42);
            elevator1.Add_Buttons(button43);
            elevator1.Add_Buttons(button44);
            elevator1.Add_Buttons(button45);
            elevator1.Add_Buttons(button46);
            elevator1.Add_Buttons(button47);
            elevator1.Add_Buttons(button48);
            elevator1.Add_Buttons(button49);
            elevator1.Add_Buttons(button50);
            elevator1.Add_Buttons(button51);
            elevator1.Add_Buttons(button52);
            elevator1.Add_Buttons(button53);
            elevator1.Add_Buttons(button54);
            elevator1.Add_Buttons(button55);
            elevator1.Add_Buttons(button56);
            elevator1.Add_Buttons(button57);
            elevator1.Add_Buttons(button58);
            elevator1.Add_Buttons(button59);
            elevator1.Add_Buttons(button60);
            elevator1.Add_Label(label101);
            elevator1.Add_Label(label102);
            elevator1.Add_Label(label103);
            elevator1.Add_Label(label104);
            elevator1.Add_Label(label105);
            elevator1.Add_Label(label106);
            elevator1.Add_Label(label107);
            elevator1.Add_Label(label108);
            elevator1.Add_Label(label109);
            elevator1.Add_Label(label110);
            elevator1.Add_Label(label111);
            elevator1.Add_Label(label112);
            elevator1.Add_Label(label113);
            elevator1.Add_Label(label114);
            elevator1.Add_Label(label115);
            elevator1.Add_Label(label116);
            elevator1.Add_Label(label117);
            elevator1.Add_Label(label118);
            elevator1.Add_Label(label119);
            elevator1.Add_Label(label120);
            elevator1.textbox1 = textBox1;
            elevator1.textbox2 = textBox2;

            elevator2.Add_Buttons(button244);
            elevator2.Add_Buttons(button243);
            elevator2.Add_Buttons(button241);
            elevator2.Add_Buttons(button237);
            elevator2.Add_Buttons(button228);
            elevator2.Add_Buttons(button242);
            elevator2.Add_Buttons(button239);
            elevator2.Add_Buttons(button235);
            elevator2.Add_Buttons(button233);
            elevator2.Add_Buttons(button227);
            elevator2.Add_Buttons(button240);
            elevator2.Add_Buttons(button236);
            elevator2.Add_Buttons(button232);
            elevator2.Add_Buttons(button231);
            elevator2.Add_Buttons(button226);
            elevator2.Add_Buttons(button238);
            elevator2.Add_Buttons(button234);
            elevator2.Add_Buttons(button230);
            elevator2.Add_Buttons(button229);
            elevator2.Add_Buttons(button225);
            elevator2.Add_Label(label201);
            elevator2.Add_Label(label202);
            elevator2.Add_Label(label203);
            elevator2.Add_Label(label204);
            elevator2.Add_Label(label205);
            elevator2.Add_Label(label206);
            elevator2.Add_Label(label207);
            elevator2.Add_Label(label208);
            elevator2.Add_Label(label209);
            elevator2.Add_Label(label210);
            elevator2.Add_Label(label211);
            elevator2.Add_Label(label212);
            elevator2.Add_Label(label213);
            elevator2.Add_Label(label214);
            elevator2.Add_Label(label215);
            elevator2.Add_Label(label216);
            elevator2.Add_Label(label217);
            elevator2.Add_Label(label218);
            elevator2.Add_Label(label219);
            elevator2.Add_Label(label220);
            elevator2.textbox1 = textBox3;
            elevator2.textbox2 = textBox4;

            elevator3.Add_Buttons(button266);
            elevator3.Add_Buttons(button265);
            elevator3.Add_Buttons(button263);
            elevator3.Add_Buttons(button259);
            elevator3.Add_Buttons(button250);
            elevator3.Add_Buttons(button264);
            elevator3.Add_Buttons(button261);
            elevator3.Add_Buttons(button257);
            elevator3.Add_Buttons(button255);
            elevator3.Add_Buttons(button249);
            elevator3.Add_Buttons(button262);
            elevator3.Add_Buttons(button258);
            elevator3.Add_Buttons(button254);
            elevator3.Add_Buttons(button253);
            elevator3.Add_Buttons(button248);
            elevator3.Add_Buttons(button260);
            elevator3.Add_Buttons(button256);
            elevator3.Add_Buttons(button252);
            elevator3.Add_Buttons(button251);
            elevator3.Add_Buttons(button247);
            elevator3.Add_Label(label301);
            elevator3.Add_Label(label302);
            elevator3.Add_Label(label303);
            elevator3.Add_Label(label304);
            elevator3.Add_Label(label305);
            elevator3.Add_Label(label306);
            elevator3.Add_Label(label307);
            elevator3.Add_Label(label308);
            elevator3.Add_Label(label309);
            elevator3.Add_Label(label310);
            elevator3.Add_Label(label311);
            elevator3.Add_Label(label312);
            elevator3.Add_Label(label313);
            elevator3.Add_Label(label314);
            elevator3.Add_Label(label315);
            elevator3.Add_Label(label316);
            elevator3.Add_Label(label317);
            elevator3.Add_Label(label318);
            elevator3.Add_Label(label319);
            elevator3.Add_Label(label320);
            elevator3.textbox1 = textBox5;
            elevator3.textbox2 = textBox6;

            elevator4.Add_Buttons(button288);
            elevator4.Add_Buttons(button287);
            elevator4.Add_Buttons(button285);
            elevator4.Add_Buttons(button281);
            elevator4.Add_Buttons(button272);
            elevator4.Add_Buttons(button286);
            elevator4.Add_Buttons(button283);
            elevator4.Add_Buttons(button279);
            elevator4.Add_Buttons(button277);
            elevator4.Add_Buttons(button271);
            elevator4.Add_Buttons(button284);
            elevator4.Add_Buttons(button280);
            elevator4.Add_Buttons(button276);
            elevator4.Add_Buttons(button275);
            elevator4.Add_Buttons(button270);
            elevator4.Add_Buttons(button282);
            elevator4.Add_Buttons(button278);
            elevator4.Add_Buttons(button274);
            elevator4.Add_Buttons(button273);
            elevator4.Add_Buttons(button269);
            elevator4.Add_Label(label401);
            elevator4.Add_Label(label402);
            elevator4.Add_Label(label403);
            elevator4.Add_Label(label404);
            elevator4.Add_Label(label405);
            elevator4.Add_Label(label406);
            elevator4.Add_Label(label407);
            elevator4.Add_Label(label408);
            elevator4.Add_Label(label409);
            elevator4.Add_Label(label410);
            elevator4.Add_Label(label411);
            elevator4.Add_Label(label412);
            elevator4.Add_Label(label413);
            elevator4.Add_Label(label414);
            elevator4.Add_Label(label415);
            elevator4.Add_Label(label416);
            elevator4.Add_Label(label417);
            elevator4.Add_Label(label418);
            elevator4.Add_Label(label419);
            elevator4.Add_Label(label420);
            elevator4.textbox1 = textBox7;
            elevator4.textbox2 = textBox8;

            elevator5.Add_Buttons(button310);
            elevator5.Add_Buttons(button309);
            elevator5.Add_Buttons(button307);
            elevator5.Add_Buttons(button303);
            elevator5.Add_Buttons(button294);
            elevator5.Add_Buttons(button308);
            elevator5.Add_Buttons(button305);
            elevator5.Add_Buttons(button301);
            elevator5.Add_Buttons(button299);
            elevator5.Add_Buttons(button293);
            elevator5.Add_Buttons(button306);
            elevator5.Add_Buttons(button302);
            elevator5.Add_Buttons(button298);
            elevator5.Add_Buttons(button297);
            elevator5.Add_Buttons(button292);
            elevator5.Add_Buttons(button304);
            elevator5.Add_Buttons(button300);
            elevator5.Add_Buttons(button296);
            elevator5.Add_Buttons(button295);
            elevator5.Add_Buttons(button291);
            elevator5.Add_Label(label501);
            elevator5.Add_Label(label502);
            elevator5.Add_Label(label503);
            elevator5.Add_Label(label504);
            elevator5.Add_Label(label505);
            elevator5.Add_Label(label506);
            elevator5.Add_Label(label507);
            elevator5.Add_Label(label508);
            elevator5.Add_Label(label509);
            elevator5.Add_Label(label510);
            elevator5.Add_Label(label511);
            elevator5.Add_Label(label512);
            elevator5.Add_Label(label513);
            elevator5.Add_Label(label514);
            elevator5.Add_Label(label515);
            elevator5.Add_Label(label516);
            elevator5.Add_Label(label517);
            elevator5.Add_Label(label518);
            elevator5.Add_Label(label519);
            elevator5.Add_Label(label520);
            elevator5.textbox1 = textBox9;
            elevator5.textbox2 = textBox10;
        }
    }
}
