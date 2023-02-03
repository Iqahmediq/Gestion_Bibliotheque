using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Biblio
{
    public partial class Livres : Form
    {
        string myConnectionString = "server=127.0.0.1;uid=root;database=projet_csharp";
        public Livres()
        {
            InitializeComponent();
            charger_Liste_Livre();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
