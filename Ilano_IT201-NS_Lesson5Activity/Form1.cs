using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Ilano_IT201_NS_Lesson5Activity
{
    public partial class Lesson5Activity : Form
    {
        public Lesson5Activity()
        {
            InitializeComponent();
            // wire event handlers for buttons
            this.btnNetIncome.Click += this.button2_Click;
            this.btnSave.Click += this.button3_Click;
            this.btnUpdate.Click += this.button4_Click;
            this.btnNew.Click += this.button5_Click;
        }

        private decimal GetValue(TextBox txt)
        {
            // Safely attempts to parse the textbox text to a decimal. If empty, returns 0.
            decimal.TryParse(txt.Text, out decimal result);
            return result;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbphoto_Click(object sender, EventArgs e)
        {

        }

        private void lblRateHourOtherIncome_Click(object sender, EventArgs e)
        {

        }

        private void lblNoOfHoursCutOffOtherIncome_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate incomes for Basic, Honorarium and Other and set gross income
            decimal basic = ParseDecimal(txtRateHourBasicIncome) * ParseDecimal(txtNoOfHoursCutOffBasicIncome);
            decimal honorarium = ParseDecimal(txtRateHourHonorariumIncome) * ParseDecimal(txtNoOfHoursCutOffHonorariumIncome);
            decimal other = ParseDecimal(txtRateHourOtherIncome) * ParseDecimal(txtNoOfHoursCutOffOtherIncome);

            txtIncomeCutOffBasicIncome.Text = basic.ToString("F2");
            txtIncomeCutOffHonorariumIncome.Text = honorarium.ToString("F2");
            txtIncomeCutOffOtherIncome.Text = other.ToString("F2");

            decimal gross = basic + honorarium + other;
            txtGrossIncomeSummaryIncome.Text = gross.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure gross income is up to date
            decimal gross;
            if (!decimal.TryParse(txtGrossIncomeSummaryIncome.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out gross))
            {
                // if gross not present, recalc by invoking button1 logic
                button1_Click(sender, e);
                gross = ParseDecimal(txtGrossIncomeSummaryIncome);
            }

            // Sum regular deductions
            decimal totalDeductions = 0m;
            totalDeductions += ParseDecimal(txtSSSContributors);
            totalDeductions += ParseDecimal(txtPhilHealthContribution);
            totalDeductions += ParseDecimal(txtPagIbigContribution);
            totalDeductions += ParseDecimal(txtIncomeTaxContribution);

            // Sum other deductions
            totalDeductions += ParseDecimal(txtSSSLoan);
            totalDeductions += ParseDecimal(txtPagIbigLoan);
            totalDeductions += ParseDecimal(txtFacultySavingsDeposit);
            totalDeductions += ParseDecimal(txtFacultySavingsLoan);
            totalDeductions += ParseDecimal(txtSalaryLoan);
            totalDeductions += ParseDecimal(txtOtherLoans);

            txtTotalDeductions.Text = totalDeductions.ToString("F2");

            decimal net = gross - totalDeductions;
            txtNetIncomeSummaryIncome.Text = net.ToString("F2");
        }

        private decimal ParseDecimal(TextBox tb)
        {
            if (tb == null)
                return 0m;

            var s = tb.Text?.Trim();
            if (string.IsNullOrEmpty(s))
                return 0m;

            decimal v;
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, out v))
                return v;

            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out v))
                return v;

            // remove common separators and try again
            var cleaned = s.Replace(",", "").Replace(" ", "");
            if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out v))
                return v;

            return 0m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SAVE - Insert new employee record
            if (!ValidateInput())
            {
                MessageBox.Show("Please fill in required fields (Employee Number, First Name).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure calculations are up to date
            button2_Click(sender, e);

            // In a real application, you would save to a database here
            MessageBox.Show($"Employee record for {txtFirstName.Text} {txtSurname.Text} saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Display payslip report
            PayslipReport payslipForm = new PayslipReport(this);
            payslipForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // UPDATE - Modify existing employee record
            if (string.IsNullOrEmpty(txtEmployeeNumber.Text))
            {
                MessageBox.Show("Please enter an employee number first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                MessageBox.Show("Please fill in required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // In a real application, you would update the database here
            MessageBox.Show($"Employee record for {txtFirstName.Text} {txtSurname.Text} updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // NEW - Clear all fields for new employee entry
            DialogResult result = MessageBox.Show("Clear all fields for a new employee record?", "New Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            // Clear employee basic info
            txtEmployeeNumber.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            txtEmployeeStatus.Clear();
            txtPaydate.Clear();
            txtQualifiedDependentsStatus.Clear();
            txtCivilStatus.Clear();
            txtSurname.Clear();
            txtMiddleName.Clear();
            txtFirstName.Clear();

            // Clear income fields
            txtRateHourBasicIncome.Clear();
            txtNoOfHoursCutOffBasicIncome.Clear();
            txtIncomeCutOffBasicIncome.Clear();

            txtRateHourHonorariumIncome.Clear();
            txtNoOfHoursCutOffHonorariumIncome.Clear();
            txtIncomeCutOffHonorariumIncome.Clear();

            txtRateHourOtherIncome.Clear();
            txtNoOfHoursCutOffOtherIncome.Clear();
            txtIncomeCutOffOtherIncome.Clear();

            txtGrossIncomeSummaryIncome.Clear();
            txtNetIncomeSummaryIncome.Clear();

            // Clear deduction fields
            txtSSSContributors.Clear();
            txtPhilHealthContribution.Clear();
            txtPagIbigContribution.Clear();
            txtIncomeTaxContribution.Clear();

            txtSSSLoan.Clear();
            txtPagIbigLoan.Clear();
            txtFacultySavingsDeposit.Clear();
            txtFacultySavingsLoan.Clear();
            txtSalaryLoan.Clear();
            txtOtherLoans.Clear();

            txtTotalDeductions.Clear();
        }

        private bool ValidateInput()
        {
            // Check required fields
            if (string.IsNullOrWhiteSpace(txtEmployeeNumber.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
                return false;

            return true;
        }
    }
}
