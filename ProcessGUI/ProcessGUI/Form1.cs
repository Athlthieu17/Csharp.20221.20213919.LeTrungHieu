using System.Diagnostics;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void getProcess()
        {
            Process[] processArr = Process.GetProcesses();
            
            foreach(Process item in processArr)
            {
                txbLog.Text = item.ProcessName + "\n" + txbLog.Text;
            }


        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            getProcess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Process.Start(Application.StartupPath + "ProcessGUI.exe");
            Process.Start(@"https:\\www.google.com");
        }

        private void btnHiden_Click(object sender, EventArgs e)
        {
            Process proC = new Process();
            proC.StartInfo.FileName = Application.StartupPath + "\\ProcessGUI.exe";
            proC.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            proC.Start();
        }
    }
}