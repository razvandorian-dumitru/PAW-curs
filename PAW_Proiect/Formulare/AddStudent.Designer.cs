using System.ComponentModel;

namespace PAW_Proiect.Formulare
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
            this.numericVarsta = new System.Windows.Forms.NumericUpDown();
            this.etNume = new System.Windows.Forms.TextBox();
            this.etCod = new System.Windows.Forms.TextBox();
            this.tvVarsta = new System.Windows.Forms.Label();
            this.tvCod = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.btSaveStud = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.numericVarsta)).BeginInit();
            this.SuspendLayout();
            // 
            // numericVarsta
            // 
            this.numericVarsta.Location = new System.Drawing.Point(109, 121);
            this.numericVarsta.Name = "numericVarsta";
            this.numericVarsta.Size = new System.Drawing.Size(91, 22);
            this.numericVarsta.TabIndex = 25;
            // 
            // etNume
            // 
            this.etNume.Location = new System.Drawing.Point(109, 84);
            this.etNume.Name = "etNume";
            this.etNume.Size = new System.Drawing.Size(120, 22);
            this.etNume.TabIndex = 23;
            // 
            // etCod
            // 
            this.etCod.Location = new System.Drawing.Point(109, 48);
            this.etCod.Name = "etCod";
            this.etCod.Size = new System.Drawing.Size(120, 22);
            this.etCod.TabIndex = 21;
            // 
            // tvVarsta
            // 
            this.tvVarsta.Location = new System.Drawing.Point(53, 123);
            this.tvVarsta.Name = "tvVarsta";
            this.tvVarsta.Size = new System.Drawing.Size(50, 15);
            this.tvVarsta.TabIndex = 28;
            this.tvVarsta.Text = "Varsta";
            // 
            // tvCod
            // 
            this.tvCod.Location = new System.Drawing.Point(53, 55);
            this.tvCod.Name = "tvCod";
            this.tvCod.Size = new System.Drawing.Size(50, 15);
            this.tvCod.TabIndex = 24;
            this.tvCod.Text = "Cod";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(53, 87);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(50, 15);
            this.Nume.TabIndex = 22;
            this.Nume.Text = "Nume";
            // 
            // btSaveStud
            // 
            this.btSaveStud.Location = new System.Drawing.Point(137, 212);
            this.btSaveStud.Name = "btSaveStud";
            this.btSaveStud.Size = new System.Drawing.Size(92, 29);
            this.btSaveStud.TabIndex = 31;
            this.btSaveStud.Text = "Save";
            this.btSaveStud.UseVisualStyleBackColor = true;
            this.btSaveStud.Click += new System.EventHandler(this.btNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 45);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericVarsta);
            this.Controls.Add(this.etNume);
            this.Controls.Add(this.etCod);
            this.Controls.Add(this.tvVarsta);
            this.Controls.Add(this.tvCod);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.btSaveStud);
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize) (this.numericVarsta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btSaveStud;
        private System.Windows.Forms.TextBox etCod;
        private System.Windows.Forms.TextBox etNume;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.NumericUpDown numericVarsta;
        private System.Windows.Forms.Label tvCod;
        private System.Windows.Forms.Label tvVarsta;

        #endregion
    }
}