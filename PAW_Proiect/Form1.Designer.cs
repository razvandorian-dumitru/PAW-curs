namespace PAW_Proiect
{
    partial class Form1
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
            this.btNew = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.tvCod = new System.Windows.Forms.Label();
            this.tvNote = new System.Windows.Forms.Label();
            this.tvVarsta = new System.Windows.Forms.Label();
            this.etCod = new System.Windows.Forms.TextBox();
            this.etNota1 = new System.Windows.Forms.TextBox();
            this.etVarsta = new System.Windows.Forms.TextBox();
            this.etNume = new System.Windows.Forms.TextBox();
            this.etNota3 = new System.Windows.Forms.TextBox();
            this.etNota2 = new System.Windows.Forms.TextBox();
            this.tvStudent = new System.Windows.Forms.Label();
            this.btString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(374, 36);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(92, 29);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "Save";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(64, 78);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(50, 15);
            this.Nume.TabIndex = 1;
            this.Nume.Text = "Nume";
            // 
            // tvCod
            // 
            this.tvCod.Location = new System.Drawing.Point(64, 46);
            this.tvCod.Name = "tvCod";
            this.tvCod.Size = new System.Drawing.Size(50, 15);
            this.tvCod.TabIndex = 2;
            this.tvCod.Text = "Cod";
            // 
            // tvNote
            // 
            this.tvNote.Location = new System.Drawing.Point(64, 171);
            this.tvNote.Name = "tvNote";
            this.tvNote.Size = new System.Drawing.Size(50, 15);
            this.tvNote.TabIndex = 3;
            this.tvNote.Text = "Note";
            // 
            // tvVarsta
            // 
            this.tvVarsta.Location = new System.Drawing.Point(64, 114);
            this.tvVarsta.Name = "tvVarsta";
            this.tvVarsta.Size = new System.Drawing.Size(50, 15);
            this.tvVarsta.TabIndex = 4;
            this.tvVarsta.Text = "Varsta";
            // 
            // etCod
            // 
            this.etCod.Location = new System.Drawing.Point(120, 39);
            this.etCod.Name = "etCod";
            this.etCod.Size = new System.Drawing.Size(158, 22);
            this.etCod.TabIndex = 8;
            // 
            // etNota1
            // 
            this.etNota1.Location = new System.Drawing.Point(120, 164);
            this.etNota1.Name = "etNota1";
            this.etNota1.Size = new System.Drawing.Size(22, 22);
            this.etNota1.TabIndex = 11;
            // 
            // etVarsta
            // 
            this.etVarsta.Location = new System.Drawing.Point(120, 111);
            this.etVarsta.Name = "etVarsta";
            this.etVarsta.Size = new System.Drawing.Size(158, 22);
            this.etVarsta.TabIndex = 12;
            // 
            // etNume
            // 
            this.etNume.Location = new System.Drawing.Point(120, 75);
            this.etNume.Name = "etNume";
            this.etNume.Size = new System.Drawing.Size(158, 22);
            this.etNume.TabIndex = 13;
            // 
            // etNota3
            // 
            this.etNota3.Location = new System.Drawing.Point(256, 164);
            this.etNota3.Name = "etNota3";
            this.etNota3.Size = new System.Drawing.Size(22, 22);
            this.etNota3.TabIndex = 14;
            // 
            // etNota2
            // 
            this.etNota2.Location = new System.Drawing.Point(189, 164);
            this.etNota2.Name = "etNota2";
            this.etNota2.Size = new System.Drawing.Size(22, 22);
            this.etNota2.TabIndex = 15;
            // 
            // tvStudent
            // 
            this.tvStudent.Location = new System.Drawing.Point(245, 212);
            this.tvStudent.Name = "tvStudent";
            this.tvStudent.Size = new System.Drawing.Size(237, 169);
            this.tvStudent.TabIndex = 16;
            this.tvStudent.Text = "text";
            this.tvStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btString
            // 
            this.btString.Location = new System.Drawing.Point(489, 34);
            this.btString.Name = "btString";
            this.btString.Size = new System.Drawing.Size(89, 31);
            this.btString.TabIndex = 17;
            this.btString.Text = "Write";
            this.btString.UseVisualStyleBackColor = true;
            this.btString.Click += new System.EventHandler(this.btString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btString);
            this.Controls.Add(this.tvStudent);
            this.Controls.Add(this.etNota2);
            this.Controls.Add(this.etNota3);
            this.Controls.Add(this.etNume);
            this.Controls.Add(this.etVarsta);
            this.Controls.Add(this.etNota1);
            this.Controls.Add(this.etCod);
            this.Controls.Add(this.tvVarsta);
            this.Controls.Add(this.tvNote);
            this.Controls.Add(this.tvCod);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.btNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btString;

        private System.Windows.Forms.Label tvStudent;

        private System.Windows.Forms.TextBox etNota3;
        private System.Windows.Forms.TextBox etNota2;

        private System.Windows.Forms.TextBox etCod;
        private System.Windows.Forms.TextBox etNota1;
        private System.Windows.Forms.TextBox etVarsta;
        private System.Windows.Forms.TextBox etNume;

        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.Label tvCod;
        private System.Windows.Forms.Label tvNote;
        private System.Windows.Forms.Label tvVarsta;

        #endregion
    }
}