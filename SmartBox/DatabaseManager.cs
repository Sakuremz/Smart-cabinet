using System.IO;
using MySql.Data.MySqlClient;

namespace SmartBOX
{
    public class DatabaseManager
    {
        public string[] items = new string[8];
        public string chkuser;
        string serverIP;
        string port;
        string userName;
        string userPassword;
        string databaseName;
        string dbLocation = "./DataBaseManager.ini";

        MySqlConnection conn;

        public DatabaseManager()
        {
            StreamReader config = new StreamReader(dbLocation);   //读取指定位置的配置文件
            string[] line = new string[6];
            for ( int i = 0; i < line.Length; i++ )
            {
                string tmp = config.ReadLine();
                if (tmp.Contains("="))
                {
                    int startindex = tmp.IndexOf("=") + 1;
                    int endindex = tmp.Length - startindex;
                    tmp = tmp.Substring(startindex, endindex);
                    line[i] = tmp;
                }
            }

            serverIP = line[1];
            port = line[2];
            userName = line[3];
            userPassword = line[4];
            databaseName = line[5];
            //对Mysql发出连接指令
            string connStr = "server=" + serverIP + ";user=" + userName + ";database=" + databaseName +
                                                                                    ";port=" + port + ";password=" + userPassword + ";";
            conn = new MySqlConnection(connStr);
        }

        public void Open()
        {
            conn.Open();            //开启链接
        }

        public void Close()
        {
            conn.Close();            //关闭链接
        }

        public void startCommand(string sql)
        {
            // 执行命令
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            int abc = 0;
            while (rdr.Read())
            {
                items[abc] = rdr[0].ToString() + "." + rdr[1].ToString() + "#   描述:" + rdr[2].ToString() + "    创建时间:" + rdr[3].ToString();                 //物品名称                                                                                                                                 //Console.WriteLine(items[abc]);
                abc++;
            }
        }

        public void checkuser(string sql)
        {
            // 执行命令
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                chkuser = rdr[1].ToString() + "--" + rdr[2].ToString();
            }


        }
    }
}
