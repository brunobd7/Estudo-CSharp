namespace ProjetoAcademia
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLUNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDICIONARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tREINOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUNOToolStripMenuItem,
            this.tREINOToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLUNOToolStripMenuItem
            // 
            this.aLUNOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDICIONARToolStripMenuItem});
            this.aLUNOToolStripMenuItem.Name = "aLUNOToolStripMenuItem";
            this.aLUNOToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aLUNOToolStripMenuItem.Text = "ALUNO";
            // 
            // aDICIONARToolStripMenuItem
            // 
            this.aDICIONARToolStripMenuItem.Name = "aDICIONARToolStripMenuItem";
            this.aDICIONARToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.aDICIONARToolStripMenuItem.Text = "CADASTRAR ALUNO";
            this.aDICIONARToolStripMenuItem.Click += new System.EventHandler(this.aDICIONARToolStripMenuItem_Click);
            // 
            // tREINOToolStripMenuItem
            // 
            this.tREINOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadasToolStripMenuItem});
            this.tREINOToolStripMenuItem.Name = "tREINOToolStripMenuItem";
            this.tREINOToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tREINOToolStripMenuItem.Text = "TREINO";
            // 
            // cadasToolStripMenuItem
            // 
            this.cadasToolStripMenuItem.Name = "cadasToolStripMenuItem";
            this.cadasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cadasToolStripMenuItem.Text = "CADASTRO DE TREINO";
            this.cadasToolStripMenuItem.Click += new System.EventHandler(this.cadasToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(568, 350);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLUNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tREINOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDICIONARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
    }
}

