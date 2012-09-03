using TryCatchFail.LearnStructureMap.Lesson3.WinForms.MVP;

namespace TryCatchFail.LearnStructureMap.Lesson3.WinForms
{
	partial class Form1 : IWelcomeForm
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
			this.lblWelcomeMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblWelcomeMessage
			// 
			this.lblWelcomeMessage.AutoSize = true;
			this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcomeMessage.Location = new System.Drawing.Point(12, 9);
			this.lblWelcomeMessage.Name = "lblWelcomeMessage";
			this.lblWelcomeMessage.Size = new System.Drawing.Size(109, 39);
			this.lblWelcomeMessage.TabIndex = 0;
			this.lblWelcomeMessage.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 258);
			this.Controls.Add(this.lblWelcomeMessage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblWelcomeMessage;
	}
}

