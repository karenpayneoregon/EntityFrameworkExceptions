using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MembersLibrary.Classes;
using MembersLibrary1;
using MembersLibrary1.Classes;

namespace ExamplesFormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

            var ops = new MembersOperations();
            var results = ops.MembersList();

            foreach (var memberItem in results)
            {
                listView1.Items.Add(new ListViewItem(new[]
                {
                    memberItem.FirstName,
                    memberItem.LastName,
                    memberItem.Gender
                }));

                listView1.Items[listView1.Items.Count -1].Tag = memberItem.Id;
            }

            listView1.Items[0].Selected = true;
            listView1.Select();
        }

        private void SelectedMemberButton_Click(object sender, EventArgs e)
        {
            var test = listView1.SelectedItems[0].Tag;
            listView1.Select();
        }

        private void AddBadNewMemberButton1_Click(object sender, EventArgs e)
        {
            var newMember = new MemberList1()
            {
                FirstName = "Constantine",
                Gender = 2,
                JoinDate = new DateTime(2019,8,1)
            };
            var ops = new MembersOperations1();
            ops.AddBadMember1(newMember);
            if (!ops.IsSuccessFul)
            {
                var test = ops.ValidationErrors;
                var f = new ExceptionResultsForm(ops.ValidationErrorMessage);
                f.ShowDialog();
            }
            
        }
    }
}
