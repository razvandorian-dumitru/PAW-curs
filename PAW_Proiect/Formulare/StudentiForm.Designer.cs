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
            this.btRefresh = new System.Windows.Forms.Button();
            this.btScriere = new System.Windows.Forms.Button();
            this.btCitire = new System.Windows.Forms.Button();
            this.sfdScriereText = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // tvStudenti
            // 
            this.tvStudenti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tvStudenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvStudenti.Location = new System.Drawing.Point(0, 0);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(800, 308);
            this.tvStudenti.TabIndex = 0;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(445, 329);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(64, 27);
            this.btRefresh.TabIndex = 1;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btScriere
            // 
            this.btScriere.Location = new System.Drawing.Point(531, 329);
            this.btScriere.Name = "btScriere";
            this.btScriere.Size = new System.Drawing.Size(64, 47);
            this.btScriere.TabIndex = 2;
            this.btScriere.Text = "Scriere Text";
            this.btScriere.UseVisualStyleBackColor = true;
            this.btScriere.Click += new System.EventHandler(this.btScriere_Click);
            // 
            // btCitire
            // 
            this.btCitire.Location = new System.Drawing.Point(628, 329);
            this.btCitire.Name = "btCitire";
            this.btCitire.Size = new System.Drawing.Size(72, 47);
            this.btCitire.TabIndex = 3;
            this.btCitire.Text = "Citire Text";
            this.btCitire.UseVisualStyleBackColor = true;
            // 
            // sfdScriereText
            // 
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCitire);
            this.Controls.Add(this.btScriere);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.tvStudenti);
            this.Name = "StudentiForm";
            this.Text = "StudentiForm";
            this.Load += new System.EventHandler(this.ListaStudenti_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SaveFileDialog sfdScriereText;

        private System.Windows.Forms.Button btCitire;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btScriere;

        private System.Windows.Forms.Label tvStudenti;

        #endregion
    }
}