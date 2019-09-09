using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public class expenseModel
    {
        public int expenseID { get; set; }

        public string Name { get; set; }

        public double Amount { get; set; }

        public string Date { get; set; }
    }
}
