namespace StickyNote
{
    partial class FormFusen
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
            this.textFusenMemo = new System.Windows.Forms.TextBox();
            this.colorDialogFusen = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // textFusenMemo
            // 
            this.textFusenMemo.BackColor = System.Drawing.Color.LemonChiffon;
            this.textFusenMemo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textFusenMemo.Font = new System.Drawing.Font("ＭＳ ゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textFusenMemo.Location = new System.Drawing.Point(0, 0);
            this.textFusenMemo.Multiline = true;
            this.textFusenMemo.Name = "textFusenMemo";
            this.textFusenMemo.Size = new System.Drawing.Size(574, 450);
            this.textFusenMemo.TabIndex = 0;
            this.textFusenMemo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textFusenMemo_KeyDown);
            this.textFusenMemo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseDoubleClick);
            this.textFusenMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseDown);
            this.textFusenMemo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textFusenMemo_MouseMove);
            // 
            // FormFusen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.textFusenMemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFusen";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFusenMemo;
        private System.Windows.Forms.ColorDialog colorDialogFusen;
    }
}

