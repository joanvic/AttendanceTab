using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceGUI
{
    public partial class Tab : Form
    {
        public List<string> attendanceList;
        public Tab()
        {
            InitializeComponent();

            attendanceList = new List<string>() { "John Doe", "nelson" };
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string studentName;

            if (!attendanceList.Contains(studentName))
            {
                // pang present
                attendanceList.Add(studentName);
                MessageBox.Show($"{studentName} is marked as present.");
            }
            else
            {

                MessageBox.Show($"{studentName} is already marked as present.");
            }
        }



        public void Attendance_ParentChanged(object sender, EventArgs e)
        {

        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void AttendanceTab_Load(object sender, EventArgs e)
        {

        }

    }
}
