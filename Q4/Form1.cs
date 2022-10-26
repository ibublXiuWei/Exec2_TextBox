using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Carlabel.Text = String.Empty;
			personlabel.Text = String.Empty;
			Sumlabel.Text=String.Empty;
		}

		private void Calcbutton_Click(object sender, EventArgs e)
		{
			string personnumber=PersontextBox.Text;
			string carnumber=CartextBox.Text;

			//取繳款總額
			try
			{
				Sumlabel.Text = Convert.ToString(GetSum(carnumber, personnumber));
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int GetSum(string carnumber, string personnumber)
		{
			bool isInt1 = int.TryParse(carnumber, out int sum1);
			const int cars = 200;
			int car = sum1 * cars;

			bool isInt2 = int.TryParse(personnumber, out int sum2);
			const int persons = 60;
			int person = sum2 * persons;
			int sum = car + person;
			//int sum = (car<person)?car :person;

			if (isInt1  && isInt2)
			{
				personlabel.Text =Convert.ToString(person) ;
				Carlabel.Text = Convert.ToString(car);
			}
			else if (!isInt1 && !isInt2)
			{
				throw new Exception("請輸入數量");
			}
			else
			{
				throw new Exception("您少填寫付款資訊");
			}
			return sum ;
		}
	}
}
