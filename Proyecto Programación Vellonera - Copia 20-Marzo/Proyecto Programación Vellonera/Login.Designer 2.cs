namespace Proyecto_Programación_Vellonera
{
    partial class Login
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
            this.NameUser = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameUser
            // 
            this.NameUser.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameUser.Location = new System.Drawing.Point(223, 132);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(277, 36);
            this.NameUser.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(223, 206);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(277, 36);
            this.Password.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblusuario.Location = new System.Drawing.Point(67, 139);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(127, 29);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "USUARIO";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblpass.Location = new System.Drawing.Point(35, 213);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(159, 29);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "PASSWORD";
            // 
            // btninicio
            // 
            this.btninicio.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btninicio.Location = new System.Drawing.Point(331, 274);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(123, 41);
            this.btninicio.TabIndex = 4;
            this.btninicio.Text = "INICIAR ";
            this.btninicio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "VELLONERA";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NameUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameUser;
        private TextBox Password;
        private Label lblusuario;
        private Label lblpass;
        private Button btninicio;
        private Label label1;
    }
}