namespace AmigoOculto.View
{
    partial class SobreView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreView));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.lblNomeProduto, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblVersao, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lblCompania, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtDescricao, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomeProduto.Location = new System.Drawing.Point(143, 0);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblNomeProduto.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(271, 17);
            this.lblNomeProduto.TabIndex = 19;
            this.lblNomeProduto.Text = "Projeto de Amigo Oculto";
            this.lblNomeProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersao
            // 
            this.lblVersao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersao.Location = new System.Drawing.Point(143, 26);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblVersao.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(271, 17);
            this.lblVersao.TabIndex = 0;
            this.lblVersao.Text = "Versão 0.01";
            this.lblVersao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Location = new System.Drawing.Point(143, 52);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(271, 17);
            this.lblCopyright.TabIndex = 21;
            this.lblCopyright.Text = "Desenvolvedor: uaijoaopaulo©";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompania
            // 
            this.lblCompania.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompania.Location = new System.Drawing.Point(143, 78);
            this.lblCompania.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lblCompania.MaximumSize = new System.Drawing.Size(0, 17);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(271, 17);
            this.lblCompania.TabIndex = 22;
            this.lblCompania.Text = "uaijoaopaulo não é uma compania mas ok";
            this.lblCompania.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Location = new System.Drawing.Point(143, 107);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescricao.Size = new System.Drawing.Size(271, 126);
            this.txtDescricao.TabIndex = 23;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.Text = "Projeto de Amigo Oculto sugerido pelo Professor Gustavo Henrique Dornelas para o " +
    "projeto do Pi, Desenvolvido por João Paulo Bráulio...";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 22);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // SobreView
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SobreView";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button okButton;
    }
}
