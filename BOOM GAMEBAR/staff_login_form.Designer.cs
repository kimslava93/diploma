namespace BOOM_GAMEBAR
{
    partial class staff_login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.today_label = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.now_label = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.password_lable = new System.Windows.Forms.Label();
            this.login_text_box = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // today_label
            // 
            this.today_label.AutoSize = true;
            this.today_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.today_label.Location = new System.Drawing.Point(31, 9);
            this.today_label.Name = "today_label";
            this.today_label.Size = new System.Drawing.Size(70, 19);
            this.today_label.TabIndex = 0;
            this.today_label.Text = "Today is: ";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_label.Location = new System.Drawing.Point(107, 9);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(38, 19);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "date";
            // 
            // now_label
            // 
            this.now_label.AutoSize = true;
            this.now_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.now_label.Location = new System.Drawing.Point(216, 9);
            this.now_label.Name = "now_label";
            this.now_label.Size = new System.Drawing.Size(57, 19);
            this.now_label.TabIndex = 2;
            this.now_label.Text = "Now is:";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_label.Location = new System.Drawing.Point(279, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(38, 19);
            this.time_label.TabIndex = 3;
            this.time_label.Text = "time";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_label.Location = new System.Drawing.Point(31, 59);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(44, 19);
            this.login_label.TabIndex = 4;
            this.login_label.Text = "Login";
            // 
            // password_lable
            // 
            this.password_lable.AutoSize = true;
            this.password_lable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_lable.Location = new System.Drawing.Point(31, 90);
            this.password_lable.Name = "password_lable";
            this.password_lable.Size = new System.Drawing.Size(71, 19);
            this.password_lable.TabIndex = 5;
            this.password_lable.Text = "Password";
            // 
            // login_text_box
            // 
            this.login_text_box.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.login_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_text_box.Location = new System.Drawing.Point(135, 55);
            this.login_text_box.Name = "login_text_box";
            this.login_text_box.Size = new System.Drawing.Size(166, 26);
            this.login_text_box.TabIndex = 6;
            // 
            // password_textbox
            // 
            this.password_textbox.AcceptsReturn = true;
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textbox.HideSelection = false;
            this.password_textbox.Location = new System.Drawing.Point(135, 86);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.ShortcutsEnabled = false;
            this.password_textbox.Size = new System.Drawing.Size(166, 26);
            this.password_textbox.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(354, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(111, 131);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(123, 29);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // staff_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(354, 189);
            this.ControlBox = false;
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_text_box);
            this.Controls.Add(this.password_lable);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.now_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.today_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "staff_login_form";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.staff_login_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label today_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label now_label;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_lable;
        private System.Windows.Forms.TextBox login_text_box;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button login_button;
    }
}