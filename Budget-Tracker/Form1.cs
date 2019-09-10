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
        int expenseID = -1;

        List<expenseModel> expenses = new List<expenseModel>();
        public Form1()
        {
            InitializeComponent();
            loadExpenseList();
        }

        private void loadExpenseList()
        {
            double totalAmount = 0;
            expenseID = -1;
            datePicker.Text = DateTime.Today.ToString();
            txtName.Text = "";
            txtAmount.Text = "";
            expenses = SQLiteDataAccess.loadExpenses();
            wireExpenseList();
            foreach (DataGridViewRow item in listBox.Rows)
            {
                totalAmount += Convert.ToDouble(item.Cells[2].Value.ToString());
            }
            txtTotalAmount.Text = totalAmount.ToString();
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
                double tempAmount = Convert.ToDouble(txtAmount.Text);
                double finalAmount = 0;
                if (tempAmount > 0)
                    finalAmount = tempAmount * -1;
                else finalAmount = tempAmount;
         

                em.Name = txtName.Text;
                em.Amount = finalAmount;
                em.Date = datePicker.Value.ToString("MM/dd/yyy");

                if (expenseID == -1)
                    SQLiteDataAccess.saveExpenses(em);
                else
                    SQLiteDataAccess.editExpenses(em, expenseID);

                loadExpenseList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBox.CurrentRow.Index != -1)
                {
                    expenseID = Convert.ToInt32(listBox.CurrentRow.Cells[0].Value.ToString());
                    txtName.Text = listBox.CurrentRow.Cells[1].Value.ToString();
                    txtAmount.Text = listBox.CurrentRow.Cells[2].Value.ToString();
                    datePicker.Text = listBox.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (expenseID != -1)
                SQLiteDataAccess.deleteExpenses(expenseID);
            loadExpenseList();
        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            try
            {
                expenseModel em = new expenseModel();
                double tempAmount = Convert.ToDouble(txtAmount.Text);
                double finalAmount = 0;
                if (tempAmount < 0)
                    finalAmount = tempAmount * -1;
                else finalAmount = tempAmount;


                em.Name = txtName.Text;
                em.Amount = finalAmount;
                em.Date = datePicker.Value.ToString("MM/dd/yyy");

                if (expenseID == -1)
                    SQLiteDataAccess.saveExpenses(em);
                else
                    SQLiteDataAccess.editExpenses(em, expenseID);

                loadExpenseList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
