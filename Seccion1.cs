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
    public partial class Seccion1 : Form
    {
        public Seccion1()
        {
            InitializeComponent();
        }

        private void Seccion1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pa = PA.Text;
            int pA = Int32.Parse(pa);
            string pna = PNA.Text;
            int pnA = Int32.Parse(pna);
            string pe = PA.Text;
            int pE = Int32.Parse(pe);

            int PrecioPa = 1000;
            int PrecioPna = 500;
            int PrecioPe = 2000;

            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = TxtCC.Text;
            fila.Cells[1].Value = TxtCliente.Text;
            fila.Cells[2].Value = Date.Text;
            fila.Cells[3].Value = PA.Text;
            fila.Cells[4].Value = PNA.Text;
            fila.Cells[5].Value = PE.Text;
            fila.Cells[6].Value = pA+pnA+pE;
            fila.Cells[7].Value = ((pA*PrecioPa)+(pnA*PrecioPna)+(pE*PrecioPe));

            dataGridView1.Rows.Add(fila);
            TxtCC.Text="";
            TxtCliente.Text="";
            Date.Text="";
            PA.Text="";
            PNA.Text="";
            PE.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
