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
    public partial class InterfataCategorii : Form
    {
        public InterfataCategorii()
        {
            InitializeComponent();
        }

        private void btnIesire3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");
        private void btnAdauga3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeCat.Text == "")
                {
                    MessageBox.Show("Adauga informatii despre categorie");

                }
                else
                {
                    Con.Open();
                    string query = "insert into CategoriiTbl values('" + txtNumeCat.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categorie adaugata");
                    Con.Close();
                    populare();
                    txtIdCat.Text = "";
                    txtNumeCat.Text = "";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void populare()
        {
            //se populeaza datagrid cu informatiile din tabela pe care le-am introdus
            Con.Open();
            string query = "select * from CategoriiTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            afisareCategorii.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void InterfataCategorii_Load(object sender, EventArgs e)
        {
            populare();
        }

        private void afisareCategorii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cand selectam ceva din tabelul din datagrid se vor afisa informatiile in textbox-ul pe care il folosim pt inserarea datelor
            txtIdCat.Text = afisareCategorii.SelectedRows[0].Cells[0].Value.ToString();
            txtNumeCat.Text = afisareCategorii.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnSterge3_Click(object sender, EventArgs e)
        {
            //se sterge din tabela informatia selectata
            try
            {
                if (txtIdCat.Text == "")
                {
                    MessageBox.Show("Selecteaza categoria pe care vrei sa o stergi");

                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoriiTbl where CatId=" + txtIdCat.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria a fost stersa");
                    Con.Close();
                    populare();
                    txtIdCat.Text = "";
                    txtNumeCat.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCat.Text == "" || txtNumeCat.Text == "")
                {
                    MessageBox.Show("Informatii lipsa");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoriiTbl set CatNume='" + txtNumeCat.Text + "' where CatId=" + txtIdCat.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria a fost updatata");
                    Con.Close();
                    populare();
                    txtIdCat.Text = "";
                    txtNumeCat.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnProdus3_Click(object sender, EventArgs e)
        {
            InterfataProdus pro = new InterfataProdus();
            pro.Show();
            this.Hide();
        }

        private void linkDec3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logare = new Form1();
            logare.Show();

        }

        private void btnCat3_Click(object sender, EventArgs e)
        {
            InterfataClienti clt = new InterfataClienti();
            clt.Show();
            this.Hide();
        }
    }
}
