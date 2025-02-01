using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect
{
    public partial class InterfataComanda : Form
    {
        public InterfataComanda()
        {
            InitializeComponent();
        }

        private void InterfataComanda_Load(object sender, EventArgs e)
        {
            //schimbarea variabilei client in numele utilizatorului
            clientNP.Text = Form1.NumeClient;
            pretPtCom.Text = Interfata2.pretPtCom;
        }

        private void btnIesireC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdauga3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Va rugam, asteptati!\nProdusele dumneavoasta sunt in procesul de pregatire.", "Procesare...");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interfata2 ret = new Interfata2();
            ret.Show();
            this.Hide();
            
        }

    }
}
