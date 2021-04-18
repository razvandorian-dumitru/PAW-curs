using System.ComponentModel;

namespace PAW_Proiect.Formulare
{
    partial class StudentiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tvStudenti = new System.Windows.Forms.Label();
            this.sfdScriereText = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textExp = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlExp = new System.Windows.Forms.ToolStripMenuItem();
            this.binarExp = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textImp = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlImp = new System.Windows.Forms.ToolStripMenuItem();
            this.binarImp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvStudenti
            // 
            this.tvStudenti.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.tvStudenti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tvStudenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvStudenti.Location = new System.Drawing.Point(0, 28);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(800, 249);
            this.tvStudenti.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exportToolStripMenuItem, this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.textExp, this.xmlExp, this.binarExp});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // textExp
            // 
            this.textExp.Name = "textExp";
            this.textExp.Size = new System.Drawing.Size(112, 24);
            this.textExp.Text = "Text";
            this.textExp.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // xmlExp
            // 
            this.xmlExp.Name = "xmlExp";
            this.xmlExp.Size = new System.Drawing.Size(112, 24);
            this.xmlExp.Text = "XML";
            this.xmlExp.Click += new System.EventHandler(this.menuXmlExp_Click);
            // 
            // binarExp
            // 
            this.binarExp.Name = "binarExp";
            this.binarExp.Size = new System.Drawing.Size(112, 24);
            this.binarExp.Text = "Binar";
            this.binarExp.Click += new System.EventHandler(this.binarExp_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.textImp, this.xmlImp, this.binarImp});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // textImp
            // 
            this.textImp.Name = "textImp";
            this.textImp.Size = new System.Drawing.Size(112, 24);
            this.textImp.Text = "Text";
            this.textImp.Click += new System.EventHandler(this.textToolStripMenuItem1_Click);
            // 
            // xmlImp
            // 
            this.xmlImp.Name = "xmlImp";
            this.xmlImp.Size = new System.Drawing.Size(112, 24);
            this.xmlImp.Text = "XML";
            this.xmlImp.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // binarImp
            // 
            this.binarImp.Name = "binarImp";
            this.binarImp.Size = new System.Drawing.Size(112, 24);
            this.binarImp.Text = "Binar";
            this.binarImp.Click += new System.EventHandler(this.binarImp_Click);
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentiForm";
            this.Text = "StudentiForm";
            this.Load += new System.EventHandler(this.ListaStudenti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem binarExp;
        private System.Windows.Forms.ToolStripMenuItem binarImp;

        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textExp;
        private System.Windows.Forms.ToolStripMenuItem textImp;
        private System.Windows.Forms.ToolStripMenuItem xmlExp;
        private System.Windows.Forms.ToolStripMenuItem xmlImp;

        private System.Windows.Forms.SaveFileDialog sfdScriereText;

        private System.Windows.Forms.Label tvStudenti;

        #endregion
    }
}