using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMailChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private int count = -1;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            OpenPop.Pop3.Pop3Client client = new OpenPop.Pop3.Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            try
            {
                client.Authenticate(txtAddress.Text, txtPassword.Text);
                int messageCount = client.GetMessageCount();

                if (count == -1)
                {
                    count = messageCount;
                }

                for (int i = messageCount; i > count; i--)
                {
                    txtNewMail.Text += client.GetMessage(i).Headers.Subject + Environment.NewLine;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.BalloonTipTitle = "New mail arrived";
                    notifyIcon1.BalloonTipText = client.GetMessage(i).Headers.Subject;
                    notifyIcon1.ShowBalloonTip(3000);
                }
                count = messageCount;
            }
            catch(OpenPop.Pop3.Exceptions.InvalidLoginException)
            {
                txtNewMail.Text += "Dose not accept pop3";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Error Occured";
                notifyIcon1.BalloonTipText = "Dose not accept pop3";
                notifyIcon1.ShowBalloonTip(3000);
            }


        }
    }
}
