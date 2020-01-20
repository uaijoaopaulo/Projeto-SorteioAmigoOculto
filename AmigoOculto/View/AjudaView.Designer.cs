namespace AmigoOculto.View
{
    partial class AjudaView
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
            this.txtAjuda = new System.Windows.Forms.TextBox();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.bttOkay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttFechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAjuda
            // 
            this.txtAjuda.Location = new System.Drawing.Point(4, 135);
            this.txtAjuda.Multiline = true;
            this.txtAjuda.Name = "txtAjuda";
            this.txtAjuda.ReadOnly = true;
            this.txtAjuda.Size = new System.Drawing.Size(277, 115);
            this.txtAjuda.TabIndex = 1;
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.Location = new System.Drawing.Point(28, 77);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(106, 13);
            this.lblNomeProjeto.TabIndex = 2;
            this.lblNomeProjeto.Text = "Projeto Amigo Oculto";
            // 
            // bttOkay
            // 
            this.bttOkay.Location = new System.Drawing.Point(206, 254);
            this.bttOkay.Name = "bttOkay";
            this.bttOkay.Size = new System.Drawing.Size(75, 23);
            this.bttOkay.TabIndex = 0;
            this.bttOkay.Text = "Ok";
            this.bttOkay.UseVisualStyleBackColor = true;
            this.bttOkay.Click += new System.EventHandler(this.bttOkay_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.bttFechar);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 42);
            this.panel1.TabIndex = 3;
            // 
            // bttFechar
            // 
            this.bttFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFechar.ForeColor = System.Drawing.Color.White;
            this.bttFechar.Location = new System.Drawing.Point(254, 6);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(34, 34);
            this.bttFechar.TabIndex = 0;
            this.bttFechar.Text = "X";
            this.bttFechar.UseVisualStyleBackColor = false;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // AjudaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttOkay);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.txtAjuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjudaView";
            this.Text = "AjudaView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAjuda;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Button bttOkay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttFechar;
    }
}