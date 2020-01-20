using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmigoOculto.View
{
    public partial class AjudaView : Form
    {
        public AjudaView()
        {
            InitializeComponent();
            txtAjuda.Text = "Caso nao consiga executar o login entre em contato com o administrador de seu grupo," +
                " Apenas o administrador tem acesso ao grupo!";
            bttFechar.FlatAppearance.BorderSize = 0;
            bttFechar.FlatStyle = FlatStyle.Flat;
        }

        private void bttOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
