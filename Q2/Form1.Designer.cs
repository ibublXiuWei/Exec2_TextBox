namespace Q2
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
			this.datetextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// resultbutton
			// 
			this.resultbutton.Location = new System.Drawing.Point(292, 67);
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
			this.label1.Location = new System.Drawing.Point(62, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "輸入生日";
			// 
			// datetextBox
			// 
			this.datetextBox.Location = new System.Drawing.Point(123, 69);
			this.datetextBox.Name = "datetextBox";
			this.datetextBox.Size = new System.Drawing.Size(145, 20);
			this.datetextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "範例：2020/01/01";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 254);
			this.Controls.Add(this.datetextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.resultbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "檢查日期";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button resultbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox datetextBox;
		private System.Windows.Forms.Label label2;
	}
}

