using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescendantsLibrary
{
    public static class ControlExtensions
    {
        /// <summary>
        /// Get a collection of a specific type of control from a control or form.
        /// </summary>
        /// <typeparam name="T">Type of control</typeparam>
        /// <param name="control">Control to traverse</param>
        /// <returns>IEnumerable of T</returns>
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T thisControl = child as T;
                if (thisControl != null)
                {
                    yield return (T)thisControl;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
        public static List<TextBox> TextBoxList(this Control pControl) => pControl.Descendants<TextBox>().ToList();
        public static List<Label> LabelList(this Control pControl) => pControl.Descendants<Label>().ToList();
        public static List<DataGridView> DataGridViewList(this Control pControl) => pControl.Descendants<DataGridView>().ToList();
        public static List<ListView> ListViewViewList(this Control pControl) => pControl.Descendants<ListView>().ToList();
        public static List<CheckBox> CheckBoxList(this Control pControl) => pControl.Descendants<CheckBox>().ToList();
        public static List<ComboBox> ComboBoxList(this Control pControl) => pControl.Descendants<ComboBox>().ToList();
        public static List<ListBox> ListBoxList(this Control pControl) => pControl.Descendants<ListBox>().ToList();
        public static List<DateTimePicker> DateTimePickerList(this Control pControl) => pControl.Descendants<DateTimePicker>().ToList();
        public static List<PictureBox> PictureBoxList(this Control pControl) => pControl.Descendants<PictureBox>().ToList();
        public static List<Panel> PanelList(this Control pControl) => pControl.Descendants<Panel>().ToList();
        public static List<GroupBox> GroupBoxList(this Control pControl) => pControl.Descendants<GroupBox>().ToList();
        public static List<Button> ButtonList(this Control pControl) => pControl.Descendants<Button>().ToList();
        public static List<RadioButton> RadioButtonList(this Control pControl) => pControl.Descendants<RadioButton>().ToList();
        public static List<NumericUpDown> NumericUpDownList(this Control pControl) => pControl.Descendants<NumericUpDown>().ToList();
        public static RadioButton RadioButtonChecked(this Control pControl, bool pChecked = true) =>
            pControl.Descendants<RadioButton>().ToList()
                .FirstOrDefault((radioButton) => radioButton.Checked == pChecked);
        public static string[] ControlNames(this IEnumerable<Control> pControls) => pControls.Select((control) => control.Name).ToArray();
    }
}