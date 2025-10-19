 namespace GuitarTabPrototype
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
            startPlaybackButton = new Button();
            endPlaybackButton = new Button();
            beginRecordingButton = new Button();
            fileNameTextbox = new TextBox();
            label1 = new Label();
            stopRecordingButton = new Button();
            recordingCountdownTimerLabel = new Label();
            SuspendLayout();
            // 
            // startPlaybackButton
            // 
            startPlaybackButton.Location = new Point(340, 32);
            startPlaybackButton.Margin = new Padding(2, 1, 2, 1);
            startPlaybackButton.Name = "startPlaybackButton";
            startPlaybackButton.Size = new Size(119, 29);
            startPlaybackButton.TabIndex = 0;
            startPlaybackButton.Text = "Start Playback";
            startPlaybackButton.UseVisualStyleBackColor = true;
            startPlaybackButton.Click += startPlaybackButton_Click;
            // 
            // endPlaybackButton
            // 
            endPlaybackButton.Location = new Point(340, 82);
            endPlaybackButton.Margin = new Padding(2, 1, 2, 1);
            endPlaybackButton.Name = "endPlaybackButton";
            endPlaybackButton.Size = new Size(119, 29);
            endPlaybackButton.TabIndex = 0;
            endPlaybackButton.Text = "End Playback";
            endPlaybackButton.UseVisualStyleBackColor = true;
            endPlaybackButton.Click += endPlaybackButton_Click;
            // 
            // beginRecordingButton
            // 
            beginRecordingButton.Location = new Point(17, 32);
            beginRecordingButton.Margin = new Padding(2, 1, 2, 1);
            beginRecordingButton.Name = "beginRecordingButton";
            beginRecordingButton.Size = new Size(134, 44);
            beginRecordingButton.TabIndex = 1;
            beginRecordingButton.Text = "Begin Recording";
            beginRecordingButton.UseVisualStyleBackColor = true;
            beginRecordingButton.Click += beginRecordingButton_Click;
            // 
            // fileNameTextbox
            // 
            fileNameTextbox.Location = new Point(17, 114);
            fileNameTextbox.Margin = new Padding(2, 1, 2, 1);
            fileNameTextbox.Name = "fileNameTextbox";
            fileNameTextbox.Size = new Size(125, 27);
            fileNameTextbox.TabIndex = 2;
            fileNameTextbox.Text = "test";
            fileNameTextbox.TextChanged += fileNameTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 93);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter File Name..";
            // 
            // stopRecordingButton
            // 
            stopRecordingButton.Location = new Point(156, 32);
            stopRecordingButton.Margin = new Padding(4);
            stopRecordingButton.Name = "stopRecordingButton";
            stopRecordingButton.Size = new Size(128, 44);
            stopRecordingButton.TabIndex = 4;
            stopRecordingButton.Text = "Stop Recording";
            stopRecordingButton.UseVisualStyleBackColor = true;
            stopRecordingButton.Click += stopRecordingButton_Click;
            // 
            // recordingCountdownTimerLabel
            // 
            recordingCountdownTimerLabel.AutoSize = true;
            recordingCountdownTimerLabel.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordingCountdownTimerLabel.Location = new Point(17, 157);
            recordingCountdownTimerLabel.Name = "recordingCountdownTimerLabel";
            recordingCountdownTimerLabel.Size = new Size(140, 28);
            recordingCountdownTimerLabel.TabIndex = 5;
            recordingCountdownTimerLabel.Text = "(countdown)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(recordingCountdownTimerLabel);
            Controls.Add(stopRecordingButton);
            Controls.Add(label1);
            Controls.Add(fileNameTextbox);
            Controls.Add(beginRecordingButton);
            Controls.Add(endPlaybackButton);
            Controls.Add(startPlaybackButton);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startPlaybackButton;
        private Button endPlaybackButton;
        private Button beginRecordingButton;
        private TextBox fileNameTextbox;
        private Label label1;
        private Button stopRecordingButton;
        private Label recordingCountdownTimerLabel;
    }
}
