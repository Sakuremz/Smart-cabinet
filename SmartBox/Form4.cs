using System;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SmartBOX
{
    public partial class Login : Form
    {
        public DatabaseManager dbManager;
        public serialPort serialPortManager;
        Mainbody mainbody = new Mainbody();
        string unPackResult;

/* +------------------------------------------------+        
     |                   以下为自定义参数                        |
*/
        string iniLocation = "./UserInfo.ini";
        string dbLocation = "./DataBaseManager.ini";

        public Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
            }
            else
            {
                this.Opacity += 0.02;
            }
        }

        private void Unpack(string tmp)
        {
            byte[] bytes = new byte[tmp.Length / 2];
            for (int i = 0; i < tmp.Length / 2; i++)
            {
                string hexByte = tmp.Substring(i * 2, 2);
                bytes[i] = byte.Parse(hexByte, System.Globalization.NumberStyles.HexNumber);
            }
            unPackResult = Encoding.ASCII.GetString(bytes);
        }

        private void Loginin_Click(object sender, EventArgs e)
        {
            //添加验证
            try
            {
                dbManager.Open();
                string Cmd = string.Format("select * from userinfo where account = '{0}' and password = '{1}'", account.Text, password.Text);
                dbManager.checkuser(Cmd);
                dbManager.Close();
                if (account.Text + "--" + password.Text == dbManager.chkuser)
                {
                    this.Hide();
                    mainbody.Show();
                }
                else
                {
                    dbManager.Open();
                    Cmd = string.Format("insert into userinfo (`account`, `password`) VALUES ('{0}', '{1}')", account.Text, password.Text);
                    dbManager.checkuser(Cmd);
                    dbManager.Close();
                    MessageBox.Show("账号可能没注册，已为您自动创建, 再次登录即可", "其实就是懒");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    MessageBox.Show("与服务器断开连接，请排除问题");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (rememberinfo.Checked is true)
            {
                File.Delete(iniLocation);
                //将账号密码保存到本地并进行加密，以便下次读取
                var writeinfo = new StreamWriter(iniLocation);
                writeinfo.WriteLine(">.<~登录账户数据~>.<");
                string encryptionUser = "";
                string encryptionKey = "";
                for (int i = 0; i < account.Text.Length; i++)
                {
                    char c = account.Text[i];
                    string hex = ((int)c).ToString("X2");
                    encryptionUser += hex;
                }
                for (int i = 0;i < password.Text.Length; i++)
                {
                    char c = password.Text[i];
                    string hex = ((int)c).ToString("X2");
                    encryptionKey += hex;
                }

                writeinfo.WriteLine("account=" + encryptionUser);
                writeinfo.WriteLine("password=" + encryptionKey);
                writeinfo.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (File.Exists(iniLocation))
            {
                using (var readinfo = new StreamReader(iniLocation))
                {
                    string[] line = new string[3];
                    for (int i = 0; i < line.Length; i++)
                    {
                        string tmp = readinfo.ReadLine();
                        if (tmp.Contains("="))
                        {
                            int startindex = tmp.IndexOf("=") + 1;
                            int endindex = tmp.Length - startindex;
                            tmp = tmp.Substring(startindex, endindex);
                            Unpack(tmp);
                        }
                        line[i] = unPackResult;
                    }
                    account.Text = line[1];
                    password.Text = line[2];
                }
            }
            else
            {
                using (StreamWriter database = new StreamWriter(dbLocation))
                {
                    database.WriteLine(" [Mysql数据库信息]\r\nserverIP=localhost\r\nPort=3306\r\nuserName=root\r\n" +
                                                    "userPassword=qwqw1378\r\ndatabaseName=sakura");
                }
            }
            dbManager = new DatabaseManager();
        }
    }
}
