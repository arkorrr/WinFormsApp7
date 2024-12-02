using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class TaskForm : Form
    {
        private MainForm.Task editingTask;

        public TaskForm()
        {
            InitializeComponent();
            DateTimePicker1.MinDate = DateTime.Today;
        }

        public void LoadTaskForEditing(MainForm.Task task) // передача інф з основної форми на додаткову 
        {
            editingTask = task;
            textBoxNameTask.Text = task.Name;
            TextBoxDescription.Text = task.Description;
            DateTimePicker1.Value = task.Deadline;

            if (task.Attachments != null)
            {
                foreach (string file in task.Attachments)
                {
                    listBoxFile.Items.Add(file);
                }
            }
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameTask.Text) || string.IsNullOrWhiteSpace(TextBoxDescription.Text))
            {
                MessageBox.Show("Fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (editingTask != null) // редагування завдання 
            {
                editingTask.Name = textBoxNameTask.Text;
                editingTask.Description = TextBoxDescription.Text;
                editingTask.Deadline = DateTimePicker1.Value;
                editingTask.Attachments = new List<string>();

                foreach (var item in listBoxFile.Items)
                {
                    editingTask.Attachments.Add(item.ToString());
                }
            }
            else // створення нового завдання 
            {
                MainForm.Task newTask = new MainForm.Task
                {
                    Name = textBoxNameTask.Text,
                    Description = TextBoxDescription.Text,
                    Deadline = DateTimePicker1.Value,
                    Attachments = new List<string>()
                };

                foreach (var item in listBoxFile.Items)
                {
                    newTask.Attachments.Add(item.ToString());
                }

                ((MainForm)Owner).AddTask(newTask);
            }

            this.Close();
        }


        private void buttonAddFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select text files",
                Filter = "*.txt|*.txt"

            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    string fileName = System.IO.Path.GetFileName(file); // отримання назви

                    if (!listBoxFile.Items.Contains(fileName)) // перевірка на дублювання
                    {
                        listBoxFile.Items.Add(fileName);
                    }
                }
            }
        }

        private void buttonDeleteFile_Click_1(object sender, EventArgs e)
        {
            if (listBoxFile.SelectedItem != null)
            {
                listBoxFile.Items.Remove(listBoxFile.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select the file to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
