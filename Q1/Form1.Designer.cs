namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.resultbutton = new System.Windows.Forms.Button();
			this.numbertextBox = new System.Windows.Forms.TextBox();
			this.numberlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultbutton
			// 
			this.resultbutton.Location = new System.Drawing.Point(121, 139);
			this.resultbutton.Name = "resultbutton";
			this.resultbutton.Size = new System.Drawing.Size(75, 23);
			this.resultbutton.TabIndex = 0;
			this.resultbutton.Text = "確認";
			this.resultbutton.UseVisualStyleBackColor = true;
			this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
			// 
			// numbertextBox
			// 
			this.numbertextBox.Location = new System.Drawing.Point(106, 90);
			this.numbertextBox.Name = "numbertextBox";
			this.numbertextBox.Size = new System.Drawing.Size(100, 20);
			this.numbertextBox.TabIndex = 1;
			// 
			// numberlabel
			// 
			this.numberlabel.AutoSize = true;
			this.numberlabel.Location = new System.Drawing.Point(42, 93);
			this.numberlabel.Name = "numberlabel";
			this.numberlabel.Size = new System.Drawing.Size(58, 13);
			this.numberlabel.TabIndex = 2;
			this.numberlabel.Text = "輸入數字:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 282);
			this.Controls.Add(this.numberlabel);
			this.Controls.Add(this.numbertextBox);
			this.Controls.Add(this.resultbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "輸入1~99的數";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultbutton;
		private System.Windows.Forms.TextBox numbertextBox;
		private System.Windows.Forms.Label numberlabel;
	}
}

