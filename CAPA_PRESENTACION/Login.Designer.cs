﻿
namespace CAPA_PRESENTACION
{
    partial class Login
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
            this.lblerror = new System.Windows.Forms.Label();
            this.lblnot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtuser = new CAPA_PRESENTACION.textboxpersonal();
            this.btnver = new CAPA_PRESENTACION.Buttonpersolizado();
            this.pictureboxpersonal1 = new CAPA_PRESENTACION.Pictureboxpersonal();
            this.btnlogin = new CAPA_PRESENTACION.Buttonpersolizado();
            this.txtpass = new CAPA_PRESENTACION.textboxpersonal();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblerror.Location = new System.Drawing.Point(314, 211);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 15);
            this.lblerror.TabIndex = 9;
            this.lblerror.Visible = false;
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.BackColor = System.Drawing.Color.Transparent;
            this.lblnot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnot.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnot.ForeColor = System.Drawing.Color.Red;
            this.lblnot.Location = new System.Drawing.Point(24, 315);
            this.lblnot.Name = "lblnot";
            this.lblnot.Size = new System.Drawing.Size(50, 19);
            this.lblnot.TabIndex = 16;
            this.lblnot.Text = "label2";
            this.lblnot.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.delete_remove_minus_icon_181585;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(257, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CAPA_PRESENTACION.Properties.Resources.delete_remove_close_checkbox_check_icon_181586;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(296, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtuser.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtuser.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtuser.BorderRadius = 0;
            this.txtuser.BorderSize = 2;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtuser.IsFocused = true;
            this.txtuser.IsPasswordChar = false;
            this.txtuser.IsPlaceholder = true;
            this.txtuser.Location = new System.Drawing.Point(29, 211);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Multiline = false;
            this.txtuser.Name = "txtuser";
            this.txtuser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtuser.PasswordChar = false;
            this.txtuser.PlaceholderColor = System.Drawing.Color.DodgerBlue;
            this.txtuser.PlaceholderText = "";
            this.txtuser.Size = new System.Drawing.Size(286, 31);
            this.txtuser.TabIndex = 22;
            this.txtuser.Texts = "";
            this.txtuser.UnderlinedStyle = true;
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // btnver
            // 
            this.btnver.BackColor = System.Drawing.Color.Transparent;
            this.btnver.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnver.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnver.BorderRadius = 0;
            this.btnver.BorderSize = 0;
            this.btnver.FlatAppearance.BorderSize = 0;
            this.btnver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnver.ForeColor = System.Drawing.Color.White;
            this.btnver.Image = global::CAPA_PRESENTACION.Properties.Resources.eye_watch_icon_icons_com_74456;
            this.btnver.Location = new System.Drawing.Point(269, 273);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(45, 20);
            this.btnver.TabIndex = 21;
            this.btnver.TextColor = System.Drawing.Color.White;
            this.btnver.UseVisualStyleBackColor = false;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // pictureboxpersonal1
            // 
            this.pictureboxpersonal1.Bordercapstyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pictureboxpersonal1.Bordercolor = System.Drawing.Color.DeepSkyBlue;
            this.pictureboxpersonal1.Bordercolor2 = System.Drawing.Color.Cyan;
            this.pictureboxpersonal1.Borderlinestyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.pictureboxpersonal1.Bordersize = 3;
            this.pictureboxpersonal1.Gradient = 50F;
            this.pictureboxpersonal1.Image = global::CAPA_PRESENTACION.Properties.Resources.human_brain_psychiatrist_icon_131296;
            this.pictureboxpersonal1.Location = new System.Drawing.Point(113, 59);
            this.pictureboxpersonal1.Name = "pictureboxpersonal1";
            this.pictureboxpersonal1.Size = new System.Drawing.Size(109, 110);
            this.pictureboxpersonal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxpersonal1.TabIndex = 20;
            this.pictureboxpersonal1.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlogin.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnlogin.BorderColor = System.Drawing.Color.Cyan;
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.BorderSize = 1;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(97, 382);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(150, 40);
            this.btnlogin.TabIndex = 19;
            this.btnlogin.Text = "Acceder";
            this.btnlogin.TextColor = System.Drawing.Color.Black;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnlogin_KeyDown);
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.txtpass.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.txtpass.BorderFocusColor = System.Drawing.Color.Aqua;
            this.txtpass.BorderRadius = 0;
            this.txtpass.BorderSize = 2;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtpass.IsFocused = true;
            this.txtpass.IsPasswordChar = true;
            this.txtpass.IsPlaceholder = true;
            this.txtpass.Location = new System.Drawing.Point(29, 267);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Multiline = false;
            this.txtpass.Name = "txtpass";
            this.txtpass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtpass.PasswordChar = true;
            this.txtpass.PlaceholderColor = System.Drawing.Color.DodgerBlue;
            this.txtpass.PlaceholderText = "";
            this.txtpass.Size = new System.Drawing.Size(286, 31);
            this.txtpass.TabIndex = 18;
            this.txtpass.Texts = "";
            this.txtpass.UnderlinedStyle = true;
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(342, 500);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.pictureboxpersonal1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblnot);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblerror);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxpersonal1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblerror;
        private Buttonpersolizado btnlogin;
        private textboxpersonal txtpass;
        private System.Windows.Forms.Label lblnot;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Pictureboxpersonal pictureboxpersonal1;
        private Buttonpersolizado btnver;
        private textboxpersonal txtuser;
        // private ShapeContainer shapeContainer1;
        //private LineShape lineShape2;
        //private LineShape lineShape1;
    }
}