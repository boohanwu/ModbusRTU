using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modbus.Device;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;

namespace ModbusRTU
{
    public partial class Form1 : Form
    {
        private static IModbusMaster Master;
        private static SerialPort Port;
        // Coils and Registers
        private bool[] CoilsBuffer;
        private ushort[] RegisterBuffer;
        // Function Code
        private string FunctionCode;
        // Number of Station (Slave Address), Starting Address, Data Length
        private byte SlaveAddress;
        private ushort StartAddress;
        private ushort NumberOfPoints;
        // COM Port parameters
        private string PortName;
        private int BaudRate;
        private Parity parity;
        private int DataBits;
        private StopBits stopBits;
        // Display time
        public DateTime PresentTime;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_portname.Items.AddRange(SerialPort.GetPortNames());
            cb_boudrate.SelectedIndex = 6;
            cb_parity.SelectedIndex = 2;
            cb_databits.SelectedIndex = 0;
            cb_stopbit.SelectedIndex = 0;
            gb_read.Enabled = false;
            gb_write.Enabled = false;
        }
        /// <summary>
        /// Initialize the parameters of COM port
        /// </summary>
        /// <returns></returns>
        private SerialPort InitSerialPortParameter()
        {
            if (cb_portname.SelectedIndex < 0 || cb_boudrate.SelectedIndex < 0 || cb_parity.SelectedIndex < 0 || cb_databits.SelectedIndex < 0 || cb_stopbit.SelectedIndex < 0)
            {
                MessageBox.Show("Please Set the COM Port!");
                return null;
            }
            else
            {
                PortName = cb_portname.SelectedItem.ToString();
                BaudRate = int.Parse(cb_boudrate.SelectedItem.ToString());
                switch (cb_parity.SelectedItem.ToString())
                {
                    case "Odd":
                        parity = Parity.Odd;
                        break;
                    case "Even":
                        parity = Parity.Even;
                        break;
                    case "None":
                        parity = Parity.None;
                        break;
                    default:
                        break;
                }
                DataBits = int.Parse(cb_databits.SelectedItem.ToString());
                switch (cb_stopbit.SelectedItem.ToString())
                {
                    case "1":
                        stopBits = StopBits.One;
                        break;
                    case "2":
                        stopBits = StopBits.Two;
                        break;
                    default:
                        break;
                }
                Port = new SerialPort(PortName, BaudRate, parity, DataBits, stopBits);
                return Port;
            }
        }
        /// <summary>
        /// Serial port connect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_connect_Click(object sender, EventArgs e)
        {
            try
            {
                InitSerialPortParameter();
                Master = ModbusSerialMaster.CreateRtu(Port);
                gb_read.Enabled = true;
                gb_write.Enabled = true;
                SetMsg("Connect Successfully! \n");
            }
            catch (Exception)
            {
                MessageBox.Show("Initialize Failed");
            }
        }
        /// <summary>
        /// Function code
        /// </summary>
        private async void ExecuteFunction()
        {
            try
            {
                if (Port.IsOpen == false) Port.Open();
                if (FunctionCode != null)
                {
                    PresentTime = DateTime.Now;
                    switch (FunctionCode)
                    {
                        case "01 Read Coil":
                            SetReadParameters();
                            CoilsBuffer = Master.ReadCoils(SlaveAddress, StartAddress, NumberOfPoints);
                            SetMsg(PresentTime.ToString() + "  >>  ");
                            for (int i = 0; i < CoilsBuffer.Length; i++)
                            {
                                SetMsg(CoilsBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "02 Read Disccrete Input":
                            SetReadParameters();
                            CoilsBuffer = Master.ReadInputs(SlaveAddress, StartAddress, NumberOfPoints);
                            SetMsg(PresentTime.ToString() + "  >>  ");
                            for (int i = 0; i < CoilsBuffer.Length; i++)
                            {
                                SetMsg(CoilsBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "03 Read Holding Registers":
                            SetReadParameters();
                            RegisterBuffer = Master.ReadHoldingRegisters(SlaveAddress, StartAddress, NumberOfPoints);
                            SetMsg(PresentTime.ToString() + "  >>  ");
                            for (int i = 0; i < RegisterBuffer.Length; i++)
                            {
                                SetMsg(RegisterBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "04 Read Input Registers":
                            SetReadParameters();
                            RegisterBuffer = Master.ReadInputRegisters(SlaveAddress, StartAddress, NumberOfPoints);
                            SetMsg(PresentTime.ToString() + "  >>  ");
                            for (int i = 0; i < RegisterBuffer.Length; i++)
                            {
                                SetMsg(RegisterBuffer[i] + " ");
                            }
                            SetMsg("\r\n");
                            break;
                        case "05 Write Single Coil":
                            SetWriteParameters();
                            await Master.WriteSingleCoilAsync(SlaveAddress, StartAddress, CoilsBuffer[0]);
                            break;
                        case "06 Write Single Holding Register":
                            SetWriteParameters();
                            await Master.WriteSingleRegisterAsync(SlaveAddress, StartAddress, RegisterBuffer[0]);
                            break;
                        case "0F Write Multiple Coils":
                            SetWriteParameters();
                            await Master.WriteMultipleCoilsAsync(SlaveAddress, StartAddress, CoilsBuffer);
                            break;
                        case "10 Write Multiple Holding Registers":
                            SetWriteParameters();
                            await Master.WriteMultipleRegistersAsync(SlaveAddress, StartAddress, RegisterBuffer);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please choose the function code!");
                }
                //Port.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Read and Write mode switcher
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_functionCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_functionCode.SelectedIndex <= 3)
            {
                // Write Operation
                gb_read.Enabled = true;
                gb_write.Enabled = false;
            }
            else
            {
                // Read Operation
                gb_read.Enabled = false;
                gb_write.Enabled = true;
            }
            cb_functionCode.Invoke(new Action(() => { FunctionCode = cb_functionCode.SelectedItem.ToString(); }));
        }
        /// <summary>
        /// Initialize parameters of read operation
        /// </summary>
        private void SetReadParameters()
        {
            if (tb_read_station.Text == "" || tb_read_startAddress.Text == "" || tb_read_length.Text == "")
            {
                MessageBox.Show("Please fill the parameters!");
            }
            else
            {
                SlaveAddress = byte.Parse(tb_read_station.Text);
                StartAddress = ushort.Parse(tb_read_startAddress.Text);
                NumberOfPoints = ushort.Parse(tb_read_length.Text);
            }
        }
        /// <summary>
        /// Initialize parameters of write operation
        /// </summary>
        private void SetWriteParameters()
        {
            if (tb_write_station.Text == "" || tb_write_startAddress.Text == "" || tb_write_data.Text == "")
            {
                MessageBox.Show("Please fill the parameters!");
            }
            else
            {
                SlaveAddress = byte.Parse(tb_write_station.Text);
                StartAddress = ushort.Parse(tb_write_startAddress.Text);
                // Write Coils
                if(cb_functionCode.SelectedIndex == 4 || cb_functionCode.SelectedIndex == 6)
                {
                    string[] strarr = tb_write_data.Text.Split(' ');
                    CoilsBuffer = new bool[strarr.Length];
                    for(int i = 0; i < strarr.Length; i++)
                    {
                        if(strarr[i] == "0")
                        {
                            CoilsBuffer[i] = false;
                        }
                        else
                        {
                            CoilsBuffer[i] = true;
                        }
                    }
                }
                else
                {
                    string[] strarr = tb_write_data.Text.Split(' ');
                    RegisterBuffer = new ushort[strarr.Length];
                    for(int i = 0; i < strarr.Length; i++)
                    {
                        RegisterBuffer[i] = ushort.Parse(strarr[i]);
                    }
                }
            }
        }
        /// <summary>
        /// Set Message
        /// </summary>
        /// <param name="msg"></param>
        public void SetMsg(string msg)
        {
            rtb_message.Invoke(new Action(() => { rtb_message.AppendText(msg); }));
        }
        /// <summary>
        /// Clear Message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_message.Clear();
        }
        /// <summary>
        /// Read operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteFunction();
            }
            catch
            {
                MessageBox.Show("Read Error");
            }
            
        }
        /// <summary>
        /// Write operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                ExecuteFunction();
            }
            catch
            {
                MessageBox.Show("Write Error");
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen == true)
            {
                Port.Close();
                SetMsg("Disconnecting... \n");
            }
        }
    }
}
