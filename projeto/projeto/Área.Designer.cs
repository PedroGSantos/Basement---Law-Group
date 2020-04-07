namespace projeto
{
    partial class Área
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 114);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_nome.Location = new System.Drawing.Point(21, 130);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(468, 22);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Selecione  a área legal seu caso está relacionado :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Civil",
            "Naval",
            "Penal"});
            this.comboBox1.Location = new System.Drawing.Point(67, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // Área
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(501, 506);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.button1);
            this.Name = "Área";
            this.Text = "Área";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}