using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            epinfo.SetError(tbBore, "Harap diisi dengan angka");
            epinfo.SetError(tbStroke, "Harap diisi dengan angka");
            epinfo.SetError(gbJumlahSilinder, "Silahkan pilih salah satu");
        }

        private void tbBore_Leave(object sender, EventArgs e)
        {
            if (tbBore.Text != "" && (tbBore.Text).All(Char.IsNumber))
            {
                epcorrect.SetError(tbBore, "Data benar");
                eperror.SetError(tbBore, "");
                epwarning.SetError(tbBore, "");
                epinfo.SetError(tbBore, "");
            }
            else if (tbBore.Text != "" && (tbBore.Text).All(Char.IsLetter))
            {
                epcorrect.SetError(tbBore, "");
                eperror.SetError(tbBore, "Data harus diisi angka");
                epwarning.SetError(tbBore, "");
                epinfo.SetError(tbBore, "");
            }
            else if (tbBore.Text == "")
            {
                epcorrect.SetError(tbBore, "");
                eperror.SetError(tbBore, "");
                epwarning.SetError(tbBore, "Data tidak boleh kosong");
                epinfo.SetError(tbBore, "");
            }
        }

        private void tbStroke_Leave(object sender, EventArgs e)
        {
            if (tbStroke.Text != "" && (tbStroke.Text).All(Char.IsNumber))
            {
                epcorrect.SetError(tbStroke, "Data benar");
                eperror.SetError(tbStroke, "");
                epwarning.SetError(tbStroke, "");
                epinfo.SetError(tbStroke, "");
            }
            else if (tbStroke.Text != "" && (tbStroke.Text).All(Char.IsLetter))
            {
                epcorrect.SetError(tbStroke, "");
                eperror.SetError(tbStroke, "Data harus diisi angka");
                epwarning.SetError(tbStroke, "");
                epinfo.SetError(tbStroke, "");
            }
            else if (tbStroke.Text == "")
            {
                epcorrect.SetError(tbStroke, "");
                eperror.SetError(tbStroke, "");
                epwarning.SetError(tbStroke, "Data tidak boleh kosong");
                epinfo.SetError(tbStroke, "");
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbBore.Clear();
            tbStroke.Clear();
            rb1Silinder.Checked = false;
            rb2Silinder.Checked = false;
            rb3Silinder.Checked = false;
            rb4Silinder.Checked = false;

            epinfo.SetError(tbBore, "Harap diisi dengan angka");
            epinfo.SetError(tbStroke, "Harap diisi dengan angka");
            epinfo.SetError(gbJumlahSilinder, "Silahkan pilih salah satu");

            epcorrect.SetError(tbBore, "");
            eperror.SetError(tbBore, "");
            epwarning.SetError(tbBore, "");

            epcorrect.SetError(tbStroke, "");
            eperror.SetError(tbStroke, "");
            epwarning.SetError(tbStroke, "");

            epcorrect.SetError(gbJumlahSilinder, "");
        }

        private void bHitung_Click(object sender, EventArgs e)
        {
            float bore = float.Parse(tbBore.Text);
            float r = bore / 2;
            float stroke = float.Parse(tbStroke.Text);

            float calc = (float)(3.142 * r * r * stroke / 1000);

            if (tbBore.Text != "" && tbStroke.Text != "" && rb1Silinder.Checked)
            {
                MessageBox.Show
                    ("Bore : " + tbBore.Text +
                    "\nStroke: " + tbStroke.Text +
                    "\nUkuran silinder: " + calc,

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (tbBore.Text != "" && tbStroke.Text != "" && rb2Silinder.Checked)
            {
                MessageBox.Show
                    ("Bore : " + tbBore.Text +
                    "\nStroke: " + tbStroke.Text +
                    "\nUkuran silinder: " + (calc * 2),

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (tbBore.Text != "" && tbStroke.Text != "" && rb3Silinder.Checked)
            {
                MessageBox.Show
                    ("Bore : " + tbBore.Text +
                    "\nStroke: " + tbStroke.Text +
                    "\nUkuran silinder: " + (calc * 3),

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (tbBore.Text != "" && tbStroke.Text != "" && rb4Silinder.Checked)
            {
                    MessageBox.Show
                    ("Bore : " + tbBore.Text +
                    "\nStroke: " + tbStroke.Text +
                    "\nUkuran silinder: " + (calc * 4),

                    "Terima kasih telah menggunakan aplikasi kami",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rb1Silinder_CheckedChanged(object sender, EventArgs e)
        {
            epinfo.SetError(gbJumlahSilinder, "");
            epcorrect.SetError(gbJumlahSilinder, "Terpilih");
        }

        private void rb3Silinder_CheckedChanged(object sender, EventArgs e)
        {
            epinfo.SetError(gbJumlahSilinder, "");
            epcorrect.SetError(gbJumlahSilinder, "Terpilih");
        }

        private void rb2Silinder_CheckedChanged(object sender, EventArgs e)
        {
            epinfo.SetError(gbJumlahSilinder, "");
            epcorrect.SetError(gbJumlahSilinder, "Terpilih");
        }

        private void rb4Silinder_CheckedChanged(object sender, EventArgs e)
        {
            epinfo.SetError(gbJumlahSilinder, "");
            epcorrect.SetError(gbJumlahSilinder, "Terpilih");
        }
    }
}
