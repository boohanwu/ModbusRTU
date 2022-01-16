
namespace ModbusRTU
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cb_portname = new System.Windows.Forms.ComboBox();
            this.cb_boudrate = new System.Windows.Forms.ComboBox();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.cb_databits = new System.Windows.Forms.ComboBox();
            this.cb_stopbit = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lb_stopbit = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.lb_databits = new System.Windows.Forms.Label();
            this.lb_parity = new System.Windows.Forms.Label();
            this.lb_baudrate = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cb_functionCode = new System.Windows.Forms.ComboBox();
            this.lb_function = new System.Windows.Forms.Label();
            this.lb_read_station = new System.Windows.Forms.Label();
            this.lb_read_startAddress = new System.Windows.Forms.Label();
            this.lb_read_length = new System.Windows.Forms.Label();
            this.tb_read_station = new System.Windows.Forms.TextBox();
            this.tb_read_startAddress = new System.Windows.Forms.TextBox();
            this.tb_read_length = new System.Windows.Forms.TextBox();
            this.gb_read = new System.Windows.Forms.GroupBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.lb_write_station = new System.Windows.Forms.Label();
            this.lb_write_startAddress = new System.Windows.Forms.Label();
            this.lb_write_data = new System.Windows.Forms.Label();
            this.tb_write_station = new System.Windows.Forms.TextBox();
            this.tb_write_startAddress = new System.Windows.Forms.TextBox();
            this.tb_write_data = new System.Windows.Forms.TextBox();
            this.btn_write = new System.Windows.Forms.Button();
            this.gb_write = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_read.SuspendLayout();
            this.gb_write.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_portname
            // 
            this.cb_portname.FormattingEnabled = true;
            this.cb_portname.Location = new System.Drawing.Point(61, 26);
            this.cb_portname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_portname.Name = "cb_portname";
            this.cb_portname.Size = new System.Drawing.Size(105, 23);
            this.cb_portname.TabIndex = 0;
            // 
            // cb_boudrate
            // 
            this.cb_boudrate.FormattingEnabled = true;
            this.cb_boudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cb_boudrate.Location = new System.Drawing.Point(249, 26);
            this.cb_boudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_boudrate.Name = "cb_boudrate";
            this.cb_boudrate.Size = new System.Drawing.Size(132, 23);
            this.cb_boudrate.TabIndex = 1;
            // 
            // cb_parity
            // 
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.cb_parity.Location = new System.Drawing.Point(445, 26);
            this.cb_parity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(132, 23);
            this.cb_parity.TabIndex = 2;
            // 
            // cb_databits
            // 
            this.cb_databits.FormattingEnabled = true;
            this.cb_databits.Items.AddRange(new object[] {
            "8"});
            this.cb_databits.Location = new System.Drawing.Point(659, 26);
            this.cb_databits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_databits.Name = "cb_databits";
            this.cb_databits.Size = new System.Drawing.Size(132, 23);
            this.cb_databits.TabIndex = 3;
            // 
            // cb_stopbit
            // 
            this.cb_stopbit.FormattingEnabled = true;
            this.cb_stopbit.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_stopbit.Location = new System.Drawing.Point(865, 26);
            this.cb_stopbit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_stopbit.Name = "cb_stopbit";
            this.cb_stopbit.Size = new System.Drawing.Size(132, 23);
            this.cb_stopbit.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.lb_stopbit);
            this.groupBox1.Controls.Add(this.cb_stopbit);
            this.groupBox1.Controls.Add(this.lb_port);
            this.groupBox1.Controls.Add(this.lb_databits);
            this.groupBox1.Controls.Add(this.cb_portname);
            this.groupBox1.Controls.Add(this.cb_databits);
            this.groupBox1.Controls.Add(this.lb_parity);
            this.groupBox1.Controls.Add(this.lb_baudrate);
            this.groupBox1.Controls.Add(this.cb_boudrate);
            this.groupBox1.Controls.Add(this.cb_parity);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1267, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_disconnect.Location = new System.Drawing.Point(1139, 24);
            this.btn_disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(100, 29);
            this.btn_disconnect.TabIndex = 6;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_connect.Location = new System.Drawing.Point(1031, 24);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 29);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // lb_stopbit
            // 
            this.lb_stopbit.AutoSize = true;
            this.lb_stopbit.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_stopbit.Location = new System.Drawing.Point(800, 30);
            this.lb_stopbit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_stopbit.Name = "lb_stopbit";
            this.lb_stopbit.Size = new System.Drawing.Size(56, 17);
            this.lb_stopbit.TabIndex = 9;
            this.lb_stopbit.Text = "StopBit";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_port.Location = new System.Drawing.Point(17, 30);
            this.lb_port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(34, 17);
            this.lb_port.TabIndex = 0;
            this.lb_port.Text = "Port";
            // 
            // lb_databits
            // 
            this.lb_databits.AutoSize = true;
            this.lb_databits.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_databits.Location = new System.Drawing.Point(587, 30);
            this.lb_databits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_databits.Name = "lb_databits";
            this.lb_databits.Size = new System.Drawing.Size(63, 17);
            this.lb_databits.TabIndex = 8;
            this.lb_databits.Text = "DataBits";
            // 
            // lb_parity
            // 
            this.lb_parity.AutoSize = true;
            this.lb_parity.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_parity.Location = new System.Drawing.Point(391, 30);
            this.lb_parity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_parity.Name = "lb_parity";
            this.lb_parity.Size = new System.Drawing.Size(45, 17);
            this.lb_parity.TabIndex = 7;
            this.lb_parity.Text = "Parity";
            // 
            // lb_baudrate
            // 
            this.lb_baudrate.AutoSize = true;
            this.lb_baudrate.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_baudrate.Location = new System.Drawing.Point(176, 30);
            this.lb_baudrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_baudrate.Name = "lb_baudrate";
            this.lb_baudrate.Size = new System.Drawing.Size(65, 17);
            this.lb_baudrate.TabIndex = 6;
            this.lb_baudrate.Text = "Baudrate";
            // 
            // cb_functionCode
            // 
            this.cb_functionCode.FormattingEnabled = true;
            this.cb_functionCode.Items.AddRange(new object[] {
            "01 Read Coil",
            "02 Read Disccrete Input",
            "03 Read Holding Registers",
            "04 Read Input Registers",
            "05 Write Single Coil",
            "06 Write Single Holding Register",
            "0F Write Multiple Coils",
            "10 Write Multiple Holding Registers"});
            this.cb_functionCode.Location = new System.Drawing.Point(144, 104);
            this.cb_functionCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_functionCode.Name = "cb_functionCode";
            this.cb_functionCode.Size = new System.Drawing.Size(449, 23);
            this.cb_functionCode.TabIndex = 6;
            this.cb_functionCode.SelectedIndexChanged += new System.EventHandler(this.cb_functionCode_SelectedIndexChanged);
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_function.Location = new System.Drawing.Point(33, 108);
            this.lb_function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(102, 17);
            this.lb_function.TabIndex = 7;
            this.lb_function.Text = "Function Code";
            // 
            // lb_read_station
            // 
            this.lb_read_station.AutoSize = true;
            this.lb_read_station.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_read_station.Location = new System.Drawing.Point(17, 31);
            this.lb_read_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_read_station.Name = "lb_read_station";
            this.lb_read_station.Size = new System.Drawing.Size(80, 17);
            this.lb_read_station.TabIndex = 8;
            this.lb_read_station.Text = "Station No.";
            // 
            // lb_read_startAddress
            // 
            this.lb_read_startAddress.AutoSize = true;
            this.lb_read_startAddress.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_read_startAddress.Location = new System.Drawing.Point(248, 31);
            this.lb_read_startAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_read_startAddress.Name = "lb_read_startAddress";
            this.lb_read_startAddress.Size = new System.Drawing.Size(93, 17);
            this.lb_read_startAddress.TabIndex = 9;
            this.lb_read_startAddress.Text = "Start Address";
            // 
            // lb_read_length
            // 
            this.lb_read_length.AutoSize = true;
            this.lb_read_length.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_read_length.Location = new System.Drawing.Point(493, 31);
            this.lb_read_length.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_read_length.Name = "lb_read_length";
            this.lb_read_length.Size = new System.Drawing.Size(87, 17);
            this.lb_read_length.TabIndex = 10;
            this.lb_read_length.Text = "Data Length";
            // 
            // tb_read_station
            // 
            this.tb_read_station.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_read_station.Location = new System.Drawing.Point(107, 26);
            this.tb_read_station.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_read_station.Name = "tb_read_station";
            this.tb_read_station.Size = new System.Drawing.Size(132, 27);
            this.tb_read_station.TabIndex = 11;
            // 
            // tb_read_startAddress
            // 
            this.tb_read_startAddress.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_read_startAddress.Location = new System.Drawing.Point(352, 26);
            this.tb_read_startAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_read_startAddress.Name = "tb_read_startAddress";
            this.tb_read_startAddress.Size = new System.Drawing.Size(132, 27);
            this.tb_read_startAddress.TabIndex = 12;
            // 
            // tb_read_length
            // 
            this.tb_read_length.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_read_length.Location = new System.Drawing.Point(588, 26);
            this.tb_read_length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_read_length.Name = "tb_read_length";
            this.tb_read_length.Size = new System.Drawing.Size(132, 27);
            this.tb_read_length.TabIndex = 13;
            // 
            // gb_read
            // 
            this.gb_read.Controls.Add(this.btn_read);
            this.gb_read.Controls.Add(this.tb_read_startAddress);
            this.gb_read.Controls.Add(this.tb_read_length);
            this.gb_read.Controls.Add(this.lb_read_station);
            this.gb_read.Controls.Add(this.lb_read_startAddress);
            this.gb_read.Controls.Add(this.tb_read_station);
            this.gb_read.Controls.Add(this.lb_read_length);
            this.gb_read.Location = new System.Drawing.Point(16, 150);
            this.gb_read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_read.Name = "gb_read";
            this.gb_read.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_read.Size = new System.Drawing.Size(1267, 75);
            this.gb_read.TabIndex = 14;
            this.gb_read.TabStop = false;
            this.gb_read.Text = "Read";
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_read.Location = new System.Drawing.Point(1031, 26);
            this.btn_read.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(100, 29);
            this.btn_read.TabIndex = 15;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // rtb_message
            // 
            this.rtb_message.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_message.Location = new System.Drawing.Point(16, 315);
            this.rtb_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(1265, 312);
            this.rtb_message.TabIndex = 15;
            this.rtb_message.Text = "";
            // 
            // lb_write_station
            // 
            this.lb_write_station.AutoSize = true;
            this.lb_write_station.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_write_station.Location = new System.Drawing.Point(17, 31);
            this.lb_write_station.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_write_station.Name = "lb_write_station";
            this.lb_write_station.Size = new System.Drawing.Size(80, 17);
            this.lb_write_station.TabIndex = 16;
            this.lb_write_station.Text = "Station No.";
            // 
            // lb_write_startAddress
            // 
            this.lb_write_startAddress.AutoSize = true;
            this.lb_write_startAddress.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_write_startAddress.Location = new System.Drawing.Point(248, 31);
            this.lb_write_startAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_write_startAddress.Name = "lb_write_startAddress";
            this.lb_write_startAddress.Size = new System.Drawing.Size(93, 17);
            this.lb_write_startAddress.TabIndex = 17;
            this.lb_write_startAddress.Text = "Start Address";
            // 
            // lb_write_data
            // 
            this.lb_write_data.AutoSize = true;
            this.lb_write_data.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_write_data.Location = new System.Drawing.Point(493, 31);
            this.lb_write_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_write_data.Name = "lb_write_data";
            this.lb_write_data.Size = new System.Drawing.Size(38, 17);
            this.lb_write_data.TabIndex = 18;
            this.lb_write_data.Text = "Data";
            // 
            // tb_write_station
            // 
            this.tb_write_station.Location = new System.Drawing.Point(107, 28);
            this.tb_write_station.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_write_station.Name = "tb_write_station";
            this.tb_write_station.Size = new System.Drawing.Size(132, 27);
            this.tb_write_station.TabIndex = 19;
            // 
            // tb_write_startAddress
            // 
            this.tb_write_startAddress.Location = new System.Drawing.Point(352, 28);
            this.tb_write_startAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_write_startAddress.Name = "tb_write_startAddress";
            this.tb_write_startAddress.Size = new System.Drawing.Size(132, 27);
            this.tb_write_startAddress.TabIndex = 20;
            // 
            // tb_write_data
            // 
            this.tb_write_data.Location = new System.Drawing.Point(540, 28);
            this.tb_write_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_write_data.Name = "tb_write_data";
            this.tb_write_data.Size = new System.Drawing.Size(457, 27);
            this.tb_write_data.TabIndex = 21;
            // 
            // btn_write
            // 
            this.btn_write.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_write.Location = new System.Drawing.Point(1031, 25);
            this.btn_write.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(100, 29);
            this.btn_write.TabIndex = 22;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // gb_write
            // 
            this.gb_write.Controls.Add(this.tb_write_startAddress);
            this.gb_write.Controls.Add(this.btn_write);
            this.gb_write.Controls.Add(this.lb_write_station);
            this.gb_write.Controls.Add(this.tb_write_data);
            this.gb_write.Controls.Add(this.lb_write_startAddress);
            this.gb_write.Controls.Add(this.lb_write_data);
            this.gb_write.Controls.Add(this.tb_write_station);
            this.gb_write.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_write.Location = new System.Drawing.Point(16, 232);
            this.gb_write.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_write.Name = "gb_write";
            this.gb_write.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_write.Size = new System.Drawing.Size(1267, 75);
            this.gb_write.TabIndex = 23;
            this.gb_write.TabStop = false;
            this.gb_write.Text = "Write";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_clear.Location = new System.Drawing.Point(1183, 644);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 29);
            this.btn_clear.TabIndex = 24;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 688);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.gb_write);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.gb_read);
            this.Controls.Add(this.lb_function);
            this.Controls.Add(this.cb_functionCode);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_read.ResumeLayout(false);
            this.gb_read.PerformLayout();
            this.gb_write.ResumeLayout(false);
            this.gb_write.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_portname;
        private System.Windows.Forms.ComboBox cb_boudrate;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.ComboBox cb_databits;
        private System.Windows.Forms.ComboBox cb_stopbit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_stopbit;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_databits;
        private System.Windows.Forms.Label lb_parity;
        private System.Windows.Forms.Label lb_baudrate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.ComboBox cb_functionCode;
        private System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.Label lb_read_station;
        private System.Windows.Forms.Label lb_read_startAddress;
        private System.Windows.Forms.Label lb_read_length;
        private System.Windows.Forms.TextBox tb_read_station;
        private System.Windows.Forms.TextBox tb_read_startAddress;
        private System.Windows.Forms.TextBox tb_read_length;
        private System.Windows.Forms.GroupBox gb_read;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.Label lb_write_station;
        private System.Windows.Forms.Label lb_write_startAddress;
        private System.Windows.Forms.Label lb_write_data;
        private System.Windows.Forms.TextBox tb_write_station;
        private System.Windows.Forms.TextBox tb_write_startAddress;
        private System.Windows.Forms.TextBox tb_write_data;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.GroupBox gb_write;
        private System.Windows.Forms.Button btn_clear;
    }
}

