namespace HealthSys_SistemaHospitalar
{
    partial class Cadastrar_Leito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Leito));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Button_SalvarCadastrarLeito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(185, 184);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(376, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 15);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(575, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 15);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Button_SalvarCadastrarLeito
            // 
            this.Button_SalvarCadastrarLeito.BackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SalvarCadastrarLeito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SalvarCadastrarLeito.ForeColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarLeito.Location = new System.Drawing.Point(655, 239);
            this.Button_SalvarCadastrarLeito.Name = "Button_SalvarCadastrarLeito";
            this.Button_SalvarCadastrarLeito.Size = new System.Drawing.Size(103, 29);
            this.Button_SalvarCadastrarLeito.TabIndex = 3;
            this.Button_SalvarCadastrarLeito.UseVisualStyleBackColor = false;
            this.Button_SalvarCadastrarLeito.Click += new System.EventHandler(this.Button_SalvarCadastrarLeito_Click);
            // 
            // Cadastrar_Leito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_27_de_mai__de_2026__07_41_43;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_SalvarCadastrarLeito);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar_Leito";
            this.Text = "Cadastrar Leito";
            this.Load += new System.EventHandler(this.Cadastrar_Leito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Button_SalvarCadastrarLeito;
    }
}