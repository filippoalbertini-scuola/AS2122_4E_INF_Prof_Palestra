
namespace AS2122_4E_INF_Prof_Palestra
{
    partial class frmMain
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPersone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMesi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero persone";
            // 
            // txtNumeroPersone
            // 
            this.txtNumeroPersone.Location = new System.Drawing.Point(177, 39);
            this.txtNumeroPersone.Name = "txtNumeroPersone";
            this.txtNumeroPersone.Size = new System.Drawing.Size(105, 27);
            this.txtNumeroPersone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesi";
            // 
            // cmbMesi
            // 
            this.cmbMesi.FormattingEnabled = true;
            this.cmbMesi.Location = new System.Drawing.Point(177, 102);
            this.cmbMesi.Name = "cmbMesi";
            this.cmbMesi.Size = new System.Drawing.Size(151, 28);
            this.cmbMesi.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMesi);
            this.Controls.Add(this.txtNumeroPersone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Prof; Lab. 2.2 4E; 09/03/22; gestione palestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPersone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMesi;
    }
}

