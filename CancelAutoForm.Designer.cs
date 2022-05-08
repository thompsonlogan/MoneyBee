namespace MoneyBee
{
	partial class CancelAutoForm
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
			this.TransLB = new System.Windows.Forms.Label();
			this.DeleteButt = new System.Windows.Forms.Button();
			this.AutoListBox = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TransLB
			// 
			this.TransLB.AutoSize = true;
			this.TransLB.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TransLB.Location = new System.Drawing.Point(115, 39);
			this.TransLB.Name = "TransLB";
			this.TransLB.Size = new System.Drawing.Size(168, 19);
			this.TransLB.TabIndex = 0;
			this.TransLB.Text = "Which One to Delete?";
			// 
			// DeleteButt
			// 
			this.DeleteButt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButt.Location = new System.Drawing.Point(342, 124);
			this.DeleteButt.Name = "DeleteButt";
			this.DeleteButt.Size = new System.Drawing.Size(122, 50);
			this.DeleteButt.TabIndex = 2;
			this.DeleteButt.Text = "Delete";
			this.DeleteButt.UseVisualStyleBackColor = true;
			this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click_1);
			// 
			// AutoListBox
			// 
			this.AutoListBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AutoListBox.FormattingEnabled = true;
			this.AutoListBox.Location = new System.Drawing.Point(119, 61);
			this.AutoListBox.Name = "AutoListBox";
			this.AutoListBox.Size = new System.Drawing.Size(182, 214);
			this.AutoListBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(119, 282);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(297, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "You must select a Transaction to delete.";
			this.label2.Visible = false;
			// 
			// CancelAutoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(617, 333);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AutoListBox);
			this.Controls.Add(this.DeleteButt);
			this.Controls.Add(this.TransLB);
			this.MinimumSize = new System.Drawing.Size(633, 372);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Name = "CancelAutoForm";
			this.Text = "CancelAutoForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void InitializeComponent(AutomaticList autoList)
		{
            this.TransLB = new System.Windows.Forms.Label();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.AutoListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransLB
            // 
            this.TransLB.AutoSize = true;
            this.TransLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransLB.Location = new System.Drawing.Point(115, 39);
            this.TransLB.Name = "TransLB";
            this.TransLB.Size = new System.Drawing.Size(165, 20);
            this.TransLB.TabIndex = 0;
            this.TransLB.Text = "Which One to Delete?";
            // 
            // DeleteButt
            // 
            this.DeleteButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButt.Location = new System.Drawing.Point(342, 124);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(122, 50);
            this.DeleteButt.TabIndex = 2;
            this.DeleteButt.Text = "Delete";
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.DeleteButt_Click_1);
            // 
            // AutoListBox
            // 
            this.AutoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoListBox.FormattingEnabled = true;
            this.AutoListBox.Location = new System.Drawing.Point(119, 61);
            this.AutoListBox.Name = "AutoListBox";
            this.AutoListBox.Size = new System.Drawing.Size(182, 214);
            this.AutoListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(119, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "You must select a Transaction to delete.";
            this.label2.Visible = false;
            // 
            // CancelAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoListBox);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.TransLB);
            this.MinimumSize = new System.Drawing.Size(635, 378);
            this.Name = "CancelAutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelAutoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TransLB;
		private System.Windows.Forms.Button DeleteButt;
		private System.Windows.Forms.CheckedListBox AutoListBox;
		//private System.Windows.Forms.Label labelErr;
		//private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}