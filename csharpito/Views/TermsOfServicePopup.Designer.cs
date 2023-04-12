namespace csharpito
{
    partial class TermsOfServicePopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsOfServicePopup));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.TermsTitle = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.btnCloseTerms = new System.Windows.Forms.Button();
            this.checkBoxTerms = new System.Windows.Forms.CheckBox();
            this.TermsTextPanel = new System.Windows.Forms.Panel();
            this.txtPanelText = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TermsTextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TermsTitle);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(10, 10);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(15);
            this.TopPanel.Size = new System.Drawing.Size(438, 55);
            this.TopPanel.TabIndex = 0;
            // 
            // TermsTitle
            // 
            this.TermsTitle.AutoSize = true;
            this.TermsTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.TermsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsTitle.Location = new System.Drawing.Point(15, 15);
            this.TermsTitle.Name = "TermsTitle";
            this.TermsTitle.Size = new System.Drawing.Size(159, 25);
            this.TermsTitle.TabIndex = 0;
            this.TermsTitle.Text = "Termos e serviços";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.btnCloseTerms);
            this.BottomPanel.Controls.Add(this.checkBoxTerms);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(10, 508);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BottomPanel.Size = new System.Drawing.Size(438, 43);
            this.BottomPanel.TabIndex = 1;
            // 
            // btnCloseTerms
            // 
            this.btnCloseTerms.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseTerms.Location = new System.Drawing.Point(353, 10);
            this.btnCloseTerms.Margin = new System.Windows.Forms.Padding(0);
            this.btnCloseTerms.Name = "btnCloseTerms";
            this.btnCloseTerms.Size = new System.Drawing.Size(75, 23);
            this.btnCloseTerms.TabIndex = 1;
            this.btnCloseTerms.Text = "Fechar";
            this.btnCloseTerms.UseVisualStyleBackColor = true;
            this.btnCloseTerms.Click += new System.EventHandler(this.btnCloseTerms_Click);
            // 
            // checkBoxTerms
            // 
            this.checkBoxTerms.AutoSize = true;
            this.checkBoxTerms.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkBoxTerms.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTerms.Location = new System.Drawing.Point(10, 10);
            this.checkBoxTerms.Name = "checkBoxTerms";
            this.checkBoxTerms.Size = new System.Drawing.Size(190, 23);
            this.checkBoxTerms.TabIndex = 0;
            this.checkBoxTerms.Text = "Lí e aceito os termos de serviço";
            this.checkBoxTerms.UseVisualStyleBackColor = true;
            this.checkBoxTerms.CheckedChanged += new System.EventHandler(this.checkBoxTerms_CheckedChanged);
            // 
            // TermsTextPanel
            // 
            this.TermsTextPanel.AutoScroll = true;
            this.TermsTextPanel.AutoScrollMargin = new System.Drawing.Size(0, 5);
            this.TermsTextPanel.AutoSize = true;
            this.TermsTextPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TermsTextPanel.Controls.Add(this.txtPanelText);
            this.TermsTextPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TermsTextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TermsTextPanel.Location = new System.Drawing.Point(10, 65);
            this.TermsTextPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TermsTextPanel.Name = "TermsTextPanel";
            this.TermsTextPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.TermsTextPanel.Size = new System.Drawing.Size(438, 443);
            this.TermsTextPanel.TabIndex = 2;
            // 
            // txtPanelText
            // 
            this.txtPanelText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPanelText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPanelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPanelText.Location = new System.Drawing.Point(5, 5);
            this.txtPanelText.Margin = new System.Windows.Forms.Padding(5);
            this.txtPanelText.Multiline = true;
            this.txtPanelText.Name = "txtPanelText";
            this.txtPanelText.ReadOnly = true;
            this.txtPanelText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPanelText.Size = new System.Drawing.Size(433, 438);
            this.txtPanelText.TabIndex = 0;
            this.txtPanelText.Text = resources.GetString("txtPanelText.Text");
            this.txtPanelText.TextChanged += new System.EventHandler(this.txtPanelText_TextChanged);
            // 
            // TermsOfServicePopup
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 561);
            this.Controls.Add(this.TermsTextPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TermsOfServicePopup";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TermsOfServicePopup";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TermsTextPanel.ResumeLayout(false);
            this.TermsTextPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label TermsTitle;
        private System.Windows.Forms.Button btnCloseTerms;
        private System.Windows.Forms.CheckBox checkBoxTerms;
        private System.Windows.Forms.Panel TermsTextPanel;
        private System.Windows.Forms.TextBox txtPanelText;
    }
}