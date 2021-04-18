using System.ComponentModel;

namespace CiureaTest
{
    partial class AddStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btList = new System.Windows.Forms.Button();
            this.btAddStud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(101, 9);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(139, 22);
            this.tbCod.TabIndex = 5;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(101, 37);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(139, 22);
            this.tbNume.TabIndex = 6;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(101, 65);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(139, 22);
            this.tbNote.TabIndex = 9;
            // 
            // btList
            // 
            this.btList.Location = new System.Drawing.Point(266, 154);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(85, 29);
            this.btList.TabIndex = 10;
            this.btList.Text = "btList";
            this.btList.UseVisualStyleBackColor = true;
            this.btList.Click += new System.EventHandler(this.btList_Click);
            // 
            // btAddStud
            // 
            this.btAddStud.Location = new System.Drawing.Point(246, 9);
            this.btAddStud.Name = "btAddStud";
            this.btAddStud.Size = new System.Drawing.Size(105, 78);
            this.btAddStud.TabIndex = 11;
            this.btAddStud.Text = "AddStud";
            this.btAddStud.UseVisualStyleBackColor = true;
            this.btAddStud.Click += new System.EventHandler(this.btAddStud_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 195);
            this.Controls.Add(this.btAddStud);
            this.Controls.Add(this.btList);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btAddStud;

        private System.Windows.Forms.Button btList;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbNote;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}