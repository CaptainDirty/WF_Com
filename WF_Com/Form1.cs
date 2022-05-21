using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using WF_Com.Models;
using System;
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
using SeriesCollection = LiveCharts.SeriesCollection;
using Axis = LiveCharts.Wpf.Axis;

namespace WF_Com
{
    public partial class Form1 : MetroForm
    {
        string dataIN;
        bool flag = false;
        DateTime time;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            cBoxBaudRate.SelectedIndex = 10;
            cBoxDataBits.SelectedIndex = 4;
            cBoxStopBits.SelectedIndex = 0;
            cBoxParityBits.SelectedIndex = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

            // Запуск в отдельном потоке
            backgroundWorker1.RunWorkerAsync();
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
                var items = dataIN.Split(new string[] { "\u0001", "\u0002", "\u0003", "\u0004", "g", "U", "S", "?" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                items.ForEach(x => x.Trim());
                items.ForEach(x => x.Replace("   ", ""));
                items.ForEach(x => x.Replace(" ", ""));

                if (items.Count >= 1)
                {
                    tBoxDataIN.Text = items[0].Trim();
                }
                Thread.Sleep(25);
            }
            catch { }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                //// Удалить первое значение
                //if (cartesianChart1.Series[0].Values.Count >= 20)
                //{
                //    cartesianChart1.Series[0].Values.RemoveAt(0);
                //    // cartesianChart.AxisX[0].Labels.RemoveAt(0);
                //}
                // Добавить новое значение
                if (flag)
                {
                    var Ch = tBoxDataIN.Text.Replace(".", ",");
                    double result = 1;

                    if (double.TryParse(Ch, out result))
                    {
                        result = Convert.ToDouble(tBoxDataIN.Text.Replace(".", ","));

                    }

                    cartesianChart1.Series[0].Values.Add(new ChartModel
                    {
                        DateTime = DateTime.Now,
                        Value = result
                    });

                    var Ch2 = tBoxVlazh.Text.Replace(".", ",");
                    double result2 = 1;

                    if (double.TryParse(Ch2, out result2))
                    {
                        result2 = Convert.ToDouble(tBoxVlazh.Text.Replace(".", ","));
                    }

                    cartesianChart2.Series[0].Values.Add(new ChartModel
                    {
                        DateTime = DateTime.Now,
                        Value = result2
                    });
                }
                // Добавляем новое значение 1 раз в секунду 
                Thread.Sleep(1000);
            }
        }

        private void btnGraphWeightStart_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                tBoxStartWeight.Text = tBoxDataIN.Text;

                var mapper = Mappers.Xy<ChartModel>()
                               .X(x => x.DateTime.Ticks)
                               .Y(x => x.Value);

                cartesianChart1.AxisX.Add(new Axis
                {
                    LabelFormatter = value => DateTime.Now.ToString("HH:mm:ss")
                });

                cartesianChart1.Series = new SeriesCollection(mapper)
            {
                new LineSeries
                {
                    Values = new ChartValues<ChartModel>
                    {
                        new ChartModel
                        {
                            DateTime = DateTime.Now,
                            Value = 0
                        }
                    }
                }
            };

                cartesianChart2.AxisX.Add(new Axis
                {
                    LabelFormatter = value => DateTime.Now.ToString("HH:mm:ss")
                });

                cartesianChart2.Series = new SeriesCollection(mapper)
            {
                new LineSeries
                {
                    Values = new ChartValues<ChartModel>
                    {
                        new ChartModel
                        {
                            DateTime = DateTime.Now,
                            Value = 0
                        }
                    }
                }
            };

                time = new DateTime(0001, 01, 01, 00, 00, 00);

                TimerSushka.Start();

                flag = true;
            }
        }

        private void btnGraphWeightReset_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                tBoxFinishWeight.Text = tBoxDataIN.Text;

                //cartesianChart1.Series[0].Values.Clear();
                cartesianChart1.AxisX.Clear();
                cartesianChart1.Series.Clear();

                cartesianChart2.AxisX.Clear();
                cartesianChart2.Series.Clear();
                flag = false;

                TimerSushka.Stop();
            }
        }

        private void tBoxDataIN_TextChanged(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "" && tBoxStartWeight.Text != "" && tBoxDataIN.Text != null && tBoxStartWeight.Text != null)
            {
                tBoxUbyl.Text = (double.Parse(tBoxStartWeight.Text) - double.Parse(tBoxDataIN.Text.Replace(".", ",").Replace(" ", ""))).ToString();
            }
        }

        private void tBoxFinishWeight_TextChanged(object sender, EventArgs e)
        {
            double resultStart = 0;
            double resultFinish = 0;
            if (double.TryParse(tBoxStartWeight.Text, out resultStart) && double.TryParse(tBoxFinishWeight.Text, out resultFinish))
            {
                tBoxH2O.Text = (resultStart - resultFinish).ToString();
            }
        }

        private void tBoxH2O_TextChanged(object sender, EventArgs e)
        {
            double resultStart = 0;
            double resultNow = 0;
            double h2o = 0;
            if (double.TryParse(tBoxStartWeight.Text, out resultStart) && double.TryParse(tBoxDataIN.Text.Replace(".", ",").Replace(" ", ""), out resultNow) && double.TryParse(tBoxH2O.Text, out h2o))
            {
                tBoxVlazh.Text = (((resultStart - resultNow) / h2o) * 100).ToString();
            }
        }

        private void TimerSushka_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            tBoxTime.Text = time.ToString("HH:mm:ss");
        }
    }
}