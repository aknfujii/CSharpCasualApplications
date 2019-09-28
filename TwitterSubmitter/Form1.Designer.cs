namespace TwitterSubmitter
{
    partial class FormTwitterPost
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.butAuthorize = new System.Windows.Forms.Button();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.butPIN = new System.Windows.Forms.Button();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.butTweet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAuthorize
            // 
            this.butAuthorize.Location = new System.Drawing.Point(28, 26);
            this.butAuthorize.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.butAuthorize.Name = "butAuthorize";
            this.butAuthorize.Size = new System.Drawing.Size(258, 46);
            this.butAuthorize.TabIndex = 0;
            this.butAuthorize.Text = "Connect Twitter";
            this.butAuthorize.UseVisualStyleBackColor = true;
            this.butAuthorize.Click += new System.EventHandler(this.butAuthorize_Click);
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(28, 106);
            this.txtPIN.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '*';
            this.txtPIN.Size = new System.Drawing.Size(253, 31);
            this.txtPIN.TabIndex = 1;
            // 
            // butPIN
            // 
            this.butPIN.Location = new System.Drawing.Point(310, 102);
            this.butPIN.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.butPIN.Name = "butPIN";
            this.butPIN.Size = new System.Drawing.Size(163, 46);
            this.butPIN.TabIndex = 2;
            this.butPIN.Text = "PIN";
            this.butPIN.UseVisualStyleBackColor = true;
            this.butPIN.Click += new System.EventHandler(this.butPIN_Click);
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(26, 174);
            this.txtTweet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTweet.Multiline = true;
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(442, 258);
            this.txtTweet.TabIndex = 3;
            // 
            // butTweet
            // 
            this.butTweet.Location = new System.Drawing.Point(312, 470);
            this.butTweet.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.butTweet.Name = "butTweet";
            this.butTweet.Size = new System.Drawing.Size(163, 46);
            this.butTweet.TabIndex = 2;
            this.butTweet.Text = "Tweet";
            this.butTweet.UseVisualStyleBackColor = true;
            this.butTweet.Click += new System.EventHandler(this.butTweet_Click);
            // 
            // FormTwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 540);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.butTweet);
            this.Controls.Add(this.butPIN);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.butAuthorize);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FormTwitterPost";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAuthorize;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button butPIN;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button butTweet;
    }
}

