namespace AmigoOculto.View
{
    partial class CadastroView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.chcAtivo = new System.Windows.Forms.CheckBox();
            this.chcAdm = new System.Windows.Forms.CheckBox();
            this.bttDelete = new System.Windows.Forms.Button();
            this.bttLimpa = new System.Windows.Forms.Button();
            this.bttProcurarID = new System.Windows.Forms.Button();
            this.lblProcurarID = new System.Windows.Forms.Label();
            this.txtProcurarID = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNomecmp = new System.Windows.Forms.Label();
            this.cmbGrupoNome = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new AmigoOculto.DataSet();
            this.grupoTableAdapter = new AmigoOculto.DataSetTableAdapters.GrupoTableAdapter();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbcCadastroUsuario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.tbcCadastroUsuario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(2, 3);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados.Size = new System.Drawing.Size(790, 148);
            this.dtgDados.TabIndex = 0;
            this.dtgDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDados_CellContentClick);
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(7, 173);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 1;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.bttMostrar_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(88, 175);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(194, 175);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(300, 175);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // chcAtivo
            // 
            this.chcAtivo.AutoSize = true;
            this.chcAtivo.Location = new System.Drawing.Point(406, 177);
            this.chcAtivo.Name = "chcAtivo";
            this.chcAtivo.Size = new System.Drawing.Size(50, 17);
            this.chcAtivo.TabIndex = 4;
            this.chcAtivo.Text = "Ativo";
            this.chcAtivo.UseVisualStyleBackColor = true;
            // 
            // chcAdm
            // 
            this.chcAdm.AutoSize = true;
            this.chcAdm.Location = new System.Drawing.Point(462, 177);
            this.chcAdm.Name = "chcAdm";
            this.chcAdm.Size = new System.Drawing.Size(89, 17);
            this.chcAdm.TabIndex = 4;
            this.chcAdm.Text = "Administrador";
            this.chcAdm.UseVisualStyleBackColor = true;
            // 
            // bttDelete
            // 
            this.bttDelete.Location = new System.Drawing.Point(7, 202);
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Size = new System.Drawing.Size(75, 23);
            this.bttDelete.TabIndex = 5;
            this.bttDelete.Text = "Delete";
            this.bttDelete.UseVisualStyleBackColor = true;
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttLimpa
            // 
            this.bttLimpa.Location = new System.Drawing.Point(7, 231);
            this.bttLimpa.Name = "bttLimpa";
            this.bttLimpa.Size = new System.Drawing.Size(75, 23);
            this.bttLimpa.TabIndex = 6;
            this.bttLimpa.Text = "Limpa";
            this.bttLimpa.UseVisualStyleBackColor = true;
            this.bttLimpa.Click += new System.EventHandler(this.bttLimpa_Click);
            // 
            // bttProcurarID
            // 
            this.bttProcurarID.Location = new System.Drawing.Point(717, 231);
            this.bttProcurarID.Name = "bttProcurarID";
            this.bttProcurarID.Size = new System.Drawing.Size(75, 23);
            this.bttProcurarID.TabIndex = 7;
            this.bttProcurarID.Text = "Pesquisar";
            this.bttProcurarID.UseVisualStyleBackColor = true;
            this.bttProcurarID.Click += new System.EventHandler(this.bttProcurarID_Click);
            // 
            // lblProcurarID
            // 
            this.lblProcurarID.AutoSize = true;
            this.lblProcurarID.Location = new System.Drawing.Point(621, 217);
            this.lblProcurarID.Name = "lblProcurarID";
            this.lblProcurarID.Size = new System.Drawing.Size(79, 13);
            this.lblProcurarID.TabIndex = 8;
            this.lblProcurarID.Text = "Procurar por ID";
            // 
            // txtProcurarID
            // 
            this.txtProcurarID.Location = new System.Drawing.Point(611, 233);
            this.txtProcurarID.Name = "txtProcurarID";
            this.txtProcurarID.Size = new System.Drawing.Size(100, 20);
            this.txtProcurarID.TabIndex = 9;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(88, 159);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "Usuario";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(194, 159);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha";
            // 
            // lblNomecmp
            // 
            this.lblNomecmp.AutoSize = true;
            this.lblNomecmp.Location = new System.Drawing.Point(300, 159);
            this.lblNomecmp.Name = "lblNomecmp";
            this.lblNomecmp.Size = new System.Drawing.Size(82, 13);
            this.lblNomecmp.TabIndex = 12;
            this.lblNomecmp.Text = "Nome Completo";
            // 
            // cmbGrupoNome
            // 
            this.cmbGrupoNome.DataSource = this.grupoBindingSource;
            this.cmbGrupoNome.DisplayMember = "Nome";
            this.cmbGrupoNome.FormattingEnabled = true;
            this.cmbGrupoNome.Location = new System.Drawing.Point(558, 173);
            this.cmbGrupoNome.Name = "cmbGrupoNome";
            this.cmbGrupoNome.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoNome.TabIndex = 5;
            this.cmbGrupoNome.ValueMember = "Id";
            this.cmbGrupoNome.SelectedIndexChanged += new System.EventHandler(this.cmbGrupoNome_SelectedIndexChanged);
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "Grupo";
            this.grupoBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataMember = "Grupo_Usuario";
            this.grupoUsuarioBindingSource.DataSource = this.dataSet;
            // 
            // tbcCadastroUsuario
            // 
            this.tbcCadastroUsuario.Controls.Add(this.tabPage1);
            this.tbcCadastroUsuario.Controls.Add(this.tabPage2);
            this.tbcCadastroUsuario.Location = new System.Drawing.Point(3, 0);
            this.tbcCadastroUsuario.Name = "tbcCadastroUsuario";
            this.tbcCadastroUsuario.SelectedIndex = 0;
            this.tbcCadastroUsuario.Size = new System.Drawing.Size(806, 288);
            this.tbcCadastroUsuario.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgDados);
            this.tabPage1.Controls.Add(this.cmbGrupoNome);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lblNomecmp);
            this.tabPage1.Controls.Add(this.bttSalvar);
            this.tabPage1.Controls.Add(this.lblSenha);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.lblUser);
            this.tabPage1.Controls.Add(this.txtSenha);
            this.tabPage1.Controls.Add(this.txtProcurarID);
            this.tabPage1.Controls.Add(this.chcAtivo);
            this.tabPage1.Controls.Add(this.lblProcurarID);
            this.tabPage1.Controls.Add(this.chcAdm);
            this.tabPage1.Controls.Add(this.bttProcurarID);
            this.tabPage1.Controls.Add(this.bttDelete);
            this.tabPage1.Controls.Add(this.bttLimpa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CadastroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 291);
            this.Controls.Add(this.tbcCadastroUsuario);
            this.Name = "CadastroView";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.CadastroView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.tbcCadastroUsuario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox chcAtivo;
        private System.Windows.Forms.CheckBox chcAdm;
        private System.Windows.Forms.Button bttDelete;
        private System.Windows.Forms.Button bttLimpa;
        private System.Windows.Forms.Button bttProcurarID;
        private System.Windows.Forms.Label lblProcurarID;
        private System.Windows.Forms.TextBox txtProcurarID;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNomecmp;
        private System.Windows.Forms.ComboBox cmbGrupoNome;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private DataSetTableAdapters.GrupoTableAdapter grupoTableAdapter;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TabControl tbcCadastroUsuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}