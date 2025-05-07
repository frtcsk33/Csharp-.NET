using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.number = "1";
            classRoom.character = "A";


            Teacher teacher = new Teacher("emirhan", "123");

           
           
        Student student = new Student("144","abdullah","123");
            student.classRoom = classRoom;
            student.teachers.Add(teacher);
            student.GetFullName();

          
            
        }

        List<Teacher> teachers = new List<Teacher>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(textBox1.Text, textBox2.Text);
            teacher.branch = textBox3.Text;
            teachers.Add(teacher);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Teacher item in teachers)
            {
                listBox1.Items.Add($"Kullanıcı adı: {item.userName} branş adı: {item.branch}");
            }
        }


        //inheritance (kalıtım)



    }
}
