﻿namespace emlakortomasyonu
{
    partial class kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit));
            this.adtextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.showpasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.passtextb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adtextb
            // 
            this.adtextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adtextb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adtextb.ForeColor = System.Drawing.Color.White;
            this.adtextb.HintForeColor = System.Drawing.Color.Empty;
            this.adtextb.HintText = "";
            this.adtextb.isPassword = false;
            this.adtextb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.adtextb.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.adtextb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.adtextb.LineThickness = 3;
            this.adtextb.Location = new System.Drawing.Point(178, 43);
            this.adtextb.Margin = new System.Windows.Forms.Padding(4);
            this.adtextb.Name = "adtextb";
            this.adtextb.Size = new System.Drawing.Size(302, 44);
            this.adtextb.TabIndex = 5;
            this.adtextb.Text = "İsim";
            this.adtextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.adtextb.OnValueChanged += new System.EventHandler(this.kullanıcıidTextbox_OnValueChanged);
            this.adtextb.Enter += new System.EventHandler(this.adtextb_Enter);
            this.adtextb.Leave += new System.EventHandler(this.adtextb_Leave);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginbutton.ForeColor = System.Drawing.Color.Black;
            this.loginbutton.Location = new System.Drawing.Point(233, 295);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(168, 40);
            this.loginbutton.TabIndex = 3;
            this.loginbutton.Text = "Kayıt Ol";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.showpasswordCheckbox);
            this.panel1.Controls.Add(this.passtextb);
            this.panel1.Controls.Add(this.adtextb);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Location = new System.Drawing.Point(184, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 366);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.HintForeColor = System.Drawing.Color.Empty;
            this.textBox2.HintText = "";
            this.textBox2.isPassword = false;
            this.textBox2.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.textBox2.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.textBox2.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.textBox2.LineThickness = 3;
            this.textBox2.Location = new System.Drawing.Point(178, 187);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(302, 44);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Cep No";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Crimson;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.comboBox2.Location = new System.Drawing.Point(177, 250);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(303, 39);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.Text = "İl";
            // 
            // showpasswordCheckbox
            // 
            this.showpasswordCheckbox.AutoSize = true;
            this.showpasswordCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showpasswordCheckbox.ForeColor = System.Drawing.Color.Cornsilk;
            this.showpasswordCheckbox.Location = new System.Drawing.Point(487, 129);
            this.showpasswordCheckbox.Name = "showpasswordCheckbox";
            this.showpasswordCheckbox.Size = new System.Drawing.Size(134, 24);
            this.showpasswordCheckbox.TabIndex = 7;
            this.showpasswordCheckbox.Text = "Şifreyi Göster";
            this.showpasswordCheckbox.UseVisualStyleBackColor = true;
            this.showpasswordCheckbox.CheckedChanged += new System.EventHandler(this.showpasswordCheckbox_CheckedChanged);
            // 
            // passtextb
            // 
            this.passtextb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtextb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passtextb.ForeColor = System.Drawing.Color.White;
            this.passtextb.HintForeColor = System.Drawing.Color.Empty;
            this.passtextb.HintText = "";
            this.passtextb.isPassword = true;
            this.passtextb.LineFocusedColor = System.Drawing.Color.BlueViolet;
            this.passtextb.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.passtextb.LineMouseHoverColor = System.Drawing.Color.BlueViolet;
            this.passtextb.LineThickness = 3;
            this.passtextb.Location = new System.Drawing.Point(178, 109);
            this.passtextb.Margin = new System.Windows.Forms.Padding(4);
            this.passtextb.Name = "passtextb";
            this.passtextb.Size = new System.Drawing.Size(302, 44);
            this.passtextb.TabIndex = 6;
            this.passtextb.Text = "Şifre";
            this.passtextb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passtextb.Enter += new System.EventHandler(this.passtextb_Enter);
            this.passtextb.Leave += new System.EventHandler(this.passtextb_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(921, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 63);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox adtextb;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showpasswordCheckbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtextb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
    }
}