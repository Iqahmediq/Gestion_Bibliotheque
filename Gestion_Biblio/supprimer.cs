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
    public partial class supprimer : Form
    {
        public supprimer()
        {
            InitializeComponent();
        }

        
        string myConnectionString = "server=127.0.0.1;uid=root;database=projet_csharp";
        MySqlConnection connMysql;
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string del;
            del = "DELETE FROM Livre WHERE Livre.ISBN =" + textBox1.Text;
            try
            {

                connMysql = new MySqlConnection(myConnectionString);
                connMysql.Open();
                MessageBox.Show("connection etablie");
                MySqlCommand Mysqlcmd;
                Mysqlcmd = new MySqlCommand(del, connMysql);
                Mysqlcmd.ExecuteNonQuery();
                connMysql.Close();
                MessageBox.Show("Item Deleted !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Etes-vous sûr de Quitter La Suppression ? ", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
