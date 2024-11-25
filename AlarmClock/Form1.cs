namespace AlarmClock
{
    public partial class Form1 : Form
    {
        private DateTime alarmTime;
        System.Timers.Timer timer;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
            //timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Elapsed;
        }


        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AlarmLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now >= alarmTime)
            {

                timer2.Stop();
                AlarmLabel.Text = "Alarm ringing";
            }
        }


        private void buttonSetTime_Click(object sender, EventArgs e)
        {
            timer.Start();
            AlarmLabel.Text = "Running....";

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


        }

        delegate void UpdateLabel(Label lbl, string value);
        void UpdateDataLabel(Label lbl, string value)
        {
            lbl.Text = value;
        }


        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            if (currTime.Hour == userTime.Hour && currTime.Minute == userTime.Minute && currTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLabel upd = UpdateDataLabel;
                    if (AlarmLabel.InvokeRequired)
                        Invoke(upd, AlarmLabel, "Stop");
                    // AlarmLabel.Text = "Alarm set for ringing";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            AlarmLabel.Text = "Stopped.";
        }

        private void AlarmLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
