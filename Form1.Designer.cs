namespace tensile_machine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.start_bt = new System.Windows.Forms.Button();
            this.home_bt = new System.Windows.Forms.Button();
            this.stop_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discription_richTextBox = new System.Windows.Forms.RichTextBox();
            this.material_textBox = new System.Windows.Forms.TextBox();
            this.company_textBox = new System.Windows.Forms.TextBox();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.thickness_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.width_textBox = new System.Windows.Forms.TextBox();
            this.length_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.time_textBox = new System.Windows.Forms.TextBox();
            this.down_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_elongation = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_tensile_strength = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.print_button = new System.Windows.Forms.Button();
            this.restzoom_button = new System.Windows.Forms.Button();
            this.autoscroll = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.spacing_box = new System.Windows.Forms.TextBox();
            this.precision_box = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // start_bt
            // 
            this.start_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_bt.Location = new System.Drawing.Point(941, 21);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(86, 34);
            this.start_bt.TabIndex = 0;
            this.start_bt.Text = "Start";
            this.start_bt.UseVisualStyleBackColor = true;
            this.start_bt.Click += new System.EventHandler(this.start_bt_Click);
            // 
            // home_bt
            // 
            this.home_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.home_bt.Location = new System.Drawing.Point(1033, 22);
            this.home_bt.Name = "home_bt";
            this.home_bt.Size = new System.Drawing.Size(83, 32);
            this.home_bt.TabIndex = 1;
            this.home_bt.Text = "Home";
            this.home_bt.UseVisualStyleBackColor = true;
            this.home_bt.Click += new System.EventHandler(this.home_bt_Click);
            // 
            // stop_bt
            // 
            this.stop_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_bt.Location = new System.Drawing.Point(1122, 22);
            this.stop_bt.Name = "stop_bt";
            this.stop_bt.Size = new System.Drawing.Size(86, 32);
            this.stop_bt.TabIndex = 2;
            this.stop_bt.Text = "Reset";
            this.stop_bt.UseVisualStyleBackColor = true;
            this.stop_bt.Click += new System.EventHandler(this.stop_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.discription_richTextBox);
            this.groupBox1.Controls.Add(this.material_textBox);
            this.groupBox1.Controls.Add(this.company_textBox);
            this.groupBox1.Controls.Add(this.id_textBox);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 410);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Information";
            // 
            // discription_richTextBox
            // 
            this.discription_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.discription_richTextBox.Location = new System.Drawing.Point(23, 191);
            this.discription_richTextBox.Name = "discription_richTextBox";
            this.discription_richTextBox.Size = new System.Drawing.Size(330, 195);
            this.discription_richTextBox.TabIndex = 13;
            this.discription_richTextBox.Text = "-";
            // 
            // material_textBox
            // 
            this.material_textBox.Location = new System.Drawing.Point(132, 128);
            this.material_textBox.Name = "material_textBox";
            this.material_textBox.Size = new System.Drawing.Size(221, 26);
            this.material_textBox.TabIndex = 12;
            this.material_textBox.Text = "-";
            // 
            // company_textBox
            // 
            this.company_textBox.Location = new System.Drawing.Point(132, 96);
            this.company_textBox.Name = "company_textBox";
            this.company_textBox.Size = new System.Drawing.Size(221, 26);
            this.company_textBox.TabIndex = 11;
            this.company_textBox.Text = "-";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(132, 63);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(221, 26);
            this.id_textBox.TabIndex = 10;
            this.id_textBox.Text = "-";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(128, 34);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(71, 20);
            this.date.TabIndex = 9;
            this.date.Text = "00/00/00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Coustomer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Material:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.thickness_textBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.width_textBox);
            this.groupBox2.Controls.Add(this.length_textBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 147);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dumbell Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(338, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "mm";
            // 
            // thickness_textBox
            // 
            this.thickness_textBox.Location = new System.Drawing.Point(132, 98);
            this.thickness_textBox.Name = "thickness_textBox";
            this.thickness_textBox.Size = new System.Drawing.Size(200, 26);
            this.thickness_textBox.TabIndex = 14;
            this.thickness_textBox.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Thickness:";
            // 
            // width_textBox
            // 
            this.width_textBox.Location = new System.Drawing.Point(132, 66);
            this.width_textBox.Name = "width_textBox";
            this.width_textBox.Size = new System.Drawing.Size(200, 26);
            this.width_textBox.TabIndex = 12;
            this.width_textBox.Text = "0.00";
            // 
            // length_textBox
            // 
            this.length_textBox.Location = new System.Drawing.Point(132, 34);
            this.length_textBox.Name = "length_textBox";
            this.length_textBox.Size = new System.Drawing.Size(200, 26);
            this.length_textBox.TabIndex = 11;
            this.length_textBox.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Length:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(152, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Acme Tensile Machine";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.time_textBox);
            this.groupBox3.Controls.Add(this.down_button);
            this.groupBox3.Controls.Add(this.up_button);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(941, 475);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 194);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog up/down";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Time (ms)";
            // 
            // time_textBox
            // 
            this.time_textBox.Location = new System.Drawing.Point(54, 47);
            this.time_textBox.Name = "time_textBox";
            this.time_textBox.Size = new System.Drawing.Size(82, 26);
            this.time_textBox.TabIndex = 19;
            this.time_textBox.Text = "3000";
            // 
            // down_button
            // 
            this.down_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.down_button.Location = new System.Drawing.Point(188, 103);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(79, 78);
            this.down_button.TabIndex = 19;
            this.down_button.Text = "DOWN";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // up_button
            // 
            this.up_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.up_button.Location = new System.Drawing.Point(188, 19);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(79, 78);
            this.up_button.TabIndex = 18;
            this.up_button.Text = "UP";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BorderlineColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(235, 9);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(565, 377);
            this.chart.TabIndex = 20;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label_elongation);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label_tensile_strength);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.print_button);
            this.groupBox4.Controls.Add(this.restzoom_button);
            this.groupBox4.Controls.Add(this.autoscroll);
            this.groupBox4.Controls.Add(this.chart);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(402, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(806, 393);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // label_elongation
            // 
            this.label_elongation.AutoSize = true;
            this.label_elongation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_elongation.Location = new System.Drawing.Point(59, 125);
            this.label_elongation.Name = "label_elongation";
            this.label_elongation.Size = new System.Drawing.Size(40, 20);
            this.label_elongation.TabIndex = 29;
            this.label_elongation.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "Elongation %";
            // 
            // label_tensile_strength
            // 
            this.label_tensile_strength.AutoSize = true;
            this.label_tensile_strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tensile_strength.Location = new System.Drawing.Point(59, 63);
            this.label_tensile_strength.Name = "label_tensile_strength";
            this.label_tensile_strength.Size = new System.Drawing.Size(40, 20);
            this.label_tensile_strength.TabIndex = 27;
            this.label_tensile_strength.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Tensile Strength";
            // 
            // print_button
            // 
            this.print_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.print_button.Location = new System.Drawing.Point(143, 350);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(86, 32);
            this.print_button.TabIndex = 25;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // restzoom_button
            // 
            this.restzoom_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.restzoom_button.Location = new System.Drawing.Point(143, 312);
            this.restzoom_button.Name = "restzoom_button";
            this.restzoom_button.Size = new System.Drawing.Size(86, 32);
            this.restzoom_button.TabIndex = 24;
            this.restzoom_button.Text = "Reset Zoom";
            this.restzoom_button.UseVisualStyleBackColor = true;
            this.restzoom_button.Click += new System.EventHandler(this.restzoom_button_Click);
            // 
            // autoscroll
            // 
            this.autoscroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoscroll.AutoSize = true;
            this.autoscroll.Checked = true;
            this.autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoscroll.Location = new System.Drawing.Point(152, 289);
            this.autoscroll.Name = "autoscroll";
            this.autoscroll.Size = new System.Drawing.Size(77, 17);
            this.autoscroll.TabIndex = 24;
            this.autoscroll.Text = "Auto Scroll";
            this.autoscroll.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.spacing_box);
            this.groupBox5.Controls.Add(this.precision_box);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(402, 522);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(257, 147);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Graph X-Axis Setting";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // spacing_box
            // 
            this.spacing_box.Location = new System.Drawing.Point(120, 66);
            this.spacing_box.Name = "spacing_box";
            this.spacing_box.Size = new System.Drawing.Size(109, 26);
            this.spacing_box.TabIndex = 22;
            this.spacing_box.Text = "30";
            // 
            // precision_box
            // 
            this.precision_box.Location = new System.Drawing.Point(120, 34);
            this.precision_box.Name = "precision_box";
            this.precision_box.Size = new System.Drawing.Size(109, 26);
            this.precision_box.TabIndex = 21;
            this.precision_box.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 20);
            this.label15.TabIndex = 19;
            this.label15.Text = "Spacing:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Precision:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tensile_machine.Properties.Resources.ACME_logo_D73740CA9C_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1229, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stop_bt);
            this.Controls.Add(this.home_bt);
            this.Controls.Add(this.start_bt);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.Text = "Acme Tensile Machine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.Button home_bt;
        private System.Windows.Forms.Button stop_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RichTextBox discription_richTextBox;
        private System.Windows.Forms.TextBox material_textBox;
        private System.Windows.Forms.TextBox company_textBox;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox width_textBox;
        private System.Windows.Forms.TextBox length_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox thickness_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox time_textBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox autoscroll;
        private System.Windows.Forms.Button restzoom_button;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox spacing_box;
        private System.Windows.Forms.TextBox precision_box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_tensile_strength;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_elongation;
        private System.Windows.Forms.Label label19;
    }
}

