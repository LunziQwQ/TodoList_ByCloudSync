﻿namespace TodoList {
    partial class MoreTextForm {
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
            this.components = new System.ComponentModel.Container();
            this.moreTextLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // moreTextLabel
            // 
            this.moreTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.moreTextLabel.Location = new System.Drawing.Point(12, 9);
            this.moreTextLabel.Name = "moreTextLabel";
            this.moreTextLabel.Padding = new System.Windows.Forms.Padding(15);
            this.moreTextLabel.Size = new System.Drawing.Size(289, 194);
            this.moreTextLabel.TabIndex = 0;
            this.moreTextLabel.Text = "No more text. Please click right this item to add it.";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MoreTextForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(313, 212);
            this.ControlBox = false;
            this.Controls.Add(this.moreTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreTextForm";
            this.Text = "MoreTextForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label moreTextLabel;
        private System.Windows.Forms.Timer Timer;
    }
}