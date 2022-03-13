
namespace Tugas_Week_2
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
			this.btn_proses = new System.Windows.Forms.Button();
			this.TextInput = new System.Windows.Forms.TextBox();
			this.LabelOutput = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_proses
			// 
			this.btn_proses.Location = new System.Drawing.Point(15, 93);
			this.btn_proses.Name = "btn_proses";
			this.btn_proses.Size = new System.Drawing.Size(117, 27);
			this.btn_proses.TabIndex = 0;
			this.btn_proses.Text = "Proses";
			this.btn_proses.UseVisualStyleBackColor = true;
			this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
			// 
			// TextInput
			// 
			this.TextInput.Location = new System.Drawing.Point(15, 45);
			this.TextInput.Name = "TextInput";
			this.TextInput.Size = new System.Drawing.Size(322, 22);
			this.TextInput.TabIndex = 1;
			this.TextInput.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
			// 
			// LabelOutput
			// 
			this.LabelOutput.AutoSize = true;
			this.LabelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelOutput.Location = new System.Drawing.Point(12, 140);
			this.LabelOutput.Name = "LabelOutput";
			this.LabelOutput.Size = new System.Drawing.Size(128, 32);
			this.LabelOutput.TabIndex = 2;
			this.LabelOutput.Text = "[EMPTY]";
			this.LabelOutput.Click += new System.EventHandler(this.LabelOutput_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Input Data:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 232);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.LabelOutput);
			this.Controls.Add(this.TextInput);
			this.Controls.Add(this.btn_proses);
			this.Name = "Form1";
			this.Text = "Form Pengaturan Warna";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_proses;
		private System.Windows.Forms.TextBox TextInput;
		private System.Windows.Forms.Label LabelOutput;
		private System.Windows.Forms.Label label2;
	}
}

