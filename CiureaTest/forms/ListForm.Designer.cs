using System.ComponentModel;

namespace CiureaTest
{
    partial class ListForm
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
            this.tbLista = new System.Windows.Forms.TextBox();
            this.btTextExport = new System.Windows.Forms.Button();
            this.btTextImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLista
            // 
            this.tbLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLista.Location = new System.Drawing.Point(0, 0);
            this.tbLista.Multiline = true;
            this.tbLista.Name = "tbLista";
            this.tbLista.Size = new System.Drawing.Size(734, 172);
            this.tbLista.TabIndex = 0;
            // 
            // btTextExport
            // 
            this.btTextExport.AutoSize = true;
            this.btTextExport.Location = new System.Drawing.Point(511, 262);
            this.btTextExport.Name = "btTextExport";
            this.btTextExport.Size = new System.Drawing.Size(81, 26);
            this.btTextExport.TabIndex = 1;
            this.btTextExport.Text = "TextExport";
            this.btTextExport.UseVisualStyleBackColor = false;
            // 
            // btTextImport
            // 
            this.btTextImport.AutoSize = true;
            this.btTextImport.Location = new System.Drawing.Point(598, 262);
            this.btTextImport.Name = "btTextImport";
            this.btTextImport.Size = new System.Drawing.Size(80, 26);
            this.btTextImport.TabIndex = 3;
            this.btTextImport.Text = "TextImport";
            this.btTextImport.UseVisualStyleBackColor = false;
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 323);
            this.Controls.Add(this.btTextImport);
            this.Controls.Add(this.btTextExport);
            this.Controls.Add(this.tbLista);
            this.Name = "ListForm";
            this.Text = "label";
            this.Load += new System.EventHandler(this.ListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btTextExport;
        private System.Windows.Forms.Button btTextImport;

        private System.Windows.Forms.TextBox tbLista;

        #endregion
    }
}