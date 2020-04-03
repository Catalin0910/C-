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
    public partial class ListaStudentiIntrodusi : Form
    {
        List<Studenti> lista2;
        public ListaStudentiIntrodusi(List<Studenti> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            foreach (Studenti s in lista2)
                textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CerereAdeverinte cer = new CerereAdeverinte();
            cer.ShowDialog();
            this.Close();
        }
    }
}
