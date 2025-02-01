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
    public partial class InterfataProdus : Form
    {
        public InterfataProdus()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");

        private void btnIesire1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdauga1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumeP.Text == "")
                {
                    MessageBox.Show("Adauga informatii despre produs");

                }
                else
                {
                    Con.Open();
                    string query = "insert into ProduseTbl values('" + txtNumeP.Text + "','" + txtTipP.Text + "','" + selectareCategorie.SelectedValue.ToString() + "'," + txtPretP.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produs adaugat");
                    Con.Close();
                    populare();
                    txtIdP.Text = "";
                    txtNumeP.Text = "";
                    txtTipP.Text = "";
                    selectareCategorie.Text = "";
                    txtPretP.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void populare()
        {
            //se populeaza datagrid cu informatiile din tabela pe care le-am introdus
            Con.Open();
            string query = "select * from ProduseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            afisareProduse.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void umplere()
        {
            //vom lega tabela de combobox ce face selectarea categoriilor
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatNume from CategoriiTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatNume", typeof(string));
            dt.Load(rdr);
            selectareCategorie.ValueMember = "catNume";
            selectareCategorie.DataSource = dt;
            Con.Close();

        }

        private void InterfataProdus_Load(object sender, EventArgs e)
        {
            umplere();
            populare();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cand selectam ceva din tabelul din datagrid se vor arata informatiile in textbox-ul pe care il folosim pt inserarea datelor
            txtIdP.Text = afisareProduse.SelectedRows[0].Cells[0].Value.ToString();
            txtNumeP.Text = afisareProduse.SelectedRows[0].Cells[1].Value.ToString();
            txtTipP.Text = afisareProduse.SelectedRows[0].Cells[2].Value.ToString();
            selectareCategorie.SelectedValue = afisareProduse.SelectedRows[0].Cells[3].Value.ToString();
            txtPretP.Text = afisareProduse.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btnCat1_Click(object sender, EventArgs e)
        {
            InterfataCategorii cat = new InterfataCategorii();
            cat.Show();
            this.Hide();
        }

        private void btnSterge1_Click(object sender, EventArgs e)
        {
            //se sterge din tabela informatia selectata
            try
            {
                if (txtIdP.Text == "")
                {
                    MessageBox.Show("Selecteaza produsul pe care vrei sa il stergi");

                }
                else
                {
                    Con.Open();
                    string query = "delete from ProduseTbl where PrId=" + txtIdP.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produsul a fost sters");
                    Con.Close();
                    populare();
                    txtIdP.Text = "";
                    txtNumeP.Text = "";
                    txtTipP.Text = "";
                    selectareCategorie.Text = "";
                    txtPretP.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdP.Text == "" || txtNumeP.Text == "" ||txtPretP.Text=="")
                {
                    MessageBox.Show("Informatii lipsa");
                }
                else
                {
                    Con.Open();
                    string query = "update ProduseTbl set PrNume='" + txtNumeP.Text + "',PrTip='"+txtTipP.Text+"',PrPret=" + txtPretP.Text + ", PrCategorie='" + selectareCategorie.SelectedValue.ToString() + "' where PrId=" + txtIdP.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produsul a fost updatat");
                    Con.Close();
                    populare();
                    txtIdP.Text = "";
                    txtNumeP.Text = "";
                    txtTipP.Text = "";
                    selectareCategorie.Text= "";
                    txtPretP.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClient1_Click(object sender, EventArgs e)
        {
            InterfataClienti clt = new InterfataClienti();
            clt.Show();
            this.Hide();
        }

        private void linkDec1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logare = new Form1();
            logare.Show();
        }

        private void selectareCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectareCategorie.SelectedIndex <= 0)
            {
                selectareCategorie.Text = "Selecteaza categoria";
            }
            else
            {
                selectareCategorie.Text = selectareCategorie.SelectedText;
            }
        }
    }
}
