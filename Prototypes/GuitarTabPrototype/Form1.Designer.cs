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
            SuspendLayout();
            // 
            // startPlaybackButton
            // 
            startPlaybackButton.Location = new Point(552, 51);
            startPlaybackButton.Margin = new Padding(4, 2, 4, 2);
            startPlaybackButton.Name = "startPlaybackButton";
            startPlaybackButton.Size = new Size(193, 47);
            startPlaybackButton.TabIndex = 0;
            startPlaybackButton.Text = "Start Playback";
            startPlaybackButton.UseVisualStyleBackColor = true;
            startPlaybackButton.Click += startPlaybackButton_Click;
            // 
            // endPlaybackButton
            // 
            endPlaybackButton.Location = new Point(552, 132);
            endPlaybackButton.Margin = new Padding(4, 2, 4, 2);
            endPlaybackButton.Name = "endPlaybackButton";
            endPlaybackButton.Size = new Size(193, 47);
            endPlaybackButton.TabIndex = 0;
            endPlaybackButton.Text = "End Playback";
            endPlaybackButton.UseVisualStyleBackColor = true;
            endPlaybackButton.Click += endPlaybackButton_Click;
            // 
            // beginRecordingButton
            // 
            beginRecordingButton.Location = new Point(28, 51);
            beginRecordingButton.Margin = new Padding(4, 2, 4, 2);
            beginRecordingButton.Name = "beginRecordingButton";
            beginRecordingButton.Size = new Size(217, 70);
            beginRecordingButton.TabIndex = 1;
            beginRecordingButton.Text = "Begin Recording";
            beginRecordingButton.UseVisualStyleBackColor = true;
            beginRecordingButton.Click += beginRecordingButton_Click;
            // 
            // fileNameTextbox
            // 
            fileNameTextbox.Location = new Point(28, 183);
            fileNameTextbox.Margin = new Padding(4, 2, 4, 2);
            fileNameTextbox.Name = "fileNameTextbox";
            fileNameTextbox.Size = new Size(201, 39);
            fileNameTextbox.TabIndex = 2;
            fileNameTextbox.TextChanged += fileNameTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 149);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 3;
            label1.Text = "Enter File Name..";
            // 
            // stopRecordingButton
            // 
            stopRecordingButton.Location = new Point(254, 51);
            stopRecordingButton.Margin = new Padding(6, 6, 6, 6);
            stopRecordingButton.Name = "stopRecordingButton";
            stopRecordingButton.Size = new Size(208, 70);
            stopRecordingButton.TabIndex = 4;
            stopRecordingButton.Text = "Stop Recording";
            stopRecordingButton.UseVisualStyleBackColor = true;
            stopRecordingButton.Click += stopRecordingButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stopRecordingButton);
            Controls.Add(label1);
            Controls.Add(fileNameTextbox);
            Controls.Add(beginRecordingButton);
            Controls.Add(endPlaybackButton);
            Controls.Add(startPlaybackButton);
            Margin = new Padding(4, 2, 4, 2);
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
    }
}
