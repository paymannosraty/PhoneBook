namespace PhoneBook
{
	partial class MainForm
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
			this.addButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.showButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.lastNameButton = new System.Windows.Forms.TextBox();
			this.firstNameButton = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(18, 294);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 0;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = true;
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(99, 294);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(75, 23);
			this.editButton.TabIndex = 0;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			// 
			// showButton
			// 
			this.showButton.Location = new System.Drawing.Point(180, 294);
			this.showButton.Name = "showButton";
			this.showButton.Size = new System.Drawing.Size(75, 23);
			this.showButton.TabIndex = 0;
			this.showButton.Text = "Show";
			this.showButton.UseVisualStyleBackColor = true;
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(261, 294);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(75, 23);
			this.deleteButton.TabIndex = 0;
			this.deleteButton.Text = "Delete";
			this.deleteButton.UseVisualStyleBackColor = true;
			// 
			// lastNameButton
			// 
			this.lastNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lastNameButton.Location = new System.Drawing.Point(6, 20);
			this.lastNameButton.MaxLength = 20;
			this.lastNameButton.Name = "lastNameButton";
			this.lastNameButton.Size = new System.Drawing.Size(276, 21);
			this.lastNameButton.TabIndex = 1;
			// 
			// firstNameButton
			// 
			this.firstNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameButton.Location = new System.Drawing.Point(288, 20);
			this.firstNameButton.MaxLength = 20;
			this.firstNameButton.Name = "firstNameButton";
			this.firstNameButton.Size = new System.Drawing.Size(282, 21);
			this.firstNameButton.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.lastNameButton);
			this.groupBox1.Controls.Add(this.firstNameButton);
			this.groupBox1.Location = new System.Drawing.Point(12, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(576, 261);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Monitor";
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(564, 208);
			this.dataGridView1.TabIndex = 0;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(600, 24);
			this.menuStrip.TabIndex = 5;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 330);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.showButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.addButton);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "PhoneBook";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button showButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox lastNameButton;
		private System.Windows.Forms.TextBox firstNameButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
	}
}