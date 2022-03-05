namespace modul2_1302204081
{
	public partial class Form1 : Form
	{
		double[] angka = new double[10];
		string input = string.Empty;
		int i = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "3";
			}
			else
			{
				label1.Text = label1.Text + "3";
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "0";
			}
			else
			{
				label1.Text = label1.Text + "0";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (label1.Text=="0" && label1.Text!= null)
			{
				label1.Text = "1";
			}
			else
			{
				label1.Text = label1.Text + "1";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "2";
			}
			else
			{
				label1.Text = label1.Text + "2";
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "4";
			}
			else
			{
				label1.Text = label1.Text + "4";
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "5";
			}
			else
			{
				label1.Text = label1.Text + "5";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "6";
			}
			else
			{
				label1.Text = label1.Text + "6";
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "7";
			}
			else
			{
				label1.Text = label1.Text + "7";
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "8";
			}
			else
			{
				label1.Text = label1.Text + "8";
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (label1.Text == "0" && label1.Text != null)
			{
				label1.Text = "9";
			}
			else
			{
				label1.Text = label1.Text + "9x	";
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{	
			
			angka[i] = Convert.ToDouble(label1.Text);
			label1.Text = "0";
			i++;

		}

		private void equal_Click(object sender, EventArgs e)
		{
			double secondNumber;
			double totalArray = 0;
			double result;
			secondNumber = Convert.ToDouble(label1.Text);
			for (int j = 0; j < i; j++)
			{
				totalArray = totalArray + angka[j];
			}
			result = totalArray + secondNumber;
			label1.Text = Convert.ToString(result);
			i = 0;
		}
	}
}