using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StrategyPattern;

namespace Strategy {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private double total = 0.0;
		private void btnOK_Click(object sender, EventArgs e) {

			CashContext context = new CashContext(methodSelect.SelectedItem.ToString());
			sumPrice.Text=context.GetResult(double.Parse(txtNum.Text)*double.Parse(txtPrice.Text)).ToString();


		}

		private void Form1_Load(object sender, EventArgs e) {
			methodSelect.Items.AddRange(new object[]{"normal","return","rebate"});
			methodSelect.SelectedIndex = 0;
		}
	}
}
