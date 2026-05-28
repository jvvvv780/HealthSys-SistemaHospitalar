namespace HealthSys_SistemaHospitalar
{
    partial class Cadastrar_Prontuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Prontuario));
            this.Button_SalvarCadastrarProntuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_SalvarCadastrarProntuario
            // 
            this.Button_SalvarCadastrarProntuario.BackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarProntuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SalvarCadastrarProntuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarProntuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarProntuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SalvarCadastrarProntuario.ForeColor = System.Drawing.Color.Transparent;
            this.Button_SalvarCadastrarProntuario.Location = new System.Drawing.Point(610, 297);
            this.Button_SalvarCadastrarProntuario.Name = "Button_SalvarCadastrarProntuario";
            this.Button_SalvarCadastrarProntuario.Size = new System.Drawing.Size(146, 33);
            this.Button_SalvarCadastrarProntuario.TabIndex = 0;
            this.Button_SalvarCadastrarProntuario.UseVisualStyleBackColor = false;
            this.Button_SalvarCadastrarProntuario.Click += new System.EventHandler(this.Button_SalvarCadastrarProntuario_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(189, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(558, 15);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(705, 226);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 15);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(184, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 15);
            this.textBox3.TabIndex = 3;
            // 
            // Cadastrar_Prontuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_27_de_mai__de_2026__20_23_54;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_SalvarCadastrarProntuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastrar_Prontuario";
            this.Text = "Cadastrar Prontuario";
            this.Load += new System.EventHandler(this.Cadastrar_Prontuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SalvarCadastrarProntuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}