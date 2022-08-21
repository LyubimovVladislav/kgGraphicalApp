using System.ComponentModel;

namespace kgGraphicalApp
{
	partial class Dlg1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.OriginXNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.OriginYNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.DestinationXNumericUpDown3 = new System.Windows.Forms.NumericUpDown();
			this.DestinationYNumericUpDown4 = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.DrawButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.OriginXNumericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.OriginYNumericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.DestinationXNumericUpDown3)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.DestinationYNumericUpDown4)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// OriginXNumericUpDown1
			// 
			this.OriginXNumericUpDown1.DecimalPlaces = 2;
			this.OriginXNumericUpDown1.Increment = new decimal(new int[] {1, 0, 0, 65536});
			this.OriginXNumericUpDown1.Location = new System.Drawing.Point(33, 25);
			this.OriginXNumericUpDown1.Maximum = new decimal(new int[] {1920, 0, 0, 0});
			this.OriginXNumericUpDown1.Name = "OriginXNumericUpDown1";
			this.OriginXNumericUpDown1.Size = new System.Drawing.Size(86, 20);
			this.OriginXNumericUpDown1.TabIndex = 0;
			this.OriginXNumericUpDown1.ValueChanged += new System.EventHandler(this.OriginXNumericUpDown1_ValueChanged);
			// 
			// OriginYNumericUpDown2
			// 
			this.OriginYNumericUpDown2.DecimalPlaces = 2;
			this.OriginYNumericUpDown2.Increment = new decimal(new int[] {1, 0, 0, 65536});
			this.OriginYNumericUpDown2.Location = new System.Drawing.Point(33, 59);
			this.OriginYNumericUpDown2.Maximum = new decimal(new int[] {1280, 0, 0, 0});
			this.OriginYNumericUpDown2.Name = "OriginYNumericUpDown2";
			this.OriginYNumericUpDown2.Size = new System.Drawing.Size(86, 20);
			this.OriginYNumericUpDown2.TabIndex = 1;
			this.OriginYNumericUpDown2.ValueChanged += new System.EventHandler(this.OriginYNumericUpDown2_ValueChanged);
			// 
			// DestinationXNumericUpDown3
			// 
			this.DestinationXNumericUpDown3.DecimalPlaces = 2;
			this.DestinationXNumericUpDown3.Increment = new decimal(new int[] {1, 0, 0, 65536});
			this.DestinationXNumericUpDown3.Location = new System.Drawing.Point(33, 27);
			this.DestinationXNumericUpDown3.Maximum = new decimal(new int[] {1920, 0, 0, 0});
			this.DestinationXNumericUpDown3.Name = "DestinationXNumericUpDown3";
			this.DestinationXNumericUpDown3.Size = new System.Drawing.Size(86, 20);
			this.DestinationXNumericUpDown3.TabIndex = 2;
			this.DestinationXNumericUpDown3.ValueChanged += new System.EventHandler(this.DestinationXNumericUpDown3_ValueChanged);
			// 
			// DestinationYNumericUpDown4
			// 
			this.DestinationYNumericUpDown4.DecimalPlaces = 2;
			this.DestinationYNumericUpDown4.Increment = new decimal(new int[] {1, 0, 0, 65536});
			this.DestinationYNumericUpDown4.Location = new System.Drawing.Point(33, 59);
			this.DestinationYNumericUpDown4.Maximum = new decimal(new int[] {1280, 0, 0, 0});
			this.DestinationYNumericUpDown4.Name = "DestinationYNumericUpDown4";
			this.DestinationYNumericUpDown4.Size = new System.Drawing.Size(86, 20);
			this.DestinationYNumericUpDown4.TabIndex = 3;
			this.DestinationYNumericUpDown4.ValueChanged += new System.EventHandler(this.DestinationYNumericUpDown4_ValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.OriginYNumericUpDown2);
			this.groupBox1.Controls.Add(this.OriginXNumericUpDown1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 92);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Точка 1";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Y: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(9, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(18, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "X: ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.DestinationYNumericUpDown4);
			this.groupBox2.Controls.Add(this.DestinationXNumericUpDown3);
			this.groupBox2.Location = new System.Drawing.Point(154, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(136, 92);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Точка 2";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(9, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Y: ";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "X: ";
			// 
			// ExitButton
			// 
			this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ExitButton.Location = new System.Drawing.Point(98, 112);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(80, 30);
			this.ExitButton.TabIndex = 6;
			this.ExitButton.Text = "Закрыть";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// DrawButton
			// 
			this.DrawButton.Location = new System.Drawing.Point(12, 112);
			this.DrawButton.Name = "DrawButton";
			this.DrawButton.Size = new System.Drawing.Size(80, 30);
			this.DrawButton.TabIndex = 7;
			this.DrawButton.Text = "Нарисовать";
			this.DrawButton.UseVisualStyleBackColor = true;
			this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
			// 
			// Dlg1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ExitButton;
			this.ClientSize = new System.Drawing.Size(305, 154);
			this.Controls.Add(this.DrawButton);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dlg1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Нецелочисленные координаты концов";
			((System.ComponentModel.ISupportInitialize) (this.OriginXNumericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.OriginYNumericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.DestinationXNumericUpDown3)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.DestinationYNumericUpDown4)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button DrawButton;

		private System.Windows.Forms.NumericUpDown OriginXNumericUpDown1;
		private System.Windows.Forms.NumericUpDown OriginYNumericUpDown2;
		private System.Windows.Forms.NumericUpDown DestinationXNumericUpDown3;
		private System.Windows.Forms.NumericUpDown DestinationYNumericUpDown4;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		

		#endregion
	}
}