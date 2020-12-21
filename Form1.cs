using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{

    public partial class Form1 : Form
    {
        public int[] Masyvas = new int[10];
        public int n = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(textBox1.Text, out Masyvas[n]))
                {
                    n++;
                    richTextBox2.Text = "Skaičiai masyve: " + "\n" + Masyvas[0] + "\n";
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox2.AppendText(Masyvas[i] + "\n");
                    }
                    if (n == 10)
                    {
                        richTextBox2.AppendText("masyvas pilnas! Galite skaiciuoti");
                        button1.Text = "Pilnas";
                    }

                }
            }
            catch (IndexOutOfRangeException) { n = 0; richTextBox2.Clear(); richTextBox1.Clear(); button1.Text = "Spausti"; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (n < 10)
            {
                Form2 frm = new Form2(this);
                frm.Show();
            }
            else
            {
                int i = 0;
                int suma = 0;
                while (true)
                {
                    suma += Masyvas[i];
                    i++;
                    if (i == n) break;
                }
                richTextBox1.Text = "Atsakymas = " + '\n' + suma;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
