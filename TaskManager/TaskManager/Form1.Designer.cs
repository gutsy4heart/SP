namespace TaskManager
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
            dataGridView1 = new DataGridView();
            ProcessName = new DataGridViewTextBoxColumn();
            PID = new DataGridViewTextBoxColumn();
            MemoryUsage = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            CpuUsage = new DataGridViewTextBoxColumn();
            Virtualization = new DataGridViewTextBoxColumn();
            btEndTask = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProcessName, PID, MemoryUsage, State, UserName, CpuUsage, Virtualization });
            dataGridView1.Location = new Point(4, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(742, 326);
            dataGridView1.TabIndex = 0;
            // 
            // ProcessName
            // 
            ProcessName.HeaderText = "ProcessName";
            ProcessName.Name = "ProcessName";
            ProcessName.ReadOnly = true;
            // 
            // PID
            // 
            PID.HeaderText = "PID";
            PID.Name = "PID";
            PID.ReadOnly = true;
            // 
            // MemoryUsage
            // 
            MemoryUsage.HeaderText = "MemoryUsage";
            MemoryUsage.Name = "MemoryUsage";
            MemoryUsage.ReadOnly = true;
            // 
            // State
            // 
            State.HeaderText = "State";
            State.Name = "State";
            State.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "UserName";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // CpuUsage
            // 
            CpuUsage.HeaderText = "CpuUsage";
            CpuUsage.Name = "CpuUsage";
            CpuUsage.ReadOnly = true;
            // 
            // Virtualization
            // 
            Virtualization.HeaderText = "Virtualization";
            Virtualization.Name = "Virtualization";
            Virtualization.ReadOnly = true;
            // 
            // btEndTask
            // 
            btEndTask.BackColor = SystemColors.HotTrack;
            btEndTask.ForeColor = SystemColors.HighlightText;
            btEndTask.Location = new Point(330, 341);
            btEndTask.Name = "btEndTask";
            btEndTask.Size = new Size(75, 23);
            btEndTask.TabIndex = 1;
            btEndTask.Text = "End Task";
            btEndTask.UseVisualStyleBackColor = false;
            btEndTask.Click += btEndTask_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(756, 376);
            Controls.Add(btEndTask);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.Desktop;
            Name = "Form1";
            Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btEndTask;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn PID;
        private DataGridViewTextBoxColumn MemoryUsage;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn CpuUsage;
        private DataGridViewTextBoxColumn Virtualization;
        private System.Windows.Forms.Timer timer1;
    }
}
