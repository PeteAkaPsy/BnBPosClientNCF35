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

        /// <summary>
        /// prints the data provided by connecting by use of TCP and closes the connection after sending the data
        /// </summary>
        /// <param name="data">the data to send to the printer</param>
        public void Print(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                //log
                return;
            }

            this.Print(Encoding.Default.GetBytes(data));
        }

        /// <summary>
        /// prints the data provided by connecting by use of TCP and closes the connection after sending the data
        /// </summary>
        /// <param name="data">the data to send to the printer</param>
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
                        System.Diagnostics.Debug.WriteLine("Trying to Print over IP to " + this.ipAddr + ":" + this.port);

                        NetworkStream ns = null;
                        Socket socket = null;
                        System.Net.IPEndPoint printerIP = null;
                        try
                        {
                            printerIP = new System.Net.IPEndPoint(System.Net.IPAddress.Parse(this.ipAddr), this.port);
                            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            socket.Connect(printerIP);
                            ns = new NetworkStream(socket);

                            ns.Write(data, 0, data.Length);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                        }
                        finally
                        {
                            if (ns != null)
                                ns.Close();
                            if (socket != null)
                                socket.Close();

                            System.Diagnostics.Debug.WriteLine("Connection Closed");
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
