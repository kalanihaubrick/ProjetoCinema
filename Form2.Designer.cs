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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            listView1 = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnListar = new Button();
            Assento = new ColumnHeader();
            Status = new ColumnHeader();
            Selecionar = new ColumnHeader();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            BtnComprar = new Button();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnListar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sessões";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(36, 188);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 1;
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
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { Assento, Status, Selecionar });
            listView1.Location = new Point(219, 30);
            listView1.Name = "listView1";
            listView1.Size = new Size(621, 302);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 102);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Data da Sessão";
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
            // BtnListar
            // 
            BtnListar.Location = new Point(55, 232);
            BtnListar.Name = "BtnListar";
            BtnListar.Size = new Size(84, 47);
            BtnListar.TabIndex = 4;
            BtnListar.Text = "Listar assentos";
            BtnListar.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(BtnComprar);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(150, 346);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 158);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Confirmar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 0;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 89);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Data da Sessão:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 31);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Filme:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 89);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 9;
            label7.Text = "Assento";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 49);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 107);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(16, 107);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 31);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 13;
            label6.Text = "Horário da Sessão:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 516);
            Controls.Add(groupBox2);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ListView listView1;
        private ColumnHeader Assento;
        private ColumnHeader Status;
        private ColumnHeader Selecionar;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Button BtnComprar;
        private TextBox textBox1;
    }
}