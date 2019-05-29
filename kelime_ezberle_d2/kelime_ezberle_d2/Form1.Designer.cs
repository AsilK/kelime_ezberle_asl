namespace kelime_ezberle_d2
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
            this.components = new System.ComponentModel.Container();
            this.txtIngilizce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSüre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.lblKelimeEklemeBölümü = new System.Windows.Forms.Label();
            this.txt_TurkceEkle = new System.Windows.Forms.TextBox();
            this.txt_IngilizceEkle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_KelimeSil = new System.Windows.Forms.Button();
            this.txtKelimeId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIngilizce
            // 
            this.txtIngilizce.Location = new System.Drawing.Point(229, 34);
            this.txtIngilizce.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngilizce.Name = "txtIngilizce";
            this.txtIngilizce.Size = new System.Drawing.Size(148, 26);
            this.txtIngilizce.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ingilizce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "türkçe";
            // 
            // lblSüre
            // 
            this.lblSüre.AutoSize = true;
            this.lblSüre.Location = new System.Drawing.Point(521, 37);
            this.lblSüre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSüre.Name = "lblSüre";
            this.lblSüre.Size = new System.Drawing.Size(27, 18);
            this.lblSüre.TabIndex = 3;
            this.lblSüre.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "süre :";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(426, 98);
            this.lblKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(64, 18);
            this.lblKelime.TabIndex = 5;
            this.lblKelime.Text = "kelime :";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(229, 90);
            this.txtTurkce.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.Size = new System.Drawing.Size(148, 26);
            this.txtTurkce.TabIndex = 1;
            this.txtTurkce.TextChanged += new System.EventHandler(this.txtTurkce_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(341, 174);
            this.lblCevap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(50, 18);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "lblcvp";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Location = new System.Drawing.Point(817, 98);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(111, 27);
            this.btnKelimeEkle.TabIndex = 11;
            this.btnKelimeEkle.Text = "Kelime Ekle";
            this.btnKelimeEkle.UseVisualStyleBackColor = true;
            this.btnKelimeEkle.Click += new System.EventHandler(this.btnKelimeEkle_Click);
            // 
            // lblKelimeEklemeBölümü
            // 
            this.lblKelimeEklemeBölümü.AutoSize = true;
            this.lblKelimeEklemeBölümü.Location = new System.Drawing.Point(790, 8);
            this.lblKelimeEklemeBölümü.Name = "lblKelimeEklemeBölümü";
            this.lblKelimeEklemeBölümü.Size = new System.Drawing.Size(172, 18);
            this.lblKelimeEklemeBölümü.TabIndex = 12;
            this.lblKelimeEklemeBölümü.Text = "Kelime Ekleme Bölümü";
            // 
            // txt_TurkceEkle
            // 
            this.txt_TurkceEkle.Location = new System.Drawing.Point(828, 29);
            this.txt_TurkceEkle.Name = "txt_TurkceEkle";
            this.txt_TurkceEkle.Size = new System.Drawing.Size(100, 26);
            this.txt_TurkceEkle.TabIndex = 13;
            // 
            // txt_IngilizceEkle
            // 
            this.txt_IngilizceEkle.Location = new System.Drawing.Point(828, 61);
            this.txt_IngilizceEkle.Name = "txt_IngilizceEkle";
            this.txt_IngilizceEkle.Size = new System.Drawing.Size(100, 26);
            this.txt_IngilizceEkle.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Türkçe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(743, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "İngilizce";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(790, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kelime Silme Bölümü";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(722, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "kelime Id:";
            // 
            // btn_KelimeSil
            // 
            this.btn_KelimeSil.Location = new System.Drawing.Point(841, 302);
            this.btn_KelimeSil.Name = "btn_KelimeSil";
            this.btn_KelimeSil.Size = new System.Drawing.Size(107, 23);
            this.btn_KelimeSil.TabIndex = 19;
            this.btn_KelimeSil.Text = "Kelime Sil";
            this.btn_KelimeSil.UseVisualStyleBackColor = true;
            this.btn_KelimeSil.Click += new System.EventHandler(this.btn_KelimeSil_Click);
            // 
            // txtKelimeId
            // 
            this.txtKelimeId.Location = new System.Drawing.Point(841, 229);
            this.txtKelimeId.Name = "txtKelimeId";
            this.txtKelimeId.Size = new System.Drawing.Size(100, 26);
            this.txtKelimeId.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 352);
            this.Controls.Add(this.txtKelimeId);
            this.Controls.Add(this.btn_KelimeSil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IngilizceEkle);
            this.Controls.Add(this.txt_TurkceEkle);
            this.Controls.Add(this.lblKelimeEklemeBölümü);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSüre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngilizce);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngilizce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSüre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.Label lblKelimeEklemeBölümü;
        private System.Windows.Forms.TextBox txt_TurkceEkle;
        private System.Windows.Forms.TextBox txt_IngilizceEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_KelimeSil;
        private System.Windows.Forms.TextBox txtKelimeId;
    }
}

