﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace WF_Com
{
    public partial class Form1 : MetroForm
    {
        string dataIN;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private int _countSeconds = 0;
        //int limitWeight = 999;

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            

            chartWeight.ChartAreas[0].AxisY.Maximum = 150;
            chartWeight.ChartAreas[0].AxisY.Minimum = 0;

            chartWeight.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";
            chartWeight.Series[0].XValueType = ChartValueType.DateTime;

            chartWeight.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartWeight.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chartWeight.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartWeight.ChartAreas[0].AxisX.Interval = 5;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ДА";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "НЕТ";
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
            progressBar1.Value = 0;
            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            lblStatusCom.Text = "НЕТ";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in dataIN)
                {
                    if (item == 'g')
                        tBoxDataIN.Text = (dataIN[dataIN.IndexOf(item) - 9].ToString()/* + dataIN[dataIN.IndexOf(item) - 8].ToString()*/ + dataIN[dataIN.IndexOf(item) - 7].ToString() + dataIN[dataIN.LastIndexOf(item) - 6] + dataIN[dataIN.IndexOf(item) - 5] + dataIN[dataIN.IndexOf(item) - 4] + dataIN[dataIN.IndexOf(item) - 3] + dataIN[dataIN.IndexOf(item) - 2] + dataIN[dataIN.IndexOf(item) - 1]).Replace(".", ",");
                }
                Thread.Sleep(10);
            }
            catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            string value = tBoxDataIN.Text;

            chartWeight.Series[0].Points.AddXY(timeNow, value);

            _countSeconds ++;

            if (_countSeconds == 550)
            {
                _countSeconds = 0;
                chartWeight.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartWeight.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

                chartWeight.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
                chartWeight.ChartAreas[0].AxisX.Interval = 5;
            }
        }


        private void btnClearChartWeight_Click(object sender, EventArgs e)
        {
            _countSeconds = 0;
            chartWeight.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartWeight.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chartWeight.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartWeight.ChartAreas[0].AxisX.Interval = 5;
        }

        private void btnStartChartWeight_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            _countSeconds = 0;
            chartWeight.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            chartWeight.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chartWeight.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartWeight.ChartAreas[0].AxisX.Interval = 5;
        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            string noprobel = tBoxDataIN.Text;
            double result = 0;
            if (double.TryParse(noprobel, out result))
                tBoxUbyl.Text = Convert.ToString(result - 20);
        }
    }
}
