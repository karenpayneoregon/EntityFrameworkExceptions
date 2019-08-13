using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamplesFormProject
{
    public partial class ExceptionResultsForm : Form
    {
        private string _ErrorMessages;
        public ExceptionResultsForm(string ErrorMessages)
        {
            InitializeComponent();
            _ErrorMessages = ErrorMessages;
            Shown += ExceptionResultsForm_Shown;
        }

        private void ExceptionResultsForm_Shown(object sender, EventArgs e)
        {
            textBox1.Text = _ErrorMessages;
        }

        public ExceptionResultsForm()
        {
            InitializeComponent();
        }
    }
}
