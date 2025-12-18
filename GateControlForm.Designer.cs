namespace GateControl
{
    partial class GateControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateControlForm));
            this.ApartmentControlPanel = new System.Windows.Forms.Panel();
            this.ApartmentLightLabel = new System.Windows.Forms.Label();
            this.StopGateButton = new System.Windows.Forms.Button();
            this.OpenGateButton = new System.Windows.Forms.Button();
            this.SimulatorPanel = new System.Windows.Forms.Panel();
            this.GateMovementProgressBar = new System.Windows.Forms.ProgressBar();
            this.FCRightPanel = new System.Windows.Forms.Panel();
            this.FCLeftPanel = new System.Windows.Forms.Panel();
            this.TextStatusLabel = new System.Windows.Forms.Label();
            this.TextTimerLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.GateLightLabel = new System.Windows.Forms.Label();
            this.MonitoringTimer = new System.Timers.Timer();
            this.ApartmentControlPanel.SuspendLayout();
            this.SimulatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonitoringTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // ApartmentControlPanel
            // 
            this.ApartmentControlPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ApartmentControlPanel.Controls.Add(this.ApartmentLightLabel);
            this.ApartmentControlPanel.Controls.Add(this.StopGateButton);
            this.ApartmentControlPanel.Controls.Add(this.OpenGateButton);
            this.ApartmentControlPanel.Location = new System.Drawing.Point(58, 64);
            this.ApartmentControlPanel.Name = "ApartmentControlPanel";
            this.ApartmentControlPanel.Size = new System.Drawing.Size(179, 404);
            this.ApartmentControlPanel.TabIndex = 0;
            // 
            // ApartmentLightLabel
            // 
            this.ApartmentLightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApartmentLightLabel.Location = new System.Drawing.Point(30, 324);
            this.ApartmentLightLabel.Name = "ApartmentLightLabel";
            this.ApartmentLightLabel.Size = new System.Drawing.Size(117, 48);
            this.ApartmentLightLabel.TabIndex = 2;
            // 
            // StopGateButton
            // 
            this.StopGateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGateButton.Location = new System.Drawing.Point(30, 118);
            this.StopGateButton.Name = "StopGateButton";
            this.StopGateButton.Size = new System.Drawing.Size(117, 53);
            this.StopGateButton.TabIndex = 1;
            this.StopGateButton.Text = "Stop";
            this.StopGateButton.UseVisualStyleBackColor = true;
            this.StopGateButton.Click += new System.EventHandler(this.StopGateButton_Click);
            // 
            // OpenGateButton
            // 
            this.OpenGateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenGateButton.Location = new System.Drawing.Point(30, 37);
            this.OpenGateButton.Name = "OpenGateButton";
            this.OpenGateButton.Size = new System.Drawing.Size(117, 53);
            this.OpenGateButton.TabIndex = 0;
            this.OpenGateButton.Text = "Apri";
            this.OpenGateButton.UseVisualStyleBackColor = true;
            this.OpenGateButton.Click += new System.EventHandler(this.OpenGateButton_Click);
            // 
            // SimulatorPanel
            // 
            this.SimulatorPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SimulatorPanel.Controls.Add(this.GateMovementProgressBar);
            this.SimulatorPanel.Controls.Add(this.FCRightPanel);
            this.SimulatorPanel.Controls.Add(this.FCLeftPanel);
            this.SimulatorPanel.Controls.Add(this.TextStatusLabel);
            this.SimulatorPanel.Controls.Add(this.TextTimerLabel);
            this.SimulatorPanel.Controls.Add(this.StatusLabel);
            this.SimulatorPanel.Controls.Add(this.TimerLabel);
            this.SimulatorPanel.Controls.Add(this.GateLightLabel);
            this.SimulatorPanel.Location = new System.Drawing.Point(272, 64);
            this.SimulatorPanel.Name = "SimulatorPanel";
            this.SimulatorPanel.Size = new System.Drawing.Size(694, 404);
            this.SimulatorPanel.TabIndex = 1;
            // 
            // GateMovementProgressBar
            // 
            this.GateMovementProgressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GateMovementProgressBar.Location = new System.Drawing.Point(97, 155);
            this.GateMovementProgressBar.Name = "GateMovementProgressBar";
            this.GateMovementProgressBar.Size = new System.Drawing.Size(493, 56);
            this.GateMovementProgressBar.TabIndex = 10;
            this.GateMovementProgressBar.Value = 100;
            this.GateMovementProgressBar.MouseEnter += new System.EventHandler(this.GateMovementProgressBar_MouseEnter);
            this.GateMovementProgressBar.MouseLeave += new System.EventHandler(this.GateMovementProgressBar_MouseLeave);
            // 
            // FCRightPanel
            // 
            this.FCRightPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FCRightPanel.Location = new System.Drawing.Point(596, 155);
            this.FCRightPanel.Name = "FCRightPanel";
            this.FCRightPanel.Size = new System.Drawing.Size(58, 57);
            this.FCRightPanel.TabIndex = 9;
            // 
            // FCLeftPanel
            // 
            this.FCLeftPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FCLeftPanel.Location = new System.Drawing.Point(33, 155);
            this.FCLeftPanel.Name = "FCLeftPanel";
            this.FCLeftPanel.Size = new System.Drawing.Size(58, 57);
            this.FCLeftPanel.TabIndex = 8;
            // 
            // TextStatusLabel
            // 
            this.TextStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStatusLabel.Location = new System.Drawing.Point(501, 313);
            this.TextStatusLabel.Name = "TextStatusLabel";
            this.TextStatusLabel.Size = new System.Drawing.Size(153, 26);
            this.TextStatusLabel.TabIndex = 7;
            this.TextStatusLabel.Text = "Stato";
            this.TextStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextTimerLabel
            // 
            this.TextTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTimerLabel.Location = new System.Drawing.Point(33, 313);
            this.TextTimerLabel.Name = "TextTimerLabel";
            this.TextTimerLabel.Size = new System.Drawing.Size(153, 26);
            this.TextTimerLabel.TabIndex = 6;
            this.TextTimerLabel.Text = "Timer";
            this.TextTimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(501, 339);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(153, 50);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLabel
            // 
            this.TimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(33, 339);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(153, 50);
            this.TimerLabel.TabIndex = 4;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GateLightLabel
            // 
            this.GateLightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GateLightLabel.Location = new System.Drawing.Point(27, 27);
            this.GateLightLabel.Name = "GateLightLabel";
            this.GateLightLabel.Size = new System.Drawing.Size(53, 48);
            this.GateLightLabel.TabIndex = 3;
            // 
            // MonitoringTimer
            // 
            this.MonitoringTimer.Enabled = true;
            this.MonitoringTimer.SynchronizingObject = this;
            this.MonitoringTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.MonitoringTimer_Elapsed);
            // 
            // GateControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1024, 541);
            this.Controls.Add(this.SimulatorPanel);
            this.Controls.Add(this.ApartmentControlPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GateControlForm";
            this.Text = "Automatic Gate Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GateControlForm_FormClosing);
            this.ApartmentControlPanel.ResumeLayout(false);
            this.SimulatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MonitoringTimer)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Timers.Timer MonitoringTimer;

        private System.Windows.Forms.Panel FCLeftPanel;
        private System.Windows.Forms.Panel FCRightPanel;
        private System.Windows.Forms.ProgressBar GateMovementProgressBar;

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TextTimerLabel;
        private System.Windows.Forms.Label TextStatusLabel;

        private System.Windows.Forms.Label GateLightLabel;
        private System.Windows.Forms.Label TimerLabel;

        private System.Windows.Forms.Label ApartmentLightLabel;

        private System.Windows.Forms.Button StopGateButton;

        private System.Windows.Forms.Button OpenGateButton;

        private System.Windows.Forms.Panel ApartmentControlPanel;
        private System.Windows.Forms.Panel SimulatorPanel;

        #endregion
    }
}