using dotnet_labs;
using Lab1.lab1;
using System.Globalization;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new();
            double xn, xk, h, a;
            xn = Convert.ToDouble(this.textBox1.Text, CultureInfo.InvariantCulture);
            xk = Convert.ToDouble(this.textBox2.Text, CultureInfo.InvariantCulture);
            h = Convert.ToDouble(this.textBox3.Text, CultureInfo.InvariantCulture);
            a = Convert.ToDouble(this.textBox4.Text, CultureInfo.InvariantCulture);

            //dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul.calculate(xn, xk, h, a);

            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy_array[i, 0], 2).ToString(),
                    Math.Round(tabul.xy_array[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy_array[i, 0], tabul.xy_array[i, 1]);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void одновимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void двовимірніМасивиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
