using MySql.Data.MySqlClient;
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
    public partial class ajouter : Form
    {
        string myConnectionString = "server=127.0.0.1;uid=root;database=projet_csharp";
        MySqlConnection connMysql;
        public ajouter()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ISBN.Text.Length > 13)
            {
                MessageBox.Show("L'annee doit etre de 13 chiffre");
            }
            else if (AnneeT.Text.Length > 4)
            {
                MessageBox.Show("L'annee doit etre de 4 chiffre");
            }
            else if (AuteurT.Text.Length > 15)
            {
                MessageBox.Show("L'annee doit etre de 15 chiffre");
            }
            else if (AuteurT.Text.Length > 15)
            {
                MessageBox.Show("L'annee doit etre de 15 chiffre");
            }
            else
            {
                string txtinsert;
                txtinsert = "insert into livre values(" +
                    ISBN.Text + "," +
                    AnneeT.Text + ",'" +
                    AuteurT.Text + "','" +
                    TypeT.Text + "','" +
                    TitreT.Text + "','" +
                    EditeurT.Text + "')";
                try
                {

                    connMysql = new MySqlConnection(myConnectionString);
                    connMysql.Open();
                    MessageBox.Show("connection etablie");
                    MessageBox.Show(txtinsert);
                    MySqlCommand Mysqlcmd;
                    Mysqlcmd = new MySqlCommand(txtinsert, connMysql);
                    Mysqlcmd.ExecuteNonQuery();
                    connMysql.Close();
                    MessageBox.Show("Ajout dans la base MySql Terminer avec succée");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr de Quitter ? ", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
