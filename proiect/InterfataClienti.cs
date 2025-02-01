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
    public partial class InterfataClienti : Form
    {
        public InterfataClienti()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");

        private void btnIesire2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProdus2_Click(object sender, EventArgs e)
        {
            InterfataProdus pro = new InterfataProdus();
            pro.Show();
            this.Hide();
        }

        private void btnCat2_Click(object sender, EventArgs e)
        {
            InterfataCategorii cat = new InterfataCategorii();
            cat.Show();
            this.Hide();
        }

        private void btnAdauga2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeCl.Text == "")
                {
                    MessageBox.Show("Adauga informatii despre client");

                }
                else
                {
                    Con.Open();
                    string query = "insert into ClientiTbl values('" + txtNumeCl.Text + "','" + txtVarstaCl.Text + "','" + txtTelCl.Text + "','" + txtParolaCl.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client adaugat");
                    Con.Close();
                    populare();
                    txtIdCl.Text = "";
                    txtNumeCl.Text = "";
                    txtVarstaCl.Text = "";
                    txtTelCl.Text = "";
                    txtParolaCl.Text = "";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populare()
        {
            //aici se populeaza datagrid cu informatiile din tabela pe care le-am introdus
            Con.Open();
            string query = "select * from ClientiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            afisareClienti.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void InterfataClienti_Load(object sender, EventArgs e)
        {
            populare();
        }

        private void afisareClienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //aici cand selectam ceva din tabelul din datagrid se vor arata informatiile in textbox-ul pe care il folosim pt inserarea datelor
            txtIdCl.Text = afisareClienti.SelectedRows[0].Cells[0].Value.ToString();
            txtNumeCl.Text = afisareClienti.SelectedRows[0].Cells[1].Value.ToString();
            txtVarstaCl.Text = afisareClienti.SelectedRows[0].Cells[2].Value.ToString();
            txtTelCl.Text= afisareClienti.SelectedRows[0].Cells[3].Value.ToString();
            txtParolaCl.Text = afisareClienti.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnSterge2_Click(object sender, EventArgs e)
        {
            //aici se sterge din tabela informatia selectata
            try
            {
                if (txtIdCl.Text == "")
                {
                    MessageBox.Show("Selecteaza produsul pe care vrei sa il stergi");

                }
                else
                {
                    Con.Open();
                    string query = "delete from ClientiTbl where ClId=" + txtIdCl.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clientul a fost sters");
                    Con.Close();
                    populare();
                    txtIdCl.Text = "";
                    txtNumeCl.Text = "";
                    txtVarstaCl.Text = "";
                    txtTelCl.Text = "";
                    txtParolaCl.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCl.Text == "" || txtNumeCl.Text == "" || txtVarstaCl.Text == "" || txtParolaCl.Text == "")
                {
                    MessageBox.Show("Informatii lipsa");
                }
                else
                {
                    Con.Open();
                    string query = "update ClientiTbl set ClNume='" + txtNumeCl.Text + "',ClAdresa='" + txtVarstaCl.Text + "',ClTelefon='" + txtTelCl.Text + "',ClParola='"+txtParolaCl.Text+"' where ClId=" + txtIdCl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Clientul a fost updatat");
                    Con.Close();
                    populare();
                    txtIdCl.Text = "";
                    txtNumeCl.Text = "";
                    txtVarstaCl.Text = "";
                    txtTelCl.Text = "";
                    txtParolaCl.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkDec2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logare = new Form1();
            logare.Show();

        }
    }
}
