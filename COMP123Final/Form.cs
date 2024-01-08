using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123Final
{
    public partial class formPeople : Form
    {
        People _people = new People();
        BindingSource _bindSource = new BindingSource();
        public formPeople()
        {
            InitializeComponent();
            dgvDisplayResult.DataSource = _bindSource;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            numAge.Value = 0;
            rbAndroid.Checked = false;
            rbApple.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.Age = Convert.ToInt32(numAge.Value);
            if(rbAndroid.Checked)
            {
                person.MobileType = MobileType.Android;
            }
            else if(rbApple.Checked)
            {
                person.MobileType = MobileType.Apple;
            }
            else
            {
                person.MobileType = MobileType.None;
            }

            _people.Add(person);
            lblTotalPeople.Text = $"Total People: {_people.Count}";
            txtFirstName.Clear();
            txtLastName.Clear();
            numAge.Value = 0;
            rbAndroid.Checked = false;
            rbApple.Checked = false;

        }

        private void rbShowAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            _bindSource.DataSource = _people.GetAllPeople();
            lblVisiblePeople.Text = $"Visible People: {_people.Count}";
            dgvDisplayResult.Refresh();
           
        }

        private void rbShowAppleUsers_CheckedChanged(object sender, EventArgs e)
        {
            _bindSource.DataSource = _people.GetApplePeople();
            lblVisiblePeople.Text = $"Visible People: { _people.Count}";
            dgvDisplayResult.Refresh();
        
        }

        private void rbShowAndroidUsers_CheckedChanged(object sender, EventArgs e)
        {
            _bindSource.DataSource = _people.GetAndroidPeople();
            lblVisiblePeople.Text = $"Visible People: { _people.Count}";
            dgvDisplayResult.Refresh();
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
                _people.Clear();         
        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
