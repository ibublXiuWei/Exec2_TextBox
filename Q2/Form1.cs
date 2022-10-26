using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultbutton_Click(object sender, EventArgs e)
		{
			string birth = datetextBox.Text;
			DateTime check;
			try
			{
				check=GetBirth(birth);
				GetCheck(check);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void GetCheck(DateTime check)
		{
			if (check > DateTime.Today)
			{
				MessageBox.Show("日期不可超過今天");
			}
			else
			{
				 MessageBox.Show($"您的生日是{check}");
			}
			return;
		}
		private DateTime GetBirth(string birth)
		{
			bool isDate=DateTime.TryParse(birth,out DateTime dt);
			return (!isDate)?  throw new Exception("請輸入正確日期") : dt;

			//if(isDate==false)
			//{
			//	throw new Exception("請輸入正確日期");
			//} return dt;
		}
	}
}
