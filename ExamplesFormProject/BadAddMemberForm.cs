using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescendantsLibrary;
using MembersLibrary1;
using MembersLibrary1.Classes;

namespace ExamplesFormProject
{
    public partial class BadAddMemberForm : Form
    {
        public BadAddMemberForm()
        {
            InitializeComponent();
            Shown += BadAddMemberForm_Shown;
        }
        /// <summary>
        /// Comment out ComboBox SelectedIndex = for
        /// testing all validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BadAddMemberForm_Shown(object sender, EventArgs e)
        {
            var ops = new MembersOperations1();
            GenderComboBox.DataSource = ops.GetGenders();
            GenderComboBox.SelectedIndex = 1;
            CountryComboBox.DataSource = ops.Countries;
            CountryComboBox.SelectedIndex = 1;
        }
        /// <summary>
        /// Attempt to add a new member record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            var controls = this.TextBoxList();
            foreach (var textBox in controls)
            {
                errorProvider1.SetError(textBox,"");
            }

            if (GenderComboBox.SelectedIndex == 0 || CountryComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("Dropdown items must be selected");
                return;
            }
            var person = new MemberList1
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Gender = ((Gender) GenderComboBox.SelectedItem).Id,
                Street = StreetTextBox.Text,
                City = CityTextBox.Text,
                State = StateTextBox.Text,
                Country = CountryComboBox.Text,
                ContactPhone = PhoneTextBox.Text
            };

            var ops = new MembersOperations1();
            ops.AddBadMember1(person);

            if (!ops.IsSuccessFul)
            {
                /*
                 * Do we have a generic error?
                 */
                if (ops.LastException != null)
                {
                    MessageBox.Show(ops.LastExceptionMessage);
                    return;
                }

                /*
                 * No generic error, move on to validation errors.
                 */
                var errorInformation = ops.ValidationErrors;
                foreach (var item in errorInformation.EntityValidationExceptionList)
                {
                    foreach (var itemItem in item.Items)
                    {
                        var currentBox = controls
                            .FirstOrDefault(tb => tb.Tag.ToString() == itemItem.PropertyName);

                        if (currentBox != null)
                        {
                            errorProvider1.SetError(currentBox,itemItem.ErrorMessage);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Added member");
            }
        }
    }
}
