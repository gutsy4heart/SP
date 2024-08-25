using System.Diagnostics;
namespace TaskManager
{
    public partial class Form1 : Form
    {
        static PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        static PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        public Form1()
        {
            InitializeComponent();
            LoadProcesses();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
        private void LoadProcesses()
        {
            var processes = Process.GetProcesses();
            dataGridView1.Rows.Clear();

            foreach (var process in processes)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells["ProcessName"].Value = process.ProcessName;
                dataGridView1.Rows[rowIndex].Cells["PID"].Value = process.Id;
                dataGridView1.Rows[rowIndex].Cells["MemoryUsage"].Value = getAvailableRAM();
                dataGridView1.Rows[rowIndex].Cells["State"].Value = process.Responding ? "Running" : "Not Responding";
                dataGridView1.Rows[rowIndex].Cells["UserName"].Value = Environment.UserName;
                dataGridView1.Rows[rowIndex].Cells["CpuUsage"].Value = GetCurrentCpuUsage();
                dataGridView1.Rows[rowIndex].Cells["Virtualization"].Value = process.SessionId == 0 ? "Virtualized" : "Not Virtualized";
            }
        }

        public static string GetCurrentCpuUsage()
        {
            return cpuCounter.NextValue() + "%";
        }
        public static string getAvailableRAM()
        {
            return ramCounter.NextValue() + "MB";
        }
        private void btEndTask_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int processId = (int)dataGridView1.SelectedRows[0].Cells["PID"].Value;
                var process = Process.GetProcessById(processId);

                try
                {
                    process.Kill();
                    MessageBox.Show($"Process {process.ProcessName} has been terminated.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to terminate process: {ex.Message}");
                }

                LoadProcesses();
            }
            else
            {
                MessageBox.Show("Please select a process first.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadProcesses();
        }

    }
}
