using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Biblio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temps.Text = DateTime.Now.ToString("");
            
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifier l1 = new modifier();
            l1.MdiParent = this;
            l1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Livres l1 = new Livres();
            l1.MdiParent = this;
            l1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ajouter a1 = new ajouter();
            a1.MdiParent = this;
            a1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supprimer l1 = new supprimer();
            l1.MdiParent = this;
            l1.Show();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Etes-vous sûr de Quitter ? ", "ATTENTION !!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temps_Click(object sender, EventArgs e)
        {

        }
    }
}
