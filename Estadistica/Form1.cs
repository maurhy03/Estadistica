using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
    public partial class Form1 : Form
    {
        estadistica objEstadistica = new estadistica();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMedia_Aritmetica_Click(object sender, EventArgs e)
        {
            //split = divide una caden aen base a un limitador (patron) y devuelve una matriz
            LblRespuesta_Serie.Text = "X="+ objEstadistica.media(TxtSerie.Text.Split(','));
        }
    }
}
