namespace ProjetoAcademia
{
    partial class ListaTreinos
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
            this.tblTreinos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // tblTreinos
            // 
            this.tblTreinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTreinos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblTreinos.Location = new System.Drawing.Point(0, 44);
            this.tblTreinos.Name = "tblTreinos";
            this.tblTreinos.Size = new System.Drawing.Size(657, 275);
            this.tblTreinos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Treinos ";
            // 
            // ListaTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblTreinos);
            this.Name = "ListaTreinos";
            this.Text = "ListaTreinos";
            ((System.ComponentModel.ISupportInitialize)(this.tblTreinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblTreinos;
        private System.Windows.Forms.Label label1;
    }
}