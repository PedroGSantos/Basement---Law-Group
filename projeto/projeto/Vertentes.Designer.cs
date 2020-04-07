namespace projeto
{
    partial class frm_vertentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vertentes));
            this.cbm_vertentes = new System.Windows.Forms.ComboBox();
            this.lbl_vertentes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_continuar2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbm_vertentes
            // 
            this.cbm_vertentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbm_vertentes.ForeColor = System.Drawing.Color.DarkRed;
            this.cbm_vertentes.FormattingEnabled = true;
            this.cbm_vertentes.Items.AddRange(new object[] {
            "Direito Civil",
            "Direito Penal",
            "Direito Comercial"});
            this.cbm_vertentes.Location = new System.Drawing.Point(121, 165);
            this.cbm_vertentes.Name = "cbm_vertentes";
            this.cbm_vertentes.Size = new System.Drawing.Size(377, 33);
            this.cbm_vertentes.TabIndex = 13;
            this.cbm_vertentes.SelectedIndexChanged += new System.EventHandler(this.cbm_vertentes_SelectedIndexChanged);
            // 
            // lbl_vertentes
            // 
            this.lbl_vertentes.AutoSize = true;
            this.lbl_vertentes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vertentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vertentes.ForeColor = System.Drawing.Color.Ivory;
            this.lbl_vertentes.Location = new System.Drawing.Point(117, 89);
            this.lbl_vertentes.Name = "lbl_vertentes";
            this.lbl_vertentes.Size = new System.Drawing.Size(402, 24);
            this.lbl_vertentes.TabIndex = 12;
            this.lbl_vertentes.Text = "Selecione a vertente relacionada ao seu caso :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto.Properties.Resources.Basement;
            this.pictureBox1.Location = new System.Drawing.Point(177, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btn_continuar2
            // 
            this.btn_continuar2.BackColor = System.Drawing.Color.Ivory;
            this.btn_continuar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar2.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_continuar2.Location = new System.Drawing.Point(337, 513);
            this.btn_continuar2.Name = "btn_continuar2";
            this.btn_continuar2.Size = new System.Drawing.Size(116, 68);
            this.btn_continuar2.TabIndex = 18;
            this.btn_continuar2.Text = "Continuar";
            this.btn_continuar2.UseVisualStyleBackColor = false;
            this.btn_continuar2.Click += new System.EventHandler(this.btn_continuar2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(177, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 68);
            this.button1.TabIndex = 19;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_vertentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(617, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_continuar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbm_vertentes);
            this.Controls.Add(this.lbl_vertentes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_vertentes";
            this.Text = "Vertentes";
            this.Load += new System.EventHandler(this.frm_vertentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_vertentes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cbm_vertentes;
        public System.Windows.Forms.Button btn_continuar2;
    }
}