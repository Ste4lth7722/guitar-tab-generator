using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.Runtime.CompilerServices;

namespace GuitarTabPrototype
{
	public partial class Form1 : Form
	{
		private WaveOutEvent outputDevice;
		private AudioFileReader audioFile;

		private String fileName = "test";
		private String filePath = "";

		Recording recordingManager;


		public Form1()
		{
			InitializeComponent();

            fileName = fileNameTextbox.Text;
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName) + ".mp3";
            pathPreviewLabel1.Text = filePath;
			pathPreviewLabel2.Text = filePath;

        }

		private void startPlaybackButton_Click(object sender, EventArgs e)
		{
			if (outputDevice == null)
			{
				outputDevice = new WaveOutEvent();
				outputDevice.PlaybackStopped += OnPlaybackStopped;
			}
			if (audioFile == null)
			{
				audioFile = new AudioFileReader(filePath);
				outputDevice.Init(audioFile);
			}
			outputDevice.Play();
		}

		private void endPlaybackButton_Click(object sender, EventArgs e)
		{
			if (outputDevice != null)
			{
				outputDevice.Stop();
			}
		}

		private void OnPlaybackStopped(object sender, StoppedEventArgs args)
		{
			Debug.WriteLine("WaveOutEvent - playback stopped (can be any reason!)");
		}


		private void beginRecordingButton_Click(object sender, EventArgs e)
		{
			if (recordingManager == null) // make a new recording object
			{
				recordingManager = new Recording();
			}
			startRecordingCountdown();
        }


		private void startRecordingCountdown()
		{
			var secondsRemaining = 3; // Total time to wait before recording starts
			var timer = new System.Windows.Forms.Timer();
			timer.Interval = 1000; // Increments every second (1000ms)
			timer.Start();

			recordingCountdownTimerLabel.Visible = true;
			recordingCountdownTimerLabel.Text = ($"{secondsRemaining} seconds remaining.");

			EventHandler onTick = null;
			onTick = (s, a) =>
			{
                secondsRemaining--;
				if (secondsRemaining > 0)
				{
                    recordingCountdownTimerLabel.Text = ($"{secondsRemaining} seconds remaining.");
                }
				else
				{
                    recordingCountdownTimerLabel.Text = ("Recording.."); /// This text also stays visible after  TODO

                    timer.Stop();
					timer.Tick -= onTick;

					var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName) + ".mp3";
                    recordingManager.beginRecording(outputFolder);
				}
			};

			timer.Tick += onTick;
		}


		private void fileNameTextbox_TextChanged(object sender, EventArgs e)
		{
			fileName = fileNameTextbox.Text;
			filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName) + ".mp3";
			pathPreviewLabel1.Text = filePath;
			pathPreviewLabel2.Text = filePath;
        }


		private void stopRecordingButton_Click(object sender, EventArgs e) /// TODO make it stop the countdown if that's currently ongoing.
		{
			if (recordingManager != null)
			{
				recordingCountdownTimerLabel.Text = "Not Recording";
				recordingManager.endRecording();
			}
		}

		private int returnCenteredX(int width, int containerWidth)
		{
			int centeredX = 0;
			centeredX = (width / 2) - containerWidth / 2;
			return centeredX;
		}
	}
}
