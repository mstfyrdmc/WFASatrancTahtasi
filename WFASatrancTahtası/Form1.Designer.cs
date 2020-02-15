namespace WFASatrancTahtası
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.flpSatranc = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpSatranc
            // 
            this.flpSatranc.Location = new System.Drawing.Point(17, 15);
            this.flpSatranc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpSatranc.Name = "flpSatranc";
            this.flpSatranc.Size = new System.Drawing.Size(400, 400);
            this.flpSatranc.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(17, 539);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(577, 55);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Satranç Tahtası Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.flpSatranc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSatranc;
        private System.Windows.Forms.Button btnOlustur;
    }
}

