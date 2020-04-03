using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW_Cebuc_Gabriel_Catalin_1048
{
    
    public partial class IntroducereStudenti : Form
    {
        List<Studenti> listaStudenti = new List<Studenti>();
        public IntroducereStudenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Introduceti Numele!");
            }
            else
                if (tbPrenume.Text == "")
            {
                errorProvider1.SetError(tbPrenume, "Introduceti prenumele!");
            }
            else
                if (tbVarsta.Text == "")
                errorProvider1.SetError(tbVarsta, "Introduceti varsta!");
            else
                if (cbAnStudiu.Text == "")
                errorProvider1.SetError(cbAnStudiu, "Selectati anulul de studiu!");
            else
                if (cbProgramStudiu.Text == "")
                errorProvider1.SetError(cbProgramStudiu, "Selectati programul de studiu urmat de student!");
            else
                if (tbGrupa.Text == "")
                errorProvider1.SetError(tbGrupa, "Introduceti grupa!");
            else
                if (cbSeria.Text == "")
                errorProvider1.SetError(cbSeria, "Selectati seria!");
            else
            {
                try
                {
                    string firstName = tbNume.Text;
                    string lastName = tbPrenume.Text;
                    int varsta = Convert.ToInt32(tbVarsta.Text);
                    int anStudiu = Convert.ToInt32(cbAnStudiu.Text);
                    string programStudiu = cbProgramStudiu.Text;
                    int grupa = Convert.ToInt32(tbGrupa.Text);
                    char seria = Convert.ToChar(cbSeria.Text);
                    Studenti s = new Studenti(programStudiu, anStudiu, varsta, firstName, lastName, grupa, seria);
                    listaStudenti.Add(s);
                    MessageBox.Show(s.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nu s-au introdus datele corect!");
                }
                finally
                {
                    cbProgramStudiu.Text = "";
                    cbAnStudiu.Text = "";
                    tbVarsta.Clear();
                    tbNume.Clear();
                    tbPrenume.Clear();
                    tbGrupa.Clear();
                    cbSeria.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaStudentiIntrodusi lsi = new ListaStudentiIntrodusi(listaStudenti);
            lsi.ShowDialog();
            this.Close();
        }

        private void tbVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbGrupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
