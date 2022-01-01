using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Xml;


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
          );
        

        //Global variables for Moving a Borderless Form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private string txtData;
        private string filePath = @"G:\Temp\log.";
        private StreamWriter txtFile;
        //private string fileName = "log.txt";
        private int chartCounter = 0;
        private int temperature = 0;
        private const String filename = @"G:\Temp\log.xml";
        private string subStringData;
        
        public Form1()
        {
            InitializeComponent();
            findConnectedPorts();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            button1_Click(this,EventArgs.Empty);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        public void findConnectedPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                comboBoxComPort.Items.Add(port);
            }


        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxComPort.Text;
                serialPort1.DataBits = Int16.Parse(comboBoxDataBits.Text);
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.DtrEnable = true;
                serialPort1.Open();

                for (int i = 0; i < progressBar1.Maximum; i++)
                {
                    progressBar1.Value++;
                }
            }
            catch (Exception)
            {
                //throw
            } 
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            serialPort1.Close();
            for (int i = 0; i < progressBar1.Maximum; i++)
            {
                progressBar1.Value--;

            }
        }

        private void writeIncomingData(string Text)
        {
            BeginInvoke(new EventHandler(delegate { textBoxReceiveData.ResetText(); textBoxReceiveData.AppendText(Text); textBoxReceiveData.ScrollToCaret(); }));

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /* string incomingText = serialPort1.ReadExisting();
             writeIncomingData(incomingText);*/
            Thread.Sleep(30);

            string data = serialPort1.ReadLine();       // bufferdan verileri oku

            if (textBoxReceiveData.InvokeRequired)
            {
                textBoxReceiveData.Invoke(new MethodInvoker(delegate { if (data.IndexOf("<context id=\"Analog\">") !=-1) { txtData = textBoxReceiveData.Text; textBoxReceiveData.Text = data; } else { textBoxReceiveData.Text += (data + "\n"); } }));
                
            }
            
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine(textBoxSendData.Text);
            textBoxSendData.Text = null;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            findConnectedPorts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartSensor1.Show();
            chartSensor2.Show();
            buttonXmlRead.Show();

            labelBaudRate.Hide();
            labelDataBits.Hide();
            labelParity.Hide();
            labelComPort.Hide();

            comboBoxBaudRate.Hide();
            comboBoxDataBits.Hide();
            comboBoxParity.Hide();
            comboBoxComPort.Hide();

            buttonSerialConnect.Hide();
            buttonSerialDisconnect.Hide();

            progressBar1.Hide();

            buttonRefresh.Hide();

            textBoxReceiveData.Hide();
            textBoxSendData.Hide();

            buttonSendData.Hide();
            buttonXmlClear.Hide();

            labelPath.Hide();
            labelTimeInterval.Hide();
            textBoxPath.Hide();
            textBoxTimeInterval.Hide();
            buttonStartTimer.Hide();
            buttonStopLogging.Hide();
            labelFileType.Hide();
            comboBoxFileType.Hide();
            labelInformation.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartSensor1.Hide();
            chartSensor2.Hide();
            buttonXmlRead.Hide();

            labelBaudRate.Show();
            labelDataBits.Show();
            labelParity.Show();
            labelComPort.Show();

            comboBoxBaudRate.Show();
            comboBoxDataBits.Show();
            comboBoxParity.Show();
            comboBoxComPort.Show();

            buttonSerialConnect.Show();
            buttonSerialDisconnect.Show();

            progressBar1.Show();

            buttonRefresh.Show();

            textBoxReceiveData.Show();
            textBoxSendData.Show();

            buttonSendData.Show();
            buttonXmlClear.Hide();

            labelPath.Hide();
            labelTimeInterval.Hide();
            textBoxPath.Hide();
            textBoxTimeInterval.Hide();
            buttonStartTimer.Hide();
            buttonStopLogging.Hide();
            labelFileType.Hide();
            comboBoxFileType.Hide();
            labelInformation.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chartSensor1.Hide();
            chartSensor2.Hide();
            buttonXmlRead.Hide();
            buttonXmlClear.Show();

            labelBaudRate.Hide();
            labelDataBits.Hide();
            labelParity.Hide();
            labelComPort.Hide();

            comboBoxBaudRate.Hide();
            comboBoxDataBits.Hide();
            comboBoxParity.Hide();
            comboBoxComPort.Hide();

            buttonSerialConnect.Hide();
            buttonSerialDisconnect.Hide();

            progressBar1.Hide();

            buttonRefresh.Hide();

            textBoxReceiveData.Hide();
            textBoxSendData.Hide();

            buttonSendData.Hide();

            labelPath.Show();
            labelTimeInterval.Show();
            textBoxPath.Show();
            textBoxTimeInterval.Show();
            buttonStartTimer.Show();
            buttonStopLogging.Show();
            labelFileType.Show();
            comboBoxFileType.Show();
            labelInformation.Hide();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            chartSensor1.Hide();
            chartSensor2.Hide();
            buttonXmlClear.Hide();

            labelBaudRate.Hide();
            labelDataBits.Hide();
            labelParity.Hide();
            labelComPort.Hide();

            comboBoxBaudRate.Hide();
            comboBoxDataBits.Hide();
            comboBoxParity.Hide();
            comboBoxComPort.Hide();

            buttonSerialConnect.Hide();
            buttonSerialDisconnect.Hide();

            progressBar1.Hide();

            buttonRefresh.Hide();

            textBoxReceiveData.Hide();
            textBoxSendData.Hide();

            buttonSendData.Hide();

            labelPath.Hide();
            labelTimeInterval.Hide();
            textBoxPath.Hide();
            textBoxTimeInterval.Hide();
            buttonStartTimer.Hide();
            buttonStopLogging.Hide();
            labelFileType.Hide();
            comboBoxFileType.Hide();

            labelInformation.Show();

            buttonXmlRead.Hide();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            timer4Logging.Stop();
            timer4Logging.Interval = int.Parse(textBoxTimeInterval.Text);
            timer4Logging.Start();

        }

        private void timer4Logging_Tick(object sender, EventArgs e)
        {
            
            string filePathLocal = filePath + comboBoxFileType.SelectedItem.ToString();
            if(File.Exists(filePathLocal))
            {
                
                File.AppendAllText(filePathLocal, txtData);
                //txtFile = new StreamWriter(filePath);
                using (txtFile = new System.IO.StreamWriter(filePathLocal, true))
                txtFile.WriteLine(txtData);
                txtFile.Close();
            }

            if(txtData.IndexOf("<context id=\"Temperature\">\n<sensorName>BMP180</sensorName>\n<value>") !=-1)
            {

                subStringData = txtData.Substring(txtData.IndexOf("<context id=\"Temperature\">\n<sensorName>BMP180</sensorName>\n<value>")+66, 6);
                Console.WriteLine("bmp180 var");
                //temperature=int.Parse(subStringData);
                chartSensor1.Series["Temperature"].Points.AddXY(chartCounter.ToString(), subStringData);
                subStringData = txtData.Substring(txtData.IndexOf("<context id=\"Pressure\">\n<sensorName>BMP180</sensorName>\n<value>") + 63, 5);
                chartSensor2.Series["Pressure"].Points.AddXY(chartCounter.ToString(), subStringData);

                ++chartCounter;
            }
        }

        private void comboBoxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelFileType_Click(object sender, EventArgs e)
        {

        }

        private void buttonStopLogging_Click(object sender, EventArgs e)
        {
            string filePathLocal = filePath + comboBoxFileType.SelectedItem.ToString();
            if (File.Exists(filePathLocal))
            {

                File.AppendAllText(filePathLocal, txtData);
                //txtFile = new StreamWriter(filePath);
                using (txtFile = new System.IO.StreamWriter(filePathLocal, true))
                    txtFile.WriteLine("</uartXmlData>");
                txtFile.Close();
            }
            timer4Logging.Stop();
            
        }

        private void comboBoxBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            xmlDoc.Save(Console.Out);

            XmlTextReader xtr = new XmlTextReader(filename);

            while(xtr.Read())
            {
                if(xtr.NodeType == XmlNodeType.Element && xtr.Name == ("sensorName"));
                {
                   string s1 = xtr.ReadElementString();
                    Console.WriteLine("context =" + s1);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == ("value"));
                {
                    string s2 = xtr.ReadElementString();
                    Console.WriteLine("sensorName =" + s2);
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == ("sampleNumber")) ;
                {
                    string s3 = xtr.ReadElementString();
                    Console.WriteLine("value =" + s3);
                }
            }
        }

        private void buttonXmlClear_Click(object sender, EventArgs e)
        {
            string filePathLocal = filePath + comboBoxFileType.SelectedItem.ToString();
            if (File.Exists(filePathLocal))
            {

                File.AppendAllText(filePathLocal, txtData);
                //txtFile = new StreamWriter(filePath);
                using (txtFile = new System.IO.StreamWriter(filePathLocal, false))
                txtFile.WriteLine("<?xml version=\"1.0\" encoding=\"utf - 8\" ?> ");
                txtFile.Close();
            }
        }
    }
    }

/* string txtBuffer = "";
 * StreamReader txtLastData = new StreamReader(filePath);
                List<string> listTxtData = new List<string>();
                int eofCounter = 0;
                while(true)
                {
                    ++eofCounter;
                    txtBuffer = txtLastData.ReadLine();
                    if (txtBuffer == null) break;
                    listTxtData.Add(txtBuffer)

                }
                listTxtData.Add(txtData);
*/
