namespace SoundPlayer {
    partial class SoundPlayer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button_PlaySound = new System.Windows.Forms.Button();
            this.button_VolumeDown = new System.Windows.Forms.Button();
            this.button_VolumeUp = new System.Windows.Forms.Button();
            this.textBox_SoundPath = new System.Windows.Forms.TextBox();
            this.button_Mute = new System.Windows.Forms.Button();
            this.button_StopSound = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_PlaySound
            // 
            this.button_PlaySound.Location = new System.Drawing.Point(24, 85);
            this.button_PlaySound.Name = "button_PlaySound";
            this.button_PlaySound.Size = new System.Drawing.Size(152, 89);
            this.button_PlaySound.TabIndex = 0;
            this.button_PlaySound.Text = "PlaySound";
            this.button_PlaySound.UseVisualStyleBackColor = true;
            this.button_PlaySound.Click += new System.EventHandler(this.button_PlaySound_Click);
            // 
            // button_VolumeDown
            // 
            this.button_VolumeDown.Location = new System.Drawing.Point(376, 85);
            this.button_VolumeDown.Name = "button_VolumeDown";
            this.button_VolumeDown.Size = new System.Drawing.Size(152, 89);
            this.button_VolumeDown.TabIndex = 0;
            this.button_VolumeDown.Text = "VolumeDown";
            this.button_VolumeDown.UseVisualStyleBackColor = true;
            this.button_VolumeDown.Click += new System.EventHandler(this.button_VolumeDown_Click);
            // 
            // button_VolumeUp
            // 
            this.button_VolumeUp.Location = new System.Drawing.Point(534, 85);
            this.button_VolumeUp.Name = "button_VolumeUp";
            this.button_VolumeUp.Size = new System.Drawing.Size(152, 89);
            this.button_VolumeUp.TabIndex = 0;
            this.button_VolumeUp.Text = "VolumeUp";
            this.button_VolumeUp.UseVisualStyleBackColor = true;
            this.button_VolumeUp.Click += new System.EventHandler(this.button_VolumeUp_Click);
            // 
            // textBox_SoundPath
            // 
            this.textBox_SoundPath.Location = new System.Drawing.Point(24, 32);
            this.textBox_SoundPath.Name = "textBox_SoundPath";
            this.textBox_SoundPath.Size = new System.Drawing.Size(820, 31);
            this.textBox_SoundPath.TabIndex = 1;
            this.textBox_SoundPath.Text = "C:\\Users\\ScottLin\\Documents\\SoundAlarm2.wav";
            // 
            // button_Mute
            // 
            this.button_Mute.Location = new System.Drawing.Point(692, 85);
            this.button_Mute.Name = "button_Mute";
            this.button_Mute.Size = new System.Drawing.Size(152, 89);
            this.button_Mute.TabIndex = 0;
            this.button_Mute.Text = "Mute";
            this.button_Mute.UseVisualStyleBackColor = true;
            this.button_Mute.Click += new System.EventHandler(this.button_Mute_Click);
            // 
            // button_StopSound
            // 
            this.button_StopSound.Location = new System.Drawing.Point(182, 85);
            this.button_StopSound.Name = "button_StopSound";
            this.button_StopSound.Size = new System.Drawing.Size(152, 89);
            this.button_StopSound.TabIndex = 0;
            this.button_StopSound.Text = "StopSound";
            this.button_StopSound.UseVisualStyleBackColor = true;
            this.button_StopSound.Click += new System.EventHandler(this.button_StopSound_Click);
            // 
            // SoundPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 201);
            this.Controls.Add(this.textBox_SoundPath);
            this.Controls.Add(this.button_StopSound);
            this.Controls.Add(this.button_VolumeDown);
            this.Controls.Add(this.button_Mute);
            this.Controls.Add(this.button_VolumeUp);
            this.Controls.Add(this.button_PlaySound);
            this.Name = "SoundPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SoundPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_PlaySound;
        private System.Windows.Forms.Button button_VolumeDown;
        private System.Windows.Forms.Button button_VolumeUp;
        private System.Windows.Forms.TextBox textBox_SoundPath;
        private System.Windows.Forms.Button button_Mute;
        private System.Windows.Forms.Button button_StopSound;
    }
}

