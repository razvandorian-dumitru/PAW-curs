using System.ComponentModel;

namespace PAW_Proiect.Formulare
{
    partial class AddMaterie
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
            this.components = new System.ComponentModel.Container();
            this.tvDenumire = new System.Windows.Forms.Label();
            this.tvNrCred = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.etDenumire = new System.Windows.Forms.TextBox();
            this.numCredite = new System.Windows.Forms.NumericUpDown();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.btAddMaterie = new System.Windows.Forms.Button();
            this.Materie = new System.Windows.Forms.Label();
            this.errorMaterie = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.numCredite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorMaterie)).BeginInit();
            this.SuspendLayout();
            // 
            // tvDenumire
            // 
            this.tvDenumire.AutoSize = true;
            this.tvDenumire.Location = new System.Drawing.Point(32, 64);
            this.tvDenumire.Margin = new System.Windows.Forms.Padding(3);
            this.tvDenumire.Name = "tvDenumire";
            this.tvDenumire.Size = new System.Drawing.Size(65, 16);
            this.tvDenumire.TabIndex = 0;
            this.tvDenumire.Text = "Denumire";
            // 
            // tvNrCred
            // 
            this.tvNrCred.AutoSize = true;
            this.tvNrCred.Location = new System.Drawing.Point(32, 103);
            this.tvNrCred.Name = "tvNrCred";
            this.tvNrCred.Size = new System.Drawing.Size(70, 16);
            this.tvNrCred.TabIndex = 1;
            this.tvNrCred.Text = "Nr. Credite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota";
            // 
            // etDenumire
            // 
            this.etDenumire.Location = new System.Drawing.Point(133, 64);
            this.etDenumire.Name = "etDenumire";
            this.etDenumire.Size = new System.Drawing.Size(139, 22);
            this.etDenumire.TabIndex = 3;
            // 
            // numCredite
            // 
            this.numCredite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCredite.Location = new System.Drawing.Point(133, 103);
            this.numCredite.Maximum = new decimal(new int[] {6, 0, 0, 0});
            this.numCredite.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numCredite.Name = "numCredite";
            this.numCredite.Size = new System.Drawing.Size(46, 22);
            this.numCredite.TabIndex = 4;
            this.numCredite.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(133, 138);
            this.numNota.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numNota.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(46, 22);
            this.numNota.TabIndex = 5;
            this.numNota.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // btAddMaterie
            // 
            this.btAddMaterie.BackColor = System.Drawing.SystemColors.Control;
            this.btAddMaterie.Location = new System.Drawing.Point(197, 115);
            this.btAddMaterie.Name = "btAddMaterie";
            this.btAddMaterie.Size = new System.Drawing.Size(75, 45);
            this.btAddMaterie.TabIndex = 6;
            this.btAddMaterie.Text = "Creare Materie";
            this.btAddMaterie.UseVisualStyleBackColor = false;
            this.btAddMaterie.Click += new System.EventHandler(this.btAddMaterie_Click);
            // 
            // Materie
            // 
            this.Materie.AutoSize = true;
            this.Materie.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Materie.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.Materie.Location = new System.Drawing.Point(45, 19);
            this.Materie.Name = "Materie";
            this.Materie.Size = new System.Drawing.Size(211, 28);
            this.Materie.TabIndex = 7;
            this.Materie.Text = "ADAUGARE MATERIE";
            // 
            // errorMaterie
            // 
            this.errorMaterie.ContainerControl = this;
            // 
            // AddMaterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.ClientSize = new System.Drawing.Size(317, 180);
            this.Controls.Add(this.Materie);
            this.Controls.Add(this.btAddMaterie);
            this.Controls.Add(this.numNota);
            this.Controls.Add(this.numCredite);
            this.Controls.Add(this.etDenumire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tvNrCred);
            this.Controls.Add(this.tvDenumire);
            this.Name = "AddMaterie";
            this.Text = "AddMaterie";
            ((System.ComponentModel.ISupportInitialize) (this.numCredite)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorMaterie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ErrorProvider errorMaterie;

        private System.Windows.Forms.Label Materie;

        private System.Windows.Forms.Button btAddMaterie;

        private System.Windows.Forms.TextBox etDenumire;
        private System.Windows.Forms.NumericUpDown numCredite;
        private System.Windows.Forms.NumericUpDown numNota;

        private System.Windows.Forms.Label tvNrCred;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label tvDenumire;

        #endregion
    }
}