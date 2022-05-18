
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chartWeight = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStartChartWeight = new MetroFramework.Controls.MetroButton();
            this.btnClearChartWeight = new MetroFramework.Controls.MetroButton();
            this.tBoxDataIN = new MetroFramework.Controls.MetroTextBox();
            this.tBoxUbyl = new MetroFramework.Controls.MetroTextBox();
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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).BeginInit();
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartWeight
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeight.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeight.Legends.Add(legend1);
            this.chartWeight.Location = new System.Drawing.Point(-10, 15);
            this.chartWeight.Name = "chartWeight";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Текущий вес, г";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Убыль влаги, г";
            this.chartWeight.Series.Add(series1);
            this.chartWeight.Series.Add(series2);
            this.chartWeight.Size = new System.Drawing.Size(694, 287);
            this.chartWeight.TabIndex = 11;
            this.chartWeight.Text = "chart1";
            // 
            // btnStartChartWeight
            // 
            this.btnStartChartWeight.Location = new System.Drawing.Point(690, 72);
            this.btnStartChartWeight.Name = "btnStartChartWeight";
            this.btnStartChartWeight.Size = new System.Drawing.Size(134, 49);
            this.btnStartChartWeight.TabIndex = 16;
            this.btnStartChartWeight.Text = "Рисовать график";
            this.btnStartChartWeight.Click += new System.EventHandler(this.btnStartChartWeight_Click);
            // 
            // btnClearChartWeight
            // 
            this.btnClearChartWeight.Location = new System.Drawing.Point(690, 178);
            this.btnClearChartWeight.Name = "btnClearChartWeight";
            this.btnClearChartWeight.Size = new System.Drawing.Size(134, 49);
            this.btnClearChartWeight.TabIndex = 17;
            this.btnClearChartWeight.Text = "Обнулить график";
            this.btnClearChartWeight.Click += new System.EventHandler(this.btnClearChartWeight_Click);
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Location = new System.Drawing.Point(677, 127);
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.Size = new System.Drawing.Size(97, 23);
            this.tBoxDataIN.TabIndex = 18;
            // 
            // tBoxUbyl
            // 
            this.tBoxUbyl.Location = new System.Drawing.Point(677, 317);
            this.tBoxUbyl.Name = "tBoxUbyl";
            this.tBoxUbyl.Size = new System.Drawing.Size(97, 23);
            this.tBoxUbyl.TabIndex = 19;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.ItemHeight = 23;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "9600"});
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
            "One"});
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
            this.metroLabel6.Location = new System.Drawing.Point(676, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(98, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Текущий вес, г";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(677, 295);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Убыль влаги, г";
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
            this.metroLabel10.Location = new System.Drawing.Point(396, 124);
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
            this.metroTabControl1.Size = new System.Drawing.Size(835, 337);
            this.metroTabControl1.TabIndex = 31;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.chartWeight);
            this.metroTabPage1.Controls.Add(this.btnStartChartWeight);
            this.metroTabPage1.Controls.Add(this.btnClearChartWeight);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(827, 298);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "График с весом";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(827, 298);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "График с";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(827, 298);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "График с";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(676, 226);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Время сушки, с";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(676, 164);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(125, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Начальная масса, г";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(676, 186);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(98, 23);
            this.metroTextBox1.TabIndex = 34;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(677, 248);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(98, 23);
            this.metroTextBox2.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 744);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
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
            this.Controls.Add(this.tBoxUbyl);
            this.Controls.Add(this.tBoxDataIN);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartWeight)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeight;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private MetroFramework.Controls.MetroButton btnStartChartWeight;
        private MetroFramework.Controls.MetroButton btnClearChartWeight;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Controls.MetroTextBox tBoxDataIN;
        private MetroFramework.Controls.MetroTextBox tBoxUbyl;
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
    }
}

