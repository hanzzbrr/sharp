using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GalimskyDayPlanner
{
    public partial class PhoneBookForm : Form
    {
        public static PhoneBookForm form;

        List<LabelPhone> labels = new List<LabelPhone>();

        Color defColor = Color.White;
        Color highlitedColor = Color.Gray;

        public PhoneBookForm()
        {
            InitializeComponent();
        }

        public static PhoneBookForm GetInstance()
        {
            if (form == null)
            {
                form = new PhoneBookForm();
                form.FormClosed += delegate {
                    form = null;
                };
            }
            return form;
        }
        int index = 0;

        private void CrtNumberButton_Click(object sender, EventArgs e)
        {
            CreatePhoneForm createPhoneForm = new CreatePhoneForm();
            createPhoneForm.inputName.Text = "Введите имя";
            createPhoneForm.inputPhone.Text = "Введите номер";
            createPhoneForm.Show();
            this.Enabled = false;
            createPhoneForm.FormClosed += delegate { this.Enabled = true; OutNumbers(); };

            //Data.numbers.Add(new PhoneNumber(testNumbers[index],testNames[index]));
            //index++;
            //OutNumbers();
        }

        private void EditNumberButton_Click(object sender, EventArgs e)
        {
            LabelPhone label = sender as LabelPhone;
            CreatePhoneForm createPhoneForm = new CreatePhoneForm();
            createPhoneForm.inputName.Text = label.phoneNumber.name;
            createPhoneForm.inputPhone.Text = label.phoneNumber.number;
            createPhoneForm.phoneNumber = label.phoneNumber;
            createPhoneForm.Show();
            this.Enabled = false;
            createPhoneForm.FormClosed += delegate { this.Enabled = true; OutNumbers(); };
        }

        private static Random rand = new Random();
        private void GenList()
        {
            Data.numbers = new List<PhoneNumber>();
            for (int i = 0; i < PhoneNumber.chars.Length; i++)
            {
                int count = 1;
                for (int j = 0; j < count; j++)
                {
                    int index = i * count + j;
                    Data.numbers.Add(new PhoneNumber());
                    Data.numbers[index].firstLetter = PhoneNumber.chars[i];
                    Data.numbers[index].SetRandomName(PhoneNumber.chars[i]);
                    Data.numbers[index].SetRandomNumber('8');
                }
            }
            Data.numbers.Sort();
        }

        private void OutNumbers()
        {
            //Console.WriteLine("=====================================================");
            Data.numbers.Sort();
            
            labels.Clear();

            numbersPanel.Controls.Clear();
            int ind = 0;

            //int charInd = 0;
            char signature = Data.numbers[0].firstLetter;
            labels.Add(new LabelPhone());
            labels.Last().Text = signature.ToString();
            labels.Last().Location = new Point(10, 10 + ind * 25);
            numbersPanel.Controls.Add(labels.Last());
            ind++;

            labels.Add(new LabelPhone());
            labels.Last().Text = Data.numbers[0].name + " | " + Data.numbers[0].number;
            labels.Last().phoneNumber = Data.numbers[0];
            labels.Last().Location = new Point(10, 10 + ind * 25);
            labels.Last().AutoSize = false;
            labels.Last().Width = 400;
            labels.Last().BackColor = defColor;
            labels.Last().Click += new EventHandler(EditNumberButton_Click);
            labels.Last().MouseEnter += new EventHandler(label_MouseEnter);
            labels.Last().MouseLeave += new EventHandler(label_MouseExit);
            numbersPanel.Controls.Add(labels.Last());
            ind++;

            for (int i=1; i < Data.numbers.Count; i++)
            {
                if (char.ToUpper(Data.numbers[i].firstLetter) != char.ToUpper(signature)) //&& charInd < PhoneNumber.chars.Length-1)
                {
                    //charInd++;
                    signature = Data.numbers[i].firstLetter;
                    labels.Add(new LabelPhone());
                    labels.Last().Text = signature.ToString();
                    labels.Last().Location = new Point(10, 10 + ind * 25);
                    numbersPanel.Controls.Add(labels.Last());
                    ind++;
                    //Console.WriteLine(signature);
                }
                //Console.WriteLine(Data.numbers[i]);
                labels.Add(new LabelPhone());
                labels.Last().Text =Data.numbers[i].name+" | " + Data.numbers[i].number;
                labels.Last().phoneNumber = Data.numbers[i];
                labels.Last().Location = new Point(10, 10+ind*25);
                labels.Last().AutoSize = false;
                labels.Last().Width = 400;
                labels.Last().BackColor = defColor;
                labels.Last().Click += new EventHandler(EditNumberButton_Click);
                labels.Last().MouseEnter += new EventHandler(label_MouseEnter);
                labels.Last().MouseLeave += new EventHandler(label_MouseExit);
                numbersPanel.Controls.Add(labels.Last());
                ind++;
            }
           
        }

        

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = highlitedColor;
        }

        private void label_MouseExit(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.BackColor = defColor;
        }

        private void LB_Click(object sender, EventArgs e)
        {
            //Label label = sender as Label;
            //label.BackColor = defColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutNumbers();
        }
    }
}
