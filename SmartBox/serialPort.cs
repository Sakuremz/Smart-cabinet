using System;
using System.IO.Ports;


namespace SmartBOX
{
    public class serialPort
    {
        //静态变量类似全局变量，不需要频繁传入实例
        public Mainbody mainbody;
        static SerialPort _serialPort;
        byte[] readBuffer;
        byte[] sendBuffer = new byte[4] { 0xFF, 0x00, 0x00, 0xFE };
        int rdIndex = 0;
        bool isPacketStart = false;
        public static bool putsuccess = true;
        public static bool takesuccess = true;
        public bool closeprogram = true; 

        public serialPort()
        {
            _serialPort = new SerialPort();
            // 允许用户设置端口参数
            _serialPort.PortName = "COM2";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            //读写超时(ms)
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            readBuffer = new byte[4];
        }


        public void Open()
        {
            //打开
            _serialPort.Open();
        }

        public void Close()
        {
            //关闭
            _serialPort.Close();
        }

        public void Send(byte cmd, byte boxCode)
        {
            //发送信息
            sendBuffer = new byte[4] { 0xFF, 0x00, 0x00, 0xFE };
            sendBuffer[1] = cmd;
            sendBuffer[2] = boxCode;
            //              Write(字节流, 偏移量, 发送的字节数量)
            _serialPort.Write(sendBuffer, 0, sendBuffer.Length);
        }

        public void Receive()               //存储为AC 取出为AD
        {
            while (closeprogram)
            {
                //接受信息
                int receiveData = 0;
                if (_serialPort.BytesToRead > 0)
                {
                    receiveData = _serialPort.ReadByte();

                    if (!isPacketStart && receiveData == 0xFF)
                    {
                        // 接收到数据包的起始标识位
                        isPacketStart = true;
                        rdIndex = 0;
                    }

                    if (isPacketStart)
                    {
                        readBuffer[rdIndex] = (byte)receiveData;
                        rdIndex++;

                        if (rdIndex >= 4)
                        {

                            // 数据包接收完成
                            isPacketStart = false;
                            ProcessPacket();
                        }
                    }
                    //创建一定的延迟保证程序的流畅度
                }
            }
        }

        private void ProcessPacket()
        {
            // 处理数据包
            if (readBuffer[0] == 0xFF && readBuffer[readBuffer.Length - 1] == 0xFE)
            {
                // 数据包的校验成功
                if (readBuffer[2] == 0xAC)
                {
                    //判断是否与Unity的柜号一致(存储)
                    if (readBuffer[1] == sendBuffer[1])
                    {
                        putsuccess = true;
                    }
                    else
                    {
                        putsuccess = false;
                    }
                }
                else if (readBuffer[2] == 0xAD)
                {
                    //判断是否与Unity的柜号一致(存储)
                    if (readBuffer[1] == sendBuffer[1])
                    {
                        takesuccess = true;
                    }
                    else
                    {
                        takesuccess = false;
                    }
                }
            }
            // 清空读到的数据
            Array.Clear(readBuffer, 0, readBuffer.Length);
        }
    }
}
