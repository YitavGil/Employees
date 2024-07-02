using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Employees2._0
{
	public partial class Form1 : Form
	{
		List<Employee> employees;
		private int nextEmployeeCode = 1; // מספר מזהה שעוקב אחר הקוד
		public Form1()
		{
			InitializeComponent();
			employees = new List<Employee>();
			// אין אפשרות לבחור שנה מה-21 שנים אחרונות כי לא ייתכן עובד צעיר בחברה
			dtpBox.Value = DateTime.Now.AddYears(-21);
			txtCode.Text = nextEmployeeCode.ToString();


		}
		private int currentIndex = -1;
		private void btnAddEmployee_Click(object sender, EventArgs e)
		{
			// אם אין עובדים, תייצר את הרשימה
			if (employees == null)
			{
				employees = new List<Employee>(); 
			}
			// לוודא שכל השדות במסמך מלאים
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
			{
				MessageBox.Show("אנא הכנס שם עובד וכתובת מייל.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			// לדוג משתנים
			string id = txtId.Text;
			int code = Int32.Parse(txtCode.Text);
			string firstName = txtFirstName.Text;
			string lastName = txtLastName.Text;
			DateTime birthday = dtpBox.Value;
			bool isMale = rbtnMale.Checked; // Check which radio button is checked
			string status = GetSelectedStatus(); // Get selected status from radio buttons
			string cellPhoneNumber = txtCellular.Text;
			string city = txtCity.Text;
			string street = txtStreet.Text;
			string streetNumber = txtStreetNum.Text;
			string email = txtMail.Text;
			// צור עובד חדש לפי המידע שהוכנס
			Employee newEmployee = new Employee(id, nextEmployeeCode, firstName, lastName, birthday, isMale, status, cellPhoneNumber, city, street, streetNumber, email);
			// הוסף את העובד לרשימה
			employees.Add(newEmployee);
			// מעלה את הקוד לעובד הבא
			nextEmployeeCode++;

			// מעדכן את הקוד החדש בתצוגה
			txtCode.Text = nextEmployeeCode.ToString();

			//מעדכן את האינדקס
			currentIndex = employees.Count - 1;

			// מנקה את השדות לאחר הוספת עובד
			ClearFormFields(this);


			// מציג קופסא שמראה שהעובד נוסף בהצלחה
			MessageBox.Show("עובד נוסף בהצלחה!");
			Console.WriteLine(employees);
		}

		private string GetSelectedStatus()
		{
			if (rbtnBachelor.Checked)
				return rbtnBachelor.Text;
			else if (rbtnDivorced.Checked)
				return rbtnDivorced.Text;
			else if (rbtnMarried.Checked)
				return rbtnMarried.Text;
			else if (rbtnWidow.Checked)
				return rbtnWidow.Text;
			else
				return ""; // אם לא נבחר סטטוס
		}

		public void ClearFormFields(Control control)
		{
			foreach (Control ctr in control.Controls)
			{
				if (ctr is TextBox && ctr != txtCode) ctr.Text = "";
				if (ctr is DateTimePicker) ((DateTimePicker)ctr).Value = DateTime.Now.AddYears(-25);
				if (ctr is RadioButton) ((RadioButton)ctr).Checked = false;
				if (ctr is Panel) ClearFormFields(ctr);
			}
		}


		private void btnPrevious_Click(object sender, EventArgs e)
		{
			// בדיקה האם הטופס ריק
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
			{
				if (employees.Count == 0)
				{
					MessageBox.Show("No previous employee available.");
				}
				else
				{
					// אם הטופס ריק, אני מציג את העובד האחרון במערכת
					DisplayEmployeeDetails(currentIndex);
				}
			
			}
			else
			{
				// אם המערכת כבר מציגה עובד, הראה את העובד הקודם
				currentIndex--;

				// בדיקה האם הגעתי לעובד הראשון
				if (currentIndex >= 0)
				{
					DisplayEmployeeDetails(currentIndex);
					
				}
				else
				{
					MessageBox.Show("No previous employee available.");
					// אם הגעתי לעובד הראשון, אני מאפס את האינדקס
					currentIndex = 0; 
				}
			}
		}



		private void btnNext_Click(object sender, EventArgs e)
		{
			// בדיקה האם הטופס ריק
			if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtMail.Text))
			{
				MessageBox.Show("No further employee available.");
				return; // יוצא מהפונקציה
			}

			// בדיקה האם אני נמצא בעובד האחרון
			if (currentIndex + 1 >= employees.Count)
			{
				MessageBox.Show("No further employee available.");
				return; 
			}

			// מעבר לעובד הבא
			currentIndex++;
			DisplayEmployeeDetails(currentIndex);
		}

		private void DisplayEmployeeDetails(int index)
		{
			Employee emp = employees[index];

			txtCode.Text = emp.Code.ToString();
			txtFirstName.Text = emp.FirstName;
			txtLastName.Text = emp.LastName;
			dtpBox.Value = emp.Birthday;
			if (emp.IsMale)
				rbtnMale.Checked = true;
			else
				rbtnFemale.Checked = true;
			

			txtCellular.Text = emp.Cellphone;
			txtCity.Text = emp.City;
			txtStreet.Text = emp.Street;
			txtStreetNum.Text = emp.StreetNumber;
			txtMail.Text = emp.Email;
			txtId.Text = emp.Id;
			txtCode.Text = emp.Code.ToString();
			

			// בדיקה של משהו הסטטוס הנכון
			switch (emp.Status)
			{
				case "רווק":
					rbtnBachelor.Checked = true;
					break;
				case "גרוש":
					rbtnDivorced.Checked = true;
					break;
				case "נשוי":
					rbtnMarried.Checked = true;
					break;
				case "אלמן":
					rbtnWidow.Checked = true;
					break;
				default:
					// אם לא נבחר סטטוס
					break;
			}
		}

		private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtnFemale.Checked)
			{
				rbtnBachelor.Text = "רווקה";
				rbtnDivorced.Text = "גרושה";
				rbtnMarried.Text = "נשואה";
				rbtnWidow.Text = "אלמנה";
			}
		}

		private void rbtnMale_CheckedChanged(object sender, EventArgs e)
		{
			if (rbtnMale.Checked)
			{
				rbtnBachelor.Text = "רווק";
				rbtnDivorced.Text = "גרוש";
				rbtnMarried.Text = "נשוי";
				rbtnWidow.Text = "אלמן";
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			// Ensure there are employees in the list and currentIndex is valid
			if (currentIndex >= 0 && currentIndex < employees.Count)
			{
				// Retrieve input values
				string id = txtId.Text;
				int code = Int32.Parse(txtCode.Text); // Assuming txtCode is editable for update
				string firstName = txtFirstName.Text;
				string lastName = txtLastName.Text;
				DateTime birthday = dtpBox.Value;
				bool isMale = rbtnMale.Checked; // Check which radio button is checked
				string status = GetSelectedStatus(); // Get selected status from radio buttons
				string cellPhoneNumber = txtCellular.Text;
				string city = txtCity.Text;
				string street = txtStreet.Text;
				string streetNumber = txtStreetNum.Text;
				string email = txtMail.Text;

				// Validate input
				if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(email))
				{
					MessageBox.Show("אנא מלא את שם העובד וכתובת המייל לפני העדכון.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Update the employee object
				Employee updatedEmployee = employees[currentIndex];
				updatedEmployee.Id = id;
				updatedEmployee.Code = code;
				updatedEmployee.FirstName = firstName;
				updatedEmployee.LastName = lastName;
				updatedEmployee.Birthday = birthday;
				updatedEmployee.IsMale = isMale;
				updatedEmployee.Status = status;
				updatedEmployee.Cellphone = cellPhoneNumber;
				updatedEmployee.City = city;
				updatedEmployee.Street = street;
				updatedEmployee.StreetNumber = streetNumber;
				updatedEmployee.Email = email;

				// Optionally update the employees list (if reference types are used)
				employees[currentIndex] = updatedEmployee;

				// Display confirmation or any necessary message
				MessageBox.Show("עובד עודכן בהצלחה!");

				// Refresh the display with updated details
				DisplayEmployeeDetails(currentIndex);
			}
			else
			{
				MessageBox.Show("אין עובדים לעדכון או האינדקס לא חוקי.");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			// Check if there are employees in the list
			if (employees.Count > 0)
			{
				// Display confirmation dialog
				DialogResult result = MessageBox.Show("האם אתה בטוח שברצונך למחוק עובד זה?", "מחיקת עובד", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				// If user confirms deletion
				if (result == DialogResult.Yes)
				{
					// Remove the employee from the list
					employees.RemoveAt(currentIndex);

					// Adjust currentIndex if it exceeds the bounds after deletion
					if (currentIndex >= employees.Count)
					{
						currentIndex = employees.Count - 1;
					}

					// Clear the form fields after deletion
					ClearFormFields(this);

					// Display confirmation message
					MessageBox.Show("עובד נמחק בהצלחה!");

					// Refresh display if there are remaining employees
					if (employees.Count > 0)
					{
						DisplayEmployeeDetails(currentIndex);
					}
					else
					{
						// Optionally clear fields or handle UI state when no employees are left
						txtCode.Text = "";
						txtFirstName.Text = "";
						txtLastName.Text = "";
						dtpBox.Value = DateTime.Now.AddYears(-21);
						// Clear other fields as needed
					}
				}
			}
			else
			{
				MessageBox.Show("אין עובדים למחיקה.");
			}
		}
	}
}
