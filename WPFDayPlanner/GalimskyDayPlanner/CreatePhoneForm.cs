using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalimskyDayPlanner
{
    public partial class CreatePhoneForm : Form
    {
        public TextBox inputPhone;
        public TextBox inputName;

        public PhoneNumber phoneNumber;

        public string phoneToSave;
        public string nameToSave;

        public CreatePhoneForm()
        {
            InitializeComponent();
            inputPhone = textBoxPhone;
            inputName = textBoxName;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine(phoneNumber);
            //Console.WriteLine(Data.numbers.Remove(new PhoneNumber() { name = phoneNumber.name, number = phoneNumber.number }));
            Console.WriteLine(Data.numbers.Remove(phoneNumber));
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (phoneNumber != null)
            {
                phoneNumber.name = textBoxName.Text;
                phoneNumber.number = textBoxPhone.Text;
            }
            else
            {

                phoneNumber = new PhoneNumber(textBoxPhone.Text, textBoxName.Text);
                if (!Data.numbers.Exists(pn => pn.name == textBoxName.Text && pn.number == textBoxPhone.Text))
                {
                    Data.numbers.Add(new PhoneNumber(textBoxPhone.Text, textBoxName.Text));
                    Data.numbers.Last().firstLetter = inputName.Text[0];
                }
            }
            Close();
        }
    }
}
