namespace projeto
{
    partial class frm_consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_consulta));
            this.dgvdados = new System.Windows.Forms.DataGridView();
            this.lblcadastrados = new System.Windows.Forms.Label();
            this.pblogo3 = new System.Windows.Forms.PictureBox();
            this.btnvoltar1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdados
            // 
            this.dgvdados.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dgvdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdados.Location = new System.Drawing.Point(12, 190);
            this.dgvdados.Name = "dgvdados";
            this.dgvdados.Size = new System.Drawing.Size(657, 230);
            this.dgvdados.TabIndex = 0;
            // 
            // lblcadastrados
            // 
            this.lblcadastrados.AutoSize = true;
            this.lblcadastrados.BackColor = System.Drawing.Color.Transparent;
            this.lblcadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcadastrados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcadastrados.Location = new System.Drawing.Point(215, 145);
            this.lblcadastrados.Name = "lblcadastrados";
            this.lblcadastrados.Size = new System.Drawing.Size(245, 29);
            this.lblcadastrados.TabIndex = 1;
            this.lblcadastrados.Text = "Usuários cadastrados";
            // 
            // pblogo3
            // 
            this.pblogo3.Image = ((System.Drawing.Image)(resources.GetObject("pblogo3.Image")));
            this.pblogo3.Location = new System.Drawing.Point(266, 12);
            this.pblogo3.Name = "pblogo3";
            this.pblogo3.Size = new System.Drawing.Size(142, 112);
            this.pblogo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pblogo3.TabIndex = 2;
            this.pblogo3.TabStop = false;
            // 
            // btnvoltar1
            // 
            this.btnvoltar1.BackColor = System.Drawing.Color.Ivory;
            this.btnvoltar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar1.ForeColor = System.Drawing.Color.DarkRed;
            this.btnvoltar1.Location = new System.Drawing.Point(280, 426);
            this.btnvoltar1.Name = "btnvoltar1";
            this.btnvoltar1.Size = new System.Drawing.Size(116, 68);
            this.btnvoltar1.TabIndex = 20;
            this.btnvoltar1.Text = "Voltar";
            this.btnvoltar1.UseVisualStyleBackColor = false;
            this.btnvoltar1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projeto.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(681, 505);
            this.Controls.Add(this.btnvoltar1);
            this.Controls.Add(this.pblogo3);
            this.Controls.Add(this.lblcadastrados);
            this.Controls.Add(this.dgvdados);
            this.Name = "frm_consulta";
            this.Text = "Consulta dos cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdados;
        private System.Windows.Forms.Label lblcadastrados;
        private System.Windows.Forms.PictureBox pblogo3;
        private System.Windows.Forms.Button btnvoltar1;
    }
}