namespace OtobusBiletSatis
{
    partial class KayıtFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.mskdtelefon = new System.Windows.Forms.MaskedTextBox();
            this.rdrbay = new System.Windows.Forms.RadioButton();
            this.rdrbayan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(177, 57);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(144, 23);
            this.txtisim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(177, 100);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(144, 23);
            this.txtSoyisim.TabIndex = 1;
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(90, 148);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(45, 15);
            this.Telefon.TabIndex = 2;
            this.Telefon.Text = "Telefon";
            // 
            // mskdtelefon
            // 
            this.mskdtelefon.Location = new System.Drawing.Point(174, 149);
            this.mskdtelefon.Mask = "(999) 000-0000";
            this.mskdtelefon.Name = "mskdtelefon";
            this.mskdtelefon.Size = new System.Drawing.Size(144, 23);
            this.mskdtelefon.TabIndex = 3;
            // 
            // rdrbay
            // 
            this.rdrbay.AutoSize = true;
            this.rdrbay.Location = new System.Drawing.Point(156, 208);
            this.rdrbay.Name = "rdrbay";
            this.rdrbay.Size = new System.Drawing.Size(44, 19);
            this.rdrbay.TabIndex = 4;
            this.rdrbay.TabStop = true;
            this.rdrbay.Text = "Bay";
            this.rdrbay.UseVisualStyleBackColor = true;
            // 
            // rdrbayan
            // 
            this.rdrbayan.AutoSize = true;
            this.rdrbayan.Location = new System.Drawing.Point(233, 208);
            this.rdrbayan.Name = "rdrbayan";
            this.rdrbayan.Size = new System.Drawing.Size(57, 19);
            this.rdrbayan.TabIndex = 5;
            this.rdrbayan.TabStop = true;
            this.rdrbayan.Text = "Bayan";
            this.rdrbayan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tamam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayıtFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdrbayan);
            this.Controls.Add(this.rdrbay);
            this.Controls.Add(this.mskdtelefon);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KayıtFormu";
            this.Text = "KayıtFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtisim;
        public System.Windows.Forms.TextBox txtSoyisim;
        public System.Windows.Forms.MaskedTextBox mskdtelefon;
        public System.Windows.Forms.RadioButton rdrbay;
        public System.Windows.Forms.RadioButton rdrbayan;
    }
}