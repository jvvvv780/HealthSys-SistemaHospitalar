namespace HealthSys_SistemaHospitalar
{
    partial class Tela_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Button_EntrarLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(474, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(474, 284);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Button_EntrarLogin
            // 
            this.Button_EntrarLogin.BackColor = System.Drawing.Color.Transparent;
            this.Button_EntrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_EntrarLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_EntrarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_EntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_EntrarLogin.Location = new System.Drawing.Point(435, 315);
            this.Button_EntrarLogin.Name = "Button_EntrarLogin";
            this.Button_EntrarLogin.Size = new System.Drawing.Size(275, 43);
            this.Button_EntrarLogin.TabIndex = 2;
            this.Button_EntrarLogin.UseVisualStyleBackColor = false;
            this.Button_EntrarLogin.Click += new System.EventHandler(this.Button_EntrarLogin_Click);
            // 
            // Tela_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_22_de_mai__de_2026__22_56_28;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_EntrarLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_Login";
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.Tela_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Button_EntrarLogin;
    }
}

