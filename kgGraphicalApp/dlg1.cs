using System;
using System.Windows.Forms;

namespace kgGraphicalApp
{
	public partial class Dlg1 : Form
	{
		public float OriginX { get; private set; }
		public float OriginY { get; private set; }
		public float DestinationX { get; private set; }
		public float DestinationY { get; private set; }

		private readonly Action<Dlg1> _callBackMethod;
		public Dlg1(Action<Dlg1> callbackMethod)
		{
			_callBackMethod = callbackMethod;
			InitializeComponent();
		}

		private void OriginXNumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			OriginX = Decimal.ToSingle(OriginXNumericUpDown1.Value);
			_callBackMethod(this);
		}

		private void OriginYNumericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			OriginY = Decimal.ToSingle(OriginYNumericUpDown2.Value);
			_callBackMethod(this);
			
		}

		private void DestinationXNumericUpDown3_ValueChanged(object sender, EventArgs e)
		{
			DestinationX = Decimal.ToSingle(DestinationXNumericUpDown3.Value);
			_callBackMethod(this);
		}

		private void DestinationYNumericUpDown4_ValueChanged(object sender, EventArgs e)
		{
			DestinationY = Decimal.ToSingle(DestinationYNumericUpDown4.Value);
			_callBackMethod(this);
		}

		private void DrawButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			_callBackMethod(this);
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}