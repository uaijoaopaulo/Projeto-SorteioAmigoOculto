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
    public partial class GrupoView : Form
    {
        private RepositoryGrupo repoGP = new RepositoryGrupo();
        private RepositoryGrupoUsuario repoGPU = new RepositoryGrupoUsuario();
        public GrupoView()
        {
            InitializeComponent();
            for (int i = 0; i < repoGP.GetAllU().Count(); i++)
            {
                Grupo grupo = repoGP.GetOneID(i);
                if (grupo != null)
                {
                    grupo.QuantidadeUsuario = repoGPU.GetAllByIdGrupoU(i).Count;
                    repoGP.Salvar(grupo);
                    dtgDadosGrupo.DataSource = repoGP.GetAllU();
                }
            }
            dtgDadosGrupo.DataSource = repoGP.GetAllU();
        }

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repoGP.GetAllU().Count(); i++)
            {
                Grupo grupo = repoGP.GetOneID(i);
                if(grupo != null)
                {
                    grupo.QuantidadeUsuario = repoGPU.GetAllByIdGrupoU(i).Count;
                    repoGP.Salvar(grupo);
                    dtgDadosGrupo.DataSource = repoGP.GetAllU();
                }
            }
            dtgDadosGrupo.DataSource = repoGP.GetAllU();
        }

        private void bttNovo_Click(object sender, EventArgs e)
        {
            Grupo grupo = new Grupo();
            grupo.Nome = txtNomeGrupo.Text;
            grupo.DttCriacao = DateTime.Now;
            grupo.Ativo = true;
            grupo.QuantidadeUsuario = 0;
            repoGP.Salvar(grupo);
            txtNomeGrupo.Text = "";
            MessageBox.Show("Grupo Criado");
            dtgDadosGrupo.DataSource = repoGP.GetAllU();
        }

        private void bttDeletar_Click(object sender, EventArgs e)
        {
            repoGP.Delete(int.Parse(txtIdDelete.Text));
            txtIdDelete.Text = "";
        }

        private void bttIdProcurar_Click(object sender, EventArgs e)
        {
            Grupo grupo = repoGP.GetOneID(int.Parse(txtIdProcurar.Text));
            dtgDadosGrupo.DataSource = grupo;
            txtIdDelete.Text = grupo.Id.ToString();
        }
    }
}
