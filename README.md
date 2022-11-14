# SerialPortInNetFramework

#### 介绍
这是基于.Net Framework 4.0，封装了串口一些操作，如打开串口、关闭串口、串口发送、串口接收等，方便下次需要使用串口功能时，直接在解决方案中添加该类库。可以直接调取使用。

#### 软件架构
1.  类库的编译器是Visual Studio 2010，框架是.Net Framework 4.0。
2.  需要订阅串口接收数据事件，才可以接收到串口数据。


#### 现有功能

1.  打开串口
2.  关闭串口
3.  广播串口收到的消息
4.  发送串口数据
5.  可以获取当前系统下的串口资源
6.  提供波特率列表接口

#### 使用方式

1、调用对象的构造函数

```c#
SerialPortUtility mySP = new SerialPortUtility();
```

2、获取当前系统下的串口资源

```C#
private void GetPortList()
{
    // 串口号
    List<SPParameterClass<string>> portList = SerialPortUtility.GetPortList();
    // 波特率
    List<SPParameterClass<int>> rateList = SerialPortUtility.SetBaudRateValues();
}
```



3、订阅串口收到数据事件

```C#
// 在程序启动的函数中添加监听函数
mySP.ReceivedDataEvent += new EventHandler<SerialPort_4NetFramework.SerialPortUtility.SerialPortRecvEventArgs>(mySp_ReceivedDataEvent);

private void mySp_ReceivedDataEvent(object sender, SerialPortUtility.SerialPortRecvEventArgs args)
{
    // args.RecvData是byte[]类型
    string OutputMessage = "";
    // 将args.RecvData转成ASCII格式
    OutputMessage = Encoding.GetEncoding("gb2312").GetString(args.RecvData, 0, args.RecvDataLength);
    // 将args.RecvData转成收到HEX格式
    for (int i = 0; i < args.RecvDataLength; i++)
    {
        OutputMessage += args.RecvData[i].ToString("X2");
    }
}
```

4、串口打开/关闭

```c#
// 打开串口
mySP.OpenSerialPort("COM1", 115200, 0, 8, 1);	// 参数分别为串口号、波特率、检验位、数据位、停止位
// 关闭串口
mySP.CloseSerialPort();
// 串口是否开启标志位
mySP.IsOpen
```

5、发送数据

```C#
mySP.SendData(data);	// data的类型为byte[]
mySP.SendData(data, encoding);	// data的类型为byte[],encoding的类型为Encoding
```
