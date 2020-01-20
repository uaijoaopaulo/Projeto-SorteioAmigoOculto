namespace AmigoOculto.View
{
    partial class Grupo_UsuarioView
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
            this.dtgGrupoUsuario = new System.Windows.Forms.DataGridView();
            this.bttAtualiza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGrupoUsuario
            // 
            this.dtgGrupoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGrupoUsuario.Location = new System.Drawing.Point(16, 15);
            this.dtgGrupoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgGrupoUsuario.Name = "dtgGrupoUsuario";
            this.dtgGrupoUsuario.ReadOnly = true;
            this.dtgGrupoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgGrupoUsuario.Size = new System.Drawing.Size(896, 185);
            this.dtgGrupoUsuario.TabIndex = 0;
            this.dtgGrupoUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bttAtualiza
            // 
            this.bttAtualiza.Location = new System.Drawing.Point(16, 207);
            this.bttAtualiza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttAtualiza.Name = "bttAtualiza";
            this.bttAtualiza.Size = new System.Drawing.Size(100, 28);
            this.bttAtualiza.TabIndex = 1;
            this.bttAtualiza.Text = "Atualiza";
            this.bttAtualiza.UseVisualStyleBackColor = true;
            this.bttAtualiza.Click += new System.EventHandler(this.bttAtualiza_Click);
            // 
            // Grupo_UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 321);
            this.Controls.Add(this.bttAtualiza);
            this.Controls.Add(this.dtgGrupoUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Grupo_UsuarioView";
            this.Text = "Grupo_UsuarioView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgGrupoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGrupoUsuario;
        private System.Windows.Forms.Button bttAtualiza;
    }
}