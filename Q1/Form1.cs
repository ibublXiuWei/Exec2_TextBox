using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultbutton_Click(object sender, EventArgs e)
		{
			string txt;
			txt = numbertextBox.Text;
			try
			{
				GetInt(txt);
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GetInt(string txt)
		{
			bool isInt = int.TryParse(txt, out int data);
			if(isInt==false)
			{
				throw new Exception("請輸入數字");
			}
			if (data > 99 || data<1 )
			{
				MessageBox.Show("數值須介於1~99");
			}else
			{
				MessageBox.Show($"您輸入的是{data}");
			}
			return data;
		}
	}
}
