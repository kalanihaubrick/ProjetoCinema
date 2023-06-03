namespace ProjetoCinema
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            ComboData = new ComboBox();
            BtnListar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ComboHora = new ComboBox();
            comboFilme = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ListViewAssentos = new ListView();
            Assento = new ColumnHeader();
            Status = new ColumnHeader();
            Selecionar = new ColumnHeader();
            groupBox2 = new GroupBox();
            label6 = new Label();
            TextConfirmacaoData = new TextBox();
            TextConfirmacaoAssento = new TextBox();
            TextConfirmacaoHora = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            BtnComprar = new Button();
            TextConfirmacaoFilme = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboData);
            groupBox1.Controls.Add(BtnListar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ComboHora);
            groupBox1.Controls.Add(comboFilme);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sessões";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // ComboData
            // 
            ComboData.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboData.Enabled = false;
            ComboData.FormattingEnabled = true;
            ComboData.Location = new Point(7, 131);
            ComboData.Name = "ComboData";
            ComboData.Size = new Size(187, 23);
            ComboData.TabIndex = 5;
            ComboData.SelectedIndexChanged += ComboData_SelectedIndexChanged;
            // 
            // BtnListar
            // 
            BtnListar.Enabled = false;
            BtnListar.Location = new Point(44, 231);
            BtnListar.Name = "BtnListar";
            BtnListar.Size = new Size(113, 47);
            BtnListar.TabIndex = 4;
            BtnListar.Text = "Listar assentos";
            BtnListar.UseVisualStyleBackColor = true;
            BtnListar.Click += BtnListar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 170);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Horário da Sessão:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 102);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Data da Sessão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Filme:";
            // 
            // ComboHora
            // 
            ComboHora.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboHora.Enabled = false;
            ComboHora.FormattingEnabled = true;
            ComboHora.Location = new Point(8, 188);
            ComboHora.Name = "ComboHora";
            ComboHora.Size = new Size(187, 23);
            ComboHora.TabIndex = 1;
            ComboHora.SelectedIndexChanged += ComboHora_SelectedIndexChanged;
            // 
            // comboFilme
            // 
            comboFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFilme.FormattingEnabled = true;
            comboFilme.Location = new Point(8, 55);
            comboFilme.Name = "comboFilme";
            comboFilme.Size = new Size(187, 23);
            comboFilme.TabIndex = 0;
            comboFilme.SelectedIndexChanged += comboFilme_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // ListViewAssentos
            // 
            ListViewAssentos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ListViewAssentos.CheckBoxes = true;
            ListViewAssentos.Columns.AddRange(new ColumnHeader[] { Assento, Status, Selecionar });
            ListViewAssentos.Location = new Point(219, 30);
            ListViewAssentos.Name = "ListViewAssentos";
            ListViewAssentos.Size = new Size(621, 302);
            ListViewAssentos.TabIndex = 3;
            ListViewAssentos.UseCompatibleStateImageBehavior = false;
            // 
            // Assento
            // 
            Assento.Tag = "";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TextConfirmacaoData);
            groupBox2.Controls.Add(TextConfirmacaoAssento);
            groupBox2.Controls.Add(TextConfirmacaoHora);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnComprar);
            groupBox2.Controls.Add(TextConfirmacaoFilme);
            groupBox2.Location = new Point(150, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 158);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Confirmar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 31);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 13;
            label6.Text = "Horário da Sessão:";
            // 
            // TextConfirmacaoData
            // 
            TextConfirmacaoData.Location = new Point(24, 107);
            TextConfirmacaoData.Name = "TextConfirmacaoData";
            TextConfirmacaoData.ReadOnly = true;
            TextConfirmacaoData.Size = new Size(237, 23);
            TextConfirmacaoData.TabIndex = 12;
            // 
            // TextConfirmacaoAssento
            // 
            TextConfirmacaoAssento.Location = new Point(299, 107);
            TextConfirmacaoAssento.Name = "TextConfirmacaoAssento";
            TextConfirmacaoAssento.ReadOnly = true;
            TextConfirmacaoAssento.Size = new Size(165, 23);
            TextConfirmacaoAssento.TabIndex = 11;
            // 
            // TextConfirmacaoHora
            // 
            TextConfirmacaoHora.Location = new Point(299, 49);
            TextConfirmacaoHora.Name = "TextConfirmacaoHora";
            TextConfirmacaoHora.ReadOnly = true;
            TextConfirmacaoHora.Size = new Size(165, 23);
            TextConfirmacaoHora.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 89);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 9;
            label7.Text = "Assento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(118, 31);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Filme:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 89);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Data da Sessão:";
            // 
            // BtnComprar
            // 
            BtnComprar.Location = new Point(478, 67);
            BtnComprar.Name = "BtnComprar";
            BtnComprar.Size = new Size(84, 47);
            BtnComprar.TabIndex = 5;
            BtnComprar.Text = "Comprar";
            BtnComprar.UseVisualStyleBackColor = true;
            // 
            // TextConfirmacaoFilme
            // 
            TextConfirmacaoFilme.Location = new Point(24, 49);
            TextConfirmacaoFilme.Name = "TextConfirmacaoFilme";
            TextConfirmacaoFilme.ReadOnly = true;
            TextConfirmacaoFilme.Size = new Size(237, 23);
            TextConfirmacaoFilme.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 516);
            Controls.Add(groupBox2);
            Controls.Add(ListViewAssentos);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button BtnListar;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox ComboHora;
        private ComboBox comboFilme;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ListView ListViewAssentos;
        private ColumnHeader Assento;
        private ColumnHeader Status;
        private ColumnHeader Selecionar;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox TextConfirmacaoData;
        private TextBox TextConfirmacaoAssento;
        private TextBox TextConfirmacaoHora;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button BtnComprar;
        private TextBox TextConfirmacaoFilme;
        private ComboBox ComboData;
    }
}