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
    public partial class InterfataInr : Form
    {
        public InterfataInr()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");

        private void btnIesire2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int parsedValue;
        private void btnAdauga2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVarstaI.Text, out parsedValue) || !int.TryParse(txtTelI.Text, out parsedValue))
            {
                MessageBox.Show("Introduceti numere");
                return;
            }
            else
                try
                {
                    if (txtNumeI.Text == "" || txtParolaI.Text == "" || txtVarstaI.Text == "" || txtTelI.Text == "")
                    {
                        MessageBox.Show("Adauga informatii");
                    }
                    else
                        if (Convert.ToInt32(txtVarstaI.Text) < 7 || Convert.ToInt32(txtVarstaI.Text) > 120)
                        {
                            MessageBox.Show("Varsta neacceptata");
                        }
                        else
                        {
                            Con.Open();
                            string query = "insert into ClientiTbl values('" + txtNumeI.Text + "','" + txtVarstaI.Text + "','" + txtTelI.Text + "','" + txtParolaI.Text + "')";
                            SqlCommand cmd = new SqlCommand(query, Con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Te-ai inregistrat cu succes!");
                            Con.Close();
                            txtNumeI.Text = "";
                            txtVarstaI.Text = "";
                            txtTelI.Text = "";
                            txtParolaI.Text = "";
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        
        }
       
        private void linkCon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logare = new Form1();
            logare.Show();
        }
    }
}
