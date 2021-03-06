﻿namespace TodoList {
    partial class ItemEditForm {
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
            this.editText = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.editMoreText = new System.Windows.Forms.TextBox();
            this.btn_isStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_isStar)).BeginInit();
            this.SuspendLayout();
            // 
            // editText
            // 
            this.editText.BackColor = System.Drawing.SystemColors.Info;
            this.editText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editText.Location = new System.Drawing.Point(56, 11);
            this.editText.Margin = new System.Windows.Forms.Padding(2);
            this.editText.Name = "editText";
            this.editText.Size = new System.Drawing.Size(218, 27);
            this.editText.TabIndex = 0;
            this.editText.TextChanged += new System.EventHandler(this.editText_TextChanged);
            this.editText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editText_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSize = true;
            this.btn_confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_confirm.Location = new System.Drawing.Point(50, 143);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(113, 31);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(219, 143);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(93, 31);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // editMoreText
            // 
            this.editMoreText.BackColor = System.Drawing.SystemColors.Info;
            this.editMoreText.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMoreText.Location = new System.Drawing.Point(56, 54);
            this.editMoreText.Margin = new System.Windows.Forms.Padding(2);
            this.editMoreText.Multiline = true;
            this.editMoreText.Name = "editMoreText";
            this.editMoreText.Size = new System.Drawing.Size(218, 81);
            this.editMoreText.TabIndex = 5;
            this.editMoreText.TextChanged += new System.EventHandler(this.editMoreText_TextChanged);
            // 
            // btn_isStar
            // 
            this.btn_isStar.BackColor = System.Drawing.Color.Transparent;
            this.btn_isStar.Location = new System.Drawing.Point(277, 100);
            this.btn_isStar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_isStar.Name = "btn_isStar";
            this.btn_isStar.Size = new System.Drawing.Size(35, 35);
            this.btn_isStar.TabIndex = 4;
            this.btn_isStar.TabStop = false;
            this.btn_isStar.Click += new System.EventHandler(this.btn_isStar_Click);
            // 
            // ItemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TodoList.Properties.Resources.EditBackImage;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.ControlBox = false;
            this.Controls.Add(this.editMoreText);
            this.Controls.Add(this.btn_isStar);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.editText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEdit";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemEditForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btn_isStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editText;
        private System.Windows.Forms.Label btn_confirm;
        private System.Windows.Forms.Label btn_cancel;
        private System.Windows.Forms.PictureBox btn_isStar;
        private System.Windows.Forms.TextBox editMoreText;
    }
}