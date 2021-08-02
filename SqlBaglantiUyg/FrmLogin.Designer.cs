
namespace SqlBaglantiUyg
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.SifreText = new System.Windows.Forms.TextBox();
            this.GiriButon = new System.Windows.Forms.Button();
            this.CikisButon = new System.Windows.Forms.Button();
            this.kullaniciKomboBox = new System.Windows.Forms.ComboBox();
            this.SifreDegLink = new System.Windows.Forms.LinkLabel();
            this.hatirlaCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(416, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(571, 178);
            this.SifreText.Name = "SifreText";
            this.SifreText.PasswordChar = '*';
            this.SifreText.Size = new System.Drawing.Size(229, 34);
            this.SifreText.TabIndex = 3;
            // 
            // GiriButon
            // 
            this.GiriButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.GiriButon.FlatAppearance.BorderSize = 0;
            this.GiriButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GiriButon.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiriButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GiriButon.Location = new System.Drawing.Point(409, 315);
            this.GiriButon.Name = "GiriButon";
            this.GiriButon.Size = new System.Drawing.Size(198, 54);
            this.GiriButon.TabIndex = 0;
            this.GiriButon.TabStop = false;
            this.GiriButon.Text = "GİRİŞ YAP";
            this.GiriButon.UseVisualStyleBackColor = false;
            this.GiriButon.Click += new System.EventHandler(this.GiriButon_Click);
            // 
            // CikisButon
            // 
            this.CikisButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(170)))));
            this.CikisButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CikisButon.FlatAppearance.BorderSize = 0;
            this.CikisButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CikisButon.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CikisButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CikisButon.Location = new System.Drawing.Point(625, 315);
            this.CikisButon.Name = "CikisButon";
            this.CikisButon.Size = new System.Drawing.Size(192, 54);
            this.CikisButon.TabIndex = 5;
            this.CikisButon.Text = "ÇIKIŞ";
            this.CikisButon.UseVisualStyleBackColor = false;
            this.CikisButon.Click += new System.EventHandler(this.CikisButon_Click);
            // 
            // kullaniciKomboBox
            // 
            this.kullaniciKomboBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kullaniciKomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciKomboBox.FormattingEnabled = true;
            this.kullaniciKomboBox.Location = new System.Drawing.Point(571, 110);
            this.kullaniciKomboBox.Name = "kullaniciKomboBox";
            this.kullaniciKomboBox.Size = new System.Drawing.Size(229, 37);
            this.kullaniciKomboBox.TabIndex = 20;
            this.kullaniciKomboBox.SelectedIndexChanged += new System.EventHandler(this.kullaniciKomboBox_SelectedIndexChanged);
            // 
            // SifreDegLink
            // 
            this.SifreDegLink.AutoSize = true;
            this.SifreDegLink.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifreDegLink.Location = new System.Drawing.Point(606, 243);
            this.SifreDegLink.Name = "SifreDegLink";
            this.SifreDegLink.Size = new System.Drawing.Size(182, 28);
            this.SifreDegLink.TabIndex = 7;
            this.SifreDegLink.TabStop = true;
            this.SifreDegLink.Text = "Şifremi Değiştir";
            this.SifreDegLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // hatirlaCheckBox
            // 
            this.hatirlaCheckBox.AutoSize = true;
            this.hatirlaCheckBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hatirlaCheckBox.Location = new System.Drawing.Point(421, 239);
            this.hatirlaCheckBox.Name = "hatirlaCheckBox";
            this.hatirlaCheckBox.Size = new System.Drawing.Size(165, 32);
            this.hatirlaCheckBox.TabIndex = 8;
            this.hatirlaCheckBox.Text = "Beni Hatırla";
            this.hatirlaCheckBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(788, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(52, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Öğrenci Yönetim Sistemi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(417, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-410, -125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1057, 891);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.GiriButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(199)))), ((int)(((byte)(250)))));
            this.CancelButton = this.CikisButon;
            this.ClientSize = new System.Drawing.Size(849, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CikisButon);
            this.Controls.Add(this.GiriButon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hatirlaCheckBox);
            this.Controls.Add(this.SifreDegLink);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullaniciKomboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button GiriButon;
        private System.Windows.Forms.Button CikisButon;
        private System.Windows.Forms.LinkLabel SifreDegLink;
        private System.Windows.Forms.CheckBox hatirlaCheckBox;
        private System.Windows.Forms.ComboBox kullaniciKomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}