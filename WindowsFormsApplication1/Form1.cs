using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Nilai_A, Nilai_B, Hasil;

            if (NamaComoBox.SelectedIndex == 0)
            {
                Nilai_A = double.Parse(NilaiA.Text);
                Nilai_B = double.Parse(NilaiB.Text);
                Hasil = Nilai_A + Nilai_B;
                txtHasil.Text = Hasil.ToString();
            }
            else if (NamaComoBox.SelectedIndex == 1)
            {
                Nilai_A = double.Parse(NilaiA.Text);
                Nilai_B = double.Parse(NilaiB.Text);
                Hasil = Nilai_A - Nilai_B;
                txtHasil.Text = Hasil.ToString();
            }

            else if (NamaComoBox.SelectedIndex == 2)
            {
                Nilai_A = double.Parse(NilaiA.Text);
                Nilai_B = double.Parse(NilaiB.Text);
                Hasil = Nilai_A * Nilai_B;
                txtHasil.Text = Hasil.ToString();
            }

            else if (NamaComoBox.SelectedIndex == 3)
            {
                Nilai_A = double.Parse(NilaiA.Text);
                Nilai_B = double.Parse(NilaiB.Text);
                Hasil = Nilai_A / Nilai_B;
                txtHasil.Text = Hasil.ToString();
            }
        }
    }
}
