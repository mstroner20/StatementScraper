namespace BudgetProgram2
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
            this.BrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FilterButton = new System.Windows.Forms.Button();
            this.AddStatementsbutton = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.SubmitFiltersButton = new System.Windows.Forms.Button();
            this.YearEndFilter = new System.Windows.Forms.ComboBox();
            this.YearDescend = new System.Windows.Forms.CheckBox();
            this.YearAscend = new System.Windows.Forms.CheckBox();
            this.ContainsFilterTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YearStartFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RangeCB = new System.Windows.Forms.CheckBox();
            this.YearsCBFilter = new System.Windows.Forms.ComboBox();
            this.YearCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.FilterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.BackColor = System.Drawing.Color.White;
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.Location = new System.Drawing.Point(1143, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(75, 34);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "Close";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetLabel.ForeColor = System.Drawing.Color.White;
            this.BudgetLabel.Location = new System.Drawing.Point(550, 9);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(177, 19);
            this.BudgetLabel.TabIndex = 0;
            this.BudgetLabel.Text = "Budget Program";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.FilterButton);
            this.panel1.Controls.Add(this.AddStatementsbutton);
            this.panel1.Controls.Add(this.CloseFormButton);
            this.panel1.Controls.Add(this.BudgetLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1226, 100);
            this.panel1.TabIndex = 4;
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.Color.White;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Location = new System.Drawing.Point(1143, 60);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 34);
            this.FilterButton.TabIndex = 5;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // AddStatementsbutton
            // 
            this.AddStatementsbutton.BackColor = System.Drawing.Color.White;
            this.AddStatementsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStatementsbutton.Location = new System.Drawing.Point(583, 50);
            this.AddStatementsbutton.Margin = new System.Windows.Forms.Padding(0);
            this.AddStatementsbutton.Name = "AddStatementsbutton";
            this.AddStatementsbutton.Size = new System.Drawing.Size(108, 37);
            this.AddStatementsbutton.TabIndex = 4;
            this.AddStatementsbutton.Text = "Add Statements";
            this.AddStatementsbutton.UseVisualStyleBackColor = false;
            this.AddStatementsbutton.Click += new System.EventHandler(this.AddStatementsbutton_Click);
            // 
            // DataView
            // 
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToResizeRows = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataView.Location = new System.Drawing.Point(0, 100);
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.Size = new System.Drawing.Size(1230, 527);
            this.DataView.TabIndex = 5;
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FilterPanel.Controls.Add(this.SubmitFiltersButton);
            this.FilterPanel.Controls.Add(this.YearEndFilter);
            this.FilterPanel.Controls.Add(this.YearDescend);
            this.FilterPanel.Controls.Add(this.YearAscend);
            this.FilterPanel.Controls.Add(this.ContainsFilterTB);
            this.FilterPanel.Controls.Add(this.label2);
            this.FilterPanel.Controls.Add(this.YearStartFilter);
            this.FilterPanel.Controls.Add(this.label1);
            this.FilterPanel.Controls.Add(this.RangeCB);
            this.FilterPanel.Controls.Add(this.YearsCBFilter);
            this.FilterPanel.Controls.Add(this.YearCB);
            this.FilterPanel.Controls.Add(this.label3);
            this.FilterPanel.Location = new System.Drawing.Point(953, 120);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(265, 318);
            this.FilterPanel.TabIndex = 6;
            // 
            // SubmitFiltersButton
            // 
            this.SubmitFiltersButton.BackColor = System.Drawing.Color.White;
            this.SubmitFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitFiltersButton.Location = new System.Drawing.Point(97, 271);
            this.SubmitFiltersButton.Margin = new System.Windows.Forms.Padding(0);
            this.SubmitFiltersButton.Name = "SubmitFiltersButton";
            this.SubmitFiltersButton.Size = new System.Drawing.Size(108, 37);
            this.SubmitFiltersButton.TabIndex = 28;
            this.SubmitFiltersButton.Text = "Submit";
            this.SubmitFiltersButton.UseVisualStyleBackColor = false;
            this.SubmitFiltersButton.Click += new System.EventHandler(this.SubmitFiltersButton_Click);
            // 
            // YearEndFilter
            // 
            this.YearEndFilter.FormattingEnabled = true;
            this.YearEndFilter.Items.AddRange(new object[] {
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
            this.YearEndFilter.Location = new System.Drawing.Point(180, 81);
            this.YearEndFilter.Name = "YearEndFilter";
            this.YearEndFilter.Size = new System.Drawing.Size(62, 21);
            this.YearEndFilter.TabIndex = 27;
            // 
            // YearDescend
            // 
            this.YearDescend.AutoSize = true;
            this.YearDescend.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearDescend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearDescend.Location = new System.Drawing.Point(204, 47);
            this.YearDescend.Name = "YearDescend";
            this.YearDescend.Size = new System.Drawing.Size(48, 15);
            this.YearDescend.TabIndex = 26;
            this.YearDescend.Text = "Des";
            this.YearDescend.UseVisualStyleBackColor = true;
            // 
            // YearAscend
            // 
            this.YearAscend.AutoSize = true;
            this.YearAscend.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearAscend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearAscend.Location = new System.Drawing.Point(150, 46);
            this.YearAscend.Name = "YearAscend";
            this.YearAscend.Size = new System.Drawing.Size(48, 15);
            this.YearAscend.TabIndex = 25;
            this.YearAscend.Text = "Asc";
            this.YearAscend.UseVisualStyleBackColor = true;
            // 
            // ContainsFilterTB
            // 
            this.ContainsFilterTB.Location = new System.Drawing.Point(97, 123);
            this.ContainsFilterTB.Name = "ContainsFilterTB";
            this.ContainsFilterTB.Size = new System.Drawing.Size(100, 20);
            this.ContainsFilterTB.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Contains";
            // 
            // YearStartFilter
            // 
            this.YearStartFilter.FormattingEnabled = true;
            this.YearStartFilter.Items.AddRange(new object[] {
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
            this.YearStartFilter.Location = new System.Drawing.Point(79, 81);
            this.YearStartFilter.Name = "YearStartFilter";
            this.YearStartFilter.Size = new System.Drawing.Size(62, 21);
            this.YearStartFilter.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "To";
            // 
            // RangeCB
            // 
            this.RangeCB.AutoSize = true;
            this.RangeCB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RangeCB.Location = new System.Drawing.Point(7, 81);
            this.RangeCB.Name = "RangeCB";
            this.RangeCB.Size = new System.Drawing.Size(71, 17);
            this.RangeCB.TabIndex = 20;
            this.RangeCB.Text = "Range";
            this.RangeCB.UseVisualStyleBackColor = true;
            // 
            // YearsCBFilter
            // 
            this.YearsCBFilter.FormattingEnabled = true;
            this.YearsCBFilter.Items.AddRange(new object[] {
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
            this.YearsCBFilter.Location = new System.Drawing.Point(79, 41);
            this.YearsCBFilter.Name = "YearsCBFilter";
            this.YearsCBFilter.Size = new System.Drawing.Size(62, 21);
            this.YearsCBFilter.TabIndex = 19;
            // 
            // YearCB
            // 
            this.YearCB.AutoSize = true;
            this.YearCB.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearCB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.YearCB.Location = new System.Drawing.Point(7, 44);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(62, 17);
            this.YearCB.TabIndex = 18;
            this.YearCB.Text = "Year";
            this.YearCB.UseVisualStyleBackColor = true;
            this.YearCB.CheckedChanged += new System.EventHandler(this.YearCB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1226, 639);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog BrowseDialog;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddStatementsbutton;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.ComboBox YearEndFilter;
        private System.Windows.Forms.CheckBox YearDescend;
        private System.Windows.Forms.CheckBox YearAscend;
        private System.Windows.Forms.TextBox ContainsFilterTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox YearStartFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RangeCB;
        private System.Windows.Forms.ComboBox YearsCBFilter;
        private System.Windows.Forms.CheckBox YearCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitFiltersButton;
    }
}

