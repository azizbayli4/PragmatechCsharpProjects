using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhotoStuForm
{
    public partial class Form1 : Form
    {
        private List<Student> room;

        public Form1()
        {
            room = new List<Student>();
            InitializeComponent();

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentList list = new StudentList(room);
            list.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFileDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string email = txtEmail.Text.Trim();

            try
            {
                Student student = new Student
                {
                    Name = name,
                    Surname = surname,
                    Email = email
                };
                room.Add(student);
                MessageBox.Show("Added!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
        }
    }
}
