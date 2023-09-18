namespace DTT_Tgz11_MSDT_Ignatenko
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			labelErrors.Text = "";
		}

		private void buttonRes_Click(object sender, EventArgs e)
		{
			int x = 0;
			bool validation = true;
			try
			{
				x = int.Parse(textBoxX.Text);
			} catch {
				labelErrors.Text = "В поле должно быть введено число!";
				validation = false;
			}
			if (validation)
			{
				labelErrors.Text = "";
				double lSide = Math.Pow(x, 5);
				double rSide = Math.Pow(x, 3);
				double tan = Math.Tan((rSide * 2) * (Math.PI / 180));
				double ctan = 1 / tan;
				double result = lSide * ctan;
				textBoxRes.Text = result.ToString();
			}
		}
	}
}