using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AmigoOculto.View;
using AmigoOculto.Model;
using AmigoOculto.Repository;

namespace AmigoOculto
{
    public partial class PrincipalView : Form
    {
        private RepositoryHistorico repository = new RepositoryHistorico();
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void cadastroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroView view = new CadastroView();
            view.ShowDialog();
            view.Location = new Point(50 + this.Location.X, this.Location.Y);
            view = null;
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Historico hist = repository.GetOneH(true);
            hist.DataSaida = DateTime.Now;
            hist.Ativo = false;
            repository.NovoH(hist);
            lblNome.Text = "";
            LoginView view = new LoginView();
            this.Hide();
            view.ShowDialog();
            this.Close();
            view = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historico hist = repository.GetOneH(true);
            //if(hist.Administrador == true)
            //{
                HistoricoView view = new HistoricoView();
                view.ShowDialog();
                view = null;
            /*}
            else
            {
                MessageBox.Show(@"Você nao tem permissões para acessar esta area!
Entre em contato com um Administrador!");
            }*/
            
        }

        private void usuarioGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupo_UsuarioView view = new Grupo_UsuarioView();
            view.ShowDialog();
            view = null;
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrupoView view = new GrupoView();
            view.ShowDialog();
            view = null;
        }

        private void sorteioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SorteioView view = new SorteioView();
            view.ShowDialog();
            view = null;
        }
    }
}
