using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onlypans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User1 = "Edwin";
            string Contra1 = "1234567890";
            string User2 = "Juan";
            string Contra2 = "1111111111";
            string User3 = "Maria";
            string Contra3 = "2222222222";
            string User4 = "Carlos";
            string Contra4 = "3333333333";
            string Admin = "Admin";
            string CAdmin = "Admin";

            if ((TxTUser.Text == User1 && TxTContra.Text == Contra1) || (TxTUser.Text == User2 && TxTContra.Text == Contra2) || (TxTUser.Text == User3 && TxTContra.Text == Contra3) || (TxTUser.Text == User4 && TxTContra.Text == Contra4))
            {
                Seccion1 seccion = new Seccion1();
                Seccion1 Ventana2 = new Seccion1();
                Ventana2.Show();
                this.Hide();

            }
            else if((TxTUser.Text == Admin && TxTContra.Text == CAdmin))
            {

                admin Ventana3 = new admin();
                Ventana3.cajarica2.Text = richTextBox3.Text;
                Ventana3.Show();
                this.Hide();
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
