using AmigoOculto.Model;
using AmigoOculto.Repository;
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
    public partial class tmsPrincipalScreenView : Form
    {
        private RepositoryUsuario repositoryUsuario = new RepositoryUsuario();
        private RepositoryHistorico repositoryHist = new RepositoryHistorico();
        private RepositoryResultado repositoryResultado = new RepositoryResultado();
        private RepositoryGrupo repositoryGrupo = new RepositoryGrupo();
        private RepositoryGrupoUsuario repositoryGrupoUsuario = new RepositoryGrupoUsuario();
        private RepositorySorteio repositorySorteio = new RepositorySorteio();
        private DataTable dataO = new DataTable();
        private DataTable dataD = new DataTable();
        decimal numero;
        char letra;
        bool bttMost = false;
        int id = 0;
        int contadorColunasO = 0, contadorColunasD = 0;
        int idteste = 0;
        int RowSelect;


        public void atualizaTudo()
        {
            if (tabSorteio.Enabled == true)
            {
                dtgDadosSorteio.DataSource = repositorySorteio.GetAll();
            }
            if(tabCadastroUsuario.Enabled == true)
            {
                dtgDados.DataSource = repositoryUsuario.GetAllU();
            }
            if (tabGrupo.Enabled == true)
            {
                bttAtualizar_Click(null, null);
            }
            if (tabGrupoUsuario.Enabled == true)
            {
                dtgGrupoUsuario.DataSource = repositoryGrupoUsuario.GetAllU();
            }
            if (tabHistorico.Enabled == true)
            {
                dtgDadosH.DataSource = repositoryHist.GetAllH();
            }
            
        }
        public tmsPrincipalScreenView()
        {
            Historico histor = repositoryHist.GetOneHDT(DateTime.Now);
            InitializeComponent();
            if(histor.Administrador == true)
            {
                tabCadastroUsuario.Enabled = true;
                tabGrupo.Enabled = true;
                tabGrupoUsuario.Enabled = true;
                tabHistorico.Enabled = true;
                tabSorteio.Enabled = true;
                atualizaTudo();
            }
            else
            {
                tabCadastroUsuario.Enabled = false;
                tabGrupo.Enabled = false;
                tabGrupoUsuario.Enabled = false;
                tabHistorico.Enabled = false;
                tabSorteio.Enabled = false;
            }
            bttFechar.FlatAppearance.BorderSize = 0;
            bttFechar.FlatStyle = FlatStyle.Flat;
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Historico hist = repositoryHist.GetOneH(true);
            hist.DataSaida = DateTime.Now;
            hist.Ativo = false;
            repositoryHist.NovoH(hist);
            lblNomeUsuario.Text = "";
            lblNomeD.Text = "";
            LoginView view = new LoginView();
            this.Hide();
            view.ShowDialog();
            this.Close();
            view = null;
        }

        private void bttMotrar_Click(object sender, EventArgs e)
        {
            Historico hist = repositoryHist.GetOneH(true);
            Usuario usuario = repositoryUsuario.GetOneU(hist.User);
            Sorteio sort = repositoryResultado.GetOneR(usuario.Id);
            Usuario usuarioD = repositoryUsuario.GetOneUID(int.Parse(sort.id_Usuario_Destino.ToString()));
            

            if (bttMost == false)
            {
                
                bttMost = true;
                bttMotrar.Text = "Esconder";
               
                lblNomeD.Text = usuarioD.NomeCmp;
                lblDttRevelacao.Text = sort.dttRevelacao.ToString("dd/MM/yyyy");

                
            }
            else
            {
                
                bttMost = false;
                bttMotrar.Text = "Mostrar";
                lblNomeD.Text = "";
                lblDttRevelacao.Text = sort.dttRevelacao.ToString("dd/MM/yyyy");
            }
            atualizaTudo();
        }

        private void tbbResultado_Click(object sender, EventArgs e)
        {

        }
        /****************************INFORMAÇÕES**************************/
        private void bttSobre_Click(object sender, EventArgs e)
        {
            SobreView sobre = new SobreView();
            sobre.ShowDialog();
            sobre = null;
        }

        private void bttAjuda_Click(object sender, EventArgs e)
        {
            AjudaView ajuda = new AjudaView();
            ajuda.ShowDialog();
            ajuda = null;
        }
        /****************************CADASTRO USUARIO**************************/
        private void dtgDados_SelectionChanged(object sender, EventArgs e)
        {
            RowSelect = dtgDados.CurrentCell.RowIndex;
        }
        private void dtgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RowSelect == -1)
            {
                MessageBox.Show("Lista Vazia");
            }
            else
            {
                txtUser.Text = dtgDados.CurrentRow.Cells["User"].Value.ToString();
                txtSenha.Text = dtgDados.CurrentRow.Cells["Password"].Value.ToString();
                txtNome.Text = dtgDados.CurrentRow.Cells["NomeCmp"].Value.ToString();
                id = int.Parse(dtgDados.CurrentRow.Cells["Id"].Value.ToString());
                txtProcurarID.Text = dtgDados.CurrentRow.Cells["Id"].Value.ToString();
                chcAtivo.Checked = bool.Parse(dtgDados.CurrentRow.Cells["Ativo"].Value.ToString());
                chcAdm.Checked = bool.Parse(dtgDados.CurrentRow.Cells["Administrador"].Value.ToString());
            }
        }
        private void bttSalvar_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "" || decimal.TryParse(txtUser.Text,out numero))
            {
                MessageBox.Show("Usuario não é valido!");
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha é Obrigatorio");
                return;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome é Obrigatorio");
                return;
            }
            Usuario usuario = null;
            if (id == 0)
            {
                usuario = new Usuario();
            }
            else
            {
                usuario = repositoryUsuario.GetOneUID(id);
            }
            usuario.User = txtUser.Text;
            usuario.Password = txtSenha.Text;
            usuario.DttCriacao = DateTime.Now;
            usuario.NomeCmp = txtNome.Text;
            usuario.Ativo = chcAtivo.Checked;
            usuario.Administrador = chcAdm.Checked;
            usuario.id_Grupo = int.Parse(cmbGrupoNome.SelectedValue.ToString());
            repositoryUsuario.NovoU(usuario);
            MessageBox.Show("Usuario Criado");

            atualizaTudo();

            Grupo_Usuario gp = repositoryGrupoUsuario.GetOneIDU(usuario.Id);
            if(gp == null)
            {
                gp = new Grupo_Usuario();
            }
            gp.id_Grupo = usuario.id_Grupo;
            gp.id_Usuario = usuario.Id;
            gp.dttCadastro = DateTime.Now;
            repositoryGrupoUsuario.Salvar(gp);

            Grupo grupo = repositoryGrupo.GetOneID(usuario.id_Grupo);
            grupo.QuantidadeUsuario = repositoryGrupoUsuario.GetAllByIdGrupoU(usuario.id_Grupo).Count;
            repositoryGrupo.Salvar(grupo);
            
            bttLimpa_Click(null, null);
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
                    Usuario usuario = repositoryUsuario.GetOneUID(id);
                    Grupo_Usuario gp = repositoryGrupoUsuario.GetOneIDU(id);

                    repositoryUsuario.Delete(usuario.Id);
                    repositoryGrupoUsuario.Delete(gp.Id);

                    Grupo grupo = repositoryGrupo.GetOneID(usuario.id_Grupo);
                    grupo.QuantidadeUsuario = repositoryGrupoUsuario.GetAllByIdGrupoU(usuario.id_Grupo).Count;
                    repositoryGrupo.Salvar(grupo);
                    MessageBox.Show("Usuario Deletado");
                }
                atualizaTudo();
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
            atualizaTudo();
        }

        private void PrincipalScreenView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.dataSet.Grupo);

        }
        private void PrincipalScreenView_Closed(object sender, EventArgs e)
        {
            Historico hist = repositoryHist.GetOneHN(lblNomeUsuario.Text);
            hist.DataSaida = DateTime.Now;
            hist.Ativo = false;
            repositoryHist.NovoH(hist);
            lblNomeUsuario.Text = "";
            lblNomeD.Text = "";
        }
        private void bttProcurarID_Click(object sender, EventArgs e)
        {
            if (txtProcurarID.Text == "" || char.TryParse(txtProcurarID.Text, out letra))
            {
                MessageBox.Show("Id INVALIDO");
                txtProcurarID.Text = "";
                return;
            }
            id = int.Parse(txtProcurarID.Text);

            BindingSource source = new BindingSource();
            source.DataSource = repositoryUsuario.GetOneUID(id);
            dtgDados.DataSource = source;
            
            Usuario usuario = repositoryUsuario.GetOneUID(id);
            chcAdm.Checked = usuario.Administrador;
            chcAtivo.Checked = usuario.Ativo;
            txtNome.Text = usuario.NomeCmp;
            txtUser.Text = usuario.User;
            txtSenha.Text = usuario.Password;
            cmbGrupoNome.DataSource = repositoryGrupo.GetAllU();
        }

        private void bttAtualiza_Click(object sender, EventArgs e)
        {
            atualizaTudo();
        }
        /****************************CADASTRO GRUPO**************************/
        private void bttNovo_Click(object sender, EventArgs e)
        {
            if(txtNomeGrupo.Text == "")
            {
                MessageBox.Show("Nome do Grupo é origatorio");
                return;
            }
            Grupo grupo = new Grupo();
            grupo.Nome = txtNomeGrupo.Text;
            grupo.DttCriacao = DateTime.Now;
            grupo.Ativo = true;
            grupo.QuantidadeUsuario = 0;
            repositoryGrupo.Salvar(grupo);
            txtNomeGrupo.Text = "";
            MessageBox.Show("Grupo Criado");
            atualizaTudo();
        }

        private void bttDeletar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdDelete.Text))
            {
                id = int.Parse(dtgDadosGrupo.CurrentRow.Cells["Id"].Value.ToString());
                txtIdDelete.Text = id.ToString();
            }
            else
            {
                id = int.Parse(txtIdDelete.Text);
            }
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir", " Excluir ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResultCon = MessageBox.Show("Confirmar Exclusao", "Atenção", MessageBoxButtons.OKCancel);
                if (dialogResultCon == DialogResult.OK)
                {
                    repositoryGrupo.Delete(id);
                    txtIdDelete.Text = "";
                    atualizaTudo();
                    id = 0;
                }
                if (dialogResultCon == DialogResult.Cancel)
                {
                    MessageBox.Show("Operação Cancelada");
                    atualizaTudo();
                }
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada");
                atualizaTudo();
            }
        }

        private void bttIdProcurar_Click(object sender, EventArgs e)
        {
            if(txtIdProcurar.Text == "" || char.TryParse(txtIdProcurar.Text, out letra))
            {
                MessageBox.Show("Digite um id de grupo");
                txtIdProcurar.Text = "";
                return;
            }
            Grupo grupo = repositoryGrupo.GetOneID(int.Parse(txtIdProcurar.Text));
            dtgDadosGrupo.DataSource = grupo;
            txtIdDelete.Text = grupo.Id.ToString();
        }

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repositoryGrupo.GetAllU().Count(); i++)
            {
                Grupo grupo = repositoryGrupo.GetOneID(i);
                if (grupo != null)
                {
                    grupo.QuantidadeUsuario = repositoryGrupoUsuario.GetAllByIdGrupoU(i).Count;
                    repositoryGrupo.Salvar(grupo);
                    dtgDadosGrupo.DataSource = repositoryGrupo.GetAllU();
                }
            }
            dtgDadosGrupo.DataSource = repositoryGrupo.GetAllU();
        }
        /****************************CADASTRO SORTEIO**************************/
        private void bttNovoSorteio_Click(object sender, EventArgs e)
        {
            if (txtIdGrupo.Text == "" || char.TryParse(txtIdGrupo.Text,out letra))
            {
                MessageBox.Show("Id Grupo Invalido");
                txtIdGrupo.Text = "";
                return;
            }
            if(dttDataRevelacaoSorteio.Value < DateTime.Now)
            {
                MessageBox.Show("Data nao pode ser no passado");
                return;
            }
            Grupo grupo = repositoryGrupo.GetOneID(int.Parse(txtIdGrupo.Text));
            if(grupo == null)
            {
                MessageBox.Show("ID de Grupo não encontrado!");
                txtIdGrupo.Text = "";
                return;
            }
            if (string.IsNullOrEmpty(txtIdGrupo.Text))
            {
                MessageBox.Show("Digite o ID do Grupo!");
                txtIdGrupo.Text = "";
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir", " Excluir ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (repositorySorteio.GetAll().Count() > 0)
                {
                    DialogResult dialogResultCon = MessageBox.Show(@"Confirmar Exclusao
Essa ação nao podera ser desfeita", "Atenção", MessageBoxButtons.OKCancel);
                    if (dialogResultCon == DialogResult.OK)
                    {
                        for (int i = 0; i <= (repositorySorteio.GetAll().Count() * 300); i++)
                        {
                            repositorySorteio.Delete(i);
                        }
                    }
                    if (dialogResultCon == DialogResult.Cancel)
                    {
                        MessageBox.Show("Operação Cancelada");
                        return;
                    }
                    atualizaTudo();
                }
                atualizaTudo();

                for (int i = 0; i <= (int.Parse(grupo.QuantidadeUsuario.ToString()) * 10); i++)//ERA SORTEIO
                {
                    atualizaTudo();
                    Grupo_Usuario grupousuario = repositoryGrupoUsuario.GetOneIDU(i);//pega o usuario pelo id nos usuario 
                    if (grupousuario != null)
                    {
                        Random rdn = new Random();
                        int n = rdn.Next(0, (repositoryUsuario.GetAllU().Count() * 10));
                        Sorteio sorteio = repositorySorteio.GetOneUO(grupousuario.id_Usuario);//ve se ja foi sorteado alguma vez o usuario de origem
                        if (sorteio == null)
                        {
                            sorteio = new Sorteio();
                        }
                        Grupo_Usuario grupousuario2 = repositoryGrupoUsuario.GetOneIDU(n);//usuario que foi sorteado
                        Sorteio sorteio2 = repositorySorteio.GetOneUD(n);//se ja foi sorteado
                        while (grupousuario2 == null /*se o usuario sorteado existe*/|| grupousuario.id_Usuario == n /*se o sorteado é voce*/
                            || sorteio2 != null /*e a pessoa ja foi sorteada*/  )
                         {
                            n = rdn.Next(0, (repositoryUsuario.GetAllU().Count() * 10));
                            grupousuario2 = repositoryGrupoUsuario.GetOneIDU(n);
                            sorteio2 = repositorySorteio.GetOneUD(n);

                        }
                        sorteio.id_Grupo = int.Parse(txtIdGrupo.Text);
                        sorteio.id_Usuario_Origem = grupousuario.id_Usuario;
                        sorteio.id_Usuario_Destino = grupousuario2.id_Usuario;
                        sorteio.dttCadastro = DateTime.Now;
                        sorteio.dttRevelacao = dttDataRevelacaoSorteio.Value;
                        repositorySorteio.Salvar(sorteio);
                    }
                }
                lblDttRevelacao.Text = dttDataRevelacaoSorteio.Value.ToString("dd/MM/yyyy");
                txtIdGrupo.Text = "";
            }
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada");
            }
            atualizaTudo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizaTudo();
        }
        /****************************HISTORICO**************************/
        private void bttAtualizaHistorico_Click(object sender, EventArgs e)
        {
            atualizaTudo();
        }
        /****************************Altera USUARIO TESTE**************************/
        private void bttAlterarUsuario_Click(object sender, EventArgs e)
        {
            if(RowSelect == -1)
            {
                MessageBox.Show("Não Tem Dados Selecionados");
            }
            else
            {
                dtgDados_CellDoubleClick(sender, null);
            }
        }

        private void bttDeleteHistorico_Click(object sender, EventArgs e)
        {
            if(TxtIdDeleteHistorico.Text == "" || char.TryParse(txtIdRevelador.Text, out letra))
            {
                MessageBox.Show("Id nao Digitado Ou Invalido");
                TxtIdDeleteHistorico.Text = "";
                return;
            }
            repositoryHist.Delete(int.Parse(TxtIdDeleteHistorico.Text));
            TxtIdDeleteHistorico.Text = "";
            atualizaTudo();
        }
        /****************************Revela Amigo Oculto**************************/
        private void bttRevela_Click(object sender, EventArgs e)
        {
            if(dtgRevelacaoDestino.Rows.Count >= dtgDadosSorteio.Rows.Count)
            {
                MessageBox.Show("Não há mais Usuarios");
                return;
            }
            Sorteio usuarioSorteioOrigem;
            if (contadorColunasD <= 0)
            {
                usuarioSorteioOrigem = repositorySorteio.GetOneUO(int.Parse(txtIdRevelador.Text));
                dataD.Columns.Add();
                contadorColunasD = 1;
            }
            else
            {
                usuarioSorteioOrigem = repositorySorteio.GetOneUO(idteste);
            }
            
            Usuario usuarioSorteioDestino = repositoryUsuario.GetOneUID(int.Parse(usuarioSorteioOrigem.id_Usuario_Destino.ToString()));
            
            dataD.Rows.Add(usuarioSorteioDestino.NomeCmp);
            dtgRevelacaoDestino.DataSource = dataD;
            dtgRevelacaoDestino.Columns[0].HeaderText = "Destino";
            if (dtgRevelacaoDestino.Rows.Count < dtgDadosSorteio.Rows.Count)
            {
                dataO.Rows.Add(usuarioSorteioDestino.NomeCmp);
                dtgRevelacaoOrigem.DataSource = dataO;
            }

            Sorteio usuarioSorteioRevelador = repositorySorteio.GetOneUO(usuarioSorteioDestino.Id);
            idteste = usuarioSorteioRevelador.id_Usuario_Origem;
        }

        private void bttLimpagrid_Click(object sender, EventArgs e)
        {
            dtgRevelacaoDestino.DataSource = null;
            dtgRevelacaoOrigem.DataSource = null;
            dataO = new DataTable();
            dataD = new DataTable();
            contadorColunasD = 0;
            contadorColunasO = 0;
            dataO.Columns.Add();
            txtIdRevelador.Text = "";
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            Historico hist = repositoryHist.GetOneH(true);
            hist.DataSaida = DateTime.Now;
            hist.Ativo = false;
            repositoryHist.NovoH(hist);
            lblNomeUsuario.Text = "";
            lblNomeD.Text = "";
            this.Hide();
            this.Close();
        }

        private void txtIdRevelador_TextChanged(object sender, EventArgs e)
        {
            if (txtIdRevelador.Text == "" )
            {
                txtIdRevelador.Enabled = true;
            }
            else
            {
                dataO.Columns.Add();
                Usuario usuarioRevelar = repositoryUsuario.GetOneUID(int.Parse(txtIdRevelador.Text));
                txtIdRevelador.Enabled = false;
                dataO.Rows.Add(usuarioRevelar.NomeCmp);
                dtgRevelacaoOrigem.DataSource = dataO;
                dtgRevelacaoOrigem.Columns[0].HeaderText = "Origem";
            }
        }
    }
}
