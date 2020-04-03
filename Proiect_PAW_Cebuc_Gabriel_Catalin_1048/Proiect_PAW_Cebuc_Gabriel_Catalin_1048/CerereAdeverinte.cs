using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_PAW_Cebuc_Gabriel_Catalin_1048
{
     
    public partial class CerereAdeverinte : Form
    {
        List<Adeverinta> listaAdev = new List<Adeverinta>();
        public CerereAdeverinte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                errorProvider1.SetError(comboBox1, "Selectați tipul adeverinței necesare!");
            else
            {
                try
                {
                    string TipAdeverinta = comboBox1.Text;
                    string AltaAdeverinta = textBox2.Text;
                    string AlteNecesitati = comboBox2.Text;
                    string necesitate = groupBox1.Text;
                    if(radioButton1.Checked==true)
                    {
                        necesitate = "Urgent";
                    }
                    else
                        if(radioButton2.Checked==true)
                        {
                        necesitate = "Normala";
                        }
                    
                    Adeverinta a = new Adeverinta(TipAdeverinta, AltaAdeverinta, AlteNecesitati,necesitate);
                    listaAdev.Add(a);
                    MessageBox.Show(a.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Date introduse gresit!");
                }
                finally
                {
                    comboBox1.Text = "";
                    textBox2.Text = "";
                    comboBox2.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdeverintaCreata adevcreata = new AdeverintaCreata(listaAdev);
            adevcreata.ShowDialog();
            this.Close();
        }

        private void urgentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("Adeverința va fi realizată în maximum două zile");
            }
            else
            {

            }
        }

        private void normalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                MessageBox.Show("Adeverința va fi realizată în maximum o săptămână");
            }
            else
            {

            }
        }
        
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
