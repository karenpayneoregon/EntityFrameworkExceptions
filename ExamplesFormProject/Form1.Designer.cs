namespace ExamplesFormProject
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedMemberButton = new System.Windows.Forms.Button();
            this.AddBadNewMemberButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(216, 94);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gender";
            // 
            // SelectedMemberButton
            // 
            this.SelectedMemberButton.Location = new System.Drawing.Point(12, 112);
            this.SelectedMemberButton.Name = "SelectedMemberButton";
            this.SelectedMemberButton.Size = new System.Drawing.Size(216, 23);
            this.SelectedMemberButton.TabIndex = 1;
            this.SelectedMemberButton.Text = "Selected Member";
            this.SelectedMemberButton.UseVisualStyleBackColor = true;
            this.SelectedMemberButton.Click += new System.EventHandler(this.SelectedMemberButton_Click);
            // 
            // AddBadNewMemberButton1
            // 
            this.AddBadNewMemberButton1.Location = new System.Drawing.Point(12, 141);
            this.AddBadNewMemberButton1.Name = "AddBadNewMemberButton1";
            this.AddBadNewMemberButton1.Size = new System.Drawing.Size(216, 23);
            this.AddBadNewMemberButton1.TabIndex = 2;
            this.AddBadNewMemberButton1.Text = "Add bad new member";
            this.AddBadNewMemberButton1.UseVisualStyleBackColor = true;
            this.AddBadNewMemberButton1.Click += new System.EventHandler(this.AddBadNewMemberButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBadNewMemberButton1);
            this.Controls.Add(this.SelectedMemberButton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button SelectedMemberButton;
        private System.Windows.Forms.Button AddBadNewMemberButton1;
    }
}

