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
    public partial class Form2 : Form
    {
        public string ReporteData;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rtxtReport.Text = ReporteData;
        }
    }
}
