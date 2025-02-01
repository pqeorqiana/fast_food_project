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
using System.Diagnostics.CodeAnalysis;

namespace proiect
{
    public partial class Interfata2 : Form
    {
        public Interfata2()
        {
            InitializeComponent();
        }

        public static string pretPtCom;
        int a = Convert.ToInt32(pretPtCom);

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\fastfooddb.mdf;Integrated Security=True");
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
            selectareCategorie.ValueMember = "catNume";
            selectareCategorie.DataSource = dt;
            Con.Close();

        }

        private void populare()
        {
            //se populeaza datagrid cu informatiile din tabela pe care le-am introdus
            Con.Open();
            string query = "select PrNume, PrPret, PrTip from ProduseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            afisareProduse1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Interfata2_Load(object sender, EventArgs e)
        {
            umplere();
            ClientN.Text = Form1.NumeClient;
        }

        private void afisareProduse1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //selectarea din datagrid si umplerea spatiului pt denumire si pret din tabela
            txtNumeCom.Text = afisareProduse1.SelectedRows[0].Cells[0].Value.ToString();
            txtPretCom.Text = afisareProduse1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnIesire4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            data.Text = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
        }

        int totalul = 0, n = 0;

        private void selectareCategorie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //se afiseaza in datagrid produsele din categoria selectata
            Con.Open();
            string query = "select PrNume, PrPret, PrTip from ProduseTbl where PrCategorie='" + selectareCategorie.SelectedValue.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            afisareProduse1.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void linkDec4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 logare = new Form1();
            logare.Show();

        }

        private void selectareCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se afiseaza in combobox: selecteaza categoria daca nu este selectata categoria
            if (selectareCategorie.SelectedIndex <= 0)
            {
                selectareCategorie.Text = "Selecteaza categoria";
            }
            else
            {
                selectareCategorie.Text = selectareCategorie.SelectedText;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (pretC.Text=="-"||pretC.Text=="0"||pretC.Text=="")
            {
                MessageBox.Show("Doriti sa comandati ceva?");
            }
            else
            {
                InterfataComanda com = new InterfataComanda();
                com.Show();
                this.Hide();
            }
                

        }
        
        private void afisareComanda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //alegerea din tabelul creat datagrid si umplerea textboxurilor 
            txtNumeCom.Text= afisareComanda.SelectedRows[0].Cells[1].Value.ToString();
            txtPretCom.Text= afisareComanda.SelectedRows[0].Cells[2].Value.ToString();
            txtCantitateCom.Text= afisareComanda.SelectedRows[0].Cells[3].Value.ToString();
            pretProdus.Text= afisareComanda.SelectedRows[0].Cells[4].Value.ToString();
           // numeProdus = txtNumeCom.Text;
        }



        int parsedValue;

        private void btnAdaugaCom_Click_1(object sender, EventArgs e)
        {  
            //se creeaza un tabel si se calculeaza totalul 
            if (txtNumeCom.Text == "" || txtCantitateCom.Text == "")
            {
                MessageBox.Show("Informatii lipsa");
            }
            else
                if (!int.TryParse(txtCantitateCom.Text, out parsedValue))
                {
                    MessageBox.Show("Introduceti numere");
                    return;
                }
                else
                {
               
                    int total = Convert.ToInt32(txtPretCom.Text) * Convert.ToInt32(txtCantitateCom.Text);
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(afisareComanda);
                    newRow.Cells[0].Value = n + 1;
                    newRow.Cells[1].Value = txtNumeCom.Text;
                    newRow.Cells[2].Value = txtPretCom.Text;
                    newRow.Cells[3].Value = txtCantitateCom.Text;
                    newRow.Cells[4].Value = Convert.ToInt32(txtPretCom.Text) * Convert.ToInt32(txtCantitateCom.Text);
                    afisareComanda.Rows.Add(newRow);
                    n++;
                    totalul = totalul + total;
                    pretC.Text = "" + totalul;
                    pretPtCom = pretC.Text;
                    txtNumeCom.Text = "";
                    txtPretCom.Text = "";
                    txtCantitateCom.Text = "";
               
                }
        }

        private void btnStergereC_Click(object sender, EventArgs e)
        {
            if (txtNumeCom.Text == "")
            {
                MessageBox.Show("Selecteaza produsul pe care vrei sa il stergi");
            }
            else
            {
                try
                {
                    if (txtNumeCom.Text == "")
                    {
                        MessageBox.Show("Selecteaza produsul pe care vrei sa il stergi");

                    }
                    else
                    {
                        if (this.afisareComanda.SelectedRows.Count > 0)
                        {
                            afisareComanda.Rows.RemoveAt(this.afisareComanda.SelectedRows[0].Index);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //in momentul stergerii produsului, totalul se actualieaza si se scade
                int ttl = Convert.ToInt32(pretC.Text) - Convert.ToInt32(pretProdus.Text);
                pretC.Text = "" + ttl;
                totalul =ttl;
                txtNumeCom.Text = "";
                txtPretCom.Text = "";
                txtCantitateCom.Text = "";
            }
        }

    }

}
