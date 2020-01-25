namespace BudgetProgram2
{
    partial class AddStatementsForm
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
            this.components = new System.ComponentModel.Container();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.OpenFolders = new System.Windows.Forms.FolderBrowserDialog();
            this.SubmitDataButton = new System.Windows.Forms.Button();
            this.YearsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenPathButton = new System.Windows.Forms.Button();
            this.PathTB = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.DirectoriesListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.PinSubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CloseAddingForm = new System.Windows.Forms.Button();
            this.ExampleLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLabel.ForeColor = System.Drawing.Color.White;
            this.BudgetLabel.Location = new System.Drawing.Point(10, 9);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(57, 19);
            this.BudgetLabel.TabIndex = 1;
            this.BudgetLabel.Text = "Year";
            // 
            // SubmitDataButton
            // 
            this.SubmitDataButton.BackColor = System.Drawing.Color.CadetBlue;
            this.SubmitDataButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SubmitDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitDataButton.Location = new System.Drawing.Point(407, 29);
            this.SubmitDataButton.Name = "SubmitDataButton";
            this.SubmitDataButton.Size = new System.Drawing.Size(69, 22);
            this.SubmitDataButton.TabIndex = 5;
            this.SubmitDataButton.Text = "Submit";
            this.SubmitDataButton.UseVisualStyleBackColor = false;
            this.SubmitDataButton.Click += new System.EventHandler(this.SubmitDataButton_Click);
            // 
            // YearsCB
            // 
            this.YearsCB.FormattingEnabled = true;
            this.YearsCB.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.YearsCB.Location = new System.Drawing.Point(14, 31);
            this.YearsCB.Name = "YearsCB";
            this.YearsCB.Size = new System.Drawing.Size(82, 21);
            this.YearsCB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Path";
            // 
            // OpenPathButton
            // 
            this.OpenPathButton.BackColor = System.Drawing.Color.CadetBlue;
            this.OpenPathButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OpenPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenPathButton.Location = new System.Drawing.Point(133, 31);
            this.OpenPathButton.Name = "OpenPathButton";
            this.OpenPathButton.Size = new System.Drawing.Size(69, 22);
            this.OpenPathButton.TabIndex = 8;
            this.OpenPathButton.Text = "Open";
            this.OpenPathButton.UseVisualStyleBackColor = false;
            this.OpenPathButton.Click += new System.EventHandler(this.OpenPathButton_Click);
            // 
            // PathTB
            // 
            this.PathTB.Location = new System.Drawing.Point(240, 32);
            this.PathTB.Name = "PathTB";
            this.PathTB.Size = new System.Drawing.Size(131, 20);
            this.PathTB.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Add another year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Directories:";
            // 
            // DirectoriesListBox
            // 
            this.DirectoriesListBox.FormattingEnabled = true;
            this.DirectoriesListBox.Location = new System.Drawing.Point(14, 149);
            this.DirectoriesListBox.Name = "DirectoriesListBox";
            this.DirectoriesListBox.Size = new System.Drawing.Size(462, 82);
            this.DirectoriesListBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter Last 4 Digits of Card: ";
            // 
            // PinTextBox
            // 
            this.PinTextBox.Location = new System.Drawing.Point(315, 73);
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(75, 20);
            this.PinTextBox.TabIndex = 14;
            // 
            // PinSubmitButton
            // 
            this.PinSubmitButton.BackColor = System.Drawing.Color.CadetBlue;
            this.PinSubmitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.PinSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinSubmitButton.Location = new System.Drawing.Point(407, 73);
            this.PinSubmitButton.Name = "PinSubmitButton";
            this.PinSubmitButton.Size = new System.Drawing.Size(69, 22);
            this.PinSubmitButton.TabIndex = 15;
            this.PinSubmitButton.Text = "Submit";
            this.PinSubmitButton.UseVisualStyleBackColor = false;
            this.PinSubmitButton.Click += new System.EventHandler(this.PinSubmitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(404, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "IMPORTANT: You only need to add your";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "statements to the DB once";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = " If you see strange/repeated entries";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "close add path panel and add each path one by one";
            // 
            // CloseAddingForm
            // 
            this.CloseAddingForm.BackColor = System.Drawing.Color.CadetBlue;
            this.CloseAddingForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseAddingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAddingForm.Location = new System.Drawing.Point(420, 415);
            this.CloseAddingForm.Name = "CloseAddingForm";
            this.CloseAddingForm.Size = new System.Drawing.Size(69, 22);
            this.CloseAddingForm.TabIndex = 20;
            this.CloseAddingForm.Text = "Finish";
            this.CloseAddingForm.UseVisualStyleBackColor = false;
            this.CloseAddingForm.Click += new System.EventHandler(this.CloseAddingForm_Click);
            // 
            // ExampleLink
            // 
            this.ExampleLink.AutoSize = true;
            this.ExampleLink.Location = new System.Drawing.Point(12, 366);
            this.ExampleLink.Name = "ExampleLink";
            this.ExampleLink.Size = new System.Drawing.Size(178, 13);
            this.ExampleLink.TabIndex = 21;
            this.ExampleLink.TabStop = true;
            this.ExampleLink.Text = "Example of correct Statement format\r\n";
            this.ExampleLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ExampleLink_LinkClicked);
            // 
            // AddStatementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(501, 449);
            this.Controls.Add(this.ExampleLink);
            this.Controls.Add(this.CloseAddingForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PinSubmitButton);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DirectoriesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTB);
            this.Controls.Add(this.OpenPathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearsCB);
            this.Controls.Add(this.SubmitDataButton);
            this.Controls.Add(this.BudgetLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddStatementsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.FolderBrowserDialog OpenFolders;
        private System.Windows.Forms.Button SubmitDataButton;
        private System.Windows.Forms.ComboBox YearsCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenPathButton;
        private System.Windows.Forms.TextBox PathTB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DirectoriesListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Button PinSubmitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CloseAddingForm;
        private System.Windows.Forms.LinkLabel ExampleLink;
    }
}