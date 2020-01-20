namespace AmigoOculto.View
{
    partial class LoginView
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
            this.bttLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.bttSobre = new System.Windows.Forms.Button();
            this.bttAjuda = new System.Windows.Forms.Button();
            this.lblNomeProjeto = new System.Windows.Forms.Label();
            this.bttFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(111, 168);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(75, 23);
            this.bttLogin.TabIndex = 3;
            this.bttLogin.Text = "Login";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(122, 131);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(122, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(73, 105);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(43, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(78, 134);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // bttSobre
            // 
            this.bttSobre.Location = new System.Drawing.Point(199, 243);
            this.bttSobre.Name = "bttSobre";
            this.bttSobre.Size = new System.Drawing.Size(75, 23);
            this.bttSobre.TabIndex = 6;
            this.bttSobre.Text = "Sobre";
            this.bttSobre.UseVisualStyleBackColor = true;
            this.bttSobre.Click += new System.EventHandler(this.bttSobre_Click);
            // 
            // bttAjuda
            // 
            this.bttAjuda.Location = new System.Drawing.Point(199, 214);
            this.bttAjuda.Name = "bttAjuda";
            this.bttAjuda.Size = new System.Drawing.Size(75, 23);
            this.bttAjuda.TabIndex = 5;
            this.bttAjuda.Text = "Ajuda";
            this.bttAjuda.UseVisualStyleBackColor = true;
            this.bttAjuda.Click += new System.EventHandler(this.bttAjuda_Click);
            // 
            // lblNomeProjeto
            // 
            this.lblNomeProjeto.AutoSize = true;
            this.lblNomeProjeto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProjeto.Location = new System.Drawing.Point(37, 44);
            this.lblNomeProjeto.Name = "lblNomeProjeto";
            this.lblNomeProjeto.Size = new System.Drawing.Size(219, 45);
            this.lblNomeProjeto.TabIndex = 7;
            this.lblNomeProjeto.Text = "Amigo Oculto";
            // 
            // bttFechar
            // 
            this.bttFechar.BackColor = System.Drawing.Color.Maroon;
            this.bttFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttFechar.ForeColor = System.Drawing.Color.White;
            this.bttFechar.Location = new System.Drawing.Point(257, 1);
            this.bttFechar.Name = "bttFechar";
            this.bttFechar.Size = new System.Drawing.Size(30, 30);
            this.bttFechar.TabIndex = 8;
            this.bttFechar.Text = "X";
            this.bttFechar.UseVisualStyleBackColor = false;
            this.bttFechar.Click += new System.EventHandler(this.bttFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.bttFechar);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 32);
            this.panel1.TabIndex = 9;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.lblNomeProjeto);
            this.Controls.Add(this.bttAjuda);
            this.Controls.Add(this.bttSobre);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.bttLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginView_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button bttSobre;
        private System.Windows.Forms.Button bttAjuda;
        private System.Windows.Forms.Label lblNomeProjeto;
        private System.Windows.Forms.Button bttFechar;
        private System.Windows.Forms.Panel panel1;
    }
}