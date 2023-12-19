using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace SmartBOX
{

    public partial class Mainbody : Form
    {
        public DatabaseManager dbManager;
        public Label[] Box = new Label[8];
        public static serialPort serialPortMgr;
        bool check = true;
        private Point mouseOffset;
        int r1 = 1;
        int g1 = 1;
        int b1 = 1;
        bool pd = true;
        bool colorx = true;
        public Mainbody()
        {
            InitializeComponent();
            serialPortMgr = new serialPort();
        }

        private void save_open_Click(object sender, EventArgs e)
        {
            save_item save_item = new save_item(dbManager);
            save_item.ShowDialog();
        }

        private void get_open_Click(object sender, EventArgs e)
        {
            get_item get_item = new get_item(dbManager);
            get_item.ShowDialog();
        }

        private void Mainbody_Load(object sender, EventArgs e)
        {
            serialPortMgr.Open();
            welcome_tip.BackColor = Color.FromArgb(100, 0, 0, 0);
            nowtime.BackColor = Color.FromArgb(100, 0, 0, 0);
            dbManager = new DatabaseManager();
            Box[0] = box1;
            Box[1] = box2;
            Box[2] = box3;
            Box[3] = box4;
            Box[4] = box5;
            Box[5] = box6;
            Box[6] = box7;
            Box[7] = box8;
            reFresh();
            //启用多线程监听串口
            Thread _thread = new Thread(serialPortMgr.Receive);
            Thread colorChange = new Thread(navcolor);
            colorChange.IsBackground = true;
            _thread.IsBackground = true;

            _thread.Start();
            //如果卡顿请注释掉colorChange.Start();
            colorChange.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = "现在的时间是：" + DateTime.Now;
        }

        public void reFresh()
        {
            
            //填写相对应的指令
            string Cmd = "select * from item_group";

            dbManager.Open();
            dbManager.startCommand(Cmd);
            int abc = 0;
            foreach (string itemx in dbManager.items)
            {
                if (string.IsNullOrEmpty(itemx))
                {
                    Box[abc].BackColor = Color.Orange;
                    Box[abc].Text = "智能柜" + (abc + 1) + "号[维护]";
                    //Console.WriteLine(itemx);
                }
                else if (!string.IsNullOrEmpty(itemx))
                {
                    if (itemx.Contains("."))
                    {
                        int dotIndex = itemx.IndexOf(".") + 1;
                        int dotindex = itemx.IndexOf("#") - dotIndex;
                        string afterDot = itemx.Substring(dotIndex, dotindex);

                        if (string.IsNullOrEmpty(afterDot))
                        {
                            Box[abc].BackColor = Color.FromArgb(145, 25, 230, 75);
                            Box[abc].Text = "智能柜" + (abc + 1) + "号[空置]";
                        }
                        else
                        {
                            Box[abc].BackColor = Color.FromArgb(145, 230, 25, 75);
                            Box[abc].Text = "智能柜" + (abc + 1) + "号[满载]";

                            //向柜子发送有哪些柜子是有东西的
                            if (check)
                            {
                                //serialPortMgr.Open();
                                serialPortMgr.Send((byte)(abc + 1), 0xAB);
                                //serialPortMgr.Close();
                                
                            } 
                        }
                    }
                }
                abc++;
            }
            check = false;
            dbManager.Close();
        }

        private void Mainbody_FormClosing(object sender, FormClosingEventArgs e)
        {
            //结束多线程并退出程序
            serialPortMgr.closeprogram = false;
            Application.Exit();
        }

        private void Mainbody_Activated(object sender, EventArgs e)
        {
            reFresh();
        }

        private void maxForm_Click(object sender, EventArgs e)
        {
            //窗口最大化
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minForm_Click(object sender, EventArgs e)
        {
            //窗口最小化
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minForm_MouseEnter(object sender, EventArgs e)
        {
            minForm.BorderStyle = BorderStyle.None;
        }

        private void minForm_MouseLeave(object sender, EventArgs e)
        {
            minForm.BorderStyle = BorderStyle.FixedSingle;
        }

        private void maxForm_MouseEnter(object sender, EventArgs e)
        {
            maxForm.BorderStyle = BorderStyle.None;
        }

        private void maxForm_MouseLeave(object sender, EventArgs e)
        {
            maxForm.BorderStyle= BorderStyle.FixedSingle;
        }

        private void closeForm_MouseEnter(object sender, EventArgs e)
        {
            closeForm.BorderStyle = BorderStyle.None;
        }

        private void closeForm_MouseLeave(object sender, EventArgs e)
        {
            closeForm.BorderStyle= BorderStyle.FixedSingle;
        }

        private void Nav_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 计算鼠标移动的距离
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);

                // 移动窗口的位置
                Location = mousePos;
            }
        }

        private void Nav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 记录鼠标点击时的坐标
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void navcolor()
        {
            while (colorx)
            {
                if (pd == true)
                {
                    if (r1 == 255)
                    {
                        if (g1 == 255)
                        {
                            if (b1 == 255)
                            {
                                pd = false;
                            }
                            else
                            {
                                b1 += 1;
                            }
                        }
                        else
                        {
                            g1 += 1;
                        }
                    }
                    else
                    {
                        r1 += 1;
                    }
                }
                if (pd == false)
                {
                    if (b1 != 0)
                    {
                        b1 -= 1;
                    }
                    else if (g1 != 0)
                    {
                        g1 -= 1;
                    }
                    else if (r1 != 0)
                    {
                        r1 -= 1;
                    }
                    else if (r1 == 0 && g1 == 0 && b1 == 0)
                    {
                        pd = true;
                    }
                }
                Nav.BackColor = Color.FromArgb(180, r1, g1, b1);
                Thread.Sleep(10);
            }
        }
    }
}
