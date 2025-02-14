namespace Supervisorio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Conexion_groupBox = new System.Windows.Forms.GroupBox();
            this.Conexion_Bar = new System.Windows.Forms.ProgressBar();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect_bt = new System.Windows.Forms.Button();
            this.Scan_bt = new System.Windows.Forms.Button();
            this.Baud_ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Ports_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.SerialMonitor_groupBox = new System.Windows.Forms.GroupBox();
            this.Serial_TexBox = new System.Windows.Forms.RichTextBox();
            this.UP_CheckBox = new System.Windows.Forms.CheckBox();
            this.Cear_BT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Enviar_bt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Robot_groupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Z_number = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Claw_checkBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.N_P = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.update_BT = new System.Windows.Forms.Button();
            this.Edit_BT = new System.Windows.Forms.Button();
            this.Delete_BT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Y_number = new System.Windows.Forms.NumericUpDown();
            this.X_Number = new System.Windows.Forms.NumericUpDown();
            this.NewPoint_BT = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Conexion_groupBox.SuspendLayout();
            this.SerialMonitor_groupBox.SuspendLayout();
            this.Robot_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Z_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Number)).BeginInit();
            this.SuspendLayout();
            // 
            // Conexion_groupBox
            // 
            this.Conexion_groupBox.Controls.Add(this.Conexion_Bar);
            this.Conexion_groupBox.Controls.Add(this.Disconnect);
            this.Conexion_groupBox.Controls.Add(this.Connect_bt);
            this.Conexion_groupBox.Controls.Add(this.Scan_bt);
            this.Conexion_groupBox.Controls.Add(this.Baud_ComboBox);
            this.Conexion_groupBox.Controls.Add(this.label2);
            this.Conexion_groupBox.Controls.Add(this.Ports_ComboBox);
            this.Conexion_groupBox.Controls.Add(this.label1);
            this.Conexion_groupBox.Location = new System.Drawing.Point(12, 12);
            this.Conexion_groupBox.Name = "Conexion_groupBox";
            this.Conexion_groupBox.Size = new System.Drawing.Size(374, 115);
            this.Conexion_groupBox.TabIndex = 0;
            this.Conexion_groupBox.TabStop = false;
            this.Conexion_groupBox.Text = "Conexion";
            // 
            // Conexion_Bar
            // 
            this.Conexion_Bar.Location = new System.Drawing.Point(67, 67);
            this.Conexion_Bar.Name = "Conexion_Bar";
            this.Conexion_Bar.Size = new System.Drawing.Size(121, 23);
            this.Conexion_Bar.TabIndex = 7;
            // 
            // Disconnect
            // 
            this.Disconnect.Enabled = false;
            this.Disconnect.Location = new System.Drawing.Point(194, 69);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(72, 22);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect_bt
            // 
            this.Connect_bt.Location = new System.Drawing.Point(194, 41);
            this.Connect_bt.Name = "Connect_bt";
            this.Connect_bt.Size = new System.Drawing.Size(72, 22);
            this.Connect_bt.TabIndex = 5;
            this.Connect_bt.Text = "Connect";
            this.Connect_bt.UseVisualStyleBackColor = true;
            this.Connect_bt.Click += new System.EventHandler(this.Connect_bt_Click);
            // 
            // Scan_bt
            // 
            this.Scan_bt.Location = new System.Drawing.Point(194, 13);
            this.Scan_bt.Name = "Scan_bt";
            this.Scan_bt.Size = new System.Drawing.Size(72, 22);
            this.Scan_bt.TabIndex = 4;
            this.Scan_bt.Text = "Scan";
            this.Scan_bt.UseVisualStyleBackColor = true;
            this.Scan_bt.Click += new System.EventHandler(this.Scan_bt_Click);
            // 
            // Baud_ComboBox
            // 
            this.Baud_ComboBox.FormattingEnabled = true;
            this.Baud_ComboBox.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "57600",
            "115200"});
            this.Baud_ComboBox.Location = new System.Drawing.Point(67, 40);
            this.Baud_ComboBox.Name = "Baud_ComboBox";
            this.Baud_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Baud_ComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // Ports_ComboBox
            // 
            this.Ports_ComboBox.FormattingEnabled = true;
            this.Ports_ComboBox.Location = new System.Drawing.Point(67, 13);
            this.Ports_ComboBox.Name = "Ports_ComboBox";
            this.Ports_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Ports_ComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM port:";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // SerialMonitor_groupBox
            // 
            this.SerialMonitor_groupBox.Controls.Add(this.Serial_TexBox);
            this.SerialMonitor_groupBox.Controls.Add(this.UP_CheckBox);
            this.SerialMonitor_groupBox.Controls.Add(this.Cear_BT);
            this.SerialMonitor_groupBox.Controls.Add(this.richTextBox1);
            this.SerialMonitor_groupBox.Controls.Add(this.Enviar_bt);
            this.SerialMonitor_groupBox.Location = new System.Drawing.Point(12, 133);
            this.SerialMonitor_groupBox.Name = "SerialMonitor_groupBox";
            this.SerialMonitor_groupBox.Size = new System.Drawing.Size(374, 383);
            this.SerialMonitor_groupBox.TabIndex = 1;
            this.SerialMonitor_groupBox.TabStop = false;
            this.SerialMonitor_groupBox.Text = "Serial Monitor";
            // 
            // Serial_TexBox
            // 
            this.Serial_TexBox.Location = new System.Drawing.Point(9, 317);
            this.Serial_TexBox.Name = "Serial_TexBox";
            this.Serial_TexBox.Size = new System.Drawing.Size(207, 50);
            this.Serial_TexBox.TabIndex = 14;
            this.Serial_TexBox.Text = "";
            // 
            // UP_CheckBox
            // 
            this.UP_CheckBox.AutoSize = true;
            this.UP_CheckBox.Enabled = false;
            this.UP_CheckBox.Location = new System.Drawing.Point(300, 319);
            this.UP_CheckBox.Name = "UP_CheckBox";
            this.UP_CheckBox.Size = new System.Drawing.Size(40, 17);
            this.UP_CheckBox.TabIndex = 13;
            this.UP_CheckBox.Text = "Up";
            this.UP_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Cear_BT
            // 
            this.Cear_BT.Location = new System.Drawing.Point(222, 345);
            this.Cear_BT.Name = "Cear_BT";
            this.Cear_BT.Size = new System.Drawing.Size(72, 22);
            this.Cear_BT.TabIndex = 11;
            this.Cear_BT.Text = "Clear";
            this.Cear_BT.UseVisualStyleBackColor = true;
            this.Cear_BT.Click += new System.EventHandler(this.Cear_BT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(359, 292);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Enviar_bt
            // 
            this.Enviar_bt.Enabled = false;
            this.Enviar_bt.Location = new System.Drawing.Point(222, 317);
            this.Enviar_bt.Name = "Enviar_bt";
            this.Enviar_bt.Size = new System.Drawing.Size(72, 22);
            this.Enviar_bt.TabIndex = 8;
            this.Enviar_bt.Text = "send";
            this.Enviar_bt.UseVisualStyleBackColor = true;
            this.Enviar_bt.Click += new System.EventHandler(this.Enviar_bt_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Robot_groupBox
            // 
            this.Robot_groupBox.Controls.Add(this.checkBox1);
            this.Robot_groupBox.Controls.Add(this.label7);
            this.Robot_groupBox.Controls.Add(this.button3);
            this.Robot_groupBox.Controls.Add(this.label6);
            this.Robot_groupBox.Controls.Add(this.Z_number);
            this.Robot_groupBox.Controls.Add(this.label5);
            this.Robot_groupBox.Controls.Add(this.Claw_checkBox);
            this.Robot_groupBox.Controls.Add(this.button2);
            this.Robot_groupBox.Controls.Add(this.N_P);
            this.Robot_groupBox.Controls.Add(this.button1);
            this.Robot_groupBox.Controls.Add(this.update_BT);
            this.Robot_groupBox.Controls.Add(this.Edit_BT);
            this.Robot_groupBox.Controls.Add(this.Delete_BT);
            this.Robot_groupBox.Controls.Add(this.label4);
            this.Robot_groupBox.Controls.Add(this.label3);
            this.Robot_groupBox.Controls.Add(this.Y_number);
            this.Robot_groupBox.Controls.Add(this.X_Number);
            this.Robot_groupBox.Controls.Add(this.NewPoint_BT);
            this.Robot_groupBox.Controls.Add(this.listBox1);
            this.Robot_groupBox.Location = new System.Drawing.Point(392, 12);
            this.Robot_groupBox.Name = "Robot_groupBox";
            this.Robot_groupBox.Size = new System.Drawing.Size(559, 505);
            this.Robot_groupBox.TabIndex = 15;
            this.Robot_groupBox.TabStop = false;
            this.Robot_groupBox.Text = "Robot";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(216, 181);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Mudar o formato dos dados enviados.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "version 0.4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 22);
            this.button3.TabIndex = 22;
            this.button3.Text = "Send Angles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Z:";
            // 
            // Z_number
            // 
            this.Z_number.Location = new System.Drawing.Point(384, 40);
            this.Z_number.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Z_number.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.Z_number.Name = "Z_number";
            this.Z_number.Size = new System.Drawing.Size(45, 20);
            this.Z_number.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "***********";
            // 
            // Claw_checkBox
            // 
            this.Claw_checkBox.AutoSize = true;
            this.Claw_checkBox.Location = new System.Drawing.Point(435, 42);
            this.Claw_checkBox.Name = "Claw_checkBox";
            this.Claw_checkBox.Size = new System.Drawing.Size(48, 17);
            this.Claw_checkBox.TabIndex = 15;
            this.Claw_checkBox.Text = "claw";
            this.Claw_checkBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 22);
            this.button2.TabIndex = 18;
            this.button2.Text = "Send points";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // N_P
            // 
            this.N_P.AutoSize = true;
            this.N_P.Location = new System.Drawing.Point(213, 16);
            this.N_P.Name = "N_P";
            this.N_P.Size = new System.Drawing.Size(104, 13);
            this.N_P.TabIndex = 17;
            this.N_P.Text = "Nuamero de Pontos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_BT
            // 
            this.update_BT.Location = new System.Drawing.Point(310, 67);
            this.update_BT.Name = "update_BT";
            this.update_BT.Size = new System.Drawing.Size(84, 22);
            this.update_BT.TabIndex = 14;
            this.update_BT.Text = "Update";
            this.update_BT.UseVisualStyleBackColor = true;
            this.update_BT.Click += new System.EventHandler(this.update_BT_Click);
            // 
            // Edit_BT
            // 
            this.Edit_BT.Location = new System.Drawing.Point(216, 124);
            this.Edit_BT.Name = "Edit_BT";
            this.Edit_BT.Size = new System.Drawing.Size(84, 22);
            this.Edit_BT.TabIndex = 13;
            this.Edit_BT.Text = "Edit";
            this.Edit_BT.UseVisualStyleBackColor = true;
            this.Edit_BT.Click += new System.EventHandler(this.Edit_BT_Click);
            // 
            // Delete_BT
            // 
            this.Delete_BT.Location = new System.Drawing.Point(216, 96);
            this.Delete_BT.Name = "Delete_BT";
            this.Delete_BT.Size = new System.Drawing.Size(84, 22);
            this.Delete_BT.TabIndex = 12;
            this.Delete_BT.Text = "Delete";
            this.Delete_BT.UseVisualStyleBackColor = true;
            this.Delete_BT.Click += new System.EventHandler(this.Delete_BT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X:";
            // 
            // Y_number
            // 
            this.Y_number.Location = new System.Drawing.Point(310, 39);
            this.Y_number.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.Y_number.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.Y_number.Name = "Y_number";
            this.Y_number.Size = new System.Drawing.Size(45, 20);
            this.Y_number.TabIndex = 10;
            // 
            // X_Number
            // 
            this.X_Number.Location = new System.Drawing.Point(236, 39);
            this.X_Number.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.X_Number.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.X_Number.Name = "X_Number";
            this.X_Number.Size = new System.Drawing.Size(45, 20);
            this.X_Number.TabIndex = 9;
            // 
            // NewPoint_BT
            // 
            this.NewPoint_BT.Location = new System.Drawing.Point(216, 69);
            this.NewPoint_BT.Name = "NewPoint_BT";
            this.NewPoint_BT.Size = new System.Drawing.Size(84, 22);
            this.NewPoint_BT.TabIndex = 8;
            this.NewPoint_BT.Text = "New Point";
            this.NewPoint_BT.UseVisualStyleBackColor = true;
            this.NewPoint_BT.Click += new System.EventHandler(this.NewPoint_BT_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 522);
            this.Controls.Add(this.Robot_groupBox);
            this.Controls.Add(this.SerialMonitor_groupBox);
            this.Controls.Add(this.Conexion_groupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed_1);
            this.Conexion_groupBox.ResumeLayout(false);
            this.Conexion_groupBox.PerformLayout();
            this.SerialMonitor_groupBox.ResumeLayout(false);
            this.SerialMonitor_groupBox.PerformLayout();
            this.Robot_groupBox.ResumeLayout(false);
            this.Robot_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Z_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Number)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Conexion_groupBox;
        private System.Windows.Forms.ComboBox Baud_ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Ports_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Scan_bt;
        private System.Windows.Forms.ProgressBar Conexion_Bar;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Connect_bt;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox SerialMonitor_groupBox;
        private System.Windows.Forms.Button Enviar_bt;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Cear_BT;
        private System.Windows.Forms.CheckBox UP_CheckBox;
        private System.Windows.Forms.RichTextBox Serial_TexBox;
        private System.Windows.Forms.GroupBox Robot_groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Y_number;
        private System.Windows.Forms.NumericUpDown X_Number;
        private System.Windows.Forms.Button NewPoint_BT;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Edit_BT;
        private System.Windows.Forms.Button Delete_BT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update_BT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label N_P;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox Claw_checkBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Z_number;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

