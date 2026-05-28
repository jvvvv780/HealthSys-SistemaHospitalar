namespace HealthSys_SistemaHospitalar
{
    partial class Deletar_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deletar_Paciente));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_ExcluirPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(193, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Button_ExcluirPaciente
            // 
            this.Button_ExcluirPaciente.BackColor = System.Drawing.Color.Transparent;
            this.Button_ExcluirPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ExcluirPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ExcluirPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ExcluirPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ExcluirPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.Button_ExcluirPaciente.Location = new System.Drawing.Point(375, 237);
            this.Button_ExcluirPaciente.Name = "Button_ExcluirPaciente";
            this.Button_ExcluirPaciente.Size = new System.Drawing.Size(168, 34);
            this.Button_ExcluirPaciente.TabIndex = 1;
            this.Button_ExcluirPaciente.UseVisualStyleBackColor = false;
            this.Button_ExcluirPaciente.Click += new System.EventHandler(this.Button_ExcluirPaciente_Click);
            // 
            // Deletar_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_26_de_mai__de_2026__22_25_41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_ExcluirPaciente);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deletar_Paciente";
            this.Text = "Deletar Paciente";
            this.Load += new System.EventHandler(this.Deletar_Paciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_ExcluirPaciente;
    }
}