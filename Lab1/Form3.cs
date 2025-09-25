using dotnet_labs.lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_labs
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms[0];
            mainForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                int rows = textBox1.Text != "" ? Convert.ToInt32(textBox1.Text) : 4;
                int cols = textBox2.Text != "" ? Convert.ToInt32(textBox2.Text) : 4;
                MyArray2D arr2D = new(rows, cols);
                DataGridViewTextBoxColumn dgcols;
                for (int i = 0; i < cols; i++)
                {
                    dgcols = new DataGridViewTextBoxColumn();
                    dgcols.Width = 70;
                    dataGridView1.Columns.Add(dgcols);
                }
                dataGridView1.RowCount = arr2D.Rows;
                dataGridView1.ColumnCount = arr2D.Cols;

                for (int i = 0; i < arr2D.Rows; i++)
                    for (int j = 0; j < arr2D.Cols; j++)
                        dataGridView1.Rows[i].Cells[j].Value = arr2D[i, j];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
