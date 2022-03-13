using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Week_2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_proses_Click(object sender, EventArgs e)
		{
			LabelOutput.Text = TextInput.Text;
		}
		private void TextInput_TextChanged(object sender, EventArgs e)
		{
			if (TextInput.Text == "HIDE")
			{
				LabelOutput.Hide();
			}
			else if (TextInput.Text == "SHOWN")
			{
				LabelOutput.Show();
			}
			else if (TextInput.Text == "WARNA: MERAH")
			{
				LabelOutput.ForeColor = Color.Red;
			}
			else if (TextInput.Text == "WARNA: HIJAU")
			{
				LabelOutput.ForeColor = Color.Green;
			}
			else if (TextInput.Text == "WARNA: BIRU")
			{
				LabelOutput.ForeColor = Color.Blue;
			}
			else if (TextInput.Text == "WARNA: DEFAULT")
			{
				LabelOutput.ForeColor = Color.Black;
			}
			else if (TextInput.Text == "RESTART")
			{
				LabelOutput.Text = "EMPTY";
				LabelOutput.ForeColor = Color.Black;
			}
		}
		private void LabelOutput_Click(object sender, EventArgs e)
		{
			
		}
	}
}
