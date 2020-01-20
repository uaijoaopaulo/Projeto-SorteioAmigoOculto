namespace AmigoOculto.View
{
    partial class ResultadoView
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
            this.lblNomeO = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNomeD = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.bttMotrar = new System.Windows.Forms.Button();
            this.lblDttSorteio = new System.Windows.Forms.Label();
            this.bttSair = new System.Windows.Forms.Button();
            this.lblDesOrigem = new System.Windows.Forms.Label();
            this.lblDesDest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomeO
            // 
            this.lblNomeO.AutoSize = true;
            this.lblNomeO.Location = new System.Drawing.Point(12, 154);
            this.lblNomeO.Name = "lblNomeO";
            this.lblNomeO.Size = new System.Drawing.Size(0, 13);
            this.lblNomeO.TabIndex = 0;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(127, 32);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 13);
            this.lblDescricao.TabIndex = 1;
            // 
            // lblNomeD
            // 
            this.lblNomeD.AutoSize = true;
            this.lblNomeD.Location = new System.Drawing.Point(145, 154);
            this.lblNomeD.Name = "lblNomeD";
            this.lblNomeD.Size = new System.Drawing.Size(0, 13);
            this.lblNomeD.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(89, 213);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(103, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data da Revelação:";
            // 
            // bttMotrar
            // 
            this.bttMotrar.Location = new System.Drawing.Point(168, 170);
            this.bttMotrar.Name = "bttMotrar";
            this.bttMotrar.Size = new System.Drawing.Size(75, 23);
            this.bttMotrar.TabIndex = 4;
            this.bttMotrar.Text = "Mostrar";
            this.bttMotrar.UseVisualStyleBackColor = true;
            this.bttMotrar.Click += new System.EventHandler(this.bttMotrar_Click);
            // 
            // lblDttSorteio
            // 
            this.lblDttSorteio.AutoSize = true;
            this.lblDttSorteio.Location = new System.Drawing.Point(100, 236);
            this.lblDttSorteio.Name = "lblDttSorteio";
            this.lblDttSorteio.Size = new System.Drawing.Size(0, 13);
            this.lblDttSorteio.TabIndex = 5;
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(197, 13);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 6;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // lblDesOrigem
            // 
            this.lblDesOrigem.AutoSize = true;
            this.lblDesOrigem.Location = new System.Drawing.Point(12, 129);
            this.lblDesOrigem.Name = "lblDesOrigem";
            this.lblDesOrigem.Size = new System.Drawing.Size(35, 13);
            this.lblDesOrigem.TabIndex = 7;
            this.lblDesOrigem.Text = "Você:";
            // 
            // lblDesDest
            // 
            this.lblDesDest.AutoSize = true;
            this.lblDesDest.Location = new System.Drawing.Point(155, 129);
            this.lblDesDest.Name = "lblDesDest";
            this.lblDesDest.Size = new System.Drawing.Size(54, 13);
            this.lblDesDest.TabIndex = 8;
            this.lblDesDest.Text = "Saiu com:";
            // 
            // ResultadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDesDest);
            this.Controls.Add(this.lblDesOrigem);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.lblDttSorteio);
            this.Controls.Add(this.bttMotrar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeD);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeO);
            this.Name = "ResultadoView";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttMotrar;
        public System.Windows.Forms.Label lblNomeD;
        public System.Windows.Forms.Label lblNomeO;
        public System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.Label lblDttSorteio;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Label lblDesOrigem;
        private System.Windows.Forms.Label lblDesDest;
    }
}