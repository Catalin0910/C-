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
    public partial class AdeverintaCreata : Form
    {
        List<Adeverinta> listaadev1;
        public AdeverintaCreata(List<Adeverinta> listaadev)
        {
            InitializeComponent();
            listaadev1 = listaadev;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach (Adeverinta a in listaadev1)
            {
                ListViewItem itm = new ListViewItem(a.TipAdeverinta.ToString());
                itm.SubItems.Add(a.AltaAdeverinta.ToString());
                itm.SubItems.Add(a.AlteNecesitati.ToString());
                itm.SubItems.Add(a.Necesitate.ToString());
                listView1.Items.Add(itm);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(listView1.Text);
                sw.Close();
                listView1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                listView1.Text = sr.ReadToEnd();
                sr.Close();
            }
            foreach (Adeverinta a in listaadev1)
            {
                ListViewItem itm = new ListViewItem(a.TipAdeverinta);
                itm.SubItems.Add(a.AltaAdeverinta);
                itm.SubItems.Add(a.AlteNecesitati);
                itm.SubItems.Add(a.Necesitate);
                listView1.Items.Add(itm);
            }
        }

        private void ștergeAdeverințeSalvateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem itm in listView1.Items)
            {
                if (itm.Selected)
                    itm.Remove();
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                e.Item.BackColor = Color.Azure;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
