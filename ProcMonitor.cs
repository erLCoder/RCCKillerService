using System;
using System.ServiceProcess;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProcMonitor
{
    public partial class ProcMonitor : ServiceBase
    {
        private bool isMonitoring = true;

        public ProcMonitor()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Task.Run(() => StartMonitoringProcess("RustCheatCheck"));
            Task.Run(() => StartMonitoringOSKProcess());
        }

        protected override void OnStop()
        {
            isMonitoring = false;
        }

        private async void StartMonitoringProcess(string processName)
        {
            while (isMonitoring)
            {
                try
                {
                    // Пытаемся получить процессы с указанным именем
                    Process[] processes = Process.GetProcessesByName(processName);

                    // Пытаемся убить первый найденный процесс, если он существует
                    if (processes.Length > 0)
                    {
                        processes[0].Kill();
                    }

                    // Пауза в 250 миллисекунд перед следующей проверкой
                    await Task.Delay(250);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("ProcMonitor", "An error occurred: " + ex.Message, EventLogEntryType.Error);
                }
            }
        }

        private async void StartMonitoringOSKProcess()
        {
            while (isMonitoring)
            {
                try
                {
                    // Пытаемся получить процессы osk
                    Process[] oskProcesses = Process.GetProcessesByName("osk");

                    // Пытаемся убить первый найденный процесс, если он существует
                    if (oskProcesses.Length > 0)
                    {
                        oskProcesses[0].Kill();
                    }

                    // Пауза в 250 миллисекунд перед следующей проверкой
                    await Task.Delay(250);
                }
                catch (Exception ex)
                {
                    EventLog.WriteEntry("ProcMonitor", "An error occurred: " + ex.Message, EventLogEntryType.Error);
                }
            }
        }
    }
}
