using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static string NumeClient = "";
      
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");
        private void btnLogare_Click(object sender, EventArgs e)
        {
            if (txtNume.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Introduceti date");
            }
            else
            {
                if (selectareRol.SelectedIndex > -1)
                {
                    if (selectareRol.SelectedItem.ToString() == "Admin")
                    {
                        if (txtNume.Text == "Georgiana" && txtParola.Text == "admin")
                        {
                            InterfataProdus prod = new InterfataProdus();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nume si parola gresite. Introduceti numele si parola de admin");
                        }

                    }
                    else
                        if (selectareRol.SelectedItem.ToString() == "Client")
                        {
                            Con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from ClientiTbl where ClNume='" + txtNume.Text + "' and ClParola='" + txtParola.Text + "'", Con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                NumeClient = txtNume.Text;
                                Interfata2 inter = new Interfata2();
                                inter.Show();
                                this.Hide();
                                Con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Nume si parola gresite");
                            }
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Alegeti un rol");
                        }
                
                }
                else
                {
                    MessageBox.Show("Selecteaza un rol");
                }
            }
        }

        private void btnIesire4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterfataInr inr = new InterfataInr();
            inr.Show();
            this.Hide();
        }

    }
}
