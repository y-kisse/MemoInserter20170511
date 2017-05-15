namespace MemoInserter20170511
{
    partial class MemosInserter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.indexLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.successTextBox = new System.Windows.Forms.RichTextBox();
            this.failedLabel = new System.Windows.Forms.Label();
            this.failedTextBox = new System.Windows.Forms.RichTextBox();
            this.errorCodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fileNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(81, 16);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "File name...";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.startButton.Location = new System.Drawing.Point(12, 37);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start inserting";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.indexLabel.Location = new System.Drawing.Point(162, 44);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(103, 16);
            this.indexLabel.TabIndex = 2;
            this.indexLabel.Text = "inserting index";
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.successLabel.Location = new System.Drawing.Point(12, 76);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(160, 16);
            this.successLabel.TabIndex = 3;
            this.successLabel.Text = "Success inserting data";
            // 
            // successTextBox
            // 
            this.successTextBox.Location = new System.Drawing.Point(12, 95);
            this.successTextBox.Name = "successTextBox";
            this.successTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.successTextBox.Size = new System.Drawing.Size(450, 150);
            this.successTextBox.TabIndex = 4;
            this.successTextBox.Text = "";
            // 
            // failedLabel
            // 
            this.failedLabel.AutoSize = true;
            this.failedLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.failedLabel.Location = new System.Drawing.Point(9, 257);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(143, 16);
            this.failedLabel.TabIndex = 5;
            this.failedLabel.Text = "Failed inserting data";
            // 
            // failedTextBox
            // 
            this.failedTextBox.Location = new System.Drawing.Point(12, 276);
            this.failedTextBox.Name = "failedTextBox";
            this.failedTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.failedTextBox.Size = new System.Drawing.Size(450, 150);
            this.failedTextBox.TabIndex = 6;
            this.failedTextBox.Text = "";
            // 
            // errorCodeLabel
            // 
            this.errorCodeLabel.AutoSize = true;
            this.errorCodeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.errorCodeLabel.Location = new System.Drawing.Point(12, 436);
            this.errorCodeLabel.Name = "errorCodeLabel";
            this.errorCodeLabel.Size = new System.Drawing.Size(89, 16);
            this.errorCodeLabel.TabIndex = 7;
            this.errorCodeLabel.Text = "Error code...";
            // 
            // MemosInserter
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.errorCodeLabel);
            this.Controls.Add(this.failedTextBox);
            this.Controls.Add(this.failedLabel);
            this.Controls.Add(this.successTextBox);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.fileNameLabel);
            this.Name = "MemosInserter";
            this.Text = "MemosInserter";
            this.Load += new System.EventHandler(this.MemosInserter_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MemosInserter_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MemosInserter_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.RichTextBox successTextBox;
        private System.Windows.Forms.Label failedLabel;
        private System.Windows.Forms.RichTextBox failedTextBox;
        private System.Windows.Forms.Label errorCodeLabel;
    }
}

