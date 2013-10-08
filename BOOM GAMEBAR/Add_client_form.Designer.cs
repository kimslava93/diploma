namespace BOOM_GAMEBAR
{
    partial class Add_client_form
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
            this.table_num_label = new System.Windows.Forms.Label();
            this.table_num = new System.Windows.Forms.ComboBox();
            this.deposit_payment_groupBox = new System.Windows.Forms.GroupBox();
            this.client_TIME_out_field = new System.Windows.Forms.DateTimePicker();
            this.client_DATE_out_field = new System.Windows.Forms.DateTimePicker();
            this.paid_sum_text_box = new System.Windows.Forms.TextBox();
            this.OR_text_label = new System.Windows.Forms.Label();
            this.paid_sum_label = new System.Windows.Forms.Label();
            this.client_time_out_label = new System.Windows.Forms.Label();
            this.add_client_button = new System.Windows.Forms.Button();
            this.deposit_payment_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_num_label
            // 
            this.table_num_label.AutoSize = true;
            this.table_num_label.Location = new System.Drawing.Point(24, 39);
            this.table_num_label.Name = "table_num_label";
            this.table_num_label.Size = new System.Drawing.Size(44, 13);
            this.table_num_label.TabIndex = 0;
            this.table_num_label.Text = "Table #";
            // 
            // table_num
            // 
            this.table_num.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.table_num.FormattingEnabled = true;
            this.table_num.Location = new System.Drawing.Point(90, 36);
            this.table_num.Name = "table_num";
            this.table_num.Size = new System.Drawing.Size(57, 21);
            this.table_num.TabIndex = 1;
            this.table_num.MouseClick += new System.Windows.Forms.MouseEventHandler(this.table_num_MouseClick);
            // 
            // deposit_payment_groupBox
            // 
            this.deposit_payment_groupBox.Controls.Add(this.client_TIME_out_field);
            this.deposit_payment_groupBox.Controls.Add(this.client_DATE_out_field);
            this.deposit_payment_groupBox.Controls.Add(this.paid_sum_text_box);
            this.deposit_payment_groupBox.Controls.Add(this.OR_text_label);
            this.deposit_payment_groupBox.Controls.Add(this.paid_sum_label);
            this.deposit_payment_groupBox.Controls.Add(this.client_time_out_label);
            this.deposit_payment_groupBox.Location = new System.Drawing.Point(27, 72);
            this.deposit_payment_groupBox.Name = "deposit_payment_groupBox";
            this.deposit_payment_groupBox.Size = new System.Drawing.Size(269, 131);
            this.deposit_payment_groupBox.TabIndex = 2;
            this.deposit_payment_groupBox.TabStop = false;
            this.deposit_payment_groupBox.Text = "Deposit payment";
            // 
            // client_TIME_out_field
            // 
            this.client_TIME_out_field.CustomFormat = "HH:mm";
            this.client_TIME_out_field.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.client_TIME_out_field.Location = new System.Drawing.Point(195, 20);
            this.client_TIME_out_field.Name = "client_TIME_out_field";
            this.client_TIME_out_field.ShowUpDown = true;
            this.client_TIME_out_field.Size = new System.Drawing.Size(58, 20);
            this.client_TIME_out_field.TabIndex = 5;
            // 
            // client_DATE_out_field
            // 
            this.client_DATE_out_field.CustomFormat = "dd/MMM/yy";
            this.client_DATE_out_field.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.client_DATE_out_field.Location = new System.Drawing.Point(103, 20);
            this.client_DATE_out_field.Name = "client_DATE_out_field";
            this.client_DATE_out_field.Size = new System.Drawing.Size(86, 20);
            this.client_DATE_out_field.TabIndex = 4;
            // 
            // paid_sum_text_box
            // 
            this.paid_sum_text_box.Location = new System.Drawing.Point(103, 89);
            this.paid_sum_text_box.Name = "paid_sum_text_box";
            this.paid_sum_text_box.Size = new System.Drawing.Size(86, 20);
            this.paid_sum_text_box.TabIndex = 3;
            this.paid_sum_text_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_sum_text_box_KeyPress);
            // 
            // OR_text_label
            // 
            this.OR_text_label.AutoSize = true;
            this.OR_text_label.Location = new System.Drawing.Point(24, 58);
            this.OR_text_label.Name = "OR_text_label";
            this.OR_text_label.Size = new System.Drawing.Size(23, 13);
            this.OR_text_label.TabIndex = 2;
            this.OR_text_label.Text = "OR";
            // 
            // paid_sum_label
            // 
            this.paid_sum_label.AutoSize = true;
            this.paid_sum_label.Location = new System.Drawing.Point(24, 92);
            this.paid_sum_label.Name = "paid_sum_label";
            this.paid_sum_label.Size = new System.Drawing.Size(50, 13);
            this.paid_sum_label.TabIndex = 1;
            this.paid_sum_label.Text = "Paid sum";
            // 
            // client_time_out_label
            // 
            this.client_time_out_label.AutoSize = true;
            this.client_time_out_label.Location = new System.Drawing.Point(24, 26);
            this.client_time_out_label.Name = "client_time_out_label";
            this.client_time_out_label.Size = new System.Drawing.Size(73, 13);
            this.client_time_out_label.TabIndex = 0;
            this.client_time_out_label.Text = "Client time out";
            // 
            // add_client_button
            // 
            this.add_client_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_client_button.Location = new System.Drawing.Point(0, 223);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(328, 38);
            this.add_client_button.TabIndex = 3;
            this.add_client_button.Text = "Add new client";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // Add_client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.add_client_button);
            this.Controls.Add(this.deposit_payment_groupBox);
            this.Controls.Add(this.table_num);
            this.Controls.Add(this.table_num_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_client_form";
            this.ShowIcon = false;
            this.Text = "ADD CLIENT";
            this.Load += new System.EventHandler(this.Add_client_form_Load);
            this.deposit_payment_groupBox.ResumeLayout(false);
            this.deposit_payment_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_num_label;
        private System.Windows.Forms.ComboBox table_num;
        private System.Windows.Forms.GroupBox deposit_payment_groupBox;
        private System.Windows.Forms.DateTimePicker client_TIME_out_field;
        private System.Windows.Forms.DateTimePicker client_DATE_out_field;
        private System.Windows.Forms.TextBox paid_sum_text_box;
        private System.Windows.Forms.Label OR_text_label;
        private System.Windows.Forms.Label paid_sum_label;
        private System.Windows.Forms.Label client_time_out_label;
        private System.Windows.Forms.Button add_client_button;
    }
}