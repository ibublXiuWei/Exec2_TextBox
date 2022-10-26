namespace Q3
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
			this.label1 = new System.Windows.Forms.Label();
			this.yeartextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// resultbutton
			// 
			this.resultbutton.Location = new System.Drawing.Point(297, 75);
			this.resultbutton.Name = "resultbutton";
			this.resultbutton.Size = new System.Drawing.Size(75, 23);
			this.resultbutton.TabIndex = 0;
			this.resultbutton.Text = "確認";
			this.resultbutton.UseVisualStyleBackColor = true;
			this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(61, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "請輸入生日";
			// 
			// yeartextBox
			// 
			this.yeartextBox.Location = new System.Drawing.Point(129, 77);
			this.yeartextBox.Name = "yeartextBox";
			this.yeartextBox.Size = new System.Drawing.Size(125, 20);
			this.yeartextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 240);
			this.Controls.Add(this.yeartextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultbutton);
			this.Name = "Form1";
			this.Text = "是否年滿13歲";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox yeartextBox;
	}
}

