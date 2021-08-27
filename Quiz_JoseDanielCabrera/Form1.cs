using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_JoseDanielCabrera
{
    public partial class Axie_Infinity_Blockchain : Form
    {
        public Axie_Infinity_Blockchain()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = rtxtResults.Text + "\n" + "--------------------" + "\n" + Wallet.Text + "\n" + Fecha.Value + "\n" + AxieType.SelectedItem + "\n" + Estado.SelectedItem + "\n" + Pureza.Value + "\n" + "--------------------";
        }

        private void Report_Click(object sender, EventArgs e)
        {
            using (Form2 sf = new Form2())
            {
                sf.ReporteData = rtxtResults.Text;
                sf.ShowDialog();
            }
        }
    }
}
