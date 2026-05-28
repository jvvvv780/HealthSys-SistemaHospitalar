namespace HealthSys_SistemaHospitalar
{
    partial class Deletar_Leito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deletar_Leito));
            this.Button_SalvarDeletarLeito = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_SalvarDeletarLeito
            // 
            this.Button_SalvarDeletarLeito.BackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarDeletarLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SalvarDeletarLeito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarDeletarLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_SalvarDeletarLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SalvarDeletarLeito.ForeColor = System.Drawing.Color.Transparent;
            this.Button_SalvarDeletarLeito.Location = new System.Drawing.Point(372, 238);
            this.Button_SalvarDeletarLeito.Name = "Button_SalvarDeletarLeito";
            this.Button_SalvarDeletarLeito.Size = new System.Drawing.Size(170, 35);
            this.Button_SalvarDeletarLeito.TabIndex = 0;
            this.Button_SalvarDeletarLeito.UseVisualStyleBackColor = false;
            this.Button_SalvarDeletarLeito.Click += new System.EventHandler(this.Button_SalvarDeletarLeito_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(195, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(554, 15);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Deletar_Leito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_27_de_mai__de_2026__07_59_56;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_SalvarDeletarLeito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deletar_Leito";
            this.Text = "Deletar Leito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SalvarDeletarLeito;
        private System.Windows.Forms.TextBox textBox1;
    }
}