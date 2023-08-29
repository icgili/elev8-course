using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace Elev8WinService
{
    public partial class Elev8Service : ServiceBase
    {
        EventLog eventLog = new EventLog();
        static int counter = 0;
        Timer newTimer = new Timer();
        public Elev8Service()
        {
            InitializeComponent();
            eventLog.Source = "Elev8WinService";
            eventLog.Log = "Elev8WinServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                EventLog.WriteEntry("Elev8 service started...");

                newTimer.Enabled = true;
                newTimer.Interval = 5000;
                newTimer.Elapsed += elev8Timer_Tick;
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Message + " StackTrace:" + e.StackTrace);
            }
        }

        protected override void OnStop()
        {
            elev8Timer.Stop();
            EventLog.WriteEntry("Elev8 service stopped...");
        }

        private void elev8Timer_Tick(object sender, EventArgs e)
        {
            counter = counter + 1;
            EventLog.WriteEntry($"Elev8 timer ticked... Date: {DateTime.Now} Count: {counter}");
        }
    }
}
