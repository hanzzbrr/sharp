namespace GalimskyDayPlanner
{
    partial class TaskInputForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.applyTaskButton = new System.Windows.Forms.Button();
            this.cancelEditButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.checkBoxDone = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(509, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // applyTaskButton
            // 
            this.applyTaskButton.Location = new System.Drawing.Point(397, 70);
            this.applyTaskButton.Name = "applyTaskButton";
            this.applyTaskButton.Size = new System.Drawing.Size(125, 23);
            this.applyTaskButton.TabIndex = 1;
            this.applyTaskButton.Text = "Сохранить задачу";
            this.applyTaskButton.UseVisualStyleBackColor = true;
            this.applyTaskButton.Click += new System.EventHandler(this.applyTaskButton_Click);
            // 
            // cancelEditButton
            // 
            this.cancelEditButton.Location = new System.Drawing.Point(211, 70);
            this.cancelEditButton.Name = "cancelEditButton";
            this.cancelEditButton.Size = new System.Drawing.Size(150, 23);
            this.cancelEditButton.TabIndex = 2;
            this.cancelEditButton.Text = "Отменить изменения";
            this.cancelEditButton.UseVisualStyleBackColor = true;
            this.cancelEditButton.Click += new System.EventHandler(this.cancelEditButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(13, 70);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(163, 23);
            this.deleteTaskButton.TabIndex = 3;
            this.deleteTaskButton.Text = "Стереть задачу";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // checkBoxDone
            // 
            this.checkBoxDone.AutoSize = true;
            this.checkBoxDone.Location = new System.Drawing.Point(13, 38);
            this.checkBoxDone.Name = "checkBoxDone";
            this.checkBoxDone.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDone.TabIndex = 4;
            this.checkBoxDone.Text = "Выполнено!";
            this.checkBoxDone.UseVisualStyleBackColor = true;
            // 
            // TaskInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 106);
            this.Controls.Add(this.checkBoxDone);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.cancelEditButton);
            this.Controls.Add(this.applyTaskButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskInputForm";
            this.Text = "TaskInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button applyTaskButton;
        private System.Windows.Forms.Button cancelEditButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.CheckBox checkBoxDone;
    }
}