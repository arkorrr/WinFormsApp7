namespace WinFormsApp7
{
    public partial class MainForm : Form
    {
        private List<Task> tasks = new List<Task>();

        public MainForm()
        {
            InitializeComponent();
            UpdateTaskList();
        }

        public class Task
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime Deadline { get; set; }
            public List<string> Attachments { get; set; } = new List<string>();

            public override string ToString()
            {
                return $"{Name} (Deadline: {Deadline.ToShortDateString()})";
            }
        }

        private void UpdateTaskList()
        {
            listBoxTask.Items.Clear();

            foreach (var task in tasks)
            {
                listBoxTask.Items.Add(task);
            }
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm
            {
                Owner = this 
            };
            taskForm.ShowDialog();
        }

        private void ButtonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedItem != null)
            {
                Task selectedTask = listBoxTask.SelectedItem as Task;

                if (selectedTask != null)
                {
                    tasks.Remove(selectedTask);
                    UpdateTaskList();
                }
            }
            else
            {
                MessageBox.Show("Select the task to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedItem != null)
            {
                Task selectedTask = listBoxTask.SelectedItem as Task;

                if (selectedTask != null)
                {
                    TaskForm taskForm = new TaskForm
                    {
                        Owner = this
                    };
                    taskForm.LoadTaskForEditing(selectedTask);
                    taskForm.ShowDialog();
                    UpdateTaskList();
                }
            }
            else
            {
                MessageBox.Show("Select a task to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddTask(Task newTask) 
        {
            tasks.Add(newTask);
            UpdateTaskList();
        }

        private void ButtonTaskInfo_Click(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedItem != null)
            {
                Task selectedTask = listBoxTask.SelectedItem as Task;

                if (selectedTask != null)
                {
                    string attachments = selectedTask.Attachments.Count > 0
                        ? string.Join("\n", selectedTask.Attachments)
                        : "no files";

                    MessageBox.Show(
                        $"Task name: {selectedTask.Name}\n" +
                        $"Description: {selectedTask.Description}\n" +
                        $"Deadline: {selectedTask.Deadline.ToShortDateString()}\n" +
                        $"Files:\n{attachments}",
                        "Info about task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select a task to view information.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}