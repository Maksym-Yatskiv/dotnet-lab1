namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView1 = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "-1.25";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "67.32";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(345, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(83, 35);
            textBox3.TabIndex = 2;
            textBox3.Text = "0.3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 38);
            label1.Name = "label1";
            label1.Size = new Size(35, 30);
            label1.TabIndex = 3;
            label1.Text = "xn";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 38);
            label2.Name = "label2";
            label2.Size = new Size(33, 30);
            label2.TabIndex = 4;
            label2.Text = "xk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(345, 38);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 5;
            label3.Text = "h";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 38);
            label4.Name = "label4";
            label4.Size = new Size(24, 30);
            label4.TabIndex = 6;
            label4.Text = "a";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(481, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(95, 35);
            textBox4.TabIndex = 7;
            textBox4.Text = "40";
            // 
            // button1
            // 
            button1.Location = new Point(627, 73);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 8;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(591, 186);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(870, 525);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView1.Location = new Point(50, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(471, 525);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.MinimumWidth = 9;
            x.Name = "x";
            x.Width = 175;
            // 
            // y
            // 
            y.HeaderText = "y";
            y.MinimumWidth = 9;
            y.Name = "y";
            y.Width = 175;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 812);
            Controls.Add(dataGridView1);
            Controls.Add(chart1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
    }
}
