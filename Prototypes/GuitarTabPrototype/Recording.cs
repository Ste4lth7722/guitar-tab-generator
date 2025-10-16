using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace GuitarTabPrototype
{
	internal class Recording
	{
		private WaveFileWriter writer = null;

		private WaveInEvent audio_input;

		private bool recording = false;

		public void beginRecording(string filePath)
		{
			if (recording == false)
			{
				recording = true;
				Debug.WriteLine(filePath);

				audio_input = new WaveInEvent();
				writer = new WaveFileWriter(filePath, audio_input.WaveFormat);
				// ensure no crash if 0 input devices.
				audio_input.StartRecording();

				SetupAudioInput();
			}
			else
			{
				Debug.WriteLine("Already recording audio!");
			}
		}


		private void SetupAudioInput()
		{
            audio_input.DataAvailable += (s, a) =>
            {
                Debug.WriteLine("Recording data..");
                byte[] data = a.Buffer; // Store newly recorded data in data variable
                int bytesRecorded = a.BytesRecorded; // Number of new bytes recorded this call
                writer.Write(data, 0, bytesRecorded); // Write data with 'offset' 0.
            };

			audio_input.RecordingStopped += (s, a) =>
			{
				Debug.WriteLine("AAA");
				writer.Dispose();
				writer = null;

			};
        }

		public void endRecording()
		{
			if (recording == true)
			{
				audio_input.StopRecording();
				
				recording = false;
			}
		}
	}
}
