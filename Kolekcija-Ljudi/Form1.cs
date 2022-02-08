using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_Ljudi
{
    public partial class Form1 : Form
    {
        string text;
        List<Ljudi> Osobe = new List<Ljudi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ljudi ljudi = new Ljudi(textBoxIme.Text, textBoxPrezime.Text, Convert.ToInt32(textBoxGodina.Text), comboBoxrod.Text, "");
                Osobe.Add(ljudi);
                textBoxIme.Clear(); 
                textBoxPrezime.Clear();
                textBoxGodina.Clear();
                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos! \r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ime" + "\tPrezime" + "\tgodRod" + "\tRod" + "\tdodatak\r\n";
            foreach(Ljudi ljudi in Osobe)
            {
                richTextBox1.AppendText(ljudi.ToString() + "\r\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            richTextBox1.AppendText("_________Obrada__________\r\n");
            foreach (Ljudi ljudi in Osobe)
            {
               
                if(ljudi.Rod == "M")
                {
                    ljudi.Dodatak = "ima brkove";
                }
                if(ljudi.Rod == "Ž")
                {
                    ljudi.Dodatak = "nema brkove";
                }
            }
            foreach(Ljudi ljudi in Osobe)
            {
                richTextBox1.AppendText(ljudi.ToString() + "\r\n");
            }
        }
    }
}
