using System;
using System.Windows.Forms;
using System.Globalization;

namespace Ilano_IT201_NS_Lesson5Activity
{
    public partial class PayslipReport : Form
    {
        private Lesson5Activity parentForm;

        public PayslipReport(Lesson5Activity parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            PopulatePayslip();
        }

        private void PopulatePayslip()
        {
            // Employee Information
            lblEmployeeNumberValue.Text = GetTextBoxValue(parentForm.Controls, "txtEmployeeNumber");
            lblFirstNameValue.Text = GetTextBoxValue(parentForm.Controls, "txtFirstName");
            lblSurnameValue.Text = GetTextBoxValue(parentForm.Controls, "txtSurname");
            lblDepartmentValue.Text = GetTextBoxValue(parentForm.Controls, "txtDepartment");
            lblDesignationValue.Text = GetTextBoxValue(parentForm.Controls, "txtDesignation");
            lblPaydateValue.Text = GetTextBoxValue(parentForm.Controls, "txtPaydate");

            // Income Details
            decimal basicIncome = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtIncomeCutOffBasicIncome"));
            decimal honorariumIncome = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtIncomeCutOffHonorariumIncome"));
            decimal otherIncome = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtIncomeCutOffOtherIncome"));
            decimal grossIncome = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtGrossIncomeSummaryIncome"));

            lblBasicIncomeValue.Text = basicIncome.ToString("N2");
            lblHonoriariumIncomeValue.Text = honorariumIncome.ToString("N2");
            lblOtherIncomeValue.Text = otherIncome.ToString("N2");
            lblGrossIncomeValue.Text = grossIncome.ToString("N2");

            // Regular Deductions
            decimal sssContribution = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtSSSContributors"));
            decimal philhealthContribution = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtPhilHealthContribution"));
            decimal pagibigContribution = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtPagIbigContribution"));
            decimal incomeTaxContribution = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtIncomeTaxContribution"));

            lblSSSValue.Text = sssContribution.ToString("N2");
            lblPhilHealthValue.Text = philhealthContribution.ToString("N2");
            lblPagIbigValue.Text = pagibigContribution.ToString("N2");
            lblIncomeTaxValue.Text = incomeTaxContribution.ToString("N2");

            // Other Deductions
            decimal sssLoan = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtSSSLoan"));
            decimal pagibigLoan = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtPagIbigLoan"));
            decimal facultySavingsDeposit = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtFacultySavingsDeposit"));
            decimal facultySavingsLoan = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtFacultySavingsLoan"));
            decimal salaryLoan = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtSalaryLoan"));
            decimal otherLoans = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtOtherLoans"));

            lblSSSLoanValue.Text = sssLoan.ToString("N2");
            lblPagIbigLoanValue.Text = pagibigLoan.ToString("N2");
            lblFacultySavingsDepositValue.Text = facultySavingsDeposit.ToString("N2");
            lblFacultySavingsLoanValue.Text = facultySavingsLoan.ToString("N2");
            lblSalaryLoanValue.Text = salaryLoan.ToString("N2");
            lblOtherLoansValue.Text = otherLoans.ToString("N2");

            // Summary
            decimal totalDeductions = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtTotalDeductions"));
            decimal netIncome = ParseDecimal(GetTextBoxValue(parentForm.Controls, "txtNetIncomeSummaryIncome"));

            lblTotalDeductionsValue.Text = totalDeductions.ToString("N2");
            lblNetIncomeValue.Text = netIncome.ToString("N2");
        }

        private string GetTextBoxValue(Control.ControlCollection controls, string textBoxName)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox && control.Name == textBoxName)
                {
                    return control.Text;
                }

                // Recursively search in groupboxes and other containers
                if (control.HasChildren)
                {
                    string result = GetTextBoxValue(control.Controls, textBoxName);
                    if (!string.IsNullOrEmpty(result))
                        return result;
                }
            }
            return "";
        }

        private decimal ParseDecimal(string value)
        {
            if (string.IsNullOrEmpty(value))
                return 0m;

            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal result))
                return result;

            if (decimal.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                return result;

            return 0m;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Print functionality can be implemented here
            MessageBox.Show("Print functionality coming soon.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
