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
    public partial class CadastroView : Form
    {
        private int id = 0;
        private RepositoryUsuario repository = new RepositoryUsuario();
        private RepositoryGrupoUsuario repositoryGPU = new RepositoryGrupoUsuario();
        private RepositoryGrupo repositoryGP = new RepositoryGrupo();
        public CadastroView()
        {
            InitializeComponent();
            dtgDados.DataSource = repository.GetAllU();
        }
        
        private void bttMostrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;
            if (id == 0)
            {
                usuario = new Usuario();
            }
            else
            {
                usuario = repository.GetOneUID(id);
            }
            usuario.User = txtUser.Text;
            usuario.Password = txtSenha.Text;
            usuario.DttCriacao = DateTime.Now;
            usuario.NomeCmp = txtNome.Text;
            usuario.Ativo = chcAtivo.Checked;
            usuario.Administrador = chcAdm.Checked;
            usuario.id_Grupo = int.Parse(cmbGrupoNome.SelectedValue.ToString());
            repository.NovoU(usuario);
            MessageBox.Show("Usuario Criado");

            dtgDados.DataSource = repository.GetAllU();

            Grupo_Usuario gp = new Grupo_Usuario();
            gp.id_Grupo = usuario.id_Grupo;
            gp.id_Usuario = usuario.Id;
            gp.dttCadastro = DateTime.Now;
            repositoryGPU.Salvar(gp);

            Grupo grupo = repositoryGP.GetOneID(usuario.id_Grupo);
            grupo.QuantidadeUsuario = repositoryGPU.GetAllByIdGrupoU(usuario.id_Grupo).Count;
            repositoryGP.Salvar(grupo);

            id = 0;
            txtUser.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtProcurarID.Text = "";
            chcAtivo.Checked = false;
            chcAdm.Checked = false;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir", " Excluir ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(dtgDados.CurrentRow.Cells["Id"].Value.ToString());

                DialogResult dialogResultCon = MessageBox.Show("Confirmar Exclusao", "Atenção", MessageBoxButtons.OKCancel);
                if (dialogResultCon == DialogResult.OK)
                {
                    Usuario usuario = repository.GetOneUID(id);
                    Grupo_Usuario gp = repositoryGPU.GetOneIDU(id);

                    repository.Delete(usuario.Id);
                    repositoryGPU.Delete(gp.Id);

                    Grupo grupo = repositoryGP.GetOneID(usuario.id_Grupo);
                    grupo.QuantidadeUsuario = repositoryGPU.GetAllByIdGrupoU(usuario.id_Grupo).Count;
                    repositoryGP.Salvar(grupo);
                    MessageBox.Show("Usuario Deletado");
                }
                dtgDados.DataSource = repository.GetAllU();
                if (dialogResultCon == DialogResult.Cancel)
                {
                    MessageBox.Show("Operação Cancelada");
                    bttLimpa_Click(null, null);
                }
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada");
                bttLimpa_Click(null, null);
            }
        }
        private void bttLimpa_Click(object sender, EventArgs e)
        {
            id = 0;
            txtUser.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
            txtProcurarID.Text = "";
            chcAtivo.Checked = false;
            chcAdm.Checked = false;
            dtgDados.DataSource = repository.GetAllU();
        }

        private void bttProcurarID_Click(object sender, EventArgs e)
        {
            
            if(txtProcurarID.Text == "")
            {
                MessageBox.Show("Nada digitado");
                return;
            }
            id = int.Parse(txtProcurarID.Text);
            BindingSource source = new BindingSource();
            source.DataSource = repository.GetOneUID(id);
            if (source.DataSource == null)
            {
                MessageBox.Show("ID nao encontrado.");
                return;
            }
            dtgDados.DataSource = null;
            dtgDados.DataSource = repository.GetAllU();

            Usuario usuario = repository.GetOneUID(id);
            txtNome.Text = usuario.NomeCmp;
            txtUser.Text = usuario.User;
            txtSenha.Text = usuario.Password;

        }

        private void dtgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CadastroView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.dataSet.Grupo);
        }

        private void cmbGrupoNome_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
