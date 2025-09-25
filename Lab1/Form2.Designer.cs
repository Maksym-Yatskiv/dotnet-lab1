namespace dotnet_labs
{
    partial class Form2
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
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(612, 808);
            button1.Name = "button1";
            button1.Size = new Size(219, 55);
            button1.TabIndex = 0;
            button1.Text = "Закрити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(25, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(420, 854);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "a";
            Column1.MinimumWidth = 9;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 180);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 2;
            label1.Text = "Сума чисел:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 51);
            label2.Name = "label2";
            label2.Size = new Size(197, 30);
            label2.TabIndex = 4;
            label2.Text = "Довжина масиву =";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(700, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 35);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(711, 180);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(559, 111);
            button2.Name = "button2";
            button2.Size = new Size(197, 40);
            button2.TabIndex = 7;
            button2.Text = "Обичислити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 914);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Button button2;
    }
}