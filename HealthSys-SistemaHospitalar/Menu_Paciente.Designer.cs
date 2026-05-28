namespace HealthSys_SistemaHospitalar
{
    partial class Menu_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Paciente));
            this.Button_CadastrarPaciente = new System.Windows.Forms.Button();
            this.Button_ConsultarPaciente = new System.Windows.Forms.Button();
            this.Button_AtualizarPaciente = new System.Windows.Forms.Button();
            this.Button_DeletarPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_CadastrarPaciente
            // 
            this.Button_CadastrarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.Button_CadastrarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CadastrarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_CadastrarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_CadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CadastrarPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.Button_CadastrarPaciente.Location = new System.Drawing.Point(181, 115);
            this.Button_CadastrarPaciente.Name = "Button_CadastrarPaciente";
            this.Button_CadastrarPaciente.Size = new System.Drawing.Size(134, 208);
            this.Button_CadastrarPaciente.TabIndex = 0;
            this.Button_CadastrarPaciente.UseVisualStyleBackColor = false;
            this.Button_CadastrarPaciente.Click += new System.EventHandler(this.Button_CadastrarPaciente_Click);
            // 
            // Button_ConsultarPaciente
            // 
            this.Button_ConsultarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.Button_ConsultarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ConsultarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_ConsultarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_ConsultarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ConsultarPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.Button_ConsultarPaciente.Location = new System.Drawing.Point(334, 115);
            this.Button_ConsultarPaciente.Name = "Button_ConsultarPaciente";
            this.Button_ConsultarPaciente.Size = new System.Drawing.Size(134, 208);
            this.Button_ConsultarPaciente.TabIndex = 1;
            this.Button_ConsultarPaciente.UseVisualStyleBackColor = false;
            this.Button_ConsultarPaciente.Click += new System.EventHandler(this.Button_ConsultarPaciente_Click);
            // 
            // Button_AtualizarPaciente
            // 
            this.Button_AtualizarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.Button_AtualizarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_AtualizarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_AtualizarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_AtualizarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_AtualizarPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.Button_AtualizarPaciente.Location = new System.Drawing.Point(483, 115);
            this.Button_AtualizarPaciente.Name = "Button_AtualizarPaciente";
            this.Button_AtualizarPaciente.Size = new System.Drawing.Size(134, 208);
            this.Button_AtualizarPaciente.TabIndex = 2;
            this.Button_AtualizarPaciente.UseVisualStyleBackColor = false;
            this.Button_AtualizarPaciente.Click += new System.EventHandler(this.Button_AtualizarPaciente_Click);
            // 
            // Button_DeletarPaciente
            // 
            this.Button_DeletarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.Button_DeletarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeletarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button_DeletarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button_DeletarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_DeletarPaciente.ForeColor = System.Drawing.Color.Transparent;
            this.Button_DeletarPaciente.Location = new System.Drawing.Point(638, 115);
            this.Button_DeletarPaciente.Name = "Button_DeletarPaciente";
            this.Button_DeletarPaciente.Size = new System.Drawing.Size(134, 208);
            this.Button_DeletarPaciente.TabIndex = 3;
            this.Button_DeletarPaciente.UseVisualStyleBackColor = false;
            this.Button_DeletarPaciente.Click += new System.EventHandler(this.Button_DeletarPaciente_Click);
            // 
            // Menu_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HealthSys_SistemaHospitalar.Properties.Resources.ChatGPT_Image_25_de_mai__de_2026__20_25_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_DeletarPaciente);
            this.Controls.Add(this.Button_AtualizarPaciente);
            this.Controls.Add(this.Button_ConsultarPaciente);
            this.Controls.Add(this.Button_CadastrarPaciente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Paciente";
            this.Text = "Menu Paciente";
            this.Load += new System.EventHandler(this.Menu_Paciente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_CadastrarPaciente;
        private System.Windows.Forms.Button Button_ConsultarPaciente;
        private System.Windows.Forms.Button Button_AtualizarPaciente;
        private System.Windows.Forms.Button Button_DeletarPaciente;
    }
}