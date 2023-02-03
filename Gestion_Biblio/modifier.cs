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
    public partial class modifier : Form
    {
        public modifier()
        {
            InitializeComponent();
            charger_Liste_Livre();
        }
        string myConnectionString = "server=127.0.0.1;uid=root;database=projet_csharp";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void charger_Liste_Livre()
        {

            dataGridView1.Rows.Clear();
            string sql = " SELECT * FROM Livre  ";
            MySqlConnection connect = new MySqlConnection(myConnectionString);
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            connect.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = new string[] {
                    reader.GetValue(0).ToString(),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5).ToString() };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
            connect.Close();
        }

       


        private void button3_Click_1(object sender, EventArgs e)
        {
            int lignecourrant;
            string ISBN, Annee, Auteur, Type, Titre, Editeur;

            if (dataGridView1.RowCount == 0)
                return;
            lignecourrant = dataGridView1.CurrentRow.Index;

            ISBN = dataGridView1.Rows[lignecourrant].Cells[0].Value.ToString();
            Annee = dataGridView1.Rows[lignecourrant].Cells[1].Value.ToString();
            Auteur = dataGridView1.Rows[lignecourrant].Cells[2].Value.ToString();
            Type = dataGridView1.Rows[lignecourrant].Cells[3].Value.ToString();
            Titre = dataGridView1.Rows[lignecourrant].Cells[4].Value.ToString();
            Editeur = dataGridView1.Rows[lignecourrant].Cells[5].Value.ToString();

            ISBNT.Text = ISBN;
            AnneeT.Text = Annee;
            AuteurT.Text = Auteur;
            TypeT.Text = Type;
            TitreT.Text = Titre;
            EditeurT.Text = Editeur;
            ISBNT.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (AnneeT.Text.Length > 4)
            {
                MessageBox.Show("L'annee doit etre de 4 chiffre");
            }
            else if (ISBNT.Text.Length > 13)
            {
                MessageBox.Show("L'annee doit etre de 13 chiffre");
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
                string txtsql = "update Livre set Editeur = '" + EditeurT.Text +
                   "',AnneeSortie='" + AnneeT.Text +
                   "',Auteur='" + AuteurT.Text +
                   "',TypeLivre='" + TypeT.Text +
                   "', TitreLivre='" + TitreT.Text +
                   "' where ISBN = " + ISBNT.Text + "";
                try
                {
                    MySqlConnection connMysql = new MySqlConnection(myConnectionString);
                    connMysql.Open();

                    MySqlCommand Mysqlcmd;
                    Mysqlcmd = new MySqlCommand(txtsql, connMysql);
                    Mysqlcmd.ExecuteNonQuery();
                    connMysql.Close();
                    MessageBox.Show("modification etablie avec succée");
                    charger_Liste_Livre();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr de Quitter ? ", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
