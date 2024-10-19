namespace PowerHub
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenharegistro = new System.Windows.Forms.TextBox();
            this.lblrepetirsenha = new System.Windows.Forms.Label();
            this.txtrepetirsenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkboxmostrarsenharegistro = new System.Windows.Forms.CheckBox();
            this.lblVoltarLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(114, 237);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(315, 26);
            this.txtnome.TabIndex = 0;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(237, 214);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(48, 18);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome";
            this.lblnome.Click += new System.EventHandler(this.txtemail_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(232, 282);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 18);
            this.lblemail.TabIndex = 4;
            this.lblemail.Text = "Email";
            this.lblemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(114, 305);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(315, 26);
            this.txtemail.TabIndex = 3;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(231, 349);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(58, 18);
            this.lblsenha.TabIndex = 6;
            this.lblsenha.Text = "Senha";
            this.lblsenha.Click += new System.EventHandler(this.lblsenha_Click);
            // 
            // txtsenharegistro
            // 
            this.txtsenharegistro.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenharegistro.Location = new System.Drawing.Point(114, 372);
            this.txtsenharegistro.Name = "txtsenharegistro";
            this.txtsenharegistro.Size = new System.Drawing.Size(315, 26);
            this.txtsenharegistro.TabIndex = 5;
            this.txtsenharegistro.UseSystemPasswordChar = true;
            this.txtsenharegistro.TextChanged += new System.EventHandler(this.txtsenharegistro_TextChanged);
            // 
            // lblrepetirsenha
            // 
            this.lblrepetirsenha.AutoSize = true;
            this.lblrepetirsenha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrepetirsenha.Location = new System.Drawing.Point(195, 416);
            this.lblrepetirsenha.Name = "lblrepetirsenha";
            this.lblrepetirsenha.Size = new System.Drawing.Size(138, 18);
            this.lblrepetirsenha.TabIndex = 8;
            this.lblrepetirsenha.Text = "Repetir Senha";
            this.lblrepetirsenha.Click += new System.EventHandler(this.lblrepetirsenha_Click);
            // 
            // txtrepetirsenha
            // 
            this.txtrepetirsenha.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepetirsenha.Location = new System.Drawing.Point(114, 441);
            this.txtrepetirsenha.Name = "txtrepetirsenha";
            this.txtrepetirsenha.Size = new System.Drawing.Size(315, 26);
            this.txtrepetirsenha.TabIndex = 7;
            this.txtrepetirsenha.UseSystemPasswordChar = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCadastrar.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(114, 498);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(315, 45);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Finalizar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // checkboxmostrarsenharegistro
            // 
            this.checkboxmostrarsenharegistro.AutoSize = true;
            this.checkboxmostrarsenharegistro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxmostrarsenharegistro.Location = new System.Drawing.Point(312, 471);
            this.checkboxmostrarsenharegistro.Name = "checkboxmostrarsenharegistro";
            this.checkboxmostrarsenharegistro.Size = new System.Drawing.Size(117, 18);
            this.checkboxmostrarsenharegistro.TabIndex = 10;
            this.checkboxmostrarsenharegistro.Text = "Mostrar Senha";
            this.checkboxmostrarsenharegistro.UseVisualStyleBackColor = true;
            this.checkboxmostrarsenharegistro.CheckedChanged += new System.EventHandler(this.checkboxmostrarsenha_CheckedChanged);
            // 
            // lblVoltarLogin
            // 
            this.lblVoltarLogin.AutoSize = true;
            this.lblVoltarLogin.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltarLogin.ForeColor = System.Drawing.Color.Red;
            this.lblVoltarLogin.Location = new System.Drawing.Point(188, 560);
            this.lblVoltarLogin.Name = "lblVoltarLogin";
            this.lblVoltarLogin.Size = new System.Drawing.Size(158, 18);
            this.lblVoltarLogin.TabIndex = 11;
            this.lblVoltarLogin.Text = "Voltar ao Login";
            this.lblVoltarLogin.Click += new System.EventHandler(this.lblVoltarLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.checkboxmostrarsenharegistro);
            this.panel1.Controls.Add(this.lblVoltarLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnome);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.lblrepetirsenha);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtrepetirsenha);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblsenha);
            this.panel1.Controls.Add(this.txtsenharegistro);
            this.panel1.Location = new System.Drawing.Point(419, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 609);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1317, 788);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Hub Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenharegistro;
        private System.Windows.Forms.Label lblrepetirsenha;
        private System.Windows.Forms.TextBox txtrepetirsenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkboxmostrarsenharegistro;
        private System.Windows.Forms.Label lblVoltarLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}