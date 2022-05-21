
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
            this.btnGraphWeightReset = new MetroFramework.Controls.MetroButton();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.btnGraphWeightStart = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.tBoxStartWeight = new MetroFramework.Controls.MetroTextBox();
            this.tBoxTimeToFresh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tBoxFinishWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tBoxUbyl = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBoxVlazh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(349, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Отключить";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(95, 23);
            this.btnOpen.TabIndex = 18;
            this.btnOpen.Text = "Соеденить";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 23);
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
            this.tBoxDataIN.Location = new System.Drawing.Point(681, 172);
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(97, 23);
            this.tBoxDataIN.TabIndex = 18;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            // 
            // tBoxH2O
            // 
            this.tBoxH2O.Location = new System.Drawing.Point(980, 237);
            this.tBoxH2O.Name = "tBoxH2O";
            this.tBoxH2O.Size = new System.Drawing.Size(97, 23);
            this.tBoxH2O.TabIndex = 19;
            this.tBoxH2O.TextChanged += new System.EventHandler(this.tBoxH2O_TextChanged);
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.ItemHeight = 23;
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
            this.cBoxBaudRate.Location = new System.Drawing.Point(126, 188);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 29);
            this.cBoxBaudRate.TabIndex = 17;
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.ItemHeight = 23;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(126, 237);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 29);
            this.cBoxDataBits.TabIndex = 18;
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.ItemHeight = 23;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(126, 285);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 29);
            this.cBoxStopBits.TabIndex = 19;
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.ItemHeight = 23;
            this.cBoxComPort.Location = new System.Drawing.Point(126, 140);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 29);
            this.cBoxComPort.TabIndex = 16;
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.ItemHeight = 23;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "Xon/Xoff",
            "Hardware",
            "None"});
            this.cBoxParityBits.Location = new System.Drawing.Point(126, 332);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 29);
            this.cBoxParityBits.TabIndex = 20;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 150);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "COM PORT";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "BAUDE RATE";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 247);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "DATA BITS";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 295);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "STOP BITS";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(30, 342);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "PARITY BITS";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(680, 150);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Текущий вес, г";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(980, 215);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(134, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Содержание воды, г";
            // 
            // metroLabel8
            // 
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.Cursor = System.Windows.Forms.Cursors.Help;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(196, 20);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(512, 57);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Лабораторная работа\r\n\"Изучение различных способов сушки\"";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Cursor = System.Windows.Forms.Cursors.Help;
            this.metroLabel9.Location = new System.Drawing.Point(51, 105);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(165, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Настройки COM-Порта";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(391, 125);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(142, 19);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Соединение активно:";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusCom.Location = new System.Drawing.Point(419, 184);
            this.lblStatusCom.Name = "lblStatusCom";
            this.lblStatusCom.Size = new System.Drawing.Size(89, 39);
            this.lblStatusCom.TabIndex = 30;
            this.lblStatusCom.Text = "НЕТ";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 387);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1176, 337);
            this.metroTabControl1.TabIndex = 31;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cartesianChart1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1168, 298);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "График с весом";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btnGraphWeightReset
            // 
            this.btnGraphWeightReset.Location = new System.Drawing.Point(802, 354);
            this.btnGraphWeightReset.Name = "btnGraphWeightReset";
            this.btnGraphWeightReset.Size = new System.Drawing.Size(116, 39);
            this.btnGraphWeightReset.TabIndex = 5;
            this.btnGraphWeightReset.Text = "СТОП";
            this.btnGraphWeightReset.Click += new System.EventHandler(this.btnGraphWeightReset_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(-4, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1176, 296);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // btnGraphWeightStart
            // 
            this.btnGraphWeightStart.Location = new System.Drawing.Point(668, 354);
            this.btnGraphWeightStart.Name = "btnGraphWeightStart";
            this.btnGraphWeightStart.Size = new System.Drawing.Size(116, 39);
            this.btnGraphWeightStart.TabIndex = 3;
            this.btnGraphWeightStart.Text = "СТАРТ";
            this.btnGraphWeightStart.Click += new System.EventHandler(this.btnGraphWeightStart_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1168, 298);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "График влажности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1168, 298);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "График этапов сушки";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(680, 215);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Время сушки, с";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(827, 150);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Начальная масса, г";
            // 
            // tBoxStartWeight
            // 
            this.tBoxStartWeight.Location = new System.Drawing.Point(827, 172);
            this.tBoxStartWeight.Name = "tBoxStartWeight";
            this.tBoxStartWeight.Size = new System.Drawing.Size(98, 23);
            this.tBoxStartWeight.TabIndex = 34;
            // 
            // tBoxTimeToFresh
            // 
            this.tBoxTimeToFresh.Location = new System.Drawing.Point(681, 237);
            this.tBoxTimeToFresh.Name = "tBoxTimeToFresh";
            this.tBoxTimeToFresh.Size = new System.Drawing.Size(98, 23);
            this.tBoxTimeToFresh.TabIndex = 35;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(827, 215);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(119, 19);
            this.metroLabel13.TabIndex = 36;
            this.metroLabel13.Text = "Конечная масса, г";
            // 
            // tBoxFinishWeight
            // 
            this.tBoxFinishWeight.Location = new System.Drawing.Point(827, 237);
            this.tBoxFinishWeight.Name = "tBoxFinishWeight";
            this.tBoxFinishWeight.Size = new System.Drawing.Size(98, 23);
            this.tBoxFinishWeight.TabIndex = 37;
            this.tBoxFinishWeight.TextChanged += new System.EventHandler(this.tBoxFinishWeight_TextChanged);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(668, 105);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(114, 25);
            this.metroLabel14.TabIndex = 38;
            this.metroLabel14.Text = "Мониторинг:";
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(802, 105);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(158, 25);
            this.metroLabel15.TabIndex = 39;
            this.metroLabel15.Text = "Введите значения:";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel16.Location = new System.Drawing.Point(980, 105);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(178, 25);
            this.metroLabel16.TabIndex = 40;
            this.metroLabel16.Text = "Расчётные значения:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(980, 150);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(97, 19);
            this.metroLabel17.TabIndex = 42;
            this.metroLabel17.Text = "Убыль влаги, г";
            // 
            // tBoxUbyl
            // 
            this.tBoxUbyl.Location = new System.Drawing.Point(980, 172);
            this.tBoxUbyl.Name = "tBoxUbyl";
            this.tBoxUbyl.Size = new System.Drawing.Size(97, 23);
            this.tBoxUbyl.TabIndex = 41;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tBoxVlazh
            // 
            this.tBoxVlazh.Location = new System.Drawing.Point(980, 310);
            this.tBoxVlazh.Name = "tBoxVlazh";
            this.tBoxVlazh.Size = new System.Drawing.Size(97, 23);
            this.tBoxVlazh.TabIndex = 43;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(980, 285);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(91, 19);
            this.metroLabel18.TabIndex = 44;
            this.metroLabel18.Text = "Влажность, %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 744);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.tBoxVlazh);
            this.Controls.Add(this.btnGraphWeightReset);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.tBoxUbyl);
            this.Controls.Add(this.btnGraphWeightStart);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.tBoxFinishWeight);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.tBoxTimeToFresh);
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
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox tBoxTimeToFresh;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox tBoxFinishWeight;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox tBoxUbyl;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton btnGraphWeightReset;
        private MetroFramework.Controls.MetroButton btnGraphWeightStart;
        private MetroFramework.Controls.MetroTextBox tBoxVlazh;
        private MetroFramework.Controls.MetroLabel metroLabel18;
    }
}

