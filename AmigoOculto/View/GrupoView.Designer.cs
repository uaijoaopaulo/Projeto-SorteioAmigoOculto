namespace AmigoOculto.View
{
    partial class GrupoView
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
            this.dtgDadosGrupo = new System.Windows.Forms.DataGridView();
            this.bttAtualizar = new System.Windows.Forms.Button();
            this.bttNovo = new System.Windows.Forms.Button();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.bttDeletar = new System.Windows.Forms.Button();
            this.txtIdDelete = new System.Windows.Forms.TextBox();
            this.lblIdDelete = new System.Windows.Forms.Label();
            this.lblIdProcurar = new System.Windows.Forms.Label();
            this.txtIdProcurar = new System.Windows.Forms.TextBox();
            this.bttIdProcurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosGrupo
            // 
            this.dtgDadosGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosGrupo.Location = new System.Drawing.Point(12, 12);
            this.dtgDadosGrupo.Name = "dtgDadosGrupo";
            this.dtgDadosGrupo.ReadOnly = true;
            this.dtgDadosGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosGrupo.Size = new System.Drawing.Size(806, 150);
            this.dtgDadosGrupo.TabIndex = 0;
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(743, 168);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 1;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            this.bttAtualizar.Click += new System.EventHandler(this.bttAtualizar_Click);
            // 
            // bttNovo
            // 
            this.bttNovo.Location = new System.Drawing.Point(12, 182);
            this.bttNovo.Name = "bttNovo";
            this.bttNovo.Size = new System.Drawing.Size(75, 23);
            this.bttNovo.TabIndex = 2;
            this.bttNovo.Text = "Novo Grupo";
            this.bttNovo.UseVisualStyleBackColor = true;
            this.bttNovo.Click += new System.EventHandler(this.bttNovo_Click);
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(93, 184);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(116, 20);
            this.txtNomeGrupo.TabIndex = 3;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(93, 168);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(114, 13);
            this.lblNomeGrupo.TabIndex = 4;
            this.lblNomeGrupo.Text = "Nome do Novo Grupo:";
            // 
            // bttDeletar
            // 
            this.bttDeletar.Location = new System.Drawing.Point(12, 230);
            this.bttDeletar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttDeletar.Name = "bttDeletar";
            this.bttDeletar.Size = new System.Drawing.Size(75, 20);
            this.bttDeletar.TabIndex = 5;
            this.bttDeletar.Text = "Deletar";
            this.bttDeletar.UseVisualStyleBackColor = true;
            this.bttDeletar.Click += new System.EventHandler(this.bttDeletar_Click);
            // 
            // txtIdDelete
            // 
            this.txtIdDelete.Location = new System.Drawing.Point(93, 230);
            this.txtIdDelete.Name = "txtIdDelete";
            this.txtIdDelete.Size = new System.Drawing.Size(116, 20);
            this.txtIdDelete.TabIndex = 6;
            // 
            // lblIdDelete
            // 
            this.lblIdDelete.AutoSize = true;
            this.lblIdDelete.Location = new System.Drawing.Point(96, 211);
            this.lblIdDelete.Name = "lblIdDelete";
            this.lblIdDelete.Size = new System.Drawing.Size(19, 13);
            this.lblIdDelete.TabIndex = 7;
            this.lblIdDelete.Text = "Id:";
            // 
            // lblIdProcurar
            // 
            this.lblIdProcurar.AutoSize = true;
            this.lblIdProcurar.Location = new System.Drawing.Point(429, 211);
            this.lblIdProcurar.Name = "lblIdProcurar";
            this.lblIdProcurar.Size = new System.Drawing.Size(19, 13);
            this.lblIdProcurar.TabIndex = 8;
            this.lblIdProcurar.Text = "Id:";
            // 
            // txtIdProcurar
            // 
            this.txtIdProcurar.Location = new System.Drawing.Point(432, 230);
            this.txtIdProcurar.Name = "txtIdProcurar";
            this.txtIdProcurar.Size = new System.Drawing.Size(100, 20);
            this.txtIdProcurar.TabIndex = 9;
            // 
            // bttIdProcurar
            // 
            this.bttIdProcurar.Location = new System.Drawing.Point(351, 228);
            this.bttIdProcurar.Name = "bttIdProcurar";
            this.bttIdProcurar.Size = new System.Drawing.Size(75, 23);
            this.bttIdProcurar.TabIndex = 10;
            this.bttIdProcurar.Text = "Procurar:";
            this.bttIdProcurar.UseVisualStyleBackColor = true;
            this.bttIdProcurar.Click += new System.EventHandler(this.bttIdProcurar_Click);
            // 
            // GrupoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 261);
            this.Controls.Add(this.bttIdProcurar);
            this.Controls.Add(this.txtIdProcurar);
            this.Controls.Add(this.lblIdProcurar);
            this.Controls.Add(this.lblIdDelete);
            this.Controls.Add(this.txtIdDelete);
            this.Controls.Add(this.bttDeletar);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.bttNovo);
            this.Controls.Add(this.bttAtualizar);
            this.Controls.Add(this.dtgDadosGrupo);
            this.Name = "GrupoView";
            this.Text = "GrupoView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosGrupo;
        private System.Windows.Forms.Button bttAtualizar;
        private System.Windows.Forms.Button bttNovo;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Button bttDeletar;
        private System.Windows.Forms.TextBox txtIdDelete;
        private System.Windows.Forms.Label lblIdDelete;
        private System.Windows.Forms.Label lblIdProcurar;
        private System.Windows.Forms.TextBox txtIdProcurar;
        private System.Windows.Forms.Button bttIdProcurar;
    }
}