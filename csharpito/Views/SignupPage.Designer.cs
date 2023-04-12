
namespace csharpito
{
    partial class SignupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ApplicationName = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.divInputs = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.linkTerms = new System.Windows.Forms.LinkLabel();
            this.checkBoxTerms = new System.Windows.Forms.CheckBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.divInputLogin = new System.Windows.Forms.Panel();
            this.FieldUserPanel = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLinkedin = new System.Windows.Forms.LinkLabel();
            this.linkInstagram = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.divInputs.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.divInputLogin.SuspendLayout();
            this.FieldUserPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::csharpito.Properties.Resources.studenth;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(428, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 681);
            this.panel2.TabIndex = 4;
            // 
            // ApplicationName
            // 
            this.ApplicationName.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(123)))), ((int)(((byte)(254)))));
            this.ApplicationName.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationName.Dock = System.Windows.Forms.DockStyle.Left;
            this.ApplicationName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplicationName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ApplicationName.LinkColor = System.Drawing.Color.Black;
            this.ApplicationName.Location = new System.Drawing.Point(70, 8);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ApplicationName.Size = new System.Drawing.Size(342, 81);
            this.ApplicationName.TabIndex = 1;
            this.ApplicationName.TabStop = true;
            this.ApplicationName.Text = "Newron";
            this.ApplicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplicationName.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conectar-se";
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkSignIn.Location = new System.Drawing.Point(118, 8);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(56, 13);
            this.linkSignIn.TabIndex = 1;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Faça login";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSingIn_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Já possui uma conta?";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.linkSignIn);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 64);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(8);
            this.panel5.Size = new System.Drawing.Size(426, 35);
            this.panel5.TabIndex = 1;
            // 
            // divInputs
            // 
            this.divInputs.Controls.Add(this.panel9);
            this.divInputs.Controls.Add(this.panel7);
            this.divInputs.Controls.Add(this.panel8);
            this.divInputs.Controls.Add(this.btnSubmit);
            this.divInputs.Controls.Add(this.divInputLogin);
            this.divInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.divInputs.Location = new System.Drawing.Point(0, 196);
            this.divInputs.Margin = new System.Windows.Forms.Padding(0);
            this.divInputs.Name = "divInputs";
            this.divInputs.Padding = new System.Windows.Forms.Padding(15, 60, 40, 0);
            this.divInputs.Size = new System.Drawing.Size(428, 414);
            this.divInputs.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.linkTerms);
            this.panel9.Controls.Add(this.checkBoxTerms);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(15, 273);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel9.Size = new System.Drawing.Size(373, 51);
            this.panel9.TabIndex = 12;
            // 
            // linkTerms
            // 
            this.linkTerms.AutoSize = true;
            this.linkTerms.Location = new System.Drawing.Point(116, 28);
            this.linkTerms.Margin = new System.Windows.Forms.Padding(0);
            this.linkTerms.Name = "linkTerms";
            this.linkTerms.Size = new System.Drawing.Size(93, 13);
            this.linkTerms.TabIndex = 1;
            this.linkTerms.TabStop = true;
            this.linkTerms.Text = "Termos e serviços";
            this.linkTerms.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTerms_LinkClicked);
            // 
            // checkBoxTerms
            // 
            this.checkBoxTerms.AutoSize = true;
            this.checkBoxTerms.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxTerms.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxTerms.Location = new System.Drawing.Point(0, 20);
            this.checkBoxTerms.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTerms.Name = "checkBoxTerms";
            this.checkBoxTerms.Size = new System.Drawing.Size(132, 31);
            this.checkBoxTerms.TabIndex = 0;
            this.checkBoxTerms.Text = "Aceite nossos termos";
            this.checkBoxTerms.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(15, 198);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel7.Size = new System.Drawing.Size(373, 75);
            this.panel7.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Window;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.txtPass);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 41);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5, 8, 5, 0);
            this.panel11.Size = new System.Drawing.Size(373, 32);
            this.panel11.TabIndex = 10;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(5, 8);
            this.txtPass.MaxLength = 255;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(361, 15);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WordWrap = false;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 20);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(15, 119);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel8.Size = new System.Drawing.Size(373, 79);
            this.panel8.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Window;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtEmail);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 41);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5, 8, 5, 0);
            this.panel10.Size = new System.Drawing.Size(373, 32);
            this.panel10.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(5, 8);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 15);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.WordWrap = false;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 20);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(15, 342);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 44);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "→";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // divInputLogin
            // 
            this.divInputLogin.Controls.Add(this.FieldUserPanel);
            this.divInputLogin.Controls.Add(this.loginLabel);
            this.divInputLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.divInputLogin.Location = new System.Drawing.Point(15, 60);
            this.divInputLogin.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.divInputLogin.Name = "divInputLogin";
            this.divInputLogin.Size = new System.Drawing.Size(373, 59);
            this.divInputLogin.TabIndex = 0;
            // 
            // FieldUserPanel
            // 
            this.FieldUserPanel.BackColor = System.Drawing.SystemColors.Window;
            this.FieldUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FieldUserPanel.Controls.Add(this.txtUser);
            this.FieldUserPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FieldUserPanel.Location = new System.Drawing.Point(0, 21);
            this.FieldUserPanel.Name = "FieldUserPanel";
            this.FieldUserPanel.Padding = new System.Windows.Forms.Padding(5, 8, 5, 0);
            this.FieldUserPanel.Size = new System.Drawing.Size(373, 32);
            this.FieldUserPanel.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(5, 8);
            this.txtUser.MaxLength = 255;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(361, 15);
            this.txtUser.TabIndex = 10;
            this.txtUser.WordWrap = false;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(0, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.loginLabel.Size = new System.Drawing.Size(54, 21);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.Text = "Usuário";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.linkLinkedin);
            this.panel6.Controls.Add(this.linkInstagram);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 621);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(16);
            this.panel6.Size = new System.Drawing.Size(428, 60);
            this.panel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(379, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label3.Size = new System.Drawing.Size(33, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "V1.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // linkLinkedin
            // 
            this.linkLinkedin.BackColor = System.Drawing.Color.Transparent;
            this.linkLinkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLinkedin.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("linkLinkedin.Image")));
            this.linkLinkedin.Location = new System.Drawing.Point(72, 16);
            this.linkLinkedin.MinimumSize = new System.Drawing.Size(32, 32);
            this.linkLinkedin.Name = "linkLinkedin";
            this.linkLinkedin.Size = new System.Drawing.Size(56, 32);
            this.linkLinkedin.TabIndex = 1;
            this.linkLinkedin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLinkedin.Click += new System.EventHandler(this.linkLinkedin_LinkClicked);
            // 
            // linkInstagram
            // 
            this.linkInstagram.BackColor = System.Drawing.Color.Transparent;
            this.linkInstagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkInstagram.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkInstagram.Image = ((System.Drawing.Image)(resources.GetObject("linkInstagram.Image")));
            this.linkInstagram.Location = new System.Drawing.Point(16, 16);
            this.linkInstagram.MinimumSize = new System.Drawing.Size(32, 32);
            this.linkInstagram.Name = "linkInstagram";
            this.linkInstagram.Size = new System.Drawing.Size(56, 32);
            this.linkInstagram.TabIndex = 0;
            this.linkInstagram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkInstagram.Click += new System.EventHandler(this.linkInstagram_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ApplicationName);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(428, 97);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::csharpito.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.divInputs);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(457, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 681);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 97);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1, 32, 1, 1);
            this.panel4.Size = new System.Drawing.Size(428, 99);
            this.panel4.TabIndex = 1;
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupPage";
            this.Text = "Cadastro - Newron";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.divInputs.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.divInputLogin.ResumeLayout(false);
            this.divInputLogin.PerformLayout();
            this.FieldUserPanel.ResumeLayout(false);
            this.FieldUserPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLinkedin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel ApplicationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel linkInstagram;
        private System.Windows.Forms.Panel divInputs;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel divInputLogin;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.LinkLabel linkTerms;
        private System.Windows.Forms.CheckBox checkBoxTerms;
        private System.Windows.Forms.Panel FieldUserPanel;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtEmail;
    }
}