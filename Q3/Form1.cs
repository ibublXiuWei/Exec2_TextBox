using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void resultbutton_Click(object sender, EventArgs e)
		{
			string birth = yeartextBox.Text;
			DateTime old;
			 
			try
			{
				old = GetBirth(birth);
				CheckOld(old);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}	

		private int CheckOld(DateTime old)
		{
				int result = TryParse(DateTime.Today)- TryParse(old);
				if (result>= 13)
				{
				throw new Exception($"您的年齡是{result}大於13歲,符合資格");
				}
				else
				{
				throw new Exception("您的年紀小於13歲不符合資格");
				}
				return result;
		}

		private int TryParse(DateTime old)
		{
			string year;
			year = old.ToString("yyyy");
			int.TryParse(year, out int result);
			return ( result);
		}

		private DateTime GetBirth(string dt)
		{
			bool isDate=DateTime.TryParse(dt,out DateTime birth);
			if(!isDate || birth > DateTime.Today)
			{
				throw new Exception("請輸入正確日期");
			}
			return birth;	
		}
	}
}
