namespace ProjetoCinema
{
    partial class FormCadastro
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
            textCadastro = new TextBox();
            label1 = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // textCadastro
            // 
            textCadastro.Location = new Point(244, 196);
            textCadastro.Name = "textCadastro";
            textCadastro.Size = new Size(280, 23);
            textCadastro.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 141);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite seu nome completo";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(319, 270);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(111, 44);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(label1);
            Controls.Add(textCadastro);
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textCadastro;
        private Label label1;
        private Button btnCadastrar;
    }
}