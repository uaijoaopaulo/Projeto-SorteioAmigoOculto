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
    public partial class LoginView : Form
    {
        private RepositoryUsuario repositoryD = new RepositoryUsuario();
        private RepositoryHistorico repositoryH = new RepositoryHistorico();
        private RepositoryResultado repositoryR = new RepositoryResultado();
        public LoginView()
        {
            InitializeComponent();
            bttFechar.FlatAppearance.BorderSize = 0;
            bttFechar.FlatStyle = FlatStyle.Flat;
        }
        private void LoginView_Load(object sender, EventArgs e)
        {

        }
        private void bttLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("") || txtUser.Text.Equals(""))
            {
                MessageBox.Show("Campos de Usuario e Senha são Obrigatorios!");
                return;
            }
            else
            {
                Usuario usuario = repositoryD.GetOneU(txtUser.Text);
                if(usuario == null)
                {
                    MessageBox.Show("Usuario ou Senha nao encontrado!");
                    txtSenha.Text = "";
                    txtUser.Text = "";
                    return;
                }
                if (txtSenha.Text.Equals(usuario.Password))
                {
                    Historico hist = new Historico();
                    hist.User = usuario.User;
                    hist.Senha = usuario.Password;
                    hist.Nome = usuario.NomeCmp;
                    hist.DataEntrada = DateTime.Now;
                    hist.Administrador = usuario.Administrador;
                    hist.Ativo = true;
                    repositoryH.NovoH(hist);
                    Sorteio sorteio = repositoryR.GetOneR(usuario.Id);
                    if (hist.Administrador == true)
                    {
                        tmsPrincipalScreenView viewR = new tmsPrincipalScreenView();
                        viewR.lblDttRevelacao.Text = sorteio.dttRevelacao.ToString("dd/MM/yyyy");
                        viewR.lblNomeO.Text = hist.Nome;
                        viewR.lblNomeD.Text = "";
                        viewR.lblNomeUsuario.Text = hist.Nome;
                        viewR.tabCadastroUsuario.Enabled = true;
                        viewR.tabGrupo.Enabled = true;
                        viewR.tabGrupoUsuario.Enabled = true;
                        viewR.tabHistorico.Enabled = true;
                        viewR.tabSorteio.Enabled = true;
                        this.Hide();
                        viewR.ShowDialog();
                        viewR = null;
                        Application.Exit();
                    }
                    else if(hist.Administrador == false)
                    {
                        tmsPrincipalScreenView viewR = new tmsPrincipalScreenView();
                        viewR.lblDttRevelacao.Text = sorteio.dttRevelacao.ToString("dd/MM/yyyy");
                        viewR.dtgDados.DataSource = null;
                        viewR.dtgDadosGrupo.DataSource = null;
                        viewR.dtgDadosSorteio.DataSource = null;
                        viewR.dtgGrupoUsuario.DataSource = null;
                        viewR.dtgDadosH.DataSource = null;
                        viewR.lblNomeO.Text = hist.Nome;
                        viewR.lblNomeD.Text = "";
                        viewR.lblNomeUsuario.Text = hist.Nome;
                        viewR.tabCadastroUsuario.Enabled = false;
                        viewR.tabGrupo.Enabled = false;
                        viewR.tabGrupoUsuario.Enabled = false;
                        viewR.tabHistorico.Enabled = false;
                        viewR.tabSorteio.Enabled = false;
                        this.Hide();
                        viewR.ShowDialog();
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha nao conferem");
                    txtSenha.Text = "";
                    txtUser.Text = "";
                    return;
                }
            }
            
        }

        private void bttSobre_Click(object sender, EventArgs e)
        {
            SobreView view = new SobreView();
            view.ShowDialog();
        }

        private void bttAjuda_Click(object sender, EventArgs e)
        {
            AjudaView view = new AjudaView();
            view.ShowDialog();
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
