namespace AlarmClock
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            tabTime = new TabControl();
            tabPage1 = new TabPage();
            timeLabel = new Label();
            tabPage2 = new TabPage();
            btnStop = new Button();
            AlarmLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonSetTime = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            tabTime.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // tabTime
            // 
            tabTime.Controls.Add(tabPage1);
            tabTime.Controls.Add(tabPage2);
            tabTime.Dock = DockStyle.Fill;
            tabTime.Location = new Point(0, 0);
            tabTime.Name = "tabTime";
            tabTime.SelectedIndex = 0;
            tabTime.Size = new Size(800, 450);
            tabTime.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(timeLabel);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Clock";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI Emoji", 20F);
            timeLabel.Location = new Point(338, 140);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(109, 46);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnStop);
            tabPage2.Controls.Add(AlarmLabel);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(buttonSetTime);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alarm";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(510, 310);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop Time";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += button1_Click;
            // 
            // AlarmLabel
            // 
            AlarmLabel.AutoSize = true;
            AlarmLabel.Font = new Font("Segoe UI", 20F);
            AlarmLabel.Location = new Point(328, 194);
            AlarmLabel.Name = "AlarmLabel";
            AlarmLabel.Size = new Size(111, 46);
            AlarmLabel.TabIndex = 3;
            AlarmLabel.Text = "Status";
            AlarmLabel.TextAlign = ContentAlignment.TopCenter;
            AlarmLabel.Click += AlarmLabel_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(261, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(243, 51);
            dateTimePicker1.TabIndex = 2;
            // 
            // buttonSetTime
            // 
            buttonSetTime.Location = new Point(178, 310);
            buttonSetTime.Name = "buttonSetTime";
            buttonSetTime.Size = new Size(94, 29);
            buttonSetTime.TabIndex = 1;
            buttonSetTime.Text = "Set Time";
            buttonSetTime.UseVisualStyleBackColor = true;
            buttonSetTime.Click += buttonSetTime_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabTime);
            Name = "Form1";
            Text = "Form1";
            tabTime.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private TabControl tabTime;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label timeLabel;
        private System.Windows.Forms.Timer timer2;
        private DateTimePicker dateTimePicker1;
        private Button buttonSetTime;
        private Label AlarmLabel;
        private Button btnStop;
    }
}
