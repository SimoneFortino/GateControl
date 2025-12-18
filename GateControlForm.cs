using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using ControlloCancello.Helpers;
using GateControl.Definitions;

namespace GateControl
{
    public partial class GateControlForm : Form
    {
        IControlloAutomaticoCancello _controlloAutomaticoCancello;
        public GateControlForm()
        {
            InitializeComponent();
            // istanzia la classe
            _controlloAutomaticoCancello =  new ControlloAutomaticoCancello();
            // configura e attiva il controllo automatico
            _controlloAutomaticoCancello.Open();
            // attiva il monitoring del sistema
            MonitoringTimer.Enabled = true;
            
            
        }

        private void OpenGateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void StopGateButton_Click(object sender, EventArgs e)
        {
            
        }


        private void GateMovementProgressBar_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GateMovementProgressBar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void MonitoringTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // aggiorna le labels stato e conteggio del tempo (sec)
            TimerLabel.Text = _controlloAutomaticoCancello.Secondi.ToString();
            StatusLabel.Text = StateHelper.ConstantToStringConverter(_controlloAutomaticoCancello.Stato);
            
            // aggiorna le spie luminose
            if (_controlloAutomaticoCancello.Uscita_LAppartamento == OutputState.ON)
                ApartmentLightLabel.BackColor = Color.Red;
            else
                ApartmentLightLabel.BackColor = Color.DarkGray;
            
            if(_controlloAutomaticoCancello.Uscita_LCancello == OutputState.ON)
                GateLightLabel.BackColor = Color.Yellow;
            else
                GateLightLabel.BackColor = Color.DarkGray;
        }

        private void GateControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // disattiva il controllo automatico
            _controlloAutomaticoCancello.Close();
            // disattiva il monitoring del sistema
            MonitoringTimer.Enabled = false;
        }
    }
}