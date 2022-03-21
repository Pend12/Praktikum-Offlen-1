using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Offlen_1
{
    public partial class formPraktikum : Form
    {

        public formPraktikum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Add(textBoxData.Text);
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == false)
            {
                labelHasilOutput.ForeColor = Color.Black;
            }
        }

        private void radioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBoxAktif.Checked == true)
            {
                labelHasilOutput.ForeColor = Color.Red;
            }
        }

        private void radioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true)
            {
                labelHasilOutput.ForeColor = Color.Blue;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasilOutput.Text = listBoxKoleksi.SelectedItem.ToString();
        }

        private void labelHasilOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxKoleksi.Items.Clear();
            labelHasilOutput.ForeColor = Color.Black;
            labelHasilOutput.Text = "...";
            radioButtonMerah.Checked = true;
            checkBoxAktif.Checked = false;
        }
    }
}
