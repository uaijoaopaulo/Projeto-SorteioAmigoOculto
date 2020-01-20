namespace AmigoOculto
{
    partial class PrincipalView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroUsuarioToolStripMenuItem,
            this.historicoToolStripMenuItem,
            this.usuarioGrupoToolStripMenuItem,
            this.grupoToolStripMenuItem,
            this.sorteioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            this.cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            this.cadastroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cadastroUsuarioToolStripMenuItem.Text = "Cadastro Usuario";
            this.cadastroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuarioToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // usuarioGrupoToolStripMenuItem
            // 
            this.usuarioGrupoToolStripMenuItem.Name = "usuarioGrupoToolStripMenuItem";
            this.usuarioGrupoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.usuarioGrupoToolStripMenuItem.Text = "Usuario_Grupo";
            this.usuarioGrupoToolStripMenuItem.Click += new System.EventHandler(this.usuarioGrupoToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // sorteioToolStripMenuItem
            // 
            this.sorteioToolStripMenuItem.Name = "sorteioToolStripMenuItem";
            this.sorteioToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sorteioToolStripMenuItem.Text = "Sorteio";
            this.sorteioToolStripMenuItem.Click += new System.EventHandler(this.sorteioToolStripMenuItem_Click);
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(13, 226);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 1;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(94, 231);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 2;
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 274);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalView";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuarioToolStripMenuItem;
        private System.Windows.Forms.Button bttSair;
        public System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteioToolStripMenuItem;
    }
}

