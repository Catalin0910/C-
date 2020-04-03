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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            passward_txt.PasswordChar = '*';
            passward_txt.MaxLength = 20;
        }

        void removeBG(PictureBox pb, PictureBox pb2)
        {
            var pos = this.PointToScreen(pb2.Location);
            pos = pb.PointToClient(pos);
            pb2.Parent = pb;
            pb2.Location = pos;
            pb2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProgramAdeverinte pa = new ProgramAdeverinte();
            pa.ShowDialog();
            this.Close();

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
