namespace dotnet_labs
{
    partial class Form3
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(981, 833);
            button1.Name = "button1";
            button1.Size = new Size(208, 60);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(789, 797);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(849, 48);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 2;
            label1.Text = "Кількість рядків =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(849, 122);
            label2.Name = "label2";
            label2.Size = new Size(233, 30);
            label2.TabIndex = 3;
            label2.Text = "Кількість стовпчиків = ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1088, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 35);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1088, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 35);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(849, 232);
            button2.Name = "button2";
            button2.Size = new Size(362, 40);
            button2.TabIndex = 6;
            button2.Text = "Згенерувати масив";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 926);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
    }
}