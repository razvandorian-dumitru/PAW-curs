﻿namespace PAW_Proiect.Formulare
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMaterieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.optiuniToolStripMenuItem, this.fisierTextToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optiuniToolStripMenuItem
            // 
            this.optiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addMaterieToolStripMenuItem, this.addAnToolStripMenuItem, this.addStudentToolStripMenuItem, this.listaStudentiToolStripMenuItem, this.aboutToolStripMenuItem});
            this.optiuniToolStripMenuItem.Name = "optiuniToolStripMenuItem";
            this.optiuniToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.optiuniToolStripMenuItem.Text = "Optiuni";
            // 
            // addMaterieToolStripMenuItem
            // 
            this.addMaterieToolStripMenuItem.Name = "addMaterieToolStripMenuItem";
            this.addMaterieToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.addMaterieToolStripMenuItem.Text = "Add Materie";
            this.addMaterieToolStripMenuItem.Click += new System.EventHandler(this.addMaterieToolStripMenuItem_Click);
            // 
            // addAnToolStripMenuItem
            // 
            this.addAnToolStripMenuItem.Name = "addAnToolStripMenuItem";
            this.addAnToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.addAnToolStripMenuItem.Text = "Add An";
            this.addAnToolStripMenuItem.Click += new System.EventHandler(this.addAnToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // listaStudentiToolStripMenuItem
            // 
            this.listaStudentiToolStripMenuItem.Name = "listaStudentiToolStripMenuItem";
            this.listaStudentiToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.listaStudentiToolStripMenuItem.Text = "Lista Studenti";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.fisierTextToolStripMenuItem.Text = "Fisier Text?";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(251, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 81);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gestiune facultate";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Start";
            this.Text = "Start";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem addAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMaterieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaStudentiToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optiuniToolStripMenuItem;

        #endregion
    }
}