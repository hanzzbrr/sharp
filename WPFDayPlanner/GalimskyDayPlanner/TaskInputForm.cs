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
    public partial class TaskInputForm : Form
    {
        public string text;
        private static TaskInputForm form = null;

        public Label lastLabel;
        public Form1 form1;
        public TextBox textBox;

        public DateTime date;
        public string keyDate; //ключ для обращения к Dictionary
        public int keyTime; //ключ для обращения к задаче

        public string startText;


        public TaskInputForm()
        {
            InitializeComponent();
            textBox = textBox1;
        }

        public static TaskInputForm GetInstance()
        {
            if (form == null)
            {
                form = new TaskInputForm();
                form.FormClosed += delegate {
                    form = null;
                };
            }
            return form;
        }

        //*********************************************************************
        //CALLBACK METHODS
        //*********************************************************************
        private void SendInput_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox = (TextBox)sender;
            text = textBox.Text;
            //form1.label.Text = text;
        }

        //данные перезаписываются, либо добавляются
        private void applyTaskButton_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();
        }
        //ничего не происходит, никакие данные не меняются
        private void cancelEditButton_Click(object sender, EventArgs e)
        {
            //form1.label.Text = startText;
            Close();
        }

        //Удаляется ячейка данных
        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            //form1.label.Text = "";

            DeleteData();
            Close();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            GetData();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }

        //*********************************************************************
        //FUNCTIONAL METHODS
        //*********************************************************************
        private void GetData()
        {
            Console.WriteLine(keyDate + " | " + (keyTime));
            // есть оба ключа:  ключ дня и ключ времени
            if (Data.days.ContainsKey(keyDate)) 
            {
                Console.WriteLine("Ключ Days есть");
                Console.WriteLine(Data.days[keyDate]);
                if (Data.days[keyDate].tasks.ContainsKey(keyTime))
                {
                    Console.WriteLine("Ключ tasks есть");
                    textBox1.Text = Data.days[keyDate].tasks[keyTime].text;
                    checkBoxDone.Checked = Data.days[keyDate].tasks[keyTime].isDone;
                }
            }
        }

        private void SaveData()
        {
            if(!Data.days.ContainsKey(keyDate)) //если такого дня нет, то можно инитить таск сразу
            {
                Day day = new Day();
                day.tasks = new Dictionary<int, CalendTask>(19);
                day.tasks.Add(keyTime, new CalendTask(textBox1.Text, checkBoxDone.Checked));
                Data.days.Add(keyDate, day);
            }
            else
            {
                if (!Data.days[keyDate].tasks.ContainsKey(keyTime)) //если ключа в tasks нет
                {
                    Data.days[keyDate].tasks.Add(keyTime, new CalendTask(textBox1.Text,checkBoxDone.Checked));
                }
                else   // в слючае имеющийся ключа в листе taks
                {
                    Data.days[keyDate].tasks[keyTime] = new CalendTask(textBox1.Text, checkBoxDone.Checked);
                }
            }
        }
        //проверка на всякий, но можно и без нее, если кнопки не активны
        private void DeleteData()
        {
            if (Data.days.ContainsKey(keyDate))
            {
                if (Data.days[keyDate].tasks.ContainsKey(keyTime))
                {
                    Data.days[keyDate].tasks.Remove(keyTime);
                }
            }
        }
    }
}
