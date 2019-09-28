using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpencesBook
{
    public partial class ItemForm : Form
    {
        private ItemForm()
        {
            //do not use
        }
        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);
        }

        public ItemForm(CategoryDataSet dsCategory,
            DateTime nowDate,
            string category,
            string item,
            int money,
            string remarks)
        {
            InitializeComponent();
            categoryDataSet.Merge(dsCategory);

            monCalendar.SetDate(nowDate);
            cmbCategory.Text = category;
            txtItem.Text = item;
            mtxtMoney.Text = money.ToString();
            txtRemarks.Text = remarks;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
