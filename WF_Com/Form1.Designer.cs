
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
            this.cBoxComPort = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
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
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.tBoxUbyl = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tBoxVlazh = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.TimerSushka = new System.Windows.Forms.Timer(this.components);
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.btnResetValues = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиCOMпортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bAUDERATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBoxBaudRate = new System.Windows.Forms.ToolStripComboBox();
            this.dATABITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBoxDataBits = new System.Windows.Forms.ToolStripComboBox();
            this.sTOPBITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBoxStopBits = new System.Windows.Forms.ToolStripComboBox();
            this.pARITYBITSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBoxParityBits = new System.Windows.Forms.ToolStripComboBox();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBoxDry = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(42, 236);
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
            this.btnOpen.Text = "Соединить";
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
            this.tBoxDataIN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxDataIN.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tBoxDataIN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 44);
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(97, 23);
            this.tBoxDataIN.TabIndex = 18;
            this.tBoxDataIN.TextChanged += new System.EventHandler(this.tBoxDataIN_TextChanged);
            this.tBoxDataIN.Click += new System.EventHandler(this.tBoxDataIN_Click);
            // 
            // tBoxH2O
            // 
            this.tBoxH2O.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxH2O.Location = new System.Drawing.Point(16, 140);
            this.tBoxH2O.Name = "tBoxH2O";
            this.tBoxH2O.Size = new System.Drawing.Size(97, 23);
            this.tBoxH2O.TabIndex = 19;
            this.tBoxH2O.TextChanged += new System.EventHandler(this.tBoxH2O_TextChanged);
            this.tBoxH2O.Click += new System.EventHandler(this.tBoxH2O_Click);
            // 
            // cBoxComPort
            // 
            this.cBoxComPort.FormattingEnabled = true;
            this.cBoxComPort.ItemHeight = 23;
            this.cBoxComPort.Location = new System.Drawing.Point(126, 87);
            this.cBoxComPort.Name = "cBoxComPort";
            this.cBoxComPort.Size = new System.Drawing.Size(121, 29);
            this.cBoxComPort.TabIndex = 16;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "COM PORT";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(6, 22);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Текущий вес, г";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 118);
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
            this.metroLabel8.Location = new System.Drawing.Point(287, 36);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(539, 57);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel8.TabIndex = 27;
            this.metroLabel8.Text = "Лабораторная работа\r\n\"Исследование режимов и способов сушки влажных материалов\"";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel9
            // 
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.Cursor = System.Windows.Forms.Cursors.Help;
            this.metroLabel9.Location = new System.Drawing.Point(64, 56);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(165, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel9.TabIndex = 28;
            this.metroLabel9.Text = "Выберите COM-Порт";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(87, 155);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(142, 19);
            this.metroLabel10.TabIndex = 29;
            this.metroLabel10.Text = "Соединение активно:";
            // 
            // lblStatusCom
            // 
            this.lblStatusCom.AutoSize = true;
            this.lblStatusCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusCom.Location = new System.Drawing.Point(113, 184);
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
            this.metroTabControl1.Location = new System.Drawing.Point(0, 361);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(974, 304);
            this.metroTabControl1.TabIndex = 31;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cartesianChart1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(966, 265);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "График с весом";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(-4, 0);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(974, 264);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.CausesValidation = false;
            this.metroTabPage2.Controls.Add(this.cartesianChart2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(966, 265);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "График влажности";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Location = new System.Drawing.Point(-4, 0);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(974, 264);
            this.cartesianChart2.TabIndex = 3;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.CausesValidation = false;
            this.metroTabPage3.Controls.Add(this.cartesianChart3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(966, 265);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "График этапов сушки";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // cartesianChart3
            // 
            this.cartesianChart3.Location = new System.Drawing.Point(-4, 0);
            this.cartesianChart3.Name = "cartesianChart3";
            this.cartesianChart3.Size = new System.Drawing.Size(974, 264);
            this.cartesianChart3.TabIndex = 4;
            this.cartesianChart3.Text = "cartesianChart3";
            // 
            // btnGraphWeightReset
            // 
            this.btnGraphWeightReset.Location = new System.Drawing.Point(641, 333);
            this.btnGraphWeightReset.Name = "btnGraphWeightReset";
            this.btnGraphWeightReset.Size = new System.Drawing.Size(116, 39);
            this.btnGraphWeightReset.TabIndex = 5;
            this.btnGraphWeightReset.Text = "СТОП";
            this.btnGraphWeightReset.Click += new System.EventHandler(this.btnGraphWeightReset_Click);
            // 
            // btnGraphWeightStart
            // 
            this.btnGraphWeightStart.Location = new System.Drawing.Point(495, 333);
            this.btnGraphWeightStart.Name = "btnGraphWeightStart";
            this.btnGraphWeightStart.Size = new System.Drawing.Size(116, 39);
            this.btnGraphWeightStart.TabIndex = 3;
            this.btnGraphWeightStart.Text = "СТАРТ";
            this.btnGraphWeightStart.Click += new System.EventHandler(this.btnGraphWeightStart_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(6, 74);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Время сушки, с";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(12, 21);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Начальная масса, г";
            // 
            // tBoxStartWeight
            // 
            this.tBoxStartWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxStartWeight.Location = new System.Drawing.Point(12, 43);
            this.tBoxStartWeight.Name = "tBoxStartWeight";
            this.tBoxStartWeight.Size = new System.Drawing.Size(98, 23);
            this.tBoxStartWeight.TabIndex = 34;
            this.tBoxStartWeight.Click += new System.EventHandler(this.tBoxStartWeight_Click);
            // 
            // tBoxTime
            // 
            this.tBoxTime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxTime.Location = new System.Drawing.Point(6, 96);
            this.tBoxTime.Name = "tBoxTime";
            this.tBoxTime.ReadOnly = true;
            this.tBoxTime.Size = new System.Drawing.Size(98, 23);
            this.tBoxTime.TabIndex = 35;
            this.tBoxTime.Click += new System.EventHandler(this.tBoxTime_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(16, 63);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(119, 19);
            this.metroLabel13.TabIndex = 36;
            this.metroLabel13.Text = "Конечная масса, г";
            // 
            // tBoxFinishWeight
            // 
            this.tBoxFinishWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxFinishWeight.Location = new System.Drawing.Point(16, 85);
            this.tBoxFinishWeight.Name = "tBoxFinishWeight";
            this.tBoxFinishWeight.Size = new System.Drawing.Size(98, 23);
            this.tBoxFinishWeight.TabIndex = 37;
            this.tBoxFinishWeight.TextChanged += new System.EventHandler(this.tBoxFinishWeight_TextChanged);
            this.tBoxFinishWeight.Click += new System.EventHandler(this.tBoxFinishWeight_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(12, 73);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(97, 19);
            this.metroLabel17.TabIndex = 42;
            this.metroLabel17.Text = "Убыль влаги, г";
            // 
            // tBoxUbyl
            // 
            this.tBoxUbyl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxUbyl.Location = new System.Drawing.Point(12, 95);
            this.tBoxUbyl.Name = "tBoxUbyl";
            this.tBoxUbyl.Size = new System.Drawing.Size(97, 23);
            this.tBoxUbyl.TabIndex = 41;
            this.tBoxUbyl.Click += new System.EventHandler(this.tBoxUbyl_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tBoxVlazh
            // 
            this.tBoxVlazh.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tBoxVlazh.Location = new System.Drawing.Point(6, 147);
            this.tBoxVlazh.Name = "tBoxVlazh";
            this.tBoxVlazh.ReadOnly = true;
            this.tBoxVlazh.Size = new System.Drawing.Size(97, 23);
            this.tBoxVlazh.TabIndex = 43;
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(6, 125);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(91, 19);
            this.metroLabel18.TabIndex = 44;
            this.metroLabel18.Text = "Влажность, %";
            // 
            // TimerSushka
            // 
            this.TimerSushka.Interval = 1000;
            this.TimerSushka.Tick += new System.EventHandler(this.TimerSushka_Tick);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(6, 26);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(161, 19);
            this.metroLabel19.TabIndex = 46;
            this.metroLabel19.Text = "Масса сухой заготовки, г";
            // 
            // btnResetValues
            // 
            this.btnResetValues.Location = new System.Drawing.Point(786, 346);
            this.btnResetValues.Name = "btnResetValues";
            this.btnResetValues.Size = new System.Drawing.Size(150, 26);
            this.btnResetValues.TabIndex = 48;
            this.btnResetValues.Text = "Сбросить значения";
            this.btnResetValues.Click += new System.EventHandler(this.btnResetValues_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиCOMпортToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиCOMпортToolStripMenuItem
            // 
            this.настройкиCOMпортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bAUDERATEToolStripMenuItem,
            this.dATABITSToolStripMenuItem,
            this.sTOPBITSToolStripMenuItem,
            this.pARITYBITSToolStripMenuItem});
            this.настройкиCOMпортToolStripMenuItem.Name = "настройкиCOMпортToolStripMenuItem";
            this.настройкиCOMпортToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.настройкиCOMпортToolStripMenuItem.Text = "Настройки COM-порт";
            // 
            // bAUDERATEToolStripMenuItem
            // 
            this.bAUDERATEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoxBaudRate});
            this.bAUDERATEToolStripMenuItem.Name = "bAUDERATEToolStripMenuItem";
            this.bAUDERATEToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.bAUDERATEToolStripMenuItem.Text = "Бит в секунду";
            // 
            // toolStripBoxBaudRate
            // 
            this.toolStripBoxBaudRate.Name = "toolStripBoxBaudRate";
            this.toolStripBoxBaudRate.Size = new System.Drawing.Size(121, 23);
            // 
            // dATABITSToolStripMenuItem
            // 
            this.dATABITSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoxDataBits});
            this.dATABITSToolStripMenuItem.Name = "dATABITSToolStripMenuItem";
            this.dATABITSToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dATABITSToolStripMenuItem.Text = "Биты данных";
            // 
            // toolStripBoxDataBits
            // 
            this.toolStripBoxDataBits.Name = "toolStripBoxDataBits";
            this.toolStripBoxDataBits.Size = new System.Drawing.Size(121, 23);
            // 
            // sTOPBITSToolStripMenuItem
            // 
            this.sTOPBITSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoxStopBits});
            this.sTOPBITSToolStripMenuItem.Name = "sTOPBITSToolStripMenuItem";
            this.sTOPBITSToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sTOPBITSToolStripMenuItem.Text = "Стоповые";
            // 
            // toolStripBoxStopBits
            // 
            this.toolStripBoxStopBits.Name = "toolStripBoxStopBits";
            this.toolStripBoxStopBits.Size = new System.Drawing.Size(121, 23);
            // 
            // pARITYBITSToolStripMenuItem
            // 
            this.pARITYBITSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBoxParityBits});
            this.pARITYBITSToolStripMenuItem.Name = "pARITYBITSToolStripMenuItem";
            this.pARITYBITSToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.pARITYBITSToolStripMenuItem.Text = "Управление потоком";
            // 
            // toolStripBoxParityBits
            // 
            this.toolStripBoxParityBits.Name = "toolStripBoxParityBits";
            this.toolStripBoxParityBits.Size = new System.Drawing.Size(121, 23);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tBoxDry
            // 
            this.tBoxDry.BackColor = System.Drawing.Color.White;
            this.tBoxDry.Location = new System.Drawing.Point(30, 48);
            this.tBoxDry.Name = "tBoxDry";
            this.tBoxDry.Size = new System.Drawing.Size(123, 24);
            this.tBoxDry.TabIndex = 52;
            this.tBoxDry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDry_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.tBoxH2O);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.tBoxFinishWeight);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(785, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 180);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Будет доступно по нажатию кнопки \"СТОП\"";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.tBoxDataIN);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.tBoxTime);
            this.groupBox3.Controls.Add(this.tBoxVlazh);
            this.groupBox3.Controls.Add(this.metroLabel18);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(489, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(115, 190);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Мониторинг";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Controls.Add(this.tBoxStartWeight);
            this.groupBox4.Controls.Add(this.metroLabel17);
            this.groupBox4.Controls.Add(this.tBoxUbyl);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(626, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 137);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расчёт";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroLabel19);
            this.groupBox5.Controls.Add(this.tBoxDry);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(287, 112);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 100);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Введите данные";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 665);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnResetValues);
            this.Controls.Add(this.btnGraphWeightReset);
            this.Controls.Add(this.btnGraphWeightStart);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lblStatusCom);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cBoxComPort);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Исследование режимов и способов сушки влажных материалов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private MetroFramework.Controls.MetroComboBox cBoxComPort;
        private MetroFramework.Controls.MetroLabel metroLabel1;
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
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private LiveCharts.WinForms.CartesianChart cartesianChart3;
        private MetroFramework.Controls.MetroButton btnResetValues;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиCOMпортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bAUDERATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripBoxBaudRate;
        private System.Windows.Forms.ToolStripMenuItem dATABITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripBoxDataBits;
        private System.Windows.Forms.ToolStripMenuItem sTOPBITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripBoxStopBits;
        private System.Windows.Forms.ToolStripMenuItem pARITYBITSToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripBoxParityBits;
        private System.Windows.Forms.TextBox tBoxDry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

