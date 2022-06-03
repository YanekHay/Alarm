using System.Media;

namespace Alarm
{
    public partial class Form1 : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Yanek\Downloads\ALERT.wav");
        int hour, minute, second;
        string alarmhour,alarmminute,alarmsecond;
        int funcCalled, interval,das;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            funcCalled = 0;
            alarmhour = comboHour.Text;
            alarmminute = comboMinute.Text;
            alarmsecond = comboSecond.Text;

            btnStop.Text = interval.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
            funcCalled = 0;
            das = 0;
            for (int i = 0; i < 60; i++)
            {
                if (i < 10) {
                    comboHour.Items.Add("0" + i.ToString());
                    comboMinute.Items.Add("0" + i.ToString());
                    comboSecond.Items.Add("0" + i.ToString());
                }
                else { 
                if (i < 24)
                {
                    comboHour.Items.Add(i.ToString());
                } 
                comboMinute.Items.Add(i.ToString());
                comboSecond.Items.Add(i.ToString());
                
            }
            }


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            interval = (int)numBoxInterval.Value;
            
            lblHour.Text = (hour.ToString().Length == 1 ? "0" + hour.ToString() : hour.ToString());
            lblMinute.Text = (minute.ToString().Length == 1 ? "0"+ minute.ToString() : minute.ToString());
            lblSecond.Text = (second.ToString().Length == 1 ? "0" + second.ToString() : second.ToString());
            GetAlarm();
            
        }
        private void GetAlarm()
        {

            if (funcCalled < 1 &&  alarmhour==lblHour.Text && alarmminute== lblMinute.Text && alarmsecond== lblSecond.Text)
            {
          
                simpleSound.Play();
                funcCalled++;
            }
            
        }

        private void NextClass()
        {

        }
    }
}