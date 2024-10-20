using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.IO;
using System.Net.Sockets;

namespace PosPrinter
{
    public class Connector
    {
        private bool writeLogs = false;

        private DeviceType deviceType;
        private string deviceName;
        private int port;
        private string ipAddr;

        //[DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        //private static extern SafeFileHandle CreateFile(
        //    string fileName,
        //    uint dwDesiredAccess,
        //    uint dwShareMode,
        //    IntPtr intptrSecurityAttributes,
        //    uint dwCreationDisposition,
        //    uint dwFlagsAndAttributes,
        //    IntPtr intptrTemplateFile
        //    );

        //enables debugging
        public Connector Debug()
        {
            this.writeLogs = true;
            return this;
        }

        public Connector InitDRV(string deviceName)
        {
            this.deviceType = DeviceType.DRV;
            this.deviceName = deviceName;
            return this;
        }

        public Connector InitSerial()
        {
            this.deviceType = DeviceType.Serial;
            return this;
        }

        public Connector InitLPT()
        {
            this.deviceType = DeviceType.LPT;
            return this;
        }

        public Connector InitTCP(string ipAddr, int port)
        {
            this.deviceType = DeviceType.TCP;
            this.ipAddr = ipAddr;
            this.port = port;
            return this;
        }

        public void Print(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                //log
                return;
            }

            this.Print(Encoding.Default.GetBytes(data));
        }

        public void Print(byte[] data)
        {
            if (data == null || data.Length == 0)
            {
                //log
                return;
            }

            switch (this.deviceType)
            {
                case DeviceType.DRV: break;
                case DeviceType.Serial:
                    {
                        //ToDo: parametrize more
                        SerialPort serial = new SerialPort(string.Format("{0}{1}", "COM", this.port), 9600, Parity.None, 8, StopBits.One);
                        try
                        {
                            //log open
                            serial.Open();
                            //ToDo: change to byte
                            serial.Write(data, 0, data.Length);
                            //serial.Write(data, 0, data.Length);
                        }
                        catch
                        {
                            //log error
                        }
                        finally
                        {
                            if (serial.IsOpen)
                            {
                                //log closed
                                serial.Close();
                            }
                        }
                    } break;
                case DeviceType.LPT:
                    {
                        //ToDo: check if this actually works with an ECS printer
                        //SafeFileHandle handle = null;
                        FileStream fs = null;
                        StreamWriter writer = null;

                        try
                        {
                            //handle = CreateFile();
                        }
                        catch
                        {
                        }
                        finally
                        {
                            if (fs != null)
                            {
                                fs.Close();
                                fs = null;
                            }
                            if (writer != null)
                            {
                                writer.Close();
                                writer = null;
                            }
                            //if (handle != null)
                            //{
                            //    handle.Close();
                            //    handle = null;
                            //}
                        }

                    } break;
                case DeviceType.TCP:
                    {
                        TcpClient tcp = new TcpClient();
                        try
                        {
                            tcp.Connect(this.ipAddr, this.port);
                            tcp.SendTimeout = 1000;
                            tcp.ReceiveTimeout = 1000;
                            if (tcp.Client.Connected)
                            {
                                tcp.Client.Send(data);
                            }
                        }
                        catch
                        {
                            //logError
                        }
                        finally
                        {
                            if (tcp != null)
                            {
                                if (tcp.Client != null)
                                {
                                    tcp.Client.Close();
                                    tcp.Client = null;
                                }
                                //log close
                                tcp.Close();
                                tcp = null;
                            }
                        }
                    } break;
                default: return; break;
            }
        }
    }

    // ToDo: move to seperate file
    public enum DeviceType
    {
        DRV,
        Serial,
        LPT,
        TCP,
    }
}
