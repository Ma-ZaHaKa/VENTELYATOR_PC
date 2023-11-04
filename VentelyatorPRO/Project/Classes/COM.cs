using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.IO.Ports;
using System.Reflection;
using System.Threading.Tasks;

namespace Project
{
    public partial class Form1
    {
        //public static void COMLogDisable(Logger logger)
        //{
        //    var field = logger.GetType().GetField("_output", BindingFlags.NonPublic | BindingFlags.Instance);
        //    field?.SetValue(logger, new Action<LogData, string>((d, s) => { }));
        //}
        public string FixString4Serial(string str) { return str.Replace("\r", "").Replace("\n", "").Replace("\t", ""); }

        public bool LOG_SEARCH_COM = false;
        public bool SET_TIMEOUT = true;
        //public static int timeout = 1000; // 1sec
        public int timeout = 1000; // 1sec

        public string FindCOMPort(string response_msg) // UPPER CASE
        {
            string[] portNames = SerialPort.GetPortNames();

            foreach (string portName in portNames)
            {
                if (LOG_SEARCH_COM) { Console.WriteLine($"TRYING: {portName}"); }
                string tmp_msg = SendMsgCom(portName, "{\"mode\":\"hello\"}");
                if (tmp_msg.Contains(response_msg)) { return portName.ToUpper(); }

                //using (SerialPort port = new SerialPort(portName))
                //{
                //    try
                //    {
                //        port.Open();
                //        port.Write(my_msg);
                //        System.Threading.Thread.Sleep(100);
                //        if (port.ReadExisting().Contains(response_msg)) { return portName; }
                //    }
                //    //catch (Exception ex) { Console.WriteLine($"Error communicating with {portName}: {ex.Message}"); }
                //    catch { }
                //}
            }
            return "";
        }

        public string SendMsgCom(string port_name, string my_msg, int baudRate = 9600)
        {
            //string[] availablePorts = SerialPort.GetPortNames();
            //port_name = port_name.ToUpper();

            //if (!availablePorts.Select(p => p.ToUpper()).Contains(port_name))
            //{
            //    //Console.WriteLine("Указанный порт не существует.");
            //    return string.Empty;
            //}
            //SerialPort serialPort = new SerialPort(port_name, baudRate);
            try
            {
                if (serialPort.PortName != port_name) { serialPort.PortName = port_name; }
                if (serialPort.BaudRate != baudRate) { serialPort.BaudRate = baudRate; }
                if (!serialPort.IsOpen) { serialPort.Open(); }

                serialPort.Write(FixString4Serial(my_msg));
                System.Threading.Thread.Sleep(100);

                // Ждем ответ (можно установить таймаут)
                if(SET_TIMEOUT)
                {
                    serialPort.ReadTimeout = timeout;
                    serialPort.WriteTimeout = timeout;
                }

                string response = serialPort.ReadLine();
                //serialPort.Close();
                return response;
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Ошибка: " + ex.Message);
                return string.Empty;
            }
            finally
            {
                //serialPort?.Close();
            }
        }
        public bool SendMsgComNoResp(string port_name, string my_msg, int baudRate = 9600)
        {
            //string[] availablePorts = SerialPort.GetPortNames();
            //port_name = port_name.ToUpper();

            //if (!availablePorts.Select(p => p.ToUpper()).Contains(port_name))
            //{
            //    //Console.WriteLine("Указанный порт не существует.");
            //    return false;
            //}
            //SerialPort serialPort = new SerialPort(port_name, baudRate);
            try
            {
                if (serialPort.PortName != port_name) { serialPort.PortName = port_name; }
                if (serialPort.BaudRate != baudRate) { serialPort.BaudRate = baudRate; }
                if (!serialPort.IsOpen) { serialPort.Open(); }
                
                serialPort.Write(FixString4Serial(my_msg));
                System.Threading.Thread.Sleep(100);

                // Ждем ответ (можно установить таймаут)
                if (SET_TIMEOUT)
                {
                    serialPort.ReadTimeout = timeout;
                    serialPort.WriteTimeout = timeout;
                }

                //serialPort.Close();
                return true;
            }
            catch (Exception ex) { return false; }
            finally
            {
                //serialPort?.Close();
            }
        }
        public async void SendMsgComNoRespAsync(string port_name, string my_msg, int baudRate = 9600)
        {
            //await Task.Run(() => // EXCEPTION NULL REF
            {
                //string[] availablePorts = SerialPort.GetPortNames();
                //port_name = port_name.ToUpper();

                //if (!availablePorts.Select(p => p.ToUpper()).Contains(port_name))
                //{
                //    //Console.WriteLine("Указанный порт не существует.");
                //    return false;
                //}
                //SerialPort serialPort = new SerialPort(port_name, baudRate);
                try
                {
                    if (serialPort.PortName != port_name) { serialPort.PortName = port_name; }
                    if (serialPort.BaudRate != baudRate) { serialPort.BaudRate = baudRate; }
                    if (!serialPort.IsOpen) { serialPort.Open(); }

                    serialPort.Write(FixString4Serial(my_msg));
                    System.Threading.Thread.Sleep(100);

                    // Ждем ответ (можно установить таймаут)
                    if (SET_TIMEOUT)
                    {
                        serialPort.ReadTimeout = timeout;
                        serialPort.WriteTimeout = timeout;
                    }

                    //serialPort.Close();
                }
                catch (Exception ex) { }
                finally
                {
                    //serialPort?.Close();
                }
                //});
            }
        }
    }
}
