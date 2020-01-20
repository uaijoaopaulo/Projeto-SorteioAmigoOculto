using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoOculto.Repository;

namespace AmigoOculto.View
{
    public partial class HistoricoView : Form
    {
        private RepositoryHistorico repositoryH = new RepositoryHistorico();
        public HistoricoView()
        {
            InitializeComponent();
            dtgDadosH.DataSource = repositoryH.GetAllH();
        }

        private void HistoricoView_Load(object sender, EventArgs e)
        {

        }

        private void dtgDadosH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
