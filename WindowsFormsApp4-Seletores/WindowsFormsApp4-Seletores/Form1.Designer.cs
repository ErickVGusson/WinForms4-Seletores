namespace WindowsFormsApp4_Seletores
{
    partial class Form1
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
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.radioCelFah = new System.Windows.Forms.RadioButton();
            this.radioCelKel = new System.Windows.Forms.RadioButton();
            this.labelResultado = new System.Windows.Forms.Label();
            this.ckbDesc = new System.Windows.Forms.CheckBox();
            this.ckbAlerta = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinente = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCheckListBox = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(12, 39);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 20);
            this.txbNumero1.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(9, 82);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioCelFah
            // 
            this.radioCelFah.AutoSize = true;
            this.radioCelFah.Location = new System.Drawing.Point(122, 39);
            this.radioCelFah.Name = "radioCelFah";
            this.radioCelFah.Size = new System.Drawing.Size(73, 17);
            this.radioCelFah.TabIndex = 2;
            this.radioCelFah.TabStop = true;
            this.radioCelFah.Text = "ºC para ºF";
            this.radioCelFah.UseVisualStyleBackColor = true;
            // 
            // radioCelKel
            // 
            this.radioCelKel.AutoSize = true;
            this.radioCelKel.Location = new System.Drawing.Point(122, 62);
            this.radioCelKel.Name = "radioCelKel";
            this.radioCelKel.Size = new System.Drawing.Size(70, 17);
            this.radioCelKel.TabIndex = 3;
            this.radioCelKel.TabStop = true;
            this.radioCelKel.Text = "ºC para K";
            this.radioCelKel.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(9, 66);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(55, 13);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "Resultado";
            // 
            // ckbDesc
            // 
            this.ckbDesc.AutoSize = true;
            this.ckbDesc.Location = new System.Drawing.Point(122, 85);
            this.ckbDesc.Name = "ckbDesc";
            this.ckbDesc.Size = new System.Drawing.Size(98, 17);
            this.ckbDesc.TabIndex = 6;
            this.ckbDesc.Text = "Com Descrição";
            this.ckbDesc.UseVisualStyleBackColor = true;
            // 
            // ckbAlerta
            // 
            this.ckbAlerta.AutoSize = true;
            this.ckbAlerta.Location = new System.Drawing.Point(122, 108);
            this.ckbAlerta.Name = "ckbAlerta";
            this.ckbAlerta.Size = new System.Drawing.Size(77, 17);
            this.ckbAlerta.TabIndex = 7;
            this.ckbAlerta.Text = "Com Alerta";
            this.ckbAlerta.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Americano",
            "Europeu",
            "Asiatico",
            "Africano",
            "Oceania",
            "Antartida"});
            this.comboBox1.Location = new System.Drawing.Point(12, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Em que continente eu estou?";
            // 
            // btnContinente
            // 
            this.btnContinente.Location = new System.Drawing.Point(12, 200);
            this.btnContinente.Name = "btnContinente";
            this.btnContinente.Size = new System.Drawing.Size(75, 23);
            this.btnContinente.TabIndex = 10;
            this.btnContinente.Text = "Continente";
            this.btnContinente.UseVisualStyleBackColor = true;
            this.btnContinente.Click += new System.EventHandler(this.btnContinente_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Acordar",
            "Comer",
            "Trabalhar",
            "Banho",
            "Dormir"});
            this.checkedListBox1.Location = new System.Drawing.Point(164, 170);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 79);
            this.checkedListBox1.TabIndex = 11;
            // 
            // btnCheckListBox
            // 
            this.btnCheckListBox.Location = new System.Drawing.Point(164, 255);
            this.btnCheckListBox.Name = "btnCheckListBox";
            this.btnCheckListBox.Size = new System.Drawing.Size(75, 23);
            this.btnCheckListBox.TabIndex = 12;
            this.btnCheckListBox.Text = "Checklistbox";
            this.btnCheckListBox.UseVisualStyleBackColor = true;
            this.btnCheckListBox.Click += new System.EventHandler(this.btnCheckListBox_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 230);
            this.maskedTextBox1.Mask = "(99) 99999-9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.teste2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.testeToolStripMenuItem.Text = "Teste";
            // 
            // teste2ToolStripMenuItem
            // 
            this.teste2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste21ToolStripMenuItem});
            this.teste2ToolStripMenuItem.Name = "teste2ToolStripMenuItem";
            this.teste2ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.teste2ToolStripMenuItem.Text = "teste2";
            // 
            // teste21ToolStripMenuItem
            // 
            this.teste21ToolStripMenuItem.Name = "teste21ToolStripMenuItem";
            this.teste21ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teste21ToolStripMenuItem.Text = "teste2.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 411);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnCheckListBox);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnContinente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ckbAlerta);
            this.Controls.Add(this.ckbDesc);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.radioCelKel);
            this.Controls.Add(this.radioCelFah);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNumero1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton radioCelFah;
        private System.Windows.Forms.RadioButton radioCelKel;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.CheckBox ckbDesc;
        private System.Windows.Forms.CheckBox ckbAlerta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContinente;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnCheckListBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste21ToolStripMenuItem;
    }
}

