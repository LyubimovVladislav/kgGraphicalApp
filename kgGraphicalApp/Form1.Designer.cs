namespace kgGraphicalApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.ClearButton = new System.Windows.Forms.Button();
			this.MiddlePointClipButton = new System.Windows.Forms.RadioButton();
			this.CohenSutherlandClipButton = new System.Windows.Forms.RadioButton();
			this.CyrusBeckClipButton = new System.Windows.Forms.RadioButton();
			this.BezierCurveButton = new System.Windows.Forms.RadioButton();
			this.BresenhamCircleButton = new System.Windows.Forms.RadioButton();
			this.nonIntegerEndAlgorythmButton = new System.Windows.Forms.RadioButton();
			this.BresenhamAlgorithmButton = new System.Windows.Forms.RadioButton();
			this.ddaAlgorythmButton = new System.Windows.Forms.RadioButton();
			this.paintArea = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.paintArea)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.ClearButton);
			this.panel1.Controls.Add(this.MiddlePointClipButton);
			this.panel1.Controls.Add(this.CohenSutherlandClipButton);
			this.panel1.Controls.Add(this.CyrusBeckClipButton);
			this.panel1.Controls.Add(this.BezierCurveButton);
			this.panel1.Controls.Add(this.BresenhamCircleButton);
			this.panel1.Controls.Add(this.nonIntegerEndAlgorythmButton);
			this.panel1.Controls.Add(this.BresenhamAlgorithmButton);
			this.panel1.Controls.Add(this.ddaAlgorythmButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 123);
			this.panel1.TabIndex = 1;
			// 
			// ClearButton
			// 
			this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.ClearButton.Location = new System.Drawing.Point(872, 12);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(100, 100);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Очистить экран";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// MiddlePointClipButton
			// 
			this.MiddlePointClipButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.MiddlePointClipButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Middle_point_icon;
			this.MiddlePointClipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MiddlePointClipButton.Location = new System.Drawing.Point(754, 12);
			this.MiddlePointClipButton.Name = "MiddlePointClipButton";
			this.MiddlePointClipButton.Size = new System.Drawing.Size(100, 100);
			this.MiddlePointClipButton.TabIndex = 7;
			this.MiddlePointClipButton.UseVisualStyleBackColor = true;
			this.MiddlePointClipButton.CheckedChanged += new System.EventHandler(this.MiddlePointClipButton_CheckedChanged);
			this.MiddlePointClipButton.Click += new System.EventHandler(this.MiddlePointClipButton_Click);
			// 
			// CohenSutherlandClipButton
			// 
			this.CohenSutherlandClipButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.CohenSutherlandClipButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Cohen_Sutherland_icon;
			this.CohenSutherlandClipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CohenSutherlandClipButton.Location = new System.Drawing.Point(648, 12);
			this.CohenSutherlandClipButton.Name = "CohenSutherlandClipButton";
			this.CohenSutherlandClipButton.Size = new System.Drawing.Size(100, 100);
			this.CohenSutherlandClipButton.TabIndex = 6;
			this.CohenSutherlandClipButton.UseVisualStyleBackColor = true;
			this.CohenSutherlandClipButton.CheckedChanged += new System.EventHandler(this.CohenSutherlandClipButton_CheckedChanged);
			this.CohenSutherlandClipButton.Click += new System.EventHandler(this.CohenSutherlandClipButton_Click);
			// 
			// CyrusBeckClipButton
			// 
			this.CyrusBeckClipButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.CyrusBeckClipButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Cyrus_Beck_icon1;
			this.CyrusBeckClipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.CyrusBeckClipButton.Location = new System.Drawing.Point(542, 12);
			this.CyrusBeckClipButton.Name = "CyrusBeckClipButton";
			this.CyrusBeckClipButton.Size = new System.Drawing.Size(100, 100);
			this.CyrusBeckClipButton.TabIndex = 5;
			this.CyrusBeckClipButton.UseVisualStyleBackColor = true;
			this.CyrusBeckClipButton.CheckedChanged += new System.EventHandler(this.CyrusBeckClipButton_CheckedChanged);
			this.CyrusBeckClipButton.Click += new System.EventHandler(this.CyrusBeckClipButton_Click);
			// 
			// BezierCurveButton
			// 
			this.BezierCurveButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.BezierCurveButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.bezier_curve_icon;
			this.BezierCurveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BezierCurveButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BezierCurveButton.Location = new System.Drawing.Point(436, 12);
			this.BezierCurveButton.Name = "BezierCurveButton";
			this.BezierCurveButton.Size = new System.Drawing.Size(100, 100);
			this.BezierCurveButton.TabIndex = 4;
			this.BezierCurveButton.UseVisualStyleBackColor = true;
			this.BezierCurveButton.CheckedChanged += new System.EventHandler(this.BezierCurveButton_CheckedChanged);
			this.BezierCurveButton.Click += new System.EventHandler(this.BezierCurveButton_Click);
			// 
			// BresenhamCircleButton
			// 
			this.BresenhamCircleButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.BresenhamCircleButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Circle_icon;
			this.BresenhamCircleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BresenhamCircleButton.Location = new System.Drawing.Point(330, 12);
			this.BresenhamCircleButton.Name = "BresenhamCircleButton";
			this.BresenhamCircleButton.Size = new System.Drawing.Size(100, 100);
			this.BresenhamCircleButton.TabIndex = 3;
			this.BresenhamCircleButton.UseVisualStyleBackColor = true;
			this.BresenhamCircleButton.Click += new System.EventHandler(this.BresenhamCircleButton_Click);
			// 
			// nonIntegerEndAlgorythmButton
			// 
			this.nonIntegerEndAlgorythmButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.nonIntegerEndAlgorythmButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.non_integer_end_coordinates_icon1;
			this.nonIntegerEndAlgorythmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.nonIntegerEndAlgorythmButton.Location = new System.Drawing.Point(224, 12);
			this.nonIntegerEndAlgorythmButton.Name = "nonIntegerEndAlgorythmButton";
			this.nonIntegerEndAlgorythmButton.Size = new System.Drawing.Size(100, 100);
			this.nonIntegerEndAlgorythmButton.TabIndex = 2;
			this.nonIntegerEndAlgorythmButton.UseVisualStyleBackColor = true;
			this.nonIntegerEndAlgorythmButton.Click += new System.EventHandler(this.NonIntegerEndAlgorithmButton_Click);
			// 
			// BresenhamAlgorithmButton
			// 
			this.BresenhamAlgorithmButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.BresenhamAlgorithmButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Bresenham_line_algorithm_icon1;
			this.BresenhamAlgorithmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BresenhamAlgorithmButton.Location = new System.Drawing.Point(118, 12);
			this.BresenhamAlgorithmButton.Name = "BresenhamAlgorithmButton";
			this.BresenhamAlgorithmButton.Size = new System.Drawing.Size(100, 100);
			this.BresenhamAlgorithmButton.TabIndex = 1;
			this.BresenhamAlgorithmButton.UseVisualStyleBackColor = true;
			this.BresenhamAlgorithmButton.Click += new System.EventHandler(this.BresenhamAlgorithmButton_Click);
			// 
			// ddaAlgorythmButton
			// 
			this.ddaAlgorythmButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.ddaAlgorythmButton.BackgroundImage = global::kgGraphicalApp.Properties.Resources.Line_DDa_icon;
			this.ddaAlgorythmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ddaAlgorythmButton.Checked = true;
			this.ddaAlgorythmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.ddaAlgorythmButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
			this.ddaAlgorythmButton.Location = new System.Drawing.Point(12, 12);
			this.ddaAlgorythmButton.Name = "ddaAlgorythmButton";
			this.ddaAlgorythmButton.Size = new System.Drawing.Size(100, 100);
			this.ddaAlgorythmButton.TabIndex = 0;
			this.ddaAlgorythmButton.TabStop = true;
			this.ddaAlgorythmButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ddaAlgorythmButton.UseVisualStyleBackColor = true;
			this.ddaAlgorythmButton.Click += new System.EventHandler(this.DdaAlgorithmButton_Click);
			// 
			// paintArea
			// 
			this.paintArea.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.paintArea.BackColor = System.Drawing.Color.White;
			this.paintArea.Cursor = System.Windows.Forms.Cursors.Cross;
			this.paintArea.Location = new System.Drawing.Point(0, 129);
			this.paintArea.Name = "paintArea";
			this.paintArea.Size = new System.Drawing.Size(984, 631);
			this.paintArea.TabIndex = 2;
			this.paintArea.TabStop = false;
			this.paintArea.Paint += new System.Windows.Forms.PaintEventHandler(this.paintArea_Paint);
			this.paintArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseDown);
			this.paintArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseMove);
			this.paintArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintArea_MouseUp);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 761);
			this.Controls.Add(this.paintArea);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(990, 500);
			this.Name = "Form1";
			this.Text = "Graphical app";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.paintArea)).EndInit();
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.RadioButton MiddlePointClipButton;

		private System.Windows.Forms.RadioButton CohenSutherlandClipButton;

		private System.Windows.Forms.Button ClearButton;

		private System.Windows.Forms.RadioButton CyrusBeckClipButton;

		private System.Windows.Forms.RadioButton BresenhamCircleButton;
		private System.Windows.Forms.RadioButton BezierCurveButton;
		

		private System.Windows.Forms.PictureBox paintArea;
		

		private System.Windows.Forms.RadioButton nonIntegerEndAlgorythmButton;

		private System.Windows.Forms.RadioButton BresenhamAlgorithmButton;

		private System.Windows.Forms.RadioButton ddaAlgorythmButton;

		private System.Windows.Forms.Panel panel1;

		#endregion
	}
}