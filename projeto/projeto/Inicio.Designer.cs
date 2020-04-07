namespace projeto
{
    partial class frm_inicioo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicioo));
            this.mnucadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuconsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusobre = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusair = new System.Windows.Forms.ToolStripMenuItem();
            this.mn1 = new System.Windows.Forms.MenuStrip();
            this.mn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnucadastro
            // 
            this.mnucadastro.Name = "mnucadastro";
            this.mnucadastro.Size = new System.Drawing.Size(66, 20);
            this.mnucadastro.Text = "Cadastro";
            this.mnucadastro.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // mnuconsulta
            // 
            this.mnuconsulta.Name = "mnuconsulta";
            this.mnuconsulta.Size = new System.Drawing.Size(66, 20);
            this.mnuconsulta.Text = "Consulta";
            this.mnuconsulta.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // mnusobre
            // 
            this.mnusobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatoToolStripMenuItem,
            this.objetivoToolStripMenuItem});
            this.mnusobre.Name = "mnusobre";
            this.mnusobre.Size = new System.Drawing.Size(49, 20);
            this.mnusobre.Text = "Sobre";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.contatoToolStripMenuItem.Text = "Contato";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // objetivoToolStripMenuItem
            // 
            this.objetivoToolStripMenuItem.Name = "objetivoToolStripMenuItem";
            this.objetivoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.objetivoToolStripMenuItem.Text = "Objetivo";
            this.objetivoToolStripMenuItem.Click += new System.EventHandler(this.objetivoToolStripMenuItem_Click);
            // 
            // mnusair
            // 
            this.mnusair.Name = "mnusair";
            this.mnusair.Size = new System.Drawing.Size(38, 20);
            this.mnusair.Text = "Sair";
            this.mnusair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_2);
            // 
            // mn1
            // 
            this.mn1.BackColor = System.Drawing.Color.White;
            this.mn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucadastro,
            this.mnuconsulta,
            this.mnusobre,
            this.mnusair});
            this.mn1.Location = new System.Drawing.Point(0, 0);
            this.mn1.Name = "mn1";
            this.mn1.Size = new System.Drawing.Size(710, 24);
            this.mn1.TabIndex = 22;
            this.mn1.Text = "menuStrip1";
            // 
            // frm_inicioo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(710, 522);
            this.Controls.Add(this.mn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mn1;
            this.MinimizeBox = false;
            this.Name = "frm_inicioo";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.mn1.ResumeLayout(false);
            this.mn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnucadastro;
        private System.Windows.Forms.ToolStripMenuItem mnuconsulta;
        private System.Windows.Forms.ToolStripMenuItem mnusobre;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnusair;
        private System.Windows.Forms.MenuStrip mn1;
    }
}