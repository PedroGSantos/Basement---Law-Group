namespace projeto
{
    partial class frm_dadospessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dadospessoais));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_ficha = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MtxtRG = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbocidade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprofissão = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbofem = new System.Windows.Forms.RadioButton();
            this.rbomasc = new System.Windows.Forms.RadioButton();
            this.btn_continuar1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.MtxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MtxtData = new System.Windows.Forms.MaskedTextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto.Properties.Resources.Basement;
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_ficha
            // 
            this.lbl_ficha.AutoSize = true;
            this.lbl_ficha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ficha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ficha.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_ficha.Location = new System.Drawing.Point(12, 12);
            this.lbl_ficha.Name = "lbl_ficha";
            this.lbl_ficha.Size = new System.Drawing.Size(260, 29);
            this.lbl_ficha.TabIndex = 1;
            this.lbl_ficha.Text = "FICHA DE CADASTRO";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_nome.Location = new System.Drawing.Point(12, 71);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(72, 24);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome :";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.Color.Ivory;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.DarkRed;
            this.txtnome.Location = new System.Drawing.Point(111, 71);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(184, 22);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF :";
            // 
            // MtxtCPF
            // 
            this.MtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtCPF.ForeColor = System.Drawing.Color.DarkRed;
            this.MtxtCPF.Location = new System.Drawing.Point(111, 123);
            this.MtxtCPF.Mask = "000.000.000-00";
            this.MtxtCPF.Name = "MtxtCPF";
            this.MtxtCPF.Size = new System.Drawing.Size(104, 22);
            this.MtxtCPF.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "RG :";
            // 
            // MtxtRG
            // 
            this.MtxtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtRG.ForeColor = System.Drawing.Color.DarkRed;
            this.MtxtRG.Location = new System.Drawing.Point(111, 180);
            this.MtxtRG.Mask = "00.000.000-0";
            this.MtxtRG.Name = "MtxtRG";
            this.MtxtRG.Size = new System.Drawing.Size(91, 22);
            this.MtxtRG.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefone :";
            // 
            // MtxtTelefone
            // 
            this.MtxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtTelefone.ForeColor = System.Drawing.Color.DarkRed;
            this.MtxtTelefone.Location = new System.Drawing.Point(111, 228);
            this.MtxtTelefone.Mask = "(00) 0000-0000";
            this.MtxtTelefone.Name = "MtxtTelefone";
            this.MtxtTelefone.Size = new System.Drawing.Size(93, 22);
            this.MtxtTelefone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cidade :";
            // 
            // cbocidade
            // 
            this.cbocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocidade.ForeColor = System.Drawing.Color.DarkRed;
            this.cbocidade.FormattingEnabled = true;
            this.cbocidade.Items.AddRange(new object[] {
            "Santos",
            "São Vicente",
            "Praia Grande",
            "Cubatão",
            "Guarujá",
            "Bertioga",
            "Mongaguá",
            "Peruíbe",
            "Itanhaém"});
            this.cbocidade.Location = new System.Drawing.Point(111, 273);
            this.cbocidade.Name = "cbocidade";
            this.cbocidade.Size = new System.Drawing.Size(121, 24);
            this.cbocidade.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(13, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Profissão :";
            // 
            // txtprofissão
            // 
            this.txtprofissão.BackColor = System.Drawing.Color.Ivory;
            this.txtprofissão.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprofissão.ForeColor = System.Drawing.Color.DarkRed;
            this.txtprofissão.Location = new System.Drawing.Point(111, 319);
            this.txtprofissão.Name = "txtprofissão";
            this.txtprofissão.Size = new System.Drawing.Size(184, 22);
            this.txtprofissão.TabIndex = 13;
            this.txtprofissão.TextChanged += new System.EventHandler(this.txtprofissão_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbofem);
            this.groupBox1.Controls.Add(this.rbomasc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(17, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbofem
            // 
            this.rbofem.AutoSize = true;
            this.rbofem.Location = new System.Drawing.Point(7, 44);
            this.rbofem.Name = "rbofem";
            this.rbofem.Size = new System.Drawing.Size(108, 28);
            this.rbofem.TabIndex = 1;
            this.rbofem.TabStop = true;
            this.rbofem.Text = "Feminino";
            this.rbofem.UseVisualStyleBackColor = true;
            // 
            // rbomasc
            // 
            this.rbomasc.AutoSize = true;
            this.rbomasc.Location = new System.Drawing.Point(6, 22);
            this.rbomasc.Name = "rbomasc";
            this.rbomasc.Size = new System.Drawing.Size(114, 28);
            this.rbomasc.TabIndex = 0;
            this.rbomasc.TabStop = true;
            this.rbomasc.Text = "Masculino";
            this.rbomasc.UseVisualStyleBackColor = true;
            // 
            // btn_continuar1
            // 
            this.btn_continuar1.BackColor = System.Drawing.Color.Ivory;
            this.btn_continuar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar1.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_continuar1.Location = new System.Drawing.Point(446, 376);
            this.btn_continuar1.Name = "btn_continuar1";
            this.btn_continuar1.Size = new System.Drawing.Size(116, 68);
            this.btn_continuar1.TabIndex = 17;
            this.btn_continuar1.Text = "Continuar";
            this.btn_continuar1.UseVisualStyleBackColor = false;
            this.btn_continuar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(13, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "CNPJ:";
            // 
            // MtxtCNPJ
            // 
            this.MtxtCNPJ.ForeColor = System.Drawing.Color.DarkRed;
            this.MtxtCNPJ.Location = new System.Drawing.Point(111, 361);
            this.MtxtCNPJ.Mask = "00.000.000/0000-00";
            this.MtxtCNPJ.Name = "MtxtCNPJ";
            this.MtxtCNPJ.Size = new System.Drawing.Size(105, 20);
            this.MtxtCNPJ.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(12, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data:";
            // 
            // MtxtData
            // 
            this.MtxtData.ForeColor = System.Drawing.Color.DarkRed;
            this.MtxtData.Location = new System.Drawing.Point(111, 399);
            this.MtxtData.Mask = "00/00/0000";
            this.MtxtData.Name = "MtxtData";
            this.MtxtData.Size = new System.Drawing.Size(106, 20);
            this.MtxtData.TabIndex = 21;
            this.MtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Ivory;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvoltar.Location = new System.Drawing.Point(306, 376);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(116, 68);
            this.btnvoltar.TabIndex = 22;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(376, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 68);
            this.button1.TabIndex = 23;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_dadospessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(574, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.MtxtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MtxtCNPJ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_continuar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprofissão);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbocidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MtxtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MtxtRG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MtxtCPF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_ficha);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dadospessoais";
            this.Load += new System.EventHandler(this.frm_dadospessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_ficha;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MtxtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MtxtTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbocidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprofissão;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbofem;
        private System.Windows.Forms.RadioButton rbomasc;
        private System.Windows.Forms.Button btn_continuar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MtxtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MtxtData;
        private System.Windows.Forms.Button btnvoltar;
        public System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
    }
}

