namespace DTT_Tgz11_MSDT_Ignatenko
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			pictureBox1 = new PictureBox();
			textBoxX = new TextBox();
			label1 = new Label();
			buttonRes = new Button();
			textBoxRes = new TextBox();
			label2 = new Label();
			label3 = new Label();
			labelErrors = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(110, 45);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(152, 48);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// textBoxX
			// 
			textBoxX.Location = new Point(168, 115);
			textBoxX.Name = "textBoxX";
			textBoxX.Size = new Size(100, 23);
			textBoxX.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(128, 118);
			label1.Name = "label1";
			label1.Size = new Size(34, 20);
			label1.TabIndex = 2;
			label1.Text = "X =";
			// 
			// buttonRes
			// 
			buttonRes.Location = new Point(168, 173);
			buttonRes.Name = "buttonRes";
			buttonRes.Size = new Size(94, 47);
			buttonRes.TabIndex = 3;
			buttonRes.Text = "Рассчитать результат";
			buttonRes.UseVisualStyleBackColor = true;
			buttonRes.Click += buttonRes_Click;
			// 
			// textBoxRes
			// 
			textBoxRes.Location = new Point(168, 144);
			textBoxRes.Name = "textBoxRes";
			textBoxRes.ReadOnly = true;
			textBoxRes.Size = new Size(100, 23);
			textBoxRes.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(83, 144);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 2;
			label2.Text = "Результат";
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			label3.Location = new Point(343, 45);
			label3.Name = "label3";
			label3.Size = new Size(367, 66);
			label3.TabIndex = 2;
			label3.Text = "Практическая работа №1 по современным инструментам разработки программного обеспечения. Разработал студент группы ТЦТ-Tgz11 Игнатенко Н.А.";
			// 
			// labelErrors
			// 
			labelErrors.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			labelErrors.ForeColor = Color.Red;
			labelErrors.Location = new Point(343, 144);
			labelErrors.Name = "labelErrors";
			labelErrors.Size = new Size(367, 66);
			labelErrors.TabIndex = 2;
			labelErrors.Text = "ERROR MESSAGES";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(787, 237);
			Controls.Add(buttonRes);
			Controls.Add(labelErrors);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxRes);
			Controls.Add(textBoxX);
			Controls.Add(pictureBox1);
			Name = "Form1";
			Text = "Игнатенко Н.А.";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox textBoxX;
		private Label label1;
		private Button buttonRes;
		private TextBox textBoxRes;
		private Label label2;
		private Label label3;
		private Label labelErrors;
	}
}