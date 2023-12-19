using System;
using System.Windows.Forms;

namespace SmartBOX
{
    public partial class save_item : Form
    {
        DatabaseManager dbManager;
        public save_item(DatabaseManager DatabaseManager)
        {
            InitializeComponent();
            this.dbManager = DatabaseManager;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string itemName = item_name.Text;
            string itemDesc = desc_item.Text;

            if (itemName.Trim() == "")
            {
                MessageBox.Show("请输入物品名称和描述");
                return;
            }
            else
            {
                int Boxcode = 0;
                //填写相对应的指令
                string Cmd = string.Format("update item_group set item_name='{0}', item_desc='{1}' where id ='{2}'", itemName, itemDesc, savebox.Text);
                if (savebox.SelectedIndex < 0)
                {
                    MessageBox.Show("未选择需要存储的柜子...");
                }
                else
                {
                    Boxcode = int.Parse(savebox.Text);
                     /*
                    * 验证头尾文件
                    * 0xFF 0x01 0xFA 0xFE
                    * 0xFF 0x01 0xFA 0xFE
                    * 名：Mainbody + 成员静态变量
                    */
                    //Mainbody.serialPortMgr.Open();
                    Mainbody.serialPortMgr.Send((byte)Boxcode, 0xAF);
                    //Mainbody.serialPortMgr.Close();
                    dbManager.Open();
                    
                    

                    if (serialPort.putsuccess)
                    {
                        dbManager.startCommand(Cmd);
                        MessageBox.Show("存放完成！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("链接智能柜失败或出现其他错误！");
                    }
                    dbManager.Close();
                }

            }
        }

        private void item_icon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //没有完善物品图标
            dialog.Title = "选择物品图标";
            dialog.Filter = "图像文件(*.*) | *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string file = dialog.FileName;
                item_icon.ImageLocation = file;
            }
        }


        private void save_item_Load(object sender, EventArgs e)
        {
            refresh();
            savebox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void refresh()               //刷新
        {
            string temp = "";
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
                        int dotIndex = itemx.IndexOf(".") + 1;
                        int dotindex = itemx.IndexOf("#") - dotIndex;
                        string afterDot = itemx.Substring(dotIndex, dotindex);
                        if (string.IsNullOrEmpty(afterDot))
                        {
                            savebox.Items.Add(itemx.Substring(0, dotIndex - 1));
                            temp += itemx.Substring(0, dotIndex - 1) + "号智能柜是空的\n";
                        }
                    }
                }
            }
            dbManager.Close();
            MessageBox.Show(temp);
        }
    }
}
