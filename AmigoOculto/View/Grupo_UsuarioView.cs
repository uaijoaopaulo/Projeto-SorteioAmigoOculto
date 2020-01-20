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
    public partial class Grupo_UsuarioView : Form
    {
        private RepositoryGrupoUsuario repogp = new RepositoryGrupoUsuario();
        public Grupo_UsuarioView()
        {
            InitializeComponent();
            dtgGrupoUsuario.DataSource = repogp.GetAllU();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttAtualiza_Click(object sender, EventArgs e)
        {
            dtgGrupoUsuario.DataSource = repogp.GetAllU();
        }
    }
}
