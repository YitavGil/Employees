namespace Employees2._0
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
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelGender = new System.Windows.Forms.Panel();
			this.rbtnFemale = new System.Windows.Forms.RadioButton();
			this.rbtnMale = new System.Windows.Forms.RadioButton();
			this.panelStatus = new System.Windows.Forms.Panel();
			this.rbtnWidow = new System.Windows.Forms.RadioButton();
			this.rbtnDivorced = new System.Windows.Forms.RadioButton();
			this.rbtnBachelor = new System.Windows.Forms.RadioButton();
			this.rbtnMarried = new System.Windows.Forms.RadioButton();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtStreetNum = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtCellular = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddEmployee = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dtpBox = new System.Windows.Forms.DateTimePicker();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panelGender.SuspendLayout();
			this.panelStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtCode
			// 
			this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCode.Location = new System.Drawing.Point(634, 85);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(66, 22);
			this.txtCode.TabIndex = 0;
			// 
			// txtFirstName
			// 
			this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFirstName.Location = new System.Drawing.Point(384, 85);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(100, 22);
			this.txtFirstName.TabIndex = 2;
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtId.Location = new System.Drawing.Point(507, 85);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 22);
			this.txtId.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(325, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "מערך עובדים";
			// 
			// panelGender
			// 
			this.panelGender.Controls.Add(this.rbtnFemale);
			this.panelGender.Controls.Add(this.rbtnMale);
			this.panelGender.Location = new System.Drawing.Point(581, 142);
			this.panelGender.Name = "panelGender";
			this.panelGender.Size = new System.Drawing.Size(119, 92);
			this.panelGender.TabIndex = 5;
			// 
			// rbtnFemale
			// 
			this.rbtnFemale.AutoSize = true;
			this.rbtnFemale.Location = new System.Drawing.Point(9, 56);
			this.rbtnFemale.Name = "rbtnFemale";
			this.rbtnFemale.Size = new System.Drawing.Size(56, 20);
			this.rbtnFemale.TabIndex = 5;
			this.rbtnFemale.TabStop = true;
			this.rbtnFemale.Text = "נקבה";
			this.rbtnFemale.UseVisualStyleBackColor = true;
			this.rbtnFemale.CheckedChanged += new System.EventHandler(this.rbtnFemale_CheckedChanged);
			// 
			// rbtnMale
			// 
			this.rbtnMale.AutoSize = true;
			this.rbtnMale.Location = new System.Drawing.Point(9, 14);
			this.rbtnMale.Name = "rbtnMale";
			this.rbtnMale.Size = new System.Drawing.Size(47, 20);
			this.rbtnMale.TabIndex = 4;
			this.rbtnMale.TabStop = true;
			this.rbtnMale.Text = "זכר";
			this.rbtnMale.UseVisualStyleBackColor = true;
			this.rbtnMale.CheckedChanged += new System.EventHandler(this.rbtnMale_CheckedChanged);
			// 
			// panelStatus
			// 
			this.panelStatus.Controls.Add(this.rbtnWidow);
			this.panelStatus.Controls.Add(this.rbtnDivorced);
			this.panelStatus.Controls.Add(this.rbtnBachelor);
			this.panelStatus.Controls.Add(this.rbtnMarried);
			this.panelStatus.Location = new System.Drawing.Point(421, 142);
			this.panelStatus.Name = "panelStatus";
			this.panelStatus.Size = new System.Drawing.Size(91, 127);
			this.panelStatus.TabIndex = 6;
			// 
			// rbtnWidow
			// 
			this.rbtnWidow.AutoSize = true;
			this.rbtnWidow.Location = new System.Drawing.Point(8, 94);
			this.rbtnWidow.Name = "rbtnWidow";
			this.rbtnWidow.Size = new System.Drawing.Size(57, 20);
			this.rbtnWidow.TabIndex = 3;
			this.rbtnWidow.TabStop = true;
			this.rbtnWidow.Text = "אלמן";
			this.rbtnWidow.UseVisualStyleBackColor = true;
			// 
			// rbtnDivorced
			// 
			this.rbtnDivorced.AutoSize = true;
			this.rbtnDivorced.Location = new System.Drawing.Point(8, 66);
			this.rbtnDivorced.Name = "rbtnDivorced";
			this.rbtnDivorced.Size = new System.Drawing.Size(55, 20);
			this.rbtnDivorced.TabIndex = 2;
			this.rbtnDivorced.TabStop = true;
			this.rbtnDivorced.Text = "גרוש";
			this.rbtnDivorced.UseVisualStyleBackColor = true;
			// 
			// rbtnBachelor
			// 
			this.rbtnBachelor.AutoSize = true;
			this.rbtnBachelor.Location = new System.Drawing.Point(8, 40);
			this.rbtnBachelor.Name = "rbtnBachelor";
			this.rbtnBachelor.Size = new System.Drawing.Size(52, 20);
			this.rbtnBachelor.TabIndex = 1;
			this.rbtnBachelor.TabStop = true;
			this.rbtnBachelor.Text = "רווק";
			this.rbtnBachelor.UseVisualStyleBackColor = true;
			// 
			// rbtnMarried
			// 
			this.rbtnMarried.AutoSize = true;
			this.rbtnMarried.Location = new System.Drawing.Point(8, 14);
			this.rbtnMarried.Name = "rbtnMarried";
			this.rbtnMarried.Size = new System.Drawing.Size(52, 20);
			this.rbtnMarried.TabIndex = 0;
			this.rbtnMarried.TabStop = true;
			this.rbtnMarried.Text = "נשוי";
			this.rbtnMarried.UseVisualStyleBackColor = true;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(234, 280);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(139, 48);
			this.btnPrevious.TabIndex = 7;
			this.btnPrevious.Text = "<<";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(507, 280);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(139, 48);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = ">>";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// txtMail
			// 
			this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMail.Location = new System.Drawing.Point(454, 361);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(93, 22);
			this.txtMail.TabIndex = 9;
			// 
			// txtCity
			// 
			this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCity.Location = new System.Drawing.Point(74, 361);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(93, 22);
			this.txtCity.TabIndex = 10;
			// 
			// txtStreetNum
			// 
			this.txtStreetNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStreetNum.Location = new System.Drawing.Point(207, 361);
			this.txtStreetNum.Name = "txtStreetNum";
			this.txtStreetNum.Size = new System.Drawing.Size(93, 22);
			this.txtStreetNum.TabIndex = 11;
			// 
			// txtStreet
			// 
			this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtStreet.Location = new System.Drawing.Point(330, 361);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(93, 22);
			this.txtStreet.TabIndex = 12;
			// 
			// txtCellular
			// 
			this.txtCellular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCellular.Location = new System.Drawing.Point(581, 361);
			this.txtCellular.Name = "txtCellular";
			this.txtCellular.Size = new System.Drawing.Size(93, 22);
			this.txtCellular.TabIndex = 13;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(570, 409);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(93, 29);
			this.btnNew.TabIndex = 14;
			this.btnNew.Text = "חדש";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(135, 409);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(93, 29);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "מחיקת עובד";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(276, 409);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(93, 29);
			this.btnUpdate.TabIndex = 16;
			this.btnUpdate.Text = "עדכון";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAddEmployee
			// 
			this.btnAddEmployee.Location = new System.Drawing.Point(419, 409);
			this.btnAddEmployee.Name = "btnAddEmployee";
			this.btnAddEmployee.Size = new System.Drawing.Size(93, 29);
			this.btnAddEmployee.TabIndex = 17;
			this.btnAddEmployee.Text = "הוספת עובד";
			this.btnAddEmployee.UseVisualStyleBackColor = true;
			this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(656, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "קוד";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(405, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 16);
			this.label3.TabIndex = 19;
			this.label3.Text = "שם פרטי";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(519, 66);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 20;
			this.label4.Text = "תעודת זהות";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(106, 66);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "תאריך לידה";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(106, 342);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(27, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "עיר";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(241, 342);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 16);
			this.label7.TabIndex = 23;
			this.label7.Text = "מספר";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(366, 342);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 16);
			this.label8.TabIndex = 24;
			this.label8.Text = "רחוב";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(597, 342);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 16);
			this.label9.TabIndex = 25;
			this.label9.Text = "טלפון נייד";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(486, 342);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(33, 16);
			this.label10.TabIndex = 26;
			this.label10.Text = "מייל";
			// 
			// dtpBox
			// 
			this.dtpBox.Location = new System.Drawing.Point(28, 85);
			this.dtpBox.Name = "dtpBox";
			this.dtpBox.Size = new System.Drawing.Size(200, 22);
			this.dtpBox.TabIndex = 27;
			// 
			// txtLastName
			// 
			this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLastName.Location = new System.Drawing.Point(257, 85);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(100, 22);
			this.txtLastName.TabIndex = 28;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(273, 66);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(67, 16);
			this.label11.TabIndex = 29;
			this.label11.Text = "שם משפחה";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.dtpBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnAddEmployee);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.txtCellular);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtStreetNum);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.panelStatus);
			this.Controls.Add(this.panelGender);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtCode);
			this.Name = "Form1";
			this.RightToLeftLayout = true;
			this.Text = "Employees";
			this.panelGender.ResumeLayout(false);
			this.panelGender.PerformLayout();
			this.panelStatus.ResumeLayout(false);
			this.panelStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelGender;
		private System.Windows.Forms.Panel panelStatus;
		private System.Windows.Forms.RadioButton rbtnWidow;
		private System.Windows.Forms.RadioButton rbtnDivorced;
		private System.Windows.Forms.RadioButton rbtnBachelor;
		private System.Windows.Forms.RadioButton rbtnMarried;
		private System.Windows.Forms.RadioButton rbtnFemale;
		private System.Windows.Forms.RadioButton rbtnMale;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtStreetNum;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.TextBox txtCellular;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAddEmployee;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dtpBox;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label11;
	}
}

