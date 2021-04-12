using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace new_app_2
{
    public partial class Form1 : Form
    {
        private string com_RGB;
        private int valor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public int R { get; private set; }
        public int G { get; private set; }
        public int B { get; private set; }
        public int count { get; private set; }
        public int R_min { get; private set; }
        public int R_max { get; private set; }
        public int G_min { get; private set; }
        public int G_max { get; private set; }
        public int B_min { get; private set; }
        public int B_max { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_Start_Click_1(object sender, EventArgs e)
        {
            // Start  SerialPort Communication
            Comport = new SerialPort();
            Comport.BaudRate = 9600;
            Comport.PortName = comboBox_Port1.Text;
            Comport.Parity = Parity.None;
            Comport.DataBits = 8;
            Comport.StopBits = StopBits.One;
            Comport.DataReceived += Comport_DataReceived;
            count = 0;

            // Open COM_Port
            try
            {
                Comport.Open();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "COM PORT Error : Check Connectivity.");
            }
        }

        private void Comport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read incoming serial data and read line by line
                com_RGB = Comport.ReadLine();

                // pass that data to displaydata_event
                this.Invoke(new EventHandler(RGBpass_event));
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "COM PORT Error : Restart Programme");
            }
        }

        private void RGBpass_event(object sender, EventArgs e)
        {
            this.timer.Start();
            if (com_RGB.Length > 10)
            {
                // Split Comport input
                string[] RGBs = com_RGB.Split('*');

                try
                {
                    // store input into R G B channels
                    R = Int32.Parse(RGBs[1]);
                    G = Int32.Parse(RGBs[2]);
                    B = Int32.Parse(RGBs[3]);
                }
                catch (Exception ex4)
                {
                    MessageBox.Show(ex4.Message, "Input error : Wait...");
                }

                count = count + 1;

                // pass R G B data to livechart and RGB range
                this.Invoke(new EventHandler(Live_event));
                this.Invoke(new EventHandler(RGB_range));

                // display in text box
                bunifutextBox_display.AppendText(com_RGB + "\n");
                pieChart1.LegendLocation = LegendLocation.Bottom;
            }
        }

        private void RGB_range(object sender, EventArgs e)
        {
            // H C value
            R_min = 25; R_max = 200;
            G_min = 50; G_max = 200;
            B_min = 40; B_max = 255;

            // Logic for check range and det
            if (R_min < R && R < R_max && G_min < G && G < G_max && B_min < B && B < B_max)
            {
                label_ripe.Show(); label_Nripe.Hide();
                riped_img.Show(); unriped_img.Hide();
            }
            else
            {
                label_Nripe.Show(); label_ripe.Hide();
                unriped_img.Show(); riped_img.Hide();
            }
        }

        private void Live_event(object sender, EventArgs e)
        {
            // Live chart Controls

            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
                {
                    new PieSeries
                    {
                        Title = "Blue",
                        Values = new ChartValues<double> {B},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },
                    new PieSeries
                    {
                        Title = "Red",
                        Values = new ChartValues<double> {R},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    },

                    new PieSeries
                    {
                        Title = "Green",
                        Values = new ChartValues<double> {G},
                        DataLabels = true,
                        LabelPoint = labelPoint
                    }
                };
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            // navigation button click

            Pages.SetPage(((Control)sender).Text);
        }

        private void button_Stop_Click_1(object sender, EventArgs e)
        {
            // Close COM_Port
            try
            {
                Comport.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "COM Port is using by another Process.");
            }
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // ProgressBar Controls

            valor += 1;

            bunifuProgressBar.Value = valor;

            if (bunifuProgressBar.Value == 100)
            {
                valor = 0;
            }

            if (bunifuProgressBar.Value == 100)
            {
                bunifuProgressBar.Value = 0;
                timer.Stop();
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {
        }
    }
}