using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TitaniumControlsApp.Properties;
using System.Media;

namespace TitaniumControlsApp
{
    public partial class PlayControl : UserControl
    {
        private int timeMins, timeSecs, readySecs, searchTime = 10;
        private bool isActive = false, isReady = false,searchingGame = false;
        private SoundPlayer gameReady;

        public PlayControl()
        {
            InitializeComponent();
        }


        #region TimerSearch

        private void RestartTimer()
        {
            timeMins = 0;
            timeSecs = 0;
            isActive = false;
            ShowTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSecs++;

                if (timeSecs >= searchTime)
                {
                    GameReady();
                }
                if (timeSecs >= 60)
                {
                    timeMins++;
                    timeSecs = 0;

                    if (timeMins >= 60)
                    {
                        timeMins = 0;
                    }
                }
            }

            ShowTime();
        }
        private void ShowTime()
        {
            secsLbl.Text = String.Format("{0:00}", timeSecs);
            minsLbl.Text = String.Format("{0:00}", timeMins);
        } 
        #endregion

        private void GameReady()
        {
            var form = Application.OpenForms["MainWindow"];
            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
                form.Focus();
            }
            //starting couting
            readySecs = 30;
            readyTimer.Text = readySecs + "";
            isReady = true;
            readyTimer.Visible = true;
            acceptBtn.Visible = true;
            GameReadyLbl.Visible = true;
            isActive = false;
            gameReady.Play();
        }

        private void StopSearch()
        {
            isActive = false;
            searchingGame = false;
            minsLbl.Visible = false;
            secsLbl.Visible = false;
            labelDots.Visible = false;
            acceptBtn.Visible = false;
            GameReadyLbl.Visible = false;
            readyTimer.Visible = false;
            PlayButton.Image = Resources.play_button1;
            RestartTimer();
        }

        private void StartSearch()
        {
            isActive = true;
            searchingGame = true;
            minsLbl.Visible = true;
            secsLbl.Visible = true;
            labelDots.Visible = true;
            searchTime = new Random().Next(3, 16);
            PlayButton.Image = Resources.cancel;
        }

        private void ReadyUp_Tick(object sender, EventArgs e)
        {
            if (isReady)
            {
                readySecs--;
                readyTimer.Text = String.Format("{00}", readySecs);
                if (readySecs < 0)
                {
                    StopSearch();
                    isReady = false;
                }
            }
        }

        private void ReadyUpBtn_Click(object sender, EventArgs e)
        {
            isActive = false;
            isReady = false;
            acceptBtn.Visible = false;
            gameReady.Stop();
            StopSearch();
            MessageBox.Show("Znaleziono serwera!\nconnect 168.0.0.1:27015", "Serwer znaleziony!", MessageBoxButtons.OK);
        }

        private void PlayControl_Leave(object sender, EventArgs e)
        {
            StopSearch();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
           if (searchingGame)
            {
                gameReady.Stop();
                StopSearch();
            }
            else
            {
                StartSearch();
            }

        }

        private void PlayControl_Load(object sender, EventArgs e)
        {
            gameReady = new SoundPlayer(Resources.game_ready);
            StopSearch();
        }
    }
}
