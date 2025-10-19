using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Diagnostics;
using System.Windows.Forms.Design;

namespace GuitarTabPrototype
{
	public partial class Form1 : Form
	{
		private WaveOutEvent outputDevice;
		private AudioFileReader audioFile;

		private String fileName = "";

		Recording recordingManager;


		public Form1()
		{
			InitializeComponent();
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
				var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName) + ".mp3";
                audioFile = new AudioFileReader(path);
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
			if (recordingManager == null)
			{
				recordingManager = new Recording();
			}
			//var outputFolder = @"C:\Users\samue\OneDrive - Hills Road Sixth Form College\Computer Science\NEA\Prototypes\GuitarTabPrototype\Files\Audio\" + fileNameTextbox.Text + ".mp3";
			var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName) + ".mp3";
			startRecordingCountdown();
			recordingManager.beginRecording(outputFolder); /// Recording starts before the countdown ends. TODO
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
				}
			};

			timer.Tick += onTick;
		}


		private void fileNameTextbox_TextChanged(object sender, EventArgs e)
		{
			fileName = fileNameTextbox.Text;
		}

		private void stopRecordingButton_Click(object sender, EventArgs e) /// TODO make it stop the countdown if that's currently ongoing.
		{
				if (recordingManager != null)
			{
				recordingManager.endRecording();
			}
		}
	}
}
