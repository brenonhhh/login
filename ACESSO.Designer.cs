namespace ACESSO
{
    partial class ACESSO
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.ckbEsqci = new System.Windows.Forms.CheckBox();
            this.gbxlogin = new System.Windows.Forms.GroupBox();
            this.gbxlogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "ENTRAR";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(163, 43);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(186, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(163, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(186, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Snow;
            this.btnOk.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(211, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(156, 47);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ACESSAR";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // ckbEsqci
            // 
            this.ckbEsqci.AutoSize = true;
            this.ckbEsqci.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEsqci.Location = new System.Drawing.Point(330, 154);
            this.ckbEsqci.Name = "ckbEsqci";
            this.ckbEsqci.Size = new System.Drawing.Size(135, 18);
            this.ckbEsqci.TabIndex = 6;
            this.ckbEsqci.Text = "esqueci minha senha";
            this.ckbEsqci.UseVisualStyleBackColor = true;
            // 
            // gbxlogin
            // 
            this.gbxlogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxlogin.Controls.Add(this.txtSenha);
            this.gbxlogin.Controls.Add(this.ckbEsqci);
            this.gbxlogin.Controls.Add(this.txtLogin);
            this.gbxlogin.Controls.Add(this.label1);
            this.gbxlogin.Controls.Add(this.label2);
            this.gbxlogin.Location = new System.Drawing.Point(48, 40);
            this.gbxlogin.Name = "gbxlogin";
            this.gbxlogin.Size = new System.Drawing.Size(532, 219);
            this.gbxlogin.TabIndex = 7;
            this.gbxlogin.TabStop = false;
            // 
            // ACESSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 395);
            this.Controls.Add(this.gbxlogin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Name = "ACESSO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxlogin.ResumeLayout(false);
            this.gbxlogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox ckbEsqci;
        private System.Windows.Forms.GroupBox gbxlogin;
    }
}

