namespace AmigoOculto.View
{
    partial class HistoricoView
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
            this.dtgDadosH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDadosH
            // 
            this.dtgDadosH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosH.Location = new System.Drawing.Point(16, 15);
            this.dtgDadosH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgDadosH.Name = "dtgDadosH";
            this.dtgDadosH.ReadOnly = true;
            this.dtgDadosH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosH.Size = new System.Drawing.Size(1087, 185);
            this.dtgDadosH.TabIndex = 0;
            this.dtgDadosH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosH_CellContentClick);
            // 
            // HistoricoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 321);
            this.Controls.Add(this.dtgDadosH);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HistoricoView";
            this.Text = "HistoricoView";
            this.Load += new System.EventHandler(this.HistoricoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDadosH;
    }
}