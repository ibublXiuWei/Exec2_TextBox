namespace Q4
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
			this.label1 = new System.Windows.Forms.Label();
			this.Calcbutton = new System.Windows.Forms.Button();
			this.PersontextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CartextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.personlabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Carlabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Sumlabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數：";
			// 
			// Calcbutton
			// 
			this.Calcbutton.Location = new System.Drawing.Point(260, 111);
			this.Calcbutton.Name = "Calcbutton";
			this.Calcbutton.Size = new System.Drawing.Size(75, 21);
			this.Calcbutton.TabIndex = 2;
			this.Calcbutton.Text = "計算";
			this.Calcbutton.UseVisualStyleBackColor = true;
			this.Calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
			// 
			// PersontextBox
			// 
			this.PersontextBox.Location = new System.Drawing.Point(73, 44);
			this.PersontextBox.Name = "PersontextBox";
			this.PersontextBox.Size = new System.Drawing.Size(100, 22);
			this.PersontextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(194, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "車輛：";
			// 
			// CartextBox
			// 
			this.CartextBox.Location = new System.Drawing.Point(235, 44);
			this.CartextBox.Name = "CartextBox";
			this.CartextBox.Size = new System.Drawing.Size(100, 22);
			this.CartextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 195);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "人";
			// 
			// personlabel
			// 
			this.personlabel.AutoSize = true;
			this.personlabel.Location = new System.Drawing.Point(68, 195);
			this.personlabel.Name = "personlabel";
			this.personlabel.Size = new System.Drawing.Size(58, 12);
			this.personlabel.TabIndex = 0;
			this.personlabel.Text = "personlabel";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(148, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(17, 12);
			this.label5.TabIndex = 0;
			this.label5.Text = "車";
			// 
			// Carlabel
			// 
			this.Carlabel.AutoSize = true;
			this.Carlabel.Location = new System.Drawing.Point(173, 195);
			this.Carlabel.Name = "Carlabel";
			this.Carlabel.Size = new System.Drawing.Size(41, 12);
			this.Carlabel.TabIndex = 0;
			this.Carlabel.Text = "carlabel";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(250, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 0;
			this.label4.Text = "共計";
			// 
			// Sumlabel
			// 
			this.Sumlabel.AutoSize = true;
			this.Sumlabel.Location = new System.Drawing.Point(287, 195);
			this.Sumlabel.Name = "Sumlabel";
			this.Sumlabel.Size = new System.Drawing.Size(46, 12);
			this.Sumlabel.TabIndex = 0;
			this.Sumlabel.Text = "sumlabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 346);
			this.Controls.Add(this.CartextBox);
			this.Controls.Add(this.PersontextBox);
			this.Controls.Add(this.Sumlabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Carlabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.personlabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Calcbutton);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "計算入場費用";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Calcbutton;
		private System.Windows.Forms.TextBox PersontextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CartextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label personlabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Carlabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Sumlabel;
	}
}

