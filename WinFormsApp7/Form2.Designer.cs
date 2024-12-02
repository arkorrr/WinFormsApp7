namespace WinFormsApp7
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNameTask = new TextBox();
            TextBoxDescription = new TextBox();
            DateTimePicker1 = new DateTimePicker();
            ButtonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAddFile = new Button();
            listBoxFile = new ListBox();
            label4 = new Label();
            buttonDeleteFile = new Button();
            SuspendLayout();
            // 
            // textBoxNameTask
            // 
            textBoxNameTask.Location = new Point(51, 48);
            textBoxNameTask.Name = "textBoxNameTask";
            textBoxNameTask.Size = new Size(240, 27);
            textBoxNameTask.TabIndex = 0;
            // 
            // TextBoxDescription
            // 
            TextBoxDescription.Location = new Point(51, 132);
            TextBoxDescription.Multiline = true;
            TextBoxDescription.Name = "TextBoxDescription";
            TextBoxDescription.ScrollBars = ScrollBars.Both;
            TextBoxDescription.Size = new Size(250, 156);
            TextBoxDescription.TabIndex = 1;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Location = new Point(50, 336);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(250, 27);
            DateTimePicker1.TabIndex = 2;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(51, 542);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(250, 29);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 13);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Enter name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 5;
            label2.Text = "Enter a description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 302);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Enter Date";
            // 
            // buttonAddFile
            // 
            buttonAddFile.Location = new Point(53, 503);
            buttonAddFile.Name = "buttonAddFile";
            buttonAddFile.Size = new Size(94, 29);
            buttonAddFile.TabIndex = 7;
            buttonAddFile.Text = "Add File";
            buttonAddFile.UseVisualStyleBackColor = true;
            buttonAddFile.Click += buttonAddFile_Click_1;
            // 
            // listBoxFile
            // 
            listBoxFile.FormattingEnabled = true;
            listBoxFile.HorizontalScrollbar = true;
            listBoxFile.Location = new Point(50, 413);
            listBoxFile.Name = "listBoxFile";
            listBoxFile.Size = new Size(248, 84);
            listBoxFile.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 376);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 9;
            label4.Text = "Files (attachments) to tasks";
            // 
            // buttonDeleteFile
            // 
            buttonDeleteFile.Location = new Point(197, 503);
            buttonDeleteFile.Name = "buttonDeleteFile";
            buttonDeleteFile.Size = new Size(94, 29);
            buttonDeleteFile.TabIndex = 10;
            buttonDeleteFile.Text = "Delete File";
            buttonDeleteFile.UseVisualStyleBackColor = true;
            buttonDeleteFile.Click += buttonDeleteFile_Click_1;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 583);
            Controls.Add(buttonDeleteFile);
            Controls.Add(label4);
            Controls.Add(listBoxFile);
            Controls.Add(buttonAddFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonSave);
            Controls.Add(DateTimePicker1);
            Controls.Add(TextBoxDescription);
            Controls.Add(textBoxNameTask);
            Name = "TaskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNameTask;
        private TextBox TextBoxDescription;
        private DateTimePicker DateTimePicker1;
        private Button ButtonSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAddFile;
        private ListBox listBoxFile;
        private Label label4;
        private Button buttonDeleteFile;
    }
}