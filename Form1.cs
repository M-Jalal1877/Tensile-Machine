using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace tensile_machine
{
    public partial class Form1 : Form
    {
        private string filePath;
        
        // variables for auto connection
        string comport = null;
        string portDescription;
        string portNamefinal;
        string[] portNames = SerialPort.GetPortNames();

        // variable for serial data processing
        string raw_data;
        string[] sep_data;
        float data_mm;
        float data_kg;
        string prev_mm = "0.00";

        List<float> tensile = new List<float>();
        List<float> elongation = new List<float>();
        public Form1()
        {
            InitializeComponent();
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "tensiledata.txt");
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                // Create the file if it doesn't exist
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    // You can write initial content here if needed
                }
            }
            else
            {
                // Clear the previous content if the file exists
                File.WriteAllText(filePath, string.Empty);
            }
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Load/kg,Extenstion/mm");
            }

            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            // Optionally, make the scroll bar visible all the time
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;

            // Set the view range size (number of points you want to show initially)
            chart.ChartAreas[0].AxisX.ScaleView.SizeType = DateTimeIntervalType.Number;
            chart.ChartAreas[0].AxisX.ScaleView.Size = pointsToShow;
            // Enable range selection and zooming end user UI
            chart.ChartAreas[0].CursorX.AutoScroll = true;
            // Set the scroll bar size
            chart.ChartAreas[0].AxisX.ScrollBar.Size = 15;
            // Set the zoom reset button (optional)
            chart.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All;
            chart.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = pointsToShow;

            chart.ChartAreas[0].AxisX.Title = "% Enlogation";
            chart.ChartAreas[0].AxisY.Title = "Ultimate Tensile Strength / Nmm²";

            chart.ChartAreas[0].AxisX.Interval = precision;
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, zoom);
            chart.ChartAreas[0].AxisY.Minimum = 0;
            chart.ChartAreas[0].AxisX.Minimum = 0;


            DateTime date_s = DateTime.Today;
            date.Text = date_s.ToString("dd-MM-yyyy");
            serialPort.ReceivedBytesThreshold = 1; // Trigger the event as soon as any data is received

            if (portNames.Length > 0)
            {
                Console.WriteLine("Available COM Ports:");
                foreach (string portName in portNames)
                {
                    portDescription = GetPortDescription(portName);
                    Console.WriteLine("COM Port Name: " + portName);
                    Console.WriteLine("COM Port Description: " + portDescription);
                    Console.WriteLine("-----------------------------------");
                    portNamefinal = portName;
                }
            }
            else
            {
                Console.WriteLine("No COM ports are available.");
            }
            if (portDescription == "Arduino Mega 2560")
            {
                try
                {

                    serialPort.PortName = portNamefinal;
                    serialPort.BaudRate = 115200;
                    serialPort.DtrEnable = true;
                    serialPort.Open();
                    Console.WriteLine("Connected");
                    serialPort.DtrEnable = false;
                }
                catch
                {
                    MessageBox.Show("Communicaiton Port is Connected to other Software");
                    System.Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("Tensile machine is not connected.");
                System.Environment.Exit(0);
            }

        }

        static string GetPortDescription(string portName)
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(" + portName + ")%'");

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    return queryObj["Description"].ToString();
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("An error occurred while querying for WMI data: " + e.Message);
            }
            return "Unknown";
        }

        // variable for graph view
        int pointsToShow = 100;
        int zoom = 2000;
        int precision = 100;
        private void Form1_Load(object sender, EventArgs e) // Auto connect of arduino mega 2560 and some UI default setting
        {
           
        }

        private StringBuilder serialBuffer = new StringBuilder();
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Read all available data
            string data = serialPort.ReadExisting();
            serialBuffer.Append(data);

            // Process each complete line of data
            string bufferString = serialBuffer.ToString();
            int lineEndIndex;
            while ((lineEndIndex = bufferString.IndexOf("\r\n")) >= 0) // Check for the newline
            {
                string line = bufferString.Substring(0, lineEndIndex); // Extract the line
                bufferString = bufferString.Substring(lineEndIndex + 2); // Remove the processed line
                ProcessLine(line); // Implement this method to handle the processing of each line
            }
            serialBuffer.Clear(); // Clear the buffer
            serialBuffer.Append(bufferString); // Append the remaining unprocessed data

            

        }

        private void ProcessLine(string line)
        {
            raw_data = line;
           
            sep_data = raw_data.Split(',');
            if (sep_data[0] != prev_mm)
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(raw_data);
                }
                try
                {
                    if (float.TryParse(sep_data[0], out data_mm) && float.TryParse(sep_data[1], out data_kg))
                    {
                        data_mm = float.Parse(sep_data[0]);
                        data_kg = float.Parse(sep_data[1]);
                        this.BeginInvoke((MethodInvoker)delegate
                        {
                            // Call your UI-related function here.
                            livechrt();
                        });
                    }
                    prev_mm = sep_data[0];
                }
                catch { 

                }
                
            }
        }
        bool timmer_s = false;
        private void start_bt_Click(object sender, EventArgs e)
        {
            if (length_textBox.Text != "0.00" && width_textBox.Text != "0.00" && thickness_textBox.Text != "0.00")
            {
                serialPort.WriteLine("s");
                up_button.Enabled = false;
                down_button.Enabled = false;
                home_bt.Enabled = false;
                timmer_s = true;
            }
            else {
                MessageBox.Show("Dumbell is not fully defined!");
            }
            
        }

        private void home_bt_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open(); // Open the serial port if it's not already open
            }
            serialPort.WriteLine("h");
            up_button.Enabled = true;
            down_button.Enabled = true;
        }

        private void stop_bt_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, string.Empty);
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.DtrEnable = true;
            serialPort.Open();
            System.Threading.Thread.Sleep(2000);
            serialPort.DtrEnable = false;
            up_button.Enabled = true;
            down_button.Enabled = true;
            home_bt.Enabled = true;

            number_of_sample = 0;
            max_tensile = 0.00f;
            raw_data= null;
            sep_data= null;
            data_mm = 0.00f;
            data_kg = 0.0f;
            elongation.Clear();
            tensile.Clear();
            prev_mm = "0.00";
            chart.Series[0].Points.Clear();
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            if (time_textBox.Text != "") {
                serialPort.WriteLine("u" + time_textBox.Text);
            }
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            if (time_textBox.Text != "")
            {
                serialPort.WriteLine("d" + time_textBox.Text);
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
        int number_of_sample;
        float max_tensile = 0.00f;
        float max_tensile_mm = 0.00f;

        float max_weight = 0.00f;
        float max_weight_mm = 0.00f;

        float elongation_temp = 0.00f;
        float tensile_temp = 0.00f;
        public void livechrt()
        {
            if (raw_data != null)
            {
                number_of_sample++;
                elongation_temp = ((data_mm / (float.Parse(length_textBox.Text))) * 100);
                tensile_temp = ((data_kg * 9.81f) / (float.Parse(width_textBox.Text) * float.Parse(thickness_textBox.Text)));

                chart.Series[0].Points.AddXY(elongation_temp.ToString("0.00"), tensile_temp.ToString("0.00"));
                
                elongation.Add(elongation_temp);
                tensile.Add(tensile_temp);

                //label_tensile_strength.Text = tensile_temp.ToString();
                //label_elongation.Text = elongation_temp.ToString();
                if (autoscroll.CheckState == CheckState.Checked)
                {
                    chart.ChartAreas[0].AxisX.ScaleView.Position = (number_of_sample + 3) - chart.ChartAreas[0].AxisX.ScaleView.Size;
                }
                if (tensile_temp > max_tensile) {
                    max_tensile = tensile_temp;
                    max_tensile_mm = elongation_temp;
                }
                if (data_kg > max_weight) 
                {
                    max_weight = data_kg;
                    max_weight_mm = elongation_temp;
                }
            }
        }

        private void restzoom_button_Click(object sender, EventArgs e)
        {
            chart.ChartAreas[0].AxisX.ScaleView.Zoom(0, zoom);
        }

        //-------------------------------------------//
        //--------------Thermal Printer--------------//
        //-------------------------------------------//


        //roate txt 
        private void DrawRotatedTextAt(Graphics gr, float angle, string txt, int x, int y, Font the_font, Brush the_brush)
        {
            GraphicsState state = gr.Save();
            gr.ResetTransform();
            gr.RotateTransform(angle);
            gr.TranslateTransform(x, y, MatrixOrder.Append);
            gr.DrawString(txt, the_font, the_brush, 0, 0);
            gr.Restore(state);
        }
        float xAxisLength;
        private void print_button_Click(object sender, EventArgs e)
        {
            xAxisLength = number_of_sample * int.Parse(spacing_box.Text);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize(" Acme ", 285, (int)xAxisLength);
            printPreviewDialog1.ShowDialog();
        }
        int y_smallline;
        int x_spacing;
        // Starting point
        int x = 20;
        int y = 20;
        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageUnit = GraphicsUnit.Pixel;
            Font font = new Font("Arial", 7);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Print the main info
            DrawRotatedTextAt(g, 0, "Acme Tensile Machine", x, y, new Font("Arial",8), brush);
            DrawRotatedTextAt(g, 0, date.Text, x+ 450, y+5, new Font("Arial", 5), brush);
            DrawRotatedTextAt(g, 0, "Id: "+id_textBox.Text, x, y+40, font, brush);
            DrawRotatedTextAt(g, 0, "Coustomer: "+company_textBox.Text, x, y + 65, font, brush);
            DrawRotatedTextAt(g, 0, "Material: " + material_textBox.Text, x, y + 90, font, brush);

            RectangleF layoutRect = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            int lastCharIndex = discription_richTextBox.TextLength - 1;
            Point endPoint = discription_richTextBox.GetPositionFromCharIndex(lastCharIndex);
            DrawRotatedTextAt(g, 0, "Description: " + discription_richTextBox.Text, x, y + 115, font, brush);

            // Calculate the adjusted ending point based on the new font size
            SizeF textSize = e.Graphics.MeasureString(discription_richTextBox.Text, font);
            PointF endingPoint = new PointF(x+20, layoutRect.Top + textSize.Height+100);

            //---------Y line---------//
            DrawRotatedTextAt(g, 0, "Ultimate Tensile Strength / Nmm²",(int)endingPoint.X + 160,(int)endingPoint.Y-65, new Font("Arial",5), brush);
            g.DrawLine(new Pen(Color.Black, 2), endingPoint.X+20, endingPoint.Y, e.PageBounds.Width+270, endingPoint.Y);
            int x_smallline = (int)endingPoint.X + 20;
            int y_numbergap = (int)Math.Round((max_tensile + (20*max_tensile)/100)/16 , MidpointRounding.AwayFromZero);
            int y_number = 0;
            Console.WriteLine(max_tensile);
            Console.WriteLine(data_mm);
            for (int i = 0; i <= 16; i++) {
                g.DrawLine(new Pen(Color.Black, 1), x_smallline, endingPoint.Y, x_smallline, endingPoint.Y-10);
                DrawRotatedTextAt(g, 90, y_number.ToString(), x_smallline+5, (int)endingPoint.Y-45, new Font("Arial", 5), brush);
                y_number += y_numbergap;
                x_smallline += 31;
            }


            //---------X line---------//
            x_spacing = int.Parse(precision_box.Text);
            int x_numbergap = (int)Math.Round(elongation_temp/x_spacing);
            int x_number = 0;
            y_smallline = (int)endingPoint.Y;
            for (int i = 0; i <= x_numbergap; i++) 
            {
                g.DrawLine(new Pen(Color.Black, 1), endingPoint.X + 20, y_smallline, endingPoint.X+10, y_smallline);
                DrawRotatedTextAt(g, 90, x_number.ToString(), (int)endingPoint.X, y_smallline-5, new Font("Arial", 5), brush);
                x_number += x_spacing;
                y_smallline += int.Parse(spacing_box.Text);
            }
            g.DrawLine(new Pen(Color.Black, 2), endingPoint.X + 20, endingPoint.Y, endingPoint.X + 20, y_smallline-30);


            //------------graph-----------//
            for (int i = 0; i <= tensile.Count-2; i++) 
            {
                if (tensile[i] > 0.00 & tensile[i + 1] > 0.00 & elongation[i] > 0.00 & elongation[i + 1] > 0.00)
                {
                    g.DrawLine(new Pen(Color.Black, 3), ((endingPoint.X + 20) + (31 * tensile[i]) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (elongation[i]) / x_spacing)), ((endingPoint.X + 20) + (31 * tensile[i + 1]) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (elongation[i + 1]) / x_spacing)));
                }
            }

            //-----------Highest Point Line ---------//
            
            // Set the pen color and width
            Pen dottedPen = new Pen(Color.Black, 2);
            // Set the pen to draw a dotted line
            dottedPen.DashStyle = DashStyle.Dot;
            dottedPen.DashPattern = new float[] { 10, 4 }; //line length, spacing

            g.DrawLine(dottedPen, ((endingPoint.X + 20) + (31 * max_tensile) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (max_tensile_mm) / x_spacing)), ((endingPoint.X + 20) + (31 * 0) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (max_tensile_mm) / x_spacing)));
            g.DrawLine(dottedPen, ((endingPoint.X + 20) + (31 * max_tensile) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (max_tensile_mm) / x_spacing)), ((endingPoint.X + 20) + (31 * max_tensile) / y_numbergap), ((endingPoint.Y) + (int.Parse(spacing_box.Text) * (0) / x_spacing)));
            

            DrawRotatedTextAt(g, 90, "% elongation", x_smallline - 565, y_smallline-50, new Font("Arial", 5), brush);

            DrawRotatedTextAt(g, 0, "Ultimate Tensile Strength / Nmm² = " + max_tensile.ToString("0.00"), x_smallline-520, y_smallline, new Font("Arial", 7), brush);
            DrawRotatedTextAt(g, 0, "Elongation % = " + max_tensile_mm.ToString(), x_smallline-520, y_smallline + 25, new Font("Arial", 7), brush);

            DrawRotatedTextAt(g, 0, "Maximun Weight / kg = " + max_weight.ToString(), x_smallline - 520, y_smallline + 60, new Font("Arial", 7), brush);
            DrawRotatedTextAt(g, 0, "Elongation % = " + max_weight_mm.ToString(), x_smallline - 520, y_smallline +85, new Font("Arial", 7), brush);


        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
