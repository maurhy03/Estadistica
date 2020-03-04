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
    public partial class Form2 : Form
    {
        moneda objmoneda = new moneda();
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            LblRespuesta.Text = objmoneda.convertir(CbxTipo.SelectedIndex, CbxDe.SelectedIndex, CbxA.SelectedIndex, double.Parse(TxtCantidad.Text)).ToString();
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxDe.Items.AddRange(objmoneda.conversor[CbxTipo.SelectedIndex]);
            CbxA.Items.AddRange(objmoneda.conversor[CbxTipo.SelectedIndex]);
        }
    }
}
