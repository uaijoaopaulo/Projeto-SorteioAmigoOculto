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
using AmigoOculto.Model;


namespace AmigoOculto.View
{
    public partial class ResultadoView : Form
    {
        private RepositoryUsuario repositoryD = new RepositoryUsuario();
        private RepositoryHistorico repositoryH = new RepositoryHistorico();
        private RepositoryResultado repositoryR = new RepositoryResultado();
        bool bttMost = false;
        public ResultadoView()
        {
            InitializeComponent();
        }

        private void bttMotrar_Click(object sender, EventArgs e)
        {
            if(bttMost == false)
            {
                bttMost = true;
                bttMotrar.Text = "Esconder";
                Historico hist = repositoryH.GetOneH(true);
                Usuario usuario = repositoryD.GetOneU(hist.User);
                Sorteio sort = repositoryR.GetOneR(usuario.Id);
                Usuario usuarioD = repositoryD.GetOneUID(int.Parse(sort.id_Usuario_Destino.ToString()));
                lblNomeD.Text = usuarioD.NomeCmp;
            }
            else
            {
                bttMost = false;
                bttMotrar.Text = "Mostrar";
                lblNomeD.Text = "";
            }
            
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Historico hist = repositoryH.GetOneH(true);
            hist.DataSaida = DateTime.Now;
            hist.Ativo = false;
            repositoryH.NovoH(hist);
            lblNomeO.Text = "";
            LoginView view = new LoginView();
            this.Hide();
            view.ShowDialog();
            this.Close();
            view = null;
        }
    }
}
