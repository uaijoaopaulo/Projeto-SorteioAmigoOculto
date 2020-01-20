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
    public partial class SorteioView : Form
    {
        private RepositoryUsuario _RepositoryUsuario = new RepositoryUsuario();
        private RepositoryGrupoUsuario _RepositoryGrupoUsuario = new RepositoryGrupoUsuario();
        private RepositorySorteio _RepositorySorteio = new RepositorySorteio();
        /*private RepositoryUsuario _RepositoryUsuario;
        private RepositoryGrupoUsuario _RepositoryGrupoUsuario;
        private RepositorySorteio _RepositorySorteio;

        public RepositoryGrupoUsuario RepositoryGrupoUsuario
        {
            get
            {
                if (_RepositoryGrupoUsuario == null)
                    _RepositoryGrupoUsuario = new RepositoryGrupoUsuario();
                return _RepositoryGrupoUsuario;
            }
            set
            {
                _RepositoryGrupoUsuario = value;
            }
        }
        public RepositorySorteio RepositorySorteio
        {
            get
            {
                if (_RepositorySorteio == null)
                    _RepositorySorteio = new RepositorySorteio();
                return _RepositorySorteio;
            }
            set
            {
                _RepositorySorteio = value;
            }
        }
        public RepositoryUsuario RepositoryUsuario
        {
            get
            {
                if (_RepositoryUsuario == null)
                    _RepositoryUsuario = new RepositoryUsuario();
                return _RepositoryUsuario;
            }
            set
            {
                _RepositoryUsuario = value;
            }
        }*/
        public SorteioView()
        {
            InitializeComponent();
            dtgDados.DataSource = _RepositorySorteio.GetAll();
        }
        private void bttNovoSorteio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdGrupo.Text))
            {
                MessageBox.Show("Digite o ID do Grupo!");
                txtIdGrupo.Text = "";
                return;
            }
            if (_RepositorySorteio.GetAll().Count() > 0)
            {
                for (int i = 0; i <= (_RepositorySorteio.GetAll().Count() *300); i++)
                {
                    _RepositorySorteio.Delete(i);
                }
                dtgDados.DataSource = _RepositorySorteio.GetAll();
            }
            dtgDados.DataSource = _RepositorySorteio.GetAll();
            for (int i = 0; i<= (_RepositoryUsuario.GetAllU().Count() +10); i++)
            {
                dtgDados.DataSource = _RepositorySorteio.GetAll();
                Grupo_Usuario grupousuario = _RepositoryGrupoUsuario.GetOneIDU(i);//pega o usuario pelo id nos usuario 
                if (grupousuario != null)
                {
                    Random rdn = new Random();
                    int n = rdn.Next(0, (_RepositoryUsuario.GetAllU().Count() + 10));
                    Sorteio sorteio = _RepositorySorteio.GetOneUO(grupousuario.id_Usuario);//ve se ja foi sorteado alguma vez o usuario de origem
                    if(sorteio == null)
                    {
                        sorteio = new Sorteio();
                    }
                    Grupo_Usuario grupousuario2 = _RepositoryGrupoUsuario.GetOneIDU(n);//usuario que foi sorteado
                    Sorteio sorteio2 = _RepositorySorteio.GetOneUD(n);//se ja foi sorteado
                    while(grupousuario2 == null /*se o usuario sorteado existe*/|| grupousuario.id_Usuario == n /*se o sorteado é voce*/
                        || sorteio2 != null /*e a pessoa ja foi sorteada*/  )
                    {
                        n = rdn.Next(0, (_RepositoryUsuario.GetAllU().Count() + 10));
                        grupousuario2 = _RepositoryGrupoUsuario.GetOneIDU(n);
                        sorteio2 = _RepositorySorteio.GetOneUD(n);
                        
                    }
                    sorteio.id_Grupo = int.Parse(txtIdGrupo.Text);
                    sorteio.id_Usuario_Origem = grupousuario.id_Usuario;
                    sorteio.id_Usuario_Destino = grupousuario2.id_Usuario;
                    sorteio.dttCadastro = DateTime.Now;
                    _RepositorySorteio.Salvar(sorteio);
                }
            }
            dtgDados.DataSource = _RepositorySorteio.GetAll();
        }

        private void bttAtualizar_Click(object sender, EventArgs e)
        {
            dtgDados.DataSource = _RepositorySorteio.GetAll();
        }
    }
}
