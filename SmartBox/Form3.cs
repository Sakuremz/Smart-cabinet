using System;
using System.Windows.Forms;

namespace SmartBOX
{
    public partial class get_item : Form
    {
        DatabaseManager dbManager;
        string tmp;
        int dotIndex;
        int dotindex;
        public get_item(DatabaseManager DatabaseManager)        //跨文件访问需将被访问的类设置成PUBLIC
        {
            InitializeComponent();
            this.dbManager = DatabaseManager;
        }

        private void getitem_Click(object sender, EventArgs e)
        {
            string itemName = item_name.Text;
            if (itemName.Trim() == "")
            {
                MessageBox.Show("请输入物品名称");
            }
            else
            {
                //填写相对应的指令
                int Boxcode = int.Parse(all_items.SelectedItem.ToString().Substring(0,dotIndex - 1));
                string Cmd = string.Format("update item_group set item_name= '', item_desc = '', create_time = null WHERE `id`= '{0}' LIMIT 1; ", tmp.Substring(0, dotIndex));
                //Console.WriteLine(Cmd);

                //发送取出的数据
                //Mainbody.serialPortMgr.Open();
                Mainbody.serialPortMgr.Send((byte)Boxcode, 0xAE);
                //Mainbody.serialPortMgr.Close();

                dbManager.Open();
                
                //判断是否成功拿取
                if (serialPort.takesuccess)
                {
                    dbManager.startCommand(Cmd);
                    MessageBox.Show("拿取成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("链接智能柜失败或出现其他错误！");
                }
                dbManager.Close();
            }
        }

        private void get_item_Load(object sender, EventArgs e)
        {
            refresh();
            if (all_items.Items.Count == 0)
            {
                MessageBox.Show("没有东西可以拿啊");
                this.Close();
            }
        }

        public void refresh()               //刷新
        {
            //填写相对应的指令
            string Cmd = "select * from item_group";

            dbManager.Open();
            dbManager.startCommand(Cmd);

            //把现有物品添加到列表框内
            foreach (string itemx in dbManager.items)
            {
                if (!string.IsNullOrEmpty(itemx))
                {
                    if (itemx.Contains("."))
                    {
                        dotIndex = itemx.IndexOf(".") + 1;
                        dotindex = itemx.IndexOf("#") - dotIndex;
                        string afterDot = itemx.Substring(dotIndex, dotindex);
                        if (!string.IsNullOrEmpty(afterDot))
                        {
                            //Console.WriteLine(itemx);
                            all_items.Items.Add(itemx);
                        }
                    }
                }
            }
            dbManager.Close();
        }

        public void tmpa()
        {
            tmp = all_items.SelectedItem.ToString();
            dotIndex = tmp.IndexOf(".") + 1;
            dotindex = tmp.IndexOf("#") - dotIndex;
            string afterDot = tmp.Substring(dotIndex, dotindex);
            item_name.Text = afterDot;
        }

        private void all_items_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (all_items.SelectedIndex != -1)
            {
                tmpa();
            }
        }
    }
}
