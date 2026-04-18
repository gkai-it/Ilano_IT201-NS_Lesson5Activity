namespace Ilano_IT201_NS_Lesson5Activity
{
    partial class PayslipReport
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlPayslip = new System.Windows.Forms.Panel();
            this.grpEmployeeInfo = new System.Windows.Forms.GroupBox();
            this.lblEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.lblEmployeeNumberValue = new System.Windows.Forms.Label();
            this.lblFirstNameLabel = new System.Windows.Forms.Label();
            this.lblFirstNameValue = new System.Windows.Forms.Label();
            this.lblSurnameLabel = new System.Windows.Forms.Label();
            this.lblSurnameValue = new System.Windows.Forms.Label();
            this.lblDepartmentLabel = new System.Windows.Forms.Label();
            this.lblDepartmentValue = new System.Windows.Forms.Label();
            this.lblDesignationLabel = new System.Windows.Forms.Label();
            this.lblDesignationValue = new System.Windows.Forms.Label();
            this.lblPaydateLabel = new System.Windows.Forms.Label();
            this.lblPaydateValue = new System.Windows.Forms.Label();
            this.grpIncomeDetails = new System.Windows.Forms.GroupBox();
            this.lblBasicIncomeLabel = new System.Windows.Forms.Label();
            this.lblBasicIncomeValue = new System.Windows.Forms.Label();
            this.lblHonoriariumIncomeLabel = new System.Windows.Forms.Label();
            this.lblHonoriariumIncomeValue = new System.Windows.Forms.Label();
            this.lblOtherIncomeLabel = new System.Windows.Forms.Label();
            this.lblOtherIncomeValue = new System.Windows.Forms.Label();
            this.lblGrossIncomeLabel = new System.Windows.Forms.Label();
            this.lblGrossIncomeValue = new System.Windows.Forms.Label();
            this.grpRegularDeductions = new System.Windows.Forms.GroupBox();
            this.lblSSSLabel = new System.Windows.Forms.Label();
            this.lblSSSValue = new System.Windows.Forms.Label();
            this.lblPhilHealthLabel = new System.Windows.Forms.Label();
            this.lblPhilHealthValue = new System.Windows.Forms.Label();
            this.lblPagIbigLabel = new System.Windows.Forms.Label();
            this.lblPagIbigValue = new System.Windows.Forms.Label();
            this.lblIncomeTaxLabel = new System.Windows.Forms.Label();
            this.lblIncomeTaxValue = new System.Windows.Forms.Label();
            this.grpOtherDeductions = new System.Windows.Forms.GroupBox();
            this.lblSSSLoanLabel = new System.Windows.Forms.Label();
            this.lblSSSLoanValue = new System.Windows.Forms.Label();
            this.lblPagIbigLoanLabel = new System.Windows.Forms.Label();
            this.lblPagIbigLoanValue = new System.Windows.Forms.Label();
            this.lblFacultySavingsDepositLabel = new System.Windows.Forms.Label();
            this.lblFacultySavingsDepositValue = new System.Windows.Forms.Label();
            this.lblFacultySavingsLoanLabel = new System.Windows.Forms.Label();
            this.lblFacultySavingsLoanValue = new System.Windows.Forms.Label();
            this.lblSalaryLoanLabel = new System.Windows.Forms.Label();
            this.lblSalaryLoanValue = new System.Windows.Forms.Label();
            this.lblOtherLoansLabel = new System.Windows.Forms.Label();
            this.lblOtherLoansValue = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalDeductionsLabel = new System.Windows.Forms.Label();
            this.lblTotalDeductionsValue = new System.Windows.Forms.Label();
            this.lblNetIncomeLabel = new System.Windows.Forms.Label();
            this.lblNetIncomeValue = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPayslip.SuspendLayout();
            this.grpEmployeeInfo.SuspendLayout();
            this.grpIncomeDetails.SuspendLayout();
            this.grpRegularDeductions.SuspendLayout();
            this.grpOtherDeductions.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();

            // pnlPayslip
            this.pnlPayslip.AutoScroll = true;
            this.pnlPayslip.Controls.Add(this.grpEmployeeInfo);
            this.pnlPayslip.Controls.Add(this.grpIncomeDetails);
            this.pnlPayslip.Controls.Add(this.grpRegularDeductions);
            this.pnlPayslip.Controls.Add(this.grpOtherDeductions);
            this.pnlPayslip.Controls.Add(this.grpSummary);
            this.pnlPayslip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPayslip.Location = new System.Drawing.Point(0, 0);
            this.pnlPayslip.Name = "pnlPayslip";
            this.pnlPayslip.Size = new System.Drawing.Size(800, 700);
            this.pnlPayslip.TabIndex = 0;

            // grpEmployeeInfo
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeNumberLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblEmployeeNumberValue);
            this.grpEmployeeInfo.Controls.Add(this.lblFirstNameLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblFirstNameValue);
            this.grpEmployeeInfo.Controls.Add(this.lblSurnameLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblSurnameValue);
            this.grpEmployeeInfo.Controls.Add(this.lblDepartmentLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblDepartmentValue);
            this.grpEmployeeInfo.Controls.Add(this.lblDesignationLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblDesignationValue);
            this.grpEmployeeInfo.Controls.Add(this.lblPaydateLabel);
            this.grpEmployeeInfo.Controls.Add(this.lblPaydateValue);
            this.grpEmployeeInfo.Location = new System.Drawing.Point(10, 10);
            this.grpEmployeeInfo.Name = "grpEmployeeInfo";
            this.grpEmployeeInfo.Size = new System.Drawing.Size(770, 120);
            this.grpEmployeeInfo.TabIndex = 0;
            this.grpEmployeeInfo.TabStop = false;
            this.grpEmployeeInfo.Text = "EMPLOYEE INFORMATION";

            // Employee Info Labels and Values
            this.lblEmployeeNumberLabel.AutoSize = true;
            this.lblEmployeeNumberLabel.Location = new System.Drawing.Point(10, 25);
            this.lblEmployeeNumberLabel.Name = "lblEmployeeNumberLabel";
            this.lblEmployeeNumberLabel.Size = new System.Drawing.Size(100, 16);
            this.lblEmployeeNumberLabel.TabIndex = 0;
            this.lblEmployeeNumberLabel.Text = "Employee No.:";

            this.lblEmployeeNumberValue.AutoSize = true;
            this.lblEmployeeNumberValue.Location = new System.Drawing.Point(150, 25);
            this.lblEmployeeNumberValue.Name = "lblEmployeeNumberValue";
            this.lblEmployeeNumberValue.Size = new System.Drawing.Size(0, 16);
            this.lblEmployeeNumberValue.TabIndex = 1;

            this.lblFirstNameLabel.AutoSize = true;
            this.lblFirstNameLabel.Location = new System.Drawing.Point(350, 25);
            this.lblFirstNameLabel.Name = "lblFirstNameLabel";
            this.lblFirstNameLabel.Size = new System.Drawing.Size(68, 16);
            this.lblFirstNameLabel.TabIndex = 2;
            this.lblFirstNameLabel.Text = "First Name:";

            this.lblFirstNameValue.AutoSize = true;
            this.lblFirstNameValue.Location = new System.Drawing.Point(450, 25);
            this.lblFirstNameValue.Name = "lblFirstNameValue";
            this.lblFirstNameValue.Size = new System.Drawing.Size(0, 16);
            this.lblFirstNameValue.TabIndex = 3;

            this.lblSurnameLabel.AutoSize = true;
            this.lblSurnameLabel.Location = new System.Drawing.Point(10, 45);
            this.lblSurnameLabel.Name = "lblSurnameLabel";
            this.lblSurnameLabel.Size = new System.Drawing.Size(68, 16);
            this.lblSurnameLabel.TabIndex = 4;
            this.lblSurnameLabel.Text = "Surname:";

            this.lblSurnameValue.AutoSize = true;
            this.lblSurnameValue.Location = new System.Drawing.Point(150, 45);
            this.lblSurnameValue.Name = "lblSurnameValue";
            this.lblSurnameValue.Size = new System.Drawing.Size(0, 16);
            this.lblSurnameValue.TabIndex = 5;

            this.lblDepartmentLabel.AutoSize = true;
            this.lblDepartmentLabel.Location = new System.Drawing.Point(350, 45);
            this.lblDepartmentLabel.Name = "lblDepartmentLabel";
            this.lblDepartmentLabel.Size = new System.Drawing.Size(80, 16);
            this.lblDepartmentLabel.TabIndex = 6;
            this.lblDepartmentLabel.Text = "Department:";

            this.lblDepartmentValue.AutoSize = true;
            this.lblDepartmentValue.Location = new System.Drawing.Point(450, 45);
            this.lblDepartmentValue.Name = "lblDepartmentValue";
            this.lblDepartmentValue.Size = new System.Drawing.Size(0, 16);
            this.lblDepartmentValue.TabIndex = 7;

            this.lblDesignationLabel.AutoSize = true;
            this.lblDesignationLabel.Location = new System.Drawing.Point(10, 65);
            this.lblDesignationLabel.Name = "lblDesignationLabel";
            this.lblDesignationLabel.Size = new System.Drawing.Size(82, 16);
            this.lblDesignationLabel.TabIndex = 8;
            this.lblDesignationLabel.Text = "Designation:";

            this.lblDesignationValue.AutoSize = true;
            this.lblDesignationValue.Location = new System.Drawing.Point(150, 65);
            this.lblDesignationValue.Name = "lblDesignationValue";
            this.lblDesignationValue.Size = new System.Drawing.Size(0, 16);
            this.lblDesignationValue.TabIndex = 9;

            this.lblPaydateLabel.AutoSize = true;
            this.lblPaydateLabel.Location = new System.Drawing.Point(350, 65);
            this.lblPaydateLabel.Name = "lblPaydateLabel";
            this.lblPaydateLabel.Size = new System.Drawing.Size(61, 16);
            this.lblPaydateLabel.TabIndex = 10;
            this.lblPaydateLabel.Text = "Paydate:";

            this.lblPaydateValue.AutoSize = true;
            this.lblPaydateValue.Location = new System.Drawing.Point(450, 65);
            this.lblPaydateValue.Name = "lblPaydateValue";
            this.lblPaydateValue.Size = new System.Drawing.Size(0, 16);
            this.lblPaydateValue.TabIndex = 11;

            // grpIncomeDetails
            this.grpIncomeDetails.Controls.Add(this.lblBasicIncomeLabel);
            this.grpIncomeDetails.Controls.Add(this.lblBasicIncomeValue);
            this.grpIncomeDetails.Controls.Add(this.lblHonoriariumIncomeLabel);
            this.grpIncomeDetails.Controls.Add(this.lblHonoriariumIncomeValue);
            this.grpIncomeDetails.Controls.Add(this.lblOtherIncomeLabel);
            this.grpIncomeDetails.Controls.Add(this.lblOtherIncomeValue);
            this.grpIncomeDetails.Controls.Add(this.lblGrossIncomeLabel);
            this.grpIncomeDetails.Controls.Add(this.lblGrossIncomeValue);
            this.grpIncomeDetails.Location = new System.Drawing.Point(10, 140);
            this.grpIncomeDetails.Name = "grpIncomeDetails";
            this.grpIncomeDetails.Size = new System.Drawing.Size(770, 100);
            this.grpIncomeDetails.TabIndex = 1;
            this.grpIncomeDetails.TabStop = false;
            this.grpIncomeDetails.Text = "INCOME";

            this.lblBasicIncomeLabel.AutoSize = true;
            this.lblBasicIncomeLabel.Location = new System.Drawing.Point(10, 25);
            this.lblBasicIncomeLabel.Name = "lblBasicIncomeLabel";
            this.lblBasicIncomeLabel.Size = new System.Drawing.Size(89, 16);
            this.lblBasicIncomeLabel.TabIndex = 0;
            this.lblBasicIncomeLabel.Text = "Basic Income:";

            this.lblBasicIncomeValue.AutoSize = true;
            this.lblBasicIncomeValue.Location = new System.Drawing.Point(200, 25);
            this.lblBasicIncomeValue.Name = "lblBasicIncomeValue";
            this.lblBasicIncomeValue.Size = new System.Drawing.Size(0, 16);
            this.lblBasicIncomeValue.TabIndex = 1;
            this.lblBasicIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblHonoriariumIncomeLabel.AutoSize = true;
            this.lblHonoriariumIncomeLabel.Location = new System.Drawing.Point(10, 45);
            this.lblHonoriariumIncomeLabel.Name = "lblHonoriariumIncomeLabel";
            this.lblHonoriariumIncomeLabel.Size = new System.Drawing.Size(125, 16);
            this.lblHonoriariumIncomeLabel.TabIndex = 2;
            this.lblHonoriariumIncomeLabel.Text = "Honorarium Income:";

            this.lblHonoriariumIncomeValue.AutoSize = true;
            this.lblHonoriariumIncomeValue.Location = new System.Drawing.Point(200, 45);
            this.lblHonoriariumIncomeValue.Name = "lblHonoriariumIncomeValue";
            this.lblHonoriariumIncomeValue.Size = new System.Drawing.Size(0, 16);
            this.lblHonoriariumIncomeValue.TabIndex = 3;
            this.lblHonoriariumIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblOtherIncomeLabel.AutoSize = true;
            this.lblOtherIncomeLabel.Location = new System.Drawing.Point(10, 65);
            this.lblOtherIncomeLabel.Name = "lblOtherIncomeLabel";
            this.lblOtherIncomeLabel.Size = new System.Drawing.Size(89, 16);
            this.lblOtherIncomeLabel.TabIndex = 4;
            this.lblOtherIncomeLabel.Text = "Other Income:";

            this.lblOtherIncomeValue.AutoSize = true;
            this.lblOtherIncomeValue.Location = new System.Drawing.Point(200, 65);
            this.lblOtherIncomeValue.Name = "lblOtherIncomeValue";
            this.lblOtherIncomeValue.Size = new System.Drawing.Size(0, 16);
            this.lblOtherIncomeValue.TabIndex = 5;
            this.lblOtherIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblGrossIncomeLabel.AutoSize = true;
            this.lblGrossIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossIncomeLabel.Location = new System.Drawing.Point(400, 45);
            this.lblGrossIncomeLabel.Name = "lblGrossIncomeLabel";
            this.lblGrossIncomeLabel.Size = new System.Drawing.Size(89, 16);
            this.lblGrossIncomeLabel.TabIndex = 6;
            this.lblGrossIncomeLabel.Text = "Gross Income:";

            this.lblGrossIncomeValue.AutoSize = true;
            this.lblGrossIncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossIncomeValue.Location = new System.Drawing.Point(550, 45);
            this.lblGrossIncomeValue.Name = "lblGrossIncomeValue";
            this.lblGrossIncomeValue.Size = new System.Drawing.Size(0, 16);
            this.lblGrossIncomeValue.TabIndex = 7;
            this.lblGrossIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // grpRegularDeductions
            this.grpRegularDeductions.Controls.Add(this.lblSSSLabel);
            this.grpRegularDeductions.Controls.Add(this.lblSSSValue);
            this.grpRegularDeductions.Controls.Add(this.lblPhilHealthLabel);
            this.grpRegularDeductions.Controls.Add(this.lblPhilHealthValue);
            this.grpRegularDeductions.Controls.Add(this.lblPagIbigLabel);
            this.grpRegularDeductions.Controls.Add(this.lblPagIbigValue);
            this.grpRegularDeductions.Controls.Add(this.lblIncomeTaxLabel);
            this.grpRegularDeductions.Controls.Add(this.lblIncomeTaxValue);
            this.grpRegularDeductions.Location = new System.Drawing.Point(10, 250);
            this.grpRegularDeductions.Name = "grpRegularDeductions";
            this.grpRegularDeductions.Size = new System.Drawing.Size(770, 100);
            this.grpRegularDeductions.TabIndex = 2;
            this.grpRegularDeductions.TabStop = false;
            this.grpRegularDeductions.Text = "REGULAR DEDUCTIONS";

            this.lblSSSLabel.AutoSize = true;
            this.lblSSSLabel.Location = new System.Drawing.Point(10, 25);
            this.lblSSSLabel.Name = "lblSSSLabel";
            this.lblSSSLabel.Size = new System.Drawing.Size(36, 16);
            this.lblSSSLabel.TabIndex = 0;
            this.lblSSSLabel.Text = "SSS:";

            this.lblSSSValue.AutoSize = true;
            this.lblSSSValue.Location = new System.Drawing.Point(200, 25);
            this.lblSSSValue.Name = "lblSSSValue";
            this.lblSSSValue.Size = new System.Drawing.Size(0, 16);
            this.lblSSSValue.TabIndex = 1;
            this.lblSSSValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPhilHealthLabel.AutoSize = true;
            this.lblPhilHealthLabel.Location = new System.Drawing.Point(10, 45);
            this.lblPhilHealthLabel.Name = "lblPhilHealthLabel";
            this.lblPhilHealthLabel.Size = new System.Drawing.Size(81, 16);
            this.lblPhilHealthLabel.TabIndex = 2;
            this.lblPhilHealthLabel.Text = "PhilHealth:";

            this.lblPhilHealthValue.AutoSize = true;
            this.lblPhilHealthValue.Location = new System.Drawing.Point(200, 45);
            this.lblPhilHealthValue.Name = "lblPhilHealthValue";
            this.lblPhilHealthValue.Size = new System.Drawing.Size(0, 16);
            this.lblPhilHealthValue.TabIndex = 3;
            this.lblPhilHealthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPagIbigLabel.AutoSize = true;
            this.lblPagIbigLabel.Location = new System.Drawing.Point(10, 65);
            this.lblPagIbigLabel.Name = "lblPagIbigLabel";
            this.lblPagIbigLabel.Size = new System.Drawing.Size(55, 16);
            this.lblPagIbigLabel.TabIndex = 4;
            this.lblPagIbigLabel.Text = "PagIbig:";

            this.lblPagIbigValue.AutoSize = true;
            this.lblPagIbigValue.Location = new System.Drawing.Point(200, 65);
            this.lblPagIbigValue.Name = "lblPagIbigValue";
            this.lblPagIbigValue.Size = new System.Drawing.Size(0, 16);
            this.lblPagIbigValue.TabIndex = 5;
            this.lblPagIbigValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblIncomeTaxLabel.AutoSize = true;
            this.lblIncomeTaxLabel.Location = new System.Drawing.Point(400, 45);
            this.lblIncomeTaxLabel.Name = "lblIncomeTaxLabel";
            this.lblIncomeTaxLabel.Size = new System.Drawing.Size(77, 16);
            this.lblIncomeTaxLabel.TabIndex = 6;
            this.lblIncomeTaxLabel.Text = "Income Tax:";

            this.lblIncomeTaxValue.AutoSize = true;
            this.lblIncomeTaxValue.Location = new System.Drawing.Point(550, 45);
            this.lblIncomeTaxValue.Name = "lblIncomeTaxValue";
            this.lblIncomeTaxValue.Size = new System.Drawing.Size(0, 16);
            this.lblIncomeTaxValue.TabIndex = 7;
            this.lblIncomeTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // grpOtherDeductions
            this.grpOtherDeductions.Controls.Add(this.lblSSSLoanLabel);
            this.grpOtherDeductions.Controls.Add(this.lblSSSLoanValue);
            this.grpOtherDeductions.Controls.Add(this.lblPagIbigLoanLabel);
            this.grpOtherDeductions.Controls.Add(this.lblPagIbigLoanValue);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsDepositLabel);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsDepositValue);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsLoanLabel);
            this.grpOtherDeductions.Controls.Add(this.lblFacultySavingsLoanValue);
            this.grpOtherDeductions.Controls.Add(this.lblSalaryLoanLabel);
            this.grpOtherDeductions.Controls.Add(this.lblSalaryLoanValue);
            this.grpOtherDeductions.Controls.Add(this.lblOtherLoansLabel);
            this.grpOtherDeductions.Controls.Add(this.lblOtherLoansValue);
            this.grpOtherDeductions.Location = new System.Drawing.Point(10, 360);
            this.grpOtherDeductions.Name = "grpOtherDeductions";
            this.grpOtherDeductions.Size = new System.Drawing.Size(770, 150);
            this.grpOtherDeductions.TabIndex = 3;
            this.grpOtherDeductions.TabStop = false;
            this.grpOtherDeductions.Text = "OTHER DEDUCTIONS";

            this.lblSSSLoanLabel.AutoSize = true;
            this.lblSSSLoanLabel.Location = new System.Drawing.Point(10, 25);
            this.lblSSSLoanLabel.Name = "lblSSSLoanLabel";
            this.lblSSSLoanLabel.Size = new System.Drawing.Size(75, 16);
            this.lblSSSLoanLabel.TabIndex = 0;
            this.lblSSSLoanLabel.Text = "SSS Loan:";

            this.lblSSSLoanValue.AutoSize = true;
            this.lblSSSLoanValue.Location = new System.Drawing.Point(200, 25);
            this.lblSSSLoanValue.Name = "lblSSSLoanValue";
            this.lblSSSLoanValue.Size = new System.Drawing.Size(0, 16);
            this.lblSSSLoanValue.TabIndex = 1;
            this.lblSSSLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblPagIbigLoanLabel.AutoSize = true;
            this.lblPagIbigLoanLabel.Location = new System.Drawing.Point(10, 45);
            this.lblPagIbigLoanLabel.Name = "lblPagIbigLoanLabel";
            this.lblPagIbigLoanLabel.Size = new System.Drawing.Size(94, 16);
            this.lblPagIbigLoanLabel.TabIndex = 2;
            this.lblPagIbigLoanLabel.Text = "PagIbig Loan:";

            this.lblPagIbigLoanValue.AutoSize = true;
            this.lblPagIbigLoanValue.Location = new System.Drawing.Point(200, 45);
            this.lblPagIbigLoanValue.Name = "lblPagIbigLoanValue";
            this.lblPagIbigLoanValue.Size = new System.Drawing.Size(0, 16);
            this.lblPagIbigLoanValue.TabIndex = 3;
            this.lblPagIbigLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblFacultySavingsDepositLabel.AutoSize = true;
            this.lblFacultySavingsDepositLabel.Location = new System.Drawing.Point(10, 65);
            this.lblFacultySavingsDepositLabel.Name = "lblFacultySavingsDepositLabel";
            this.lblFacultySavingsDepositLabel.Size = new System.Drawing.Size(156, 16);
            this.lblFacultySavingsDepositLabel.TabIndex = 4;
            this.lblFacultySavingsDepositLabel.Text = "Faculty Savings Deposit:";

            this.lblFacultySavingsDepositValue.AutoSize = true;
            this.lblFacultySavingsDepositValue.Location = new System.Drawing.Point(200, 65);
            this.lblFacultySavingsDepositValue.Name = "lblFacultySavingsDepositValue";
            this.lblFacultySavingsDepositValue.Size = new System.Drawing.Size(0, 16);
            this.lblFacultySavingsDepositValue.TabIndex = 5;
            this.lblFacultySavingsDepositValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblFacultySavingsLoanLabel.AutoSize = true;
            this.lblFacultySavingsLoanLabel.Location = new System.Drawing.Point(10, 85);
            this.lblFacultySavingsLoanLabel.Name = "lblFacultySavingsLoanLabel";
            this.lblFacultySavingsLoanLabel.Size = new System.Drawing.Size(139, 16);
            this.lblFacultySavingsLoanLabel.TabIndex = 6;
            this.lblFacultySavingsLoanLabel.Text = "Faculty Savings Loan:";

            this.lblFacultySavingsLoanValue.AutoSize = true;
            this.lblFacultySavingsLoanValue.Location = new System.Drawing.Point(200, 85);
            this.lblFacultySavingsLoanValue.Name = "lblFacultySavingsLoanValue";
            this.lblFacultySavingsLoanValue.Size = new System.Drawing.Size(0, 16);
            this.lblFacultySavingsLoanValue.TabIndex = 7;
            this.lblFacultySavingsLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblSalaryLoanLabel.AutoSize = true;
            this.lblSalaryLoanLabel.Location = new System.Drawing.Point(400, 25);
            this.lblSalaryLoanLabel.Name = "lblSalaryLoanLabel";
            this.lblSalaryLoanLabel.Size = new System.Drawing.Size(89, 16);
            this.lblSalaryLoanLabel.TabIndex = 8;
            this.lblSalaryLoanLabel.Text = "Salary Loan:";

            this.lblSalaryLoanValue.AutoSize = true;
            this.lblSalaryLoanValue.Location = new System.Drawing.Point(550, 25);
            this.lblSalaryLoanValue.Name = "lblSalaryLoanValue";
            this.lblSalaryLoanValue.Size = new System.Drawing.Size(0, 16);
            this.lblSalaryLoanValue.TabIndex = 9;
            this.lblSalaryLoanValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblOtherLoansLabel.AutoSize = true;
            this.lblOtherLoansLabel.Location = new System.Drawing.Point(400, 45);
            this.lblOtherLoansLabel.Name = "lblOtherLoansLabel";
            this.lblOtherLoansLabel.Size = new System.Drawing.Size(89, 16);
            this.lblOtherLoansLabel.TabIndex = 10;
            this.lblOtherLoansLabel.Text = "Other Loans:";

            this.lblOtherLoansValue.AutoSize = true;
            this.lblOtherLoansValue.Location = new System.Drawing.Point(550, 45);
            this.lblOtherLoansValue.Name = "lblOtherLoansValue";
            this.lblOtherLoansValue.Size = new System.Drawing.Size(0, 16);
            this.lblOtherLoansValue.TabIndex = 11;
            this.lblOtherLoansValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // grpSummary
            this.grpSummary.Controls.Add(this.lblTotalDeductionsLabel);
            this.grpSummary.Controls.Add(this.lblTotalDeductionsValue);
            this.grpSummary.Controls.Add(this.lblNetIncomeLabel);
            this.grpSummary.Controls.Add(this.lblNetIncomeValue);
            this.grpSummary.Location = new System.Drawing.Point(10, 520);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(770, 80);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "PAYSLIP SUMMARY";

            this.lblTotalDeductionsLabel.AutoSize = true;
            this.lblTotalDeductionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeductionsLabel.Location = new System.Drawing.Point(10, 25);
            this.lblTotalDeductionsLabel.Name = "lblTotalDeductionsLabel";
            this.lblTotalDeductionsLabel.Size = new System.Drawing.Size(116, 16);
            this.lblTotalDeductionsLabel.TabIndex = 0;
            this.lblTotalDeductionsLabel.Text = "Total Deductions:";

            this.lblTotalDeductionsValue.AutoSize = true;
            this.lblTotalDeductionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeductionsValue.Location = new System.Drawing.Point(200, 25);
            this.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            this.lblTotalDeductionsValue.Size = new System.Drawing.Size(0, 16);
            this.lblTotalDeductionsValue.TabIndex = 1;
            this.lblTotalDeductionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblNetIncomeLabel.AutoSize = true;
            this.lblNetIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetIncomeLabel.Location = new System.Drawing.Point(400, 25);
            this.lblNetIncomeLabel.Name = "lblNetIncomeLabel";
            this.lblNetIncomeLabel.Size = new System.Drawing.Size(83, 16);
            this.lblNetIncomeLabel.TabIndex = 2;
            this.lblNetIncomeLabel.Text = "Net Income:";

            this.lblNetIncomeValue.AutoSize = true;
            this.lblNetIncomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetIncomeValue.Location = new System.Drawing.Point(550, 25);
            this.lblNetIncomeValue.Name = "lblNetIncomeValue";
            this.lblNetIncomeValue.Size = new System.Drawing.Size(0, 16);
            this.lblNetIncomeValue.TabIndex = 3;
            this.lblNetIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Height = 50;
            this.pnlButtons.Location = new System.Drawing.Point(0, 650);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 50);
            this.pnlButtons.TabIndex = 1;

            // btnPrint
            this.btnPrint.Location = new System.Drawing.Point(300, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(410, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // PayslipReport
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.pnlPayslip);
            this.Controls.Add(this.pnlButtons);
            this.Name = "PayslipReport";
            this.Text = "Payslip Report";
            this.pnlPayslip.ResumeLayout(false);
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpEmployeeInfo.ResumeLayout(false);
            this.grpIncomeDetails.ResumeLayout(false);
            this.grpIncomeDetails.ResumeLayout(false);
            this.grpRegularDeductions.ResumeLayout(false);
            this.grpRegularDeductions.ResumeLayout(false);
            this.grpOtherDeductions.ResumeLayout(false);
            this.grpOtherDeductions.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlPayslip;
        private System.Windows.Forms.GroupBox grpEmployeeInfo;
        private System.Windows.Forms.Label lblEmployeeNumberLabel;
        private System.Windows.Forms.Label lblEmployeeNumberValue;
        private System.Windows.Forms.Label lblFirstNameLabel;
        private System.Windows.Forms.Label lblFirstNameValue;
        private System.Windows.Forms.Label lblSurnameLabel;
        private System.Windows.Forms.Label lblSurnameValue;
        private System.Windows.Forms.Label lblDepartmentLabel;
        private System.Windows.Forms.Label lblDepartmentValue;
        private System.Windows.Forms.Label lblDesignationLabel;
        private System.Windows.Forms.Label lblDesignationValue;
        private System.Windows.Forms.Label lblPaydateLabel;
        private System.Windows.Forms.Label lblPaydateValue;
        private System.Windows.Forms.GroupBox grpIncomeDetails;
        private System.Windows.Forms.Label lblBasicIncomeLabel;
        private System.Windows.Forms.Label lblBasicIncomeValue;
        private System.Windows.Forms.Label lblHonoriariumIncomeLabel;
        private System.Windows.Forms.Label lblHonoriariumIncomeValue;
        private System.Windows.Forms.Label lblOtherIncomeLabel;
        private System.Windows.Forms.Label lblOtherIncomeValue;
        private System.Windows.Forms.Label lblGrossIncomeLabel;
        private System.Windows.Forms.Label lblGrossIncomeValue;
        private System.Windows.Forms.GroupBox grpRegularDeductions;
        private System.Windows.Forms.Label lblSSSLabel;
        private System.Windows.Forms.Label lblSSSValue;
        private System.Windows.Forms.Label lblPhilHealthLabel;
        private System.Windows.Forms.Label lblPhilHealthValue;
        private System.Windows.Forms.Label lblPagIbigLabel;
        private System.Windows.Forms.Label lblPagIbigValue;
        private System.Windows.Forms.Label lblIncomeTaxLabel;
        private System.Windows.Forms.Label lblIncomeTaxValue;
        private System.Windows.Forms.GroupBox grpOtherDeductions;
        private System.Windows.Forms.Label lblSSSLoanLabel;
        private System.Windows.Forms.Label lblSSSLoanValue;
        private System.Windows.Forms.Label lblPagIbigLoanLabel;
        private System.Windows.Forms.Label lblPagIbigLoanValue;
        private System.Windows.Forms.Label lblFacultySavingsDepositLabel;
        private System.Windows.Forms.Label lblFacultySavingsDepositValue;
        private System.Windows.Forms.Label lblFacultySavingsLoanLabel;
        private System.Windows.Forms.Label lblFacultySavingsLoanValue;
        private System.Windows.Forms.Label lblSalaryLoanLabel;
        private System.Windows.Forms.Label lblSalaryLoanValue;
        private System.Windows.Forms.Label lblOtherLoansLabel;
        private System.Windows.Forms.Label lblOtherLoansValue;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotalDeductionsLabel;
        private System.Windows.Forms.Label lblTotalDeductionsValue;
        private System.Windows.Forms.Label lblNetIncomeLabel;
        private System.Windows.Forms.Label lblNetIncomeValue;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}
