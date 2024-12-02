namespace WinFormsApp7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTask = new ListBox();
            ButtonAddTask = new Button();
            buttonDeleteTask = new Button();
            buttonEditTask = new Button();
            buttonTaskInfo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxTask
            // 
            listBoxTask.FormattingEnabled = true;
            listBoxTask.Location = new Point(30, 49);
            listBoxTask.Name = "listBoxTask";
            listBoxTask.Size = new Size(360, 184);
            listBoxTask.TabIndex = 0;
            // 
            // ButtonAddTask
            // 
            ButtonAddTask.Location = new Point(28, 239);
            ButtonAddTask.Name = "ButtonAddTask";
            ButtonAddTask.Size = new Size(94, 29);
            ButtonAddTask.TabIndex = 1;
            ButtonAddTask.Text = "Add Task";
            ButtonAddTask.UseVisualStyleBackColor = true;
            ButtonAddTask.Click += ButtonAddTask_Click;
            // 
            // buttonDeleteTask
            // 
            buttonDeleteTask.Location = new Point(158, 239);
            buttonDeleteTask.Name = "buttonDeleteTask";
            buttonDeleteTask.Size = new Size(94, 29);
            buttonDeleteTask.TabIndex = 2;
            buttonDeleteTask.Text = "Delete Task";
            buttonDeleteTask.UseVisualStyleBackColor = true;
            buttonDeleteTask.Click += ButtonDeleteTask_Click;
            // 
            // buttonEditTask
            // 
            buttonEditTask.Location = new Point(28, 274);
            buttonEditTask.Name = "buttonEditTask";
            buttonEditTask.Size = new Size(94, 29);
            buttonEditTask.TabIndex = 3;
            buttonEditTask.Text = "Edit Task";
            buttonEditTask.UseVisualStyleBackColor = true;
            buttonEditTask.Click += ButtonEditTask_Click;
            // 
            // buttonTaskInfo
            // 
            buttonTaskInfo.Location = new Point(158, 274);
            buttonTaskInfo.Name = "buttonTaskInfo";
            buttonTaskInfo.Size = new Size(94, 29);
            buttonTaskInfo.TabIndex = 4;
            buttonTaskInfo.Text = "Task Info";
            buttonTaskInfo.UseVisualStyleBackColor = true;
            buttonTaskInfo.Click += ButtonTaskInfo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 5;
            label1.Text = "Tasks";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 330);
            Controls.Add(label1);
            Controls.Add(buttonTaskInfo);
            Controls.Add(buttonEditTask);
            Controls.Add(buttonDeleteTask);
            Controls.Add(ButtonAddTask);
            Controls.Add(listBoxTask);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTask;
        private Button ButtonAddTask;
        private Button buttonDeleteTask;
        private Button buttonEditTask;
        private Button buttonTaskInfo;
        private Label label1;
    }
}
