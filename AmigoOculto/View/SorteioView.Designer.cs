namespace AmigoOculto.View
{
    partial class SorteioView
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
            this.bttNovoSorteio = new System.Windows.Forms.Button();
            this.txtIdGrupo = new System.Windows.Forms.TextBox();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.bttAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // bttNovoSorteio
            // 
            this.bttNovoSorteio.Location = new System.Drawing.Point(11, 214);
            this.bttNovoSorteio.Margin = new System.Windows.Forms.Padding(2);
            this.bttNovoSorteio.Name = "bttNovoSorteio";
            this.bttNovoSorteio.Size = new System.Drawing.Size(86, 19);
            this.bttNovoSorteio.TabIndex = 0;
            this.bttNovoSorteio.Text = "Novo Sorteio";
            this.bttNovoSorteio.UseVisualStyleBackColor = true;
            this.bttNovoSorteio.Click += new System.EventHandler(this.bttNovoSorteio_Click);
            // 
            // txtIdGrupo
            // 
            this.txtIdGrupo.Location = new System.Drawing.Point(13, 189);
            this.txtIdGrupo.Name = "txtIdGrupo";
            this.txtIdGrupo.Size = new System.Drawing.Size(100, 20);
            this.txtIdGrupo.TabIndex = 1;
            // 
            // dtgDados
            // 
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(11, 12);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.ReadOnly = true;
            this.dtgDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDados.Size = new System.Drawing.Size(698, 150);
            this.dtgDados.TabIndex = 2;
            // 
            // bttAtualizar
            // 
            this.bttAtualizar.Location = new System.Drawing.Point(634, 209);
            this.bttAtualizar.Name = "bttAtualizar";
            this.bttAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bttAtualizar.TabIndex = 3;
            this.bttAtualizar.Text = "Atualizar";
            this.bttAtualizar.UseVisualStyleBackColor = true;
            this.bttAtualizar.Click += new System.EventHandler(this.bttAtualizar_Click);
            // 
            // SorteioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 244);
            this.Controls.Add(this.bttAtualizar);
            this.Controls.Add(this.dtgDados);
            this.Controls.Add(this.txtIdGrupo);
            this.Controls.Add(this.bttNovoSorteio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SorteioView";
            this.Text = "SorteioView";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttNovoSorteio;
        private System.Windows.Forms.TextBox txtIdGrupo;
        private System.Windows.Forms.DataGridView dtgDados;
        private System.Windows.Forms.Button bttAtualizar;
    }
}