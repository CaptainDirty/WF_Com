﻿
namespace WF_Com
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tBoxDataIN = new MetroFramework.Controls.MetroTextBox();
            this.tBoxH2O = new MetroFramework.Controls.MetroTextBox();
            this.cBoxBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.cBoxDataBits = new MetroFramework.Controls.MetroComboBox();
            this.cBoxStopBits = new MetroFramework.Controls.MetroComboBox();
            this.cBoxComPort = new MetroFramework.Controls.MetroComboBox();
            this.cBoxParityBits = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblStatusCom = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.cartesianChart3 = new LiveCharts.WinForms.CartesianChart();
            this.btnGraphWeightReset = new MetroFramework.Controls.MetroButton();
            this.btnGraphWeightStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tBoxStartWeight = new MetroFramework.Controls.MetroTextBox();
            this.tBoxTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tBoxFinishWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tBoxUbyl = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBoxVlazh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.TimerSushka = new System.Windows.Forms.Timer(this.components);
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.tBoxDry = new MetroFramework.Controls.MetroTextBox();
            this.btnResetValues = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(423, 308);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(297, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 23);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 28);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Отключить";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(8, 23);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(127, 28);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Соединить";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 78);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(281, 28);
            this.progressBar1.TabIndex = 17;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.BackColor = System.Drawing.Color.White;
            this.tBoxDataIN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tBoxDataIN.Location = new System.Drawing.Point(804, 210);
            this.tBoxDataIN.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(129, 28);
            this.tBoxDataIN.TabIndex = 18;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // tBoxH2O
            // 
            this.tBoxH2O.Location = new System.Drawing.Point(1407, 290);
            this.tBoxH2O.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxH2O.Name = "tBoxH2O";
            this.tBoxH2O.Size = new System.Drawing.Size(129, 28);
            this.tBoxH2O.TabIndex = 19;
            this.tBoxH2O.TextChanged += new System.EventHandler(this.tBoxH2O_TextChanged);
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.ItemHeight = 24;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "134400",
            "161280",
            "201600",
            "230400",
            "268800",
            "403200",
            "460800",
            "614400",
            "806400",
            "921600",
            "1228800",
            "3000000",
            "4000000",
            "5000000",
            "6000000",
            "12000000"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(168, 231);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(160, 30);
            this.cBoxBaudRate.TabIndex = 17;
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.ItemHeight = 24;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(168, 292);
            this.cBoxDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(160, 30);
            this.cBoxDataBits.TabIndex = 18;
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.ItemHeight = 24;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(168, 351);
            this.cBoxStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(160, 30);
            this.cBoxStopBits.TabIndex = 19;
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.ItemHeight = 24;
            this.cBoxComPort.Location = new System.Drawing.Point(168, 172);
            this.cBoxComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(160, 30);
            this.cBoxComPort.TabIndex = 16;
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.ItemHeight = 24;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "Xon/Xoff",
            "Hardware",
            "None"});
            this.cBoxParityBits.Location = new System.Drawing.Point(168, 409);
            this.cBoxParityBits.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(160, 30);
            this.cBoxParityBits.TabIndex = 20;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 185);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 20);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "COM PORT";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 244);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(89, 20);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "BAUDE RATE";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 304);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "DATA BITS";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(40, 363);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 20);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "STOP BITS";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(40, 421);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(81, 20);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "PARITY BITS";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(803, 183);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(105, 20);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Текущий вес, г";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(1407, 263);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(140, 20);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Содержание воды, г";
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Cursor = System.Windows.Forms.Cursors.Help;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(261, 25);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(719, 70);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Лабораторная работа\r\n\"Исследование режимов и способов сушки влажных материалов\"";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Cursor = System.Windows.Forms.Cursors.Help;
            this.metroLabel9.Location = new System.Drawing.Point(68, 129);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(220, 23);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Настройки COM-Порта";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(479, 158);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(148, 20);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Соединение активно:";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusCom.Location = new System.Drawing.Point(516, 230);
            this.lblStatusCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(114, 52);
            this.lblStatusCom.TabIndex = 30;
            this.lblStatusCom.Text = "НЕТ";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 501);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1621, 415);
            this.metroTabControl1.TabIndex = 31;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cartesianChart1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1613, 372);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "График с весом";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(-5, 4);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1621, 363);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.CausesValidation = false;
            this.metroTabPage2.Controls.Add(this.cartesianChart2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1613, 372);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "График влажности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(-5, 1);
            this.cartesianChart2.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1621, 366);
            this.cartesianChart2.TabIndex = 3;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.CausesValidation = false;
            this.metroTabPage3.Controls.Add(this.cartesianChart3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarSize = 12;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1613, 372);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "График этапов сушки";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarSize = 13;
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(-5, 1);
            this.cartesianChart3.Margin = new System.Windows.Forms.Padding(4);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(1621, 366);
            this.cartesianChart3.TabIndex = 4;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // btnGraphWeightReset
            // 
            this.btnGraphWeightReset.Location = new System.Drawing.Point(1069, 436);
            this.btnGraphWeightReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraphWeightReset.Name = "btnGraphWeightReset";
            this.btnGraphWeightReset.Size = new System.Drawing.Size(155, 48);
            this.btnGraphWeightReset.TabIndex = 5;
            this.btnGraphWeightReset.Text = "СТОП";
            this.btnGraphWeightReset.Click += new System.EventHandler(this.btnGraphWeightReset_Click);
            // 
            // btnGraphWeightStart
            // 
            this.btnGraphWeightStart.Location = new System.Drawing.Point(891, 436);
            this.btnGraphWeightStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnGraphWeightStart.Name = "btnGraphWeightStart";
            this.btnGraphWeightStart.Size = new System.Drawing.Size(155, 48);
            this.btnGraphWeightStart.TabIndex = 3;
            this.btnGraphWeightStart.Text = "СТАРТ";
            this.btnGraphWeightStart.Click += new System.EventHandler(this.btnGraphWeightStart_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(803, 263);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(108, 20);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Время сушки, с";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(1203, 183);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(132, 20);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Начальная масса, г";
            // 
            // tBoxStartWeight
            // 
            this.tBoxStartWeight.Location = new System.Drawing.Point(1203, 210);
            this.tBoxStartWeight.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxStartWeight.Name = "tBoxStartWeight";
            this.tBoxStartWeight.Size = new System.Drawing.Size(131, 28);
            this.tBoxStartWeight.TabIndex = 34;
            // 
            // tBoxTime
            // 
            this.tBoxTime.Location = new System.Drawing.Point(804, 290);
            this.tBoxTime.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxTime.Name = "tBoxTime";
            this.tBoxTime.ReadOnly = true;
            this.tBoxTime.Size = new System.Drawing.Size(131, 28);
            this.tBoxTime.TabIndex = 35;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(1203, 263);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(125, 20);
            this.metroLabel13.TabIndex = 36;
            this.metroLabel13.Text = "Конечная масса, г";
            // 
            // tBoxFinishWeight
            // 
            this.tBoxFinishWeight.Location = new System.Drawing.Point(1203, 290);
            this.tBoxFinishWeight.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxFinishWeight.Name = "tBoxFinishWeight";
            this.tBoxFinishWeight.Size = new System.Drawing.Size(131, 28);
            this.tBoxFinishWeight.TabIndex = 37;
            this.tBoxFinishWeight.TextChanged += new System.EventHandler(this.tBoxFinishWeight_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(787, 128);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(117, 25);
            this.metroLabel14.TabIndex = 38;
            this.metroLabel14.Text = "Мониторинг:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.Location = new System.Drawing.Point(1241, 128);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(184, 25);
            this.metroLabel16.TabIndex = 40;
            this.metroLabel16.Text = "Расчётные значения:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(1407, 183);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(101, 20);
            this.metroLabel17.TabIndex = 42;
            this.metroLabel17.Text = "Убыль влаги, г";
            // 
            // tBoxUbyl
            // 
            this.tBoxUbyl.Location = new System.Drawing.Point(1407, 210);
            this.tBoxUbyl.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxUbyl.Name = "tBoxUbyl";
            this.tBoxUbyl.Size = new System.Drawing.Size(129, 28);
            this.tBoxUbyl.TabIndex = 41;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tBoxVlazh
            // 
            this.tBoxVlazh.Location = new System.Drawing.Point(1407, 380);
            this.tBoxVlazh.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxVlazh.Name = "tBoxVlazh";
            this.tBoxVlazh.Size = new System.Drawing.Size(129, 28);
            this.tBoxVlazh.TabIndex = 43;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(1407, 350);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(97, 20);
            this.metroLabel18.TabIndex = 44;
            this.metroLabel18.Text = "Влажность, %";
            // 
            // TimerSushka
            // 
            this.TimerSushka.Interval = 1000;
            this.TimerSushka.Tick += new System.EventHandler(this.TimerSushka_Tick);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(971, 128);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(164, 25);
            this.metroLabel15.TabIndex = 45;
            this.metroLabel15.Text = "Исходные данные:";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(971, 183);
            this.metroLabel19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(168, 20);
            this.metroLabel19.TabIndex = 46;
            this.metroLabel19.Text = "Масса сухой заготовки, г";
            // 
            // tBoxDry
            // 
            this.tBoxDry.Location = new System.Drawing.Point(1003, 210);
            this.tBoxDry.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxDry.Name = "tBoxDry";
            this.tBoxDry.Size = new System.Drawing.Size(131, 28);
            this.tBoxDry.TabIndex = 47;
            this.tBoxDry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDry_KeyPress);
            // 
            // btnResetValues
            // 
            this.btnResetValues.Location = new System.Drawing.Point(1241, 452);
            this.btnResetValues.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetValues.Name = "btnResetValues";
            this.btnResetValues.Size = new System.Drawing.Size(200, 32);
            this.btnResetValues.TabIndex = 48;
            this.btnResetValues.Text = "Сбросить значения";
            this.btnResetValues.Click += new System.EventHandler(this.btnResetValues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1621, 916);
            this.Controls.Add(this.btnResetValues);
            this.Controls.Add(this.tBoxDry);
            this.Controls.Add(this.metroLabel19);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.tBoxVlazh);
            this.Controls.Add(this.btnGraphWeightReset);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.tBoxUbyl);
            this.Controls.Add(this.btnGraphWeightStart);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.tBoxFinishWeight);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tBoxTime);
            this.Controls.Add(this.tBoxStartWeight);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lblStatusCom);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cBoxParityBits);
            this.Controls.Add(this.cBoxComPort);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cBoxStopBits);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cBoxDataBits);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cBoxBaudRate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tBoxH2O);
            this.Controls.Add(this.tBoxDataIN);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Исследование режимов и способов сушки влажных материалов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroTextBox tBoxDataIN;
        private MetroFramework.Controls.MetroTextBox tBoxH2O;
        private MetroFramework.Controls.MetroComboBox cBoxBaudRate;
        private MetroFramework.Controls.MetroComboBox cBoxDataBits;
        private MetroFramework.Controls.MetroComboBox cBoxStopBits;
        private MetroFramework.Controls.MetroComboBox cBoxComPort;
        private MetroFramework.Controls.MetroComboBox cBoxParityBits;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Label lblStatusCom;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox tBoxStartWeight;
        private MetroFramework.Controls.MetroTextBox tBoxTime;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tBoxFinishWeight;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox tBoxUbyl;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton btnGraphWeightReset;
        private MetroFramework.Controls.MetroButton btnGraphWeightStart;
        private MetroFramework.Controls.MetroTextBox tBoxVlazh;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.Timer TimerSushka;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox tBoxDry;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private MetroFramework.Controls.MetroButton btnResetValues;
    }
}

