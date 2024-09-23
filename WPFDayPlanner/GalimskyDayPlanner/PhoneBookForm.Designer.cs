namespace GalimskyDayPlanner
{
    partial class PhoneBookForm
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
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.CrtNumberButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numbersPanel
            // 
            this.numbersPanel.AutoScroll = true;
            this.numbersPanel.Location = new System.Drawing.Point(13, 12);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(431, 406);
            this.numbersPanel.TabIndex = 0;
            // 
            // CrtNumberButton
            // 
            this.CrtNumberButton.Location = new System.Drawing.Point(161, 424);
            this.CrtNumberButton.Name = "CrtNumberButton";
            this.CrtNumberButton.Size = new System.Drawing.Size(116, 24);
            this.CrtNumberButton.TabIndex = 1;
            this.CrtNumberButton.Text = "Записать номер";
            this.CrtNumberButton.UseVisualStyleBackColor = true;
            this.CrtNumberButton.Click += new System.EventHandler(this.CrtNumberButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "GenList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 423);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "OutList";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CrtNumberButton);
            this.Controls.Add(this.numbersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhoneBookForm";
            this.Text = "PhoneBookForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel numbersPanel;
        private System.Windows.Forms.Button CrtNumberButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}