namespace Projeto04_AppClientes
{
    partial class FormCadastro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incluirClienteButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.incluirAutomovelButton = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listarAutomoveisButton = new System.Windows.Forms.Button();
            this.automoveisListBox = new System.Windows.Forms.ListBox();
            this.nomesListBox = new System.Windows.Forms.ListBox();
            this.listarClientesButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listarClientesButton);
            this.groupBox1.Controls.Add(this.nomesListBox);
            this.groupBox1.Controls.Add(this.incluirClienteButton);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.documentoTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Clientes";
            // 
            // incluirClienteButton
            // 
            this.incluirClienteButton.Location = new System.Drawing.Point(9, 130);
            this.incluirClienteButton.Name = "incluirClienteButton";
            this.incluirClienteButton.Size = new System.Drawing.Size(141, 23);
            this.incluirClienteButton.TabIndex = 5;
            this.incluirClienteButton.Text = "Incluir Cliente";
            this.incluirClienteButton.UseVisualStyleBackColor = true;
            this.incluirClienteButton.Click += new System.EventHandler(this.incluirClienteButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(77, 104);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(238, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(77, 78);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(238, 20);
            this.telefoneTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(77, 52);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(238, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Location = new System.Drawing.Point(77, 26);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(238, 20);
            this.documentoTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.automoveisListBox);
            this.groupBox2.Controls.Add(this.listarAutomoveisButton);
            this.groupBox2.Controls.Add(this.incluirAutomovelButton);
            this.groupBox2.Controls.Add(this.clienteComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.anoTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.modeloTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.marcaTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastro de Automóveis";
            // 
            // incluirAutomovelButton
            // 
            this.incluirAutomovelButton.Location = new System.Drawing.Point(6, 130);
            this.incluirAutomovelButton.Name = "incluirAutomovelButton";
            this.incluirAutomovelButton.Size = new System.Drawing.Size(141, 23);
            this.incluirAutomovelButton.TabIndex = 10;
            this.incluirAutomovelButton.Text = "Incluir Automóvel";
            this.incluirAutomovelButton.UseVisualStyleBackColor = true;
            this.incluirAutomovelButton.Click += new System.EventHandler(this.incluirAutomovelButton_Click);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(65, 26);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(238, 21);
            this.clienteComboBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cliente:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.Location = new System.Drawing.Point(65, 104);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(238, 20);
            this.anoTextBox.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ano:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(65, 78);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(238, 20);
            this.modeloTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Modelo";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.Location = new System.Drawing.Point(65, 52);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(238, 20);
            this.marcaTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marca:";
            // 
            // listarAutomoveisButton
            // 
            this.listarAutomoveisButton.Location = new System.Drawing.Point(153, 130);
            this.listarAutomoveisButton.Name = "listarAutomoveisButton";
            this.listarAutomoveisButton.Size = new System.Drawing.Size(150, 23);
            this.listarAutomoveisButton.TabIndex = 11;
            this.listarAutomoveisButton.Text = "Listar Automóveis";
            this.listarAutomoveisButton.UseVisualStyleBackColor = true;
            this.listarAutomoveisButton.Click += new System.EventHandler(this.listarAutomoveisButton_Click);
            // 
            // automoveisListBox
            // 
            this.automoveisListBox.FormattingEnabled = true;
            this.automoveisListBox.Location = new System.Drawing.Point(6, 159);
            this.automoveisListBox.Name = "automoveisListBox";
            this.automoveisListBox.Size = new System.Drawing.Size(297, 251);
            this.automoveisListBox.TabIndex = 12;
            // 
            // nomesListBox
            // 
            this.nomesListBox.FormattingEnabled = true;
            this.nomesListBox.Location = new System.Drawing.Point(9, 159);
            this.nomesListBox.Name = "nomesListBox";
            this.nomesListBox.Size = new System.Drawing.Size(297, 251);
            this.nomesListBox.TabIndex = 12;
            // 
            // listarClientesButton
            // 
            this.listarClientesButton.Location = new System.Drawing.Point(156, 130);
            this.listarClientesButton.Name = "listarClientesButton";
            this.listarClientesButton.Size = new System.Drawing.Size(150, 23);
            this.listarClientesButton.TabIndex = 13;
            this.listarClientesButton.Text = "Listar Clientes";
            this.listarClientesButton.UseVisualStyleBackColor = true;
            this.listarClientesButton.Click += new System.EventHandler(this.listarClientesButton_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button incluirClienteButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button incluirAutomovelButton;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox automoveisListBox;
        private System.Windows.Forms.Button listarAutomoveisButton;
        private System.Windows.Forms.ListBox nomesListBox;
        private System.Windows.Forms.Button listarClientesButton;
    }
}

