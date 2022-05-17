
namespace nomeArquivo
{
    partial class Form
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
            this.lblEn = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblPa = new System.Windows.Forms.Label();
            this.btnEn = new System.Windows.Forms.Button();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.tbxEn = new System.Windows.Forms.TextBox();
            this.tbxDe = new System.Windows.Forms.TextBox();
            this.tbxPa = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblEn
            // 
            this.lblEn.AutoSize = true;
            this.lblEn.Location = new System.Drawing.Point(64, 68);
            this.lblEn.Name = "lblEn";
            this.lblEn.Size = new System.Drawing.Size(56, 15);
            this.lblEn.TabIndex = 0;
            this.lblEn.Text = "Endereço";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(64, 142);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 15);
            this.lblDe.TabIndex = 1;
            this.lblDe.Text = "De";
            // 
            // lblPa
            // 
            this.lblPa.AutoSize = true;
            this.lblPa.Location = new System.Drawing.Point(64, 216);
            this.lblPa.Name = "lblPa";
            this.lblPa.Size = new System.Drawing.Size(30, 15);
            this.lblPa.TabIndex = 2;
            this.lblPa.Text = "Para";
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(488, 68);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(71, 26);
            this.btnEn.TabIndex = 4;
            this.btnEn.Text = "...";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(477, 136);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(82, 95);
            this.btnTrocar.TabIndex = 5;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // tbxEn
            // 
            this.tbxEn.Location = new System.Drawing.Point(131, 68);
            this.tbxEn.Name = "tbxEn";
            this.tbxEn.Size = new System.Drawing.Size(351, 23);
            this.tbxEn.TabIndex = 7;
            // 
            // tbxDe
            // 
            this.tbxDe.Location = new System.Drawing.Point(131, 134);
            this.tbxDe.Name = "tbxDe";
            this.tbxDe.Size = new System.Drawing.Size(310, 23);
            this.tbxDe.TabIndex = 8;
            // 
            // tbxPa
            // 
            this.tbxPa.Location = new System.Drawing.Point(131, 208);
            this.tbxPa.Name = "tbxPa";
            this.tbxPa.Size = new System.Drawing.Size(310, 23);
            this.tbxPa.TabIndex = 9;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(642, 349);
            this.Controls.Add(this.tbxPa);
            this.Controls.Add(this.tbxDe);
            this.Controls.Add(this.tbxEn);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.lblPa);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblEn);
            this.Name = "Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEn;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblPa;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnTrocar;
        private System.Windows.Forms.TextBox tbxEn;
        private System.Windows.Forms.TextBox tbxDe;
        private System.Windows.Forms.TextBox tbxPa;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

