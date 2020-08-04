using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Acme.Models;
using Acme.Services.Implementations;
using Rectangle = Acme.Models.Rectangle;

namespace Acme.Forms.UI
{
    public partial class MainForm : Form
    {
        protected Random Random = new Random();

        protected List<Rectangle> Rectangles = new List<Rectangle>();

        protected bool IsAuthenticated;

        protected ApplicationUserService ApplicationUserService = new ApplicationUserService();

        protected EmployeeService EmployeeService = new EmployeeService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UserTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTabs.SelectedIndex > 0 && !IsAuthenticated)
            {
                UserTabs.SelectedIndex = 0;

                MessageBox.Show(@"You must Logon to access this area", @"Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (UserTabs.SelectedIndex == 0 && IsAuthenticated)
            {
                UserTabs.SelectedIndex = 1;
            }

            if (UserTabs.SelectedIndex == 1)
            {
                var employees = EmployeeService.GetEmployees();

                UsersGrid.DataSource = employees;
            }
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show(@"Please enter a username", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show(@"Please enter a password", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (ApplicationUserService.ValidateCredentials(Username.Text, Password.Text))
            {
                IsAuthenticated = true;

                UserTabs.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show(@"Invalid Credentials, please try again", @"Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationUserService.SeedApplicationUsers();

            EmployeeService.SeedEmployeesData();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Firstname = Firstname.Text,
                Surname = Surname.Text,
                WorkEmail = WorkEmail.Text,
                PersonalEmail = PersonalEmail.Text,
                StartDate = DateTime.Parse(StartDate.Text)
            };

            var errorMessages = employee.Validate();

            if (errorMessages.IsValid)
            {
                EmployeeService.AddEmployee(employee);

                Firstname.Text = "";
                Surname.Text = "";
                WorkEmail.Text = "";
                PersonalEmail.Text = "";
                StartDate.Text = "";

                MessageBox.Show(@"The employee has been sucessfully added", @"Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"There are some problems with the form as follow" + Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine, errorMessages.Errors) , @"Form Problems", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var employees = EmployeeService.GetEmployees(SearchText.Text);

            UsersGrid.DataSource = employees;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            SearchText.Text = "";

            var employees = EmployeeService.GetEmployees();

            UsersGrid.DataSource = employees;
        }

        private void AddShapeButton_Click(object sender, EventArgs e)
        {
            if (ShapeTypeCombo.SelectedItem == null)
            {
                MessageBox.Show(@"Please select a shape to add", @"Shape Type Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrEmpty(ShapeWidth.Text))
            {
                MessageBox.Show(@"Please enter a width", @"Width Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (!ShapeWidth.Text.All(char.IsDigit))
            {
                MessageBox.Show(@"Please enter a numeric value for the width", @"Width Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrEmpty(ShapeHeight.Text))
            {
                MessageBox.Show(@"Please enter a height", @"Height Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            var width = Convert.ToInt32(ShapeWidth.Text);
            var height = Convert.ToInt32(ShapeHeight.Text);

            if (width < 10 || width > 100)
            {
                MessageBox.Show(@"Please enter a width between 10 and 100", @"Width Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (height < 10 || height > 100)
            {
                MessageBox.Show(@"Please enter a height between 10 and 100", @"Height Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Rectangle r = CreateShape(ShapeTypeCombo.SelectedItem.ToString(), width, height);

            Rectangles.Add(r);

            Canvas.Controls.Add(new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = r.GetWidth(),
                Height = r.GetHeight(),
                Left = r.Left,
                Top = r.Top,
                BackColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256))
            });
        }

        private Rectangle CreateShape(string shapeType, int width, int height)
        {
            if (shapeType == "Rectangle")
            {
                var shape = new Rectangle();

                shape.SetWidth(width);
                shape.SetHeight(height);

                shape.Left = Random.Next(2, Canvas.Width - width + 2);
                shape.Top = Random.Next(2, Canvas.Height - height + 2);

                return shape;
            }

            if (shapeType == "Square")
            {
                var shape = new Square();

                shape.SetWidth(width);
                shape.SetHeight(height);

                shape.Left = Random.Next(2, Canvas.Width - width + 2);
                shape.Top = Random.Next(2, Canvas.Height - height + 2);

                return shape;
            }

            throw new Exception("Invalid Shape Type");
        }

        private void ClearCanvasButton_Click(object sender, EventArgs e)
        {
            Canvas.Controls.Clear();

            Rectangles.Clear();
        }

        private void DoubleAllWidthsButton_Click(object sender, EventArgs e)
        {
            foreach (var rectangle in Rectangles)
            {
                rectangle.IncreaseWidth(rectangle.GetWidth());
            }

            Canvas.Controls.Clear();

            foreach (var rectangle in Rectangles)
            {
                Canvas.Controls.Add(new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = rectangle.GetWidth(),
                    Height = rectangle.GetHeight(),
                    Left = rectangle.Left,
                    Top = rectangle.Top,
                    BackColor = Color.FromArgb(Random.Next(256), Random.Next(256), Random.Next(256))
                });
            }
        }
    }
}