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
            this.rtxtResults.Text = this.rtxtResults.Text + "\n" + "--------------------" + "\n" + this.Wallet.Text + "\n" + this.Fecha.Value + "\n" + this.AxieType.SelectedItem + "\n" + this.Estado.SelectedItem + "\n" + Pureza.Value + "\n" + "--------------------";
        }
    }
}
