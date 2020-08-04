namespace Acme.Forms.UI
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
            this.UserTabs = new System.Windows.Forms.TabControl();
            this.LogonTab = new System.Windows.Forms.TabPage();
            this.LogonButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.AddEmployeesTab = new System.Windows.Forms.TabPage();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.PersonalEmail = new System.Windows.Forms.TextBox();
            this.PersonalEmailLabel = new System.Windows.Forms.Label();
            this.WorkEmail = new System.Windows.Forms.TextBox();
            this.WorkEmailLabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.GraphicsTab = new System.Windows.Forms.TabPage();
            this.ShapeHeight = new System.Windows.Forms.TextBox();
            this.ShapeWidth = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.AddShapeButton = new System.Windows.Forms.Button();
            this.ShapeTypeCombo = new System.Windows.Forms.ComboBox();
            this.ShapeTypeLabel = new System.Windows.Forms.Label();
            this.Canvas = new System.Windows.Forms.Panel();
            this.ClearCanvasButton = new System.Windows.Forms.Button();
            this.DoubleAllWidthsButton = new System.Windows.Forms.Button();
            this.UserTabs.SuspendLayout();
            this.LogonTab.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.AddEmployeesTab.SuspendLayout();
            this.GraphicsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserTabs
            // 
            this.UserTabs.Controls.Add(this.LogonTab);
            this.UserTabs.Controls.Add(this.EmployeesTab);
            this.UserTabs.Controls.Add(this.AddEmployeesTab);
            this.UserTabs.Controls.Add(this.GraphicsTab);
            this.UserTabs.Location = new System.Drawing.Point(14, 13);
            this.UserTabs.Name = "UserTabs";
            this.UserTabs.SelectedIndex = 0;
            this.UserTabs.Size = new System.Drawing.Size(874, 496);
            this.UserTabs.TabIndex = 0;
            this.UserTabs.SelectedIndexChanged += new System.EventHandler(this.UserTabs_SelectedIndexChanged);
            // 
            // LogonTab
            // 
            this.LogonTab.Controls.Add(this.LogonButton);
            this.LogonTab.Controls.Add(this.Password);
            this.LogonTab.Controls.Add(this.Username);
            this.LogonTab.Controls.Add(this.PasswordLabel);
            this.LogonTab.Controls.Add(this.UsernameLabel);
            this.LogonTab.Location = new System.Drawing.Point(4, 22);
            this.LogonTab.Name = "LogonTab";
            this.LogonTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogonTab.Size = new System.Drawing.Size(866, 470);
            this.LogonTab.TabIndex = 0;
            this.LogonTab.Text = "Logon";
            this.LogonTab.UseVisualStyleBackColor = true;
            // 
            // LogonButton
            // 
            this.LogonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogonButton.Location = new System.Drawing.Point(316, 219);
            this.LogonButton.Name = "LogonButton";
            this.LogonButton.Size = new System.Drawing.Size(117, 33);
            this.LogonButton.TabIndex = 4;
            this.LogonButton.Text = "Logon";
            this.LogonButton.UseVisualStyleBackColor = true;
            this.LogonButton.Click += new System.EventHandler(this.LogonButton_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(316, 171);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(223, 22);
            this.Password.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(316, 127);
            this.Username.MaxLength = 20;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(223, 22);
            this.Username.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(225, 171);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(225, 130);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 16);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.ShowAllButton);
            this.EmployeesTab.Controls.Add(this.SearchButton);
            this.EmployeesTab.Controls.Add(this.SearchText);
            this.EmployeesTab.Controls.Add(this.SearchLabel);
            this.EmployeesTab.Controls.Add(this.UsersGrid);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesTab.Size = new System.Drawing.Size(866, 470);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "List + Search Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllButton.Location = new System.Drawing.Point(442, 23);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(186, 27);
            this.ShowAllButton.TabIndex = 16;
            this.ShowAllButton.Text = "Show All Employees";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(329, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 27);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(91, 25);
            this.SearchText.MaxLength = 50;
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(223, 22);
            this.SearchText.TabIndex = 6;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(25, 28);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(51, 16);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search";
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(15, 70);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersGrid.Size = new System.Drawing.Size(845, 384);
            this.UsersGrid.TabIndex = 0;
            // 
            // AddEmployeesTab
            // 
            this.AddEmployeesTab.Controls.Add(this.StartDate);
            this.AddEmployeesTab.Controls.Add(this.AddEmployeeButton);
            this.AddEmployeesTab.Controls.Add(this.StartDateLabel);
            this.AddEmployeesTab.Controls.Add(this.PersonalEmail);
            this.AddEmployeesTab.Controls.Add(this.PersonalEmailLabel);
            this.AddEmployeesTab.Controls.Add(this.WorkEmail);
            this.AddEmployeesTab.Controls.Add(this.WorkEmailLabel);
            this.AddEmployeesTab.Controls.Add(this.Surname);
            this.AddEmployeesTab.Controls.Add(this.SurnameLabel);
            this.AddEmployeesTab.Controls.Add(this.Firstname);
            this.AddEmployeesTab.Controls.Add(this.FirstnameLabel);
            this.AddEmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.AddEmployeesTab.Name = "AddEmployeesTab";
            this.AddEmployeesTab.Size = new System.Drawing.Size(866, 470);
            this.AddEmployeesTab.TabIndex = 2;
            this.AddEmployeesTab.Text = "Add Employee";
            this.AddEmployeesTab.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(163, 244);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(151, 24);
            this.StartDate.TabIndex = 15;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(163, 297);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(129, 33);
            this.AddEmployeeButton.TabIndex = 14;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(44, 244);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(67, 16);
            this.StartDateLabel.TabIndex = 11;
            this.StartDateLabel.Text = "Start Date";
            // 
            // PersonalEmail
            // 
            this.PersonalEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalEmail.Location = new System.Drawing.Point(163, 196);
            this.PersonalEmail.MaxLength = 255;
            this.PersonalEmail.Name = "PersonalEmail";
            this.PersonalEmail.Size = new System.Drawing.Size(296, 22);
            this.PersonalEmail.TabIndex = 10;
            // 
            // PersonalEmailLabel
            // 
            this.PersonalEmailLabel.AutoSize = true;
            this.PersonalEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalEmailLabel.Location = new System.Drawing.Point(44, 199);
            this.PersonalEmailLabel.Name = "PersonalEmailLabel";
            this.PersonalEmailLabel.Size = new System.Drawing.Size(99, 16);
            this.PersonalEmailLabel.TabIndex = 9;
            this.PersonalEmailLabel.Text = "Personal Email";
            // 
            // WorkEmail
            // 
            this.WorkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkEmail.Location = new System.Drawing.Point(163, 150);
            this.WorkEmail.MaxLength = 255;
            this.WorkEmail.Name = "WorkEmail";
            this.WorkEmail.Size = new System.Drawing.Size(296, 22);
            this.WorkEmail.TabIndex = 8;
            // 
            // WorkEmailLabel
            // 
            this.WorkEmailLabel.AutoSize = true;
            this.WorkEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkEmailLabel.Location = new System.Drawing.Point(44, 153);
            this.WorkEmailLabel.Name = "WorkEmailLabel";
            this.WorkEmailLabel.Size = new System.Drawing.Size(77, 16);
            this.WorkEmailLabel.TabIndex = 7;
            this.WorkEmailLabel.Text = "Work Email";
            // 
            // Surname
            // 
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(163, 101);
            this.Surname.MaxLength = 50;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(223, 22);
            this.Surname.TabIndex = 6;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.Location = new System.Drawing.Point(44, 104);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(62, 16);
            this.SurnameLabel.TabIndex = 5;
            this.SurnameLabel.Text = "Surname";
            // 
            // Firstname
            // 
            this.Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.Location = new System.Drawing.Point(163, 57);
            this.Firstname.MaxLength = 50;
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(223, 22);
            this.Firstname.TabIndex = 4;
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameLabel.Location = new System.Drawing.Point(44, 60);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(67, 16);
            this.FirstnameLabel.TabIndex = 3;
            this.FirstnameLabel.Text = "Firstname";
            // 
            // GraphicsTab
            // 
            this.GraphicsTab.Controls.Add(this.DoubleAllWidthsButton);
            this.GraphicsTab.Controls.Add(this.ClearCanvasButton);
            this.GraphicsTab.Controls.Add(this.Canvas);
            this.GraphicsTab.Controls.Add(this.ShapeHeight);
            this.GraphicsTab.Controls.Add(this.ShapeWidth);
            this.GraphicsTab.Controls.Add(this.Height);
            this.GraphicsTab.Controls.Add(this.WidthLabel);
            this.GraphicsTab.Controls.Add(this.AddShapeButton);
            this.GraphicsTab.Controls.Add(this.ShapeTypeCombo);
            this.GraphicsTab.Controls.Add(this.ShapeTypeLabel);
            this.GraphicsTab.Location = new System.Drawing.Point(4, 22);
            this.GraphicsTab.Name = "GraphicsTab";
            this.GraphicsTab.Size = new System.Drawing.Size(866, 470);
            this.GraphicsTab.TabIndex = 3;
            this.GraphicsTab.Text = "Graphics";
            this.GraphicsTab.UseVisualStyleBackColor = true;
            // 
            // ShapeHeight
            // 
            this.ShapeHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeHeight.Location = new System.Drawing.Point(220, 119);
            this.ShapeHeight.MaxLength = 20;
            this.ShapeHeight.Name = "ShapeHeight";
            this.ShapeHeight.Size = new System.Drawing.Size(71, 22);
            this.ShapeHeight.TabIndex = 12;
            // 
            // ShapeWidth
            // 
            this.ShapeWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeWidth.Location = new System.Drawing.Point(220, 84);
            this.ShapeWidth.MaxLength = 20;
            this.ShapeWidth.Name = "ShapeWidth";
            this.ShapeWidth.Size = new System.Drawing.Size(71, 22);
            this.ShapeWidth.TabIndex = 11;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(121, 122);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(47, 16);
            this.Height.TabIndex = 10;
            this.Height.Text = "Height";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(121, 84);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(42, 16);
            this.WidthLabel.TabIndex = 9;
            this.WidthLabel.Text = "Width";
            // 
            // AddShapeButton
            // 
            this.AddShapeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShapeButton.Location = new System.Drawing.Point(283, 22);
            this.AddShapeButton.Name = "AddShapeButton";
            this.AddShapeButton.Size = new System.Drawing.Size(117, 33);
            this.AddShapeButton.TabIndex = 8;
            this.AddShapeButton.Text = "Add Shape";
            this.AddShapeButton.UseVisualStyleBackColor = true;
            this.AddShapeButton.Click += new System.EventHandler(this.AddShapeButton_Click);
            // 
            // ShapeTypeCombo
            // 
            this.ShapeTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ShapeTypeCombo.FormattingEnabled = true;
            this.ShapeTypeCombo.Items.AddRange(new object[] {
            "Rectangle",
            "Square"});
            this.ShapeTypeCombo.Location = new System.Drawing.Point(123, 26);
            this.ShapeTypeCombo.Name = "ShapeTypeCombo";
            this.ShapeTypeCombo.Size = new System.Drawing.Size(141, 24);
            this.ShapeTypeCombo.TabIndex = 7;
            // 
            // ShapeTypeLabel
            // 
            this.ShapeTypeLabel.AutoSize = true;
            this.ShapeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShapeTypeLabel.Location = new System.Drawing.Point(24, 28);
            this.ShapeTypeLabel.Name = "ShapeTypeLabel";
            this.ShapeTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.ShapeTypeLabel.TabIndex = 6;
            this.ShapeTypeLabel.Text = "Shape Type";
            // 
            // Canvas
            // 
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(27, 159);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(826, 296);
            this.Canvas.TabIndex = 13;
            // 
            // ClearCanvasButton
            // 
            this.ClearCanvasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCanvasButton.Location = new System.Drawing.Point(406, 22);
            this.ClearCanvasButton.Name = "ClearCanvasButton";
            this.ClearCanvasButton.Size = new System.Drawing.Size(117, 33);
            this.ClearCanvasButton.TabIndex = 14;
            this.ClearCanvasButton.Text = "Clear Canvas";
            this.ClearCanvasButton.UseVisualStyleBackColor = true;
            this.ClearCanvasButton.Click += new System.EventHandler(this.ClearCanvasButton_Click);
            // 
            // DoubleAllWidthsButton
            // 
            this.DoubleAllWidthsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoubleAllWidthsButton.Location = new System.Drawing.Point(529, 22);
            this.DoubleAllWidthsButton.Name = "DoubleAllWidthsButton";
            this.DoubleAllWidthsButton.Size = new System.Drawing.Size(128, 33);
            this.DoubleAllWidthsButton.TabIndex = 15;
            this.DoubleAllWidthsButton.Text = "DoubleAllWidths";
            this.DoubleAllWidthsButton.UseVisualStyleBackColor = true;
            this.DoubleAllWidthsButton.Click += new System.EventHandler(this.DoubleAllWidthsButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.LogonButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 521);
            this.Controls.Add(this.UserTabs);
            this.MaximumSize = new System.Drawing.Size(916, 560);
            this.MinimumSize = new System.Drawing.Size(916, 560);
            this.Name = "MainForm";
            this.Text = "Acme User Management copyright 1980";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UserTabs.ResumeLayout(false);
            this.LogonTab.ResumeLayout(false);
            this.LogonTab.PerformLayout();
            this.EmployeesTab.ResumeLayout(false);
            this.EmployeesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.AddEmployeesTab.ResumeLayout(false);
            this.AddEmployeesTab.PerformLayout();
            this.GraphicsTab.ResumeLayout(false);
            this.GraphicsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserTabs;
        private System.Windows.Forms.TabPage LogonTab;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogonButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.TabPage AddEmployeesTab;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.TextBox PersonalEmail;
        private System.Windows.Forms.Label PersonalEmailLabel;
        private System.Windows.Forms.TextBox WorkEmail;
        private System.Windows.Forms.Label WorkEmailLabel;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.TabPage GraphicsTab;
        private System.Windows.Forms.ComboBox ShapeTypeCombo;
        private System.Windows.Forms.Label ShapeTypeLabel;
        private System.Windows.Forms.Button AddShapeButton;
        private System.Windows.Forms.TextBox ShapeHeight;
        private System.Windows.Forms.TextBox ShapeWidth;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button ClearCanvasButton;
        private System.Windows.Forms.Button DoubleAllWidthsButton;
    }
}

