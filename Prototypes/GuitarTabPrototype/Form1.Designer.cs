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
            fileControlPanel = new Panel();
            pathPreviewLabel1 = new Label();
            panel1 = new Panel();
            pathPreviewLabel2 = new Label();
            fileControlPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // startPlaybackButton
            // 
            startPlaybackButton.Location = new Point(12, 39);
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
            endPlaybackButton.Location = new Point(144, 39);
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
            beginRecordingButton.Location = new Point(12, 42);
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
            fileNameTextbox.Location = new Point(293, 36);
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
            label1.Location = new Point(298, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter File Name..";
            // 
            // stopRecordingButton
            // 
            stopRecordingButton.Location = new Point(161, 42);
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
            recordingCountdownTimerLabel.Dock = DockStyle.Bottom;
            recordingCountdownTimerLabel.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordingCountdownTimerLabel.Location = new Point(3, 97);
            recordingCountdownTimerLabel.Name = "recordingCountdownTimerLabel";
            recordingCountdownTimerLabel.Size = new Size(293, 28);
            recordingCountdownTimerLabel.TabIndex = 5;
            recordingCountdownTimerLabel.Text = "Not Recording";
            recordingCountdownTimerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileControlPanel
            // 
            fileControlPanel.BorderStyle = BorderStyle.FixedSingle;
            fileControlPanel.Controls.Add(pathPreviewLabel1);
            fileControlPanel.Controls.Add(beginRecordingButton);
            fileControlPanel.Controls.Add(recordingCountdownTimerLabel);
            fileControlPanel.Controls.Add(stopRecordingButton);
            fileControlPanel.Location = new Point(33, 85);
            fileControlPanel.Name = "fileControlPanel";
            fileControlPanel.Padding = new Padding(3);
            fileControlPanel.Size = new Size(301, 130);
            fileControlPanel.TabIndex = 6;
            // 
            // pathPreviewLabel1
            // 
            pathPreviewLabel1.Dock = DockStyle.Top;
            pathPreviewLabel1.Location = new Point(3, 3);
            pathPreviewLabel1.Name = "pathPreviewLabel1";
            pathPreviewLabel1.Size = new Size(293, 20);
            pathPreviewLabel1.TabIndex = 6;
            pathPreviewLabel1.Text = "path";
            pathPreviewLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pathPreviewLabel2);
            panel1.Controls.Add(startPlaybackButton);
            panel1.Controls.Add(endPlaybackButton);
            panel1.Location = new Point(374, 85);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(275, 87);
            panel1.TabIndex = 7;
            // 
            // pathPreviewLabel2
            // 
            pathPreviewLabel2.Dock = DockStyle.Top;
            pathPreviewLabel2.Location = new Point(3, 3);
            pathPreviewLabel2.Name = "pathPreviewLabel2";
            pathPreviewLabel2.Size = new Size(267, 20);
            pathPreviewLabel2.TabIndex = 1;
            pathPreviewLabel2.Text = "path";
            pathPreviewLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 364);
            Controls.Add(panel1);
            Controls.Add(fileControlPanel);
            Controls.Add(fileNameTextbox);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            fileControlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private Panel fileControlPanel;
        private Label pathPreviewLabel1;
        private Panel panel1;
        private Label pathPreviewLabel2;
    }
}
