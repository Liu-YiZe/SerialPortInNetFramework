using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerialPort_4NetFramework
{
    /// <summary>
    /// 串口参数类
    /// </summary>
    /// <typeparam name="T">value选择需要使用的值</typeparam>
    public class SPParameterClass<T>
    {
        /// <summary>
        /// 显示值
        /// </summary>
        string name;

        /// <summary>
        /// 显示值
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 值
        /// </summary>
        T value;

        /// <summary>
        /// 值
        /// </summary>
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

    }

    /// <summary>
    /// 串口波特率列表。
    /// 75,110,150,300,600,1200,2400,4800,9600,14400,19200,28800,38400,56000,57600,
    /// 115200,128000,230400,256000
    /// </summary>
    public enum SerialPortBaudRates
    {
        BaudRate_75 = 75,
        BaudRate_110 = 110,
        BaudRate_150 = 150,
        BaudRate_300 = 300,
        BaudRate_600 = 600,
        BaudRate_1200 = 1200,
        BaudRate_2400 = 2400,
        BaudRate_4800 = 4800,
        BaudRate_9600 = 9600,
        BaudRate_14400 = 14400,
        BaudRate_19200 = 19200,
        BaudRate_28800 = 28800,
        BaudRate_38400 = 38400,
        BaudRate_56000 = 56000,
        BaudRate_57600 = 57600,
        BaudRate_115200 = 115200,
        BaudRate_128000 = 128000,
        BaudRate_230400 = 230400,
        BaudRate_256000 = 256000
    }
}
