using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Tracker
{
    public partial class Form1 : Form
    {
        List<expenseModel> expenses = new List<expenseModel>();
        public Form1()
        {
            InitializeComponent();
            loadExpenseList();
        }

        private void loadExpenseList()
        {
            expenses = SQLiteDataAccess.loadExpenses();
            wireExpenseList();
        }

        private void wireExpenseList()
        {
            listBox.DataSource = null;
            listBox.DataSource = expenses;
            listBox.Columns[0].Visible = false;
        }

        private void expenseButton_Click(object sender, EventArgs e)
        {
            try
            {
                expenseModel em = new expenseModel();

                em.Name = txtName.Text;
                em.Amount = Convert.ToDouble(txtAmount.Text);
                em.Date = datePicker.Value.ToString("MM/dd/yyy");

                SQLiteDataAccess.saveExpenses(em);

                loadExpenseList();

                txtName.Text = "";
                txtAmount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
