using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGUiAppFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Width = 150;
            label4.Height = 200;
            comboLocation.Items.Insert(0, "----Select location----");
            comboLocation.Items.Add("Pune");
            comboLocation.Items.Add("Mumbai");
            comboLocation.Items.Add("Chennai");
            comboLocation.Items.Add("Bangluru");
            comboLocation.Items.Add("Hyderabad");
            comboLocation.SelectedIndex = 0;
            string[] myFruit = { "EDP", "Accounts", "Finance" ,"research","Infra Mgmt"};
            checkedListBox1.Items.AddRange(myFruit);
            checkedListBox1.CheckOnClick = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int dCode = Convert.ToInt32(txtDeptCode.Text);
            string dName = txtDeptName.Text;
            string location = comboLocation.SelectedItem.ToString();
            string strchk = "Sub devisiosn are: ";
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                // Use the IndexOf method to get the index of an item.
                strchk +=  "-- " + itemChecked.ToString(); //+
                                //"\", is checked. Checked state is: " +
                                //checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".";
            }
            label4.Text = "You eneter details as " + Environment.NewLine + dCode + " " + dName + " " + location + " " + strchk;
            DialogResult result= MessageBox.Show("Do you want to continue?",
                            "WonderWord",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                txtDeptCode.Text = "";
                txtDeptCode.Focus();
                txtDeptName.Text = "";
                comboLocation.SelectedIndex = 0;
            }
            else
            {
                this.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
