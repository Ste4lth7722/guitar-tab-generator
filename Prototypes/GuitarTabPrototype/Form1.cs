using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;
using System.Diagnostics;

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
                audioFile = new AudioFileReader(@"C:\Users\SH166361\OneDrive - Hills Road Sixth Form College\Computer Science\NEA\Prototypes\GuitarTabPrototype\Files\Audio\test1.mp3");
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

        }

        private void beginRecordingButton_Click(object sender, EventArgs e)
        {
            if (recordingManager == null)
            {
                recordingManager = new Recording();
            }
            //var outputFolder = @"C:\Users\samue\OneDrive - Hills Road Sixth Form College\Computer Science\NEA\Prototypes\GuitarTabPrototype\Files\Audio\" + fileNameTextbox.Text + ".mp3";
            var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileNameTextbox.Text) + ".mp3";
            recordingManager.beginRecording(outputFolder);
        }

        private void fileNameTextbox_TextChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(fileNameTextbox.Text);
        }

        private void stopRecordingButton_Click(object sender, EventArgs e)
        {
                if (recordingManager != null)
            {
                recordingManager.endRecording();
            }
        }
    }
}
