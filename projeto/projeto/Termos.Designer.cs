namespace projeto
{
    partial class frm_termos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_termos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtrelato = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chbtermos = new System.Windows.Forms.CheckBox();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escreva um relato resumido dos fatos que o levaram \r\na buscar um de nossos advoga" +
    "dos ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtrelato
            // 
            this.txtrelato.ForeColor = System.Drawing.Color.DarkRed;
            this.txtrelato.Location = new System.Drawing.Point(308, 74);
            this.txtrelato.Name = "txtrelato";
            this.txtrelato.Size = new System.Drawing.Size(300, 20);
            this.txtrelato.TabIndex = 1;
            this.txtrelato.TextChanged += new System.EventHandler(this.txtrelato_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Pelo presente instrumento particular de contrato, um(a) advogado(a), contratado(a" +
                ") pela empresa de caráter privado Basement Law Group, inscrito(a) na OAB, com ",
            "escritório profissional à Avenida Ana Costa nª 370, Gonzaga, Santos - SP, doravan" +
                "te denominada “Contratado” (independente de gênero e número), convenciona, ",
            "neste ato representada doravante denominada “Contratante” (independente de gênero" +
                " e número) o seguinte:",
            "",
            "Cláusula 1ª. O Contratado compromete-se com o presente termo a prestar Assessoria" +
                " Jurídica a Contratante no tocante ao ajuizamento e acompanhamento ",
            "até a segunda instância.",
            "",
            "Cláusula 2ª.  Fica estabelecido que o valor fixado ou arbitrado judicialmente, a " +
                "título de honorários de sucumbência porventura existentes, pertencerão,",
            "por direito, ao Contratado, de acordo com o estabelecido na lei nº 8.906, de 4 de" +
                " julho de 1994, em seus arts. 22 e 23.",
            "Cláusula 3ª. Quando os honorários forem contratados para pagamentos futuros, são " +
                "estabelecidas as seguintes condições:",
            "",
            "§ 1º. Quando pactuados honorários mínimos ou parcelados, para pagamento futuro e " +
                "ainda indeterminado, ou dependente de condição, este valor será",
            "atualizado monetariamente, a partir da data da assinatura do contrato, até o efet" +
                "ivo pagamento ou início de pagamento, pelo índice INPC.",
            "",
            "",
            "§ 2º. Sempre que houver falta de pagamento dos honorários dentro dos prazos pactu" +
                "ados, sejam integrais ou parcelados, fica acordada a aplicação de ",
            "multa contratual de 20% (vinte por cento), juros de mora de 1% ao mês e atualizaç" +
                "ão monetária pelo índice INPC.",
            "",
            "Cláusula 4ª. Fica o Contratado autorizado desde já a fazer a retenção de seus hon" +
                "orários quando do recebimento de valores devidos ao Contratante, advindos ",
            "de êxito da demanda, ainda que parcial.",
            "Cláusula 5ª. São OBRIGAÇÕES DO CONTRATANTE: fornecer a documentação necessária à " +
                "propositura e andamento da ação; pagar todas as despesas ",
            "derivadas da causa, tais como custas processuais judiciais, periciais e honorário" +
                "s advocatícios da parte contrária, em caso de eventual sucumbência; ",
            "custas de projeto e laudo técnico de topografia; despesas com viagens, xerox, cer" +
                "tidões, averbações e outras, como honorários advocatícios contratuais.",
            "Cláusula 6ª. São OBRIGAÇÕES DO CONTRATADO: promover a defesa dos interesses do Co" +
                "ntratante na ação já mencionada, até segunda instância, com diligência e dedicaç" +
                "ão."});
            this.listBox1.Location = new System.Drawing.Point(35, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(809, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // chbtermos
            // 
            this.chbtermos.AutoSize = true;
            this.chbtermos.BackColor = System.Drawing.Color.Transparent;
            this.chbtermos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbtermos.ForeColor = System.Drawing.Color.White;
            this.chbtermos.Location = new System.Drawing.Point(35, 342);
            this.chbtermos.Name = "chbtermos";
            this.chbtermos.Size = new System.Drawing.Size(300, 28);
            this.chbtermos.TabIndex = 3;
            this.chbtermos.Text = "Li e aceito os termos de contrato";
            this.chbtermos.UseVisualStyleBackColor = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.White;
            this.btnconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnconfirmar.Location = new System.Drawing.Point(171, 376);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(235, 48);
            this.btnconfirmar.TabIndex = 4;
            this.btnconfirmar.Text = "CONFIRMAR";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(458, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "INICIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // frm_termos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(879, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnconfirmar);
            this.Controls.Add(this.chbtermos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtrelato);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_termos";
            this.Text = "Termos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrelato;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chbtermos;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Button button1;
    }
}