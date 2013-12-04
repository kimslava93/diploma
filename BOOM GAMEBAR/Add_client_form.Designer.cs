﻿namespace BOOM_GAMEBAR
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
            this.components = new System.ComponentModel.Container();
            this.table_num_label = new System.Windows.Forms.Label();
            this.table_num = new System.Windows.Forms.ComboBox();
            this.deposit_payment_groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonTimeOut = new System.Windows.Forms.RadioButton();
            this.radioButtonPaidSum = new System.Windows.Forms.RadioButton();
            this.paid_price_numeric_up_down = new System.Windows.Forms.NumericUpDown();
            this.client_TIME_out_field = new System.Windows.Forms.DateTimePicker();
            this.client_DATE_out_field = new System.Windows.Forms.DateTimePicker();
            this.OR_text_label = new System.Windows.Forms.Label();
            this.paid_sum_label = new System.Windows.Forms.Label();
            this.client_time_out_label = new System.Windows.Forms.Label();
            this.add_client_button = new System.Windows.Forms.Button();
            this.current_time_label = new System.Windows.Forms.Label();
            this.current_time_timer = new System.Windows.Forms.Timer(this.components);
            this.combo_box_client_discount_card = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.client_info_group_box = new System.Windows.Forms.GroupBox();
            this.add_payment_button = new System.Windows.Forms.Button();
            this.add_money_on_card_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clients_money_left_textBox = new System.Windows.Forms.TextBox();
            this.client_name_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deposit_payment_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_price_numeric_up_down)).BeginInit();
            this.client_info_group_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_money_on_card_numericUpDown)).BeginInit();
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
            this.table_num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table_num.Location = new System.Drawing.Point(74, 36);
            this.table_num.Name = "table_num";
            this.table_num.Size = new System.Drawing.Size(57, 21);
            this.table_num.TabIndex = 1;
            this.table_num.SelectedIndexChanged += new System.EventHandler(this.table_num_SelectedIndexChanged);
            this.table_num.MouseClick += new System.Windows.Forms.MouseEventHandler(this.table_num_MouseClick);
            // 
            // deposit_payment_groupBox
            // 
            this.deposit_payment_groupBox.Controls.Add(this.radioButtonTimeOut);
            this.deposit_payment_groupBox.Controls.Add(this.radioButtonPaidSum);
            this.deposit_payment_groupBox.Controls.Add(this.paid_price_numeric_up_down);
            this.deposit_payment_groupBox.Controls.Add(this.client_TIME_out_field);
            this.deposit_payment_groupBox.Controls.Add(this.client_DATE_out_field);
            this.deposit_payment_groupBox.Controls.Add(this.OR_text_label);
            this.deposit_payment_groupBox.Controls.Add(this.paid_sum_label);
            this.deposit_payment_groupBox.Controls.Add(this.client_time_out_label);
            this.deposit_payment_groupBox.Location = new System.Drawing.Point(12, 72);
            this.deposit_payment_groupBox.Name = "deposit_payment_groupBox";
            this.deposit_payment_groupBox.Size = new System.Drawing.Size(303, 147);
            this.deposit_payment_groupBox.TabIndex = 2;
            this.deposit_payment_groupBox.TabStop = false;
            this.deposit_payment_groupBox.Text = "Deposit payment";
            // 
            // radioButtonTimeOut
            // 
            this.radioButtonTimeOut.AutoSize = true;
            this.radioButtonTimeOut.Location = new System.Drawing.Point(16, 93);
            this.radioButtonTimeOut.Name = "radioButtonTimeOut";
            this.radioButtonTimeOut.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTimeOut.TabIndex = 3;
            this.radioButtonTimeOut.UseVisualStyleBackColor = true;
            this.radioButtonTimeOut.CheckedChanged += new System.EventHandler(this.radioButtonTimeOut_CheckedChanged);
            // 
            // radioButtonPaidSum
            // 
            this.radioButtonPaidSum.AutoSize = true;
            this.radioButtonPaidSum.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPaidSum.Checked = true;
            this.radioButtonPaidSum.Location = new System.Drawing.Point(16, 29);
            this.radioButtonPaidSum.Name = "radioButtonPaidSum";
            this.radioButtonPaidSum.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPaidSum.TabIndex = 3;
            this.radioButtonPaidSum.TabStop = true;
            this.radioButtonPaidSum.UseVisualStyleBackColor = true;
            this.radioButtonPaidSum.CheckedChanged += new System.EventHandler(this.radioButtonPaidSum_CheckedChanged);
            // 
            // paid_price_numeric_up_down
            // 
            this.paid_price_numeric_up_down.DecimalPlaces = 2;
            this.paid_price_numeric_up_down.Location = new System.Drawing.Point(138, 27);
            this.paid_price_numeric_up_down.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.paid_price_numeric_up_down.Name = "paid_price_numeric_up_down";
            this.paid_price_numeric_up_down.Size = new System.Drawing.Size(94, 20);
            this.paid_price_numeric_up_down.TabIndex = 4;
            this.paid_price_numeric_up_down.ValueChanged += new System.EventHandler(this.paid_price_numeric_up_down_ValueChanged);
            this.paid_price_numeric_up_down.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paid_price_numeric_up_down_KeyPress);
            this.paid_price_numeric_up_down.KeyUp += new System.Windows.Forms.KeyEventHandler(this.paid_price_numeric_up_down_KeyUp);
            // 
            // client_TIME_out_field
            // 
            this.client_TIME_out_field.CustomFormat = "HH:mm";
            this.client_TIME_out_field.Enabled = false;
            this.client_TIME_out_field.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.client_TIME_out_field.Location = new System.Drawing.Point(230, 89);
            this.client_TIME_out_field.Name = "client_TIME_out_field";
            this.client_TIME_out_field.ShowUpDown = true;
            this.client_TIME_out_field.Size = new System.Drawing.Size(58, 20);
            this.client_TIME_out_field.TabIndex = 4;
            this.client_TIME_out_field.ValueChanged += new System.EventHandler(this.client_TIME_out_field_ValueChanged);
            // 
            // client_DATE_out_field
            // 
            this.client_DATE_out_field.CustomFormat = "dd/MMM/yy";
            this.client_DATE_out_field.Enabled = false;
            this.client_DATE_out_field.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.client_DATE_out_field.Location = new System.Drawing.Point(138, 89);
            this.client_DATE_out_field.Name = "client_DATE_out_field";
            this.client_DATE_out_field.Size = new System.Drawing.Size(86, 20);
            this.client_DATE_out_field.TabIndex = 6;
            // 
            // OR_text_label
            // 
            this.OR_text_label.AutoSize = true;
            this.OR_text_label.Location = new System.Drawing.Point(59, 60);
            this.OR_text_label.Name = "OR_text_label";
            this.OR_text_label.Size = new System.Drawing.Size(23, 13);
            this.OR_text_label.TabIndex = 2;
            this.OR_text_label.Text = "OR";
            // 
            // paid_sum_label
            // 
            this.paid_sum_label.AutoSize = true;
            this.paid_sum_label.Location = new System.Drawing.Point(59, 29);
            this.paid_sum_label.Name = "paid_sum_label";
            this.paid_sum_label.Size = new System.Drawing.Size(50, 13);
            this.paid_sum_label.TabIndex = 1;
            this.paid_sum_label.Text = "Paid sum";
            // 
            // client_time_out_label
            // 
            this.client_time_out_label.AutoSize = true;
            this.client_time_out_label.Enabled = false;
            this.client_time_out_label.Location = new System.Drawing.Point(59, 93);
            this.client_time_out_label.Name = "client_time_out_label";
            this.client_time_out_label.Size = new System.Drawing.Size(73, 13);
            this.client_time_out_label.TabIndex = 0;
            this.client_time_out_label.Text = "Client time out";
            // 
            // add_client_button
            // 
            this.add_client_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_client_button.Location = new System.Drawing.Point(0, 225);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(623, 38);
            this.add_client_button.TabIndex = 5;
            this.add_client_button.Text = "Add new client";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // current_time_label
            // 
            this.current_time_label.AutoSize = true;
            this.current_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.current_time_label.Location = new System.Drawing.Point(413, 9);
            this.current_time_label.Name = "current_time_label";
            this.current_time_label.Size = new System.Drawing.Size(90, 16);
            this.current_time_label.TabIndex = 4;
            this.current_time_label.Text = "Current time";
            // 
            // current_time_timer
            // 
            this.current_time_timer.Enabled = true;
            this.current_time_timer.Interval = 1000;
            this.current_time_timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // combo_box_client_discount_card
            // 
            this.combo_box_client_discount_card.FormattingEnabled = true;
            this.combo_box_client_discount_card.Location = new System.Drawing.Point(258, 36);
            this.combo_box_client_discount_card.Name = "combo_box_client_discount_card";
            this.combo_box_client_discount_card.Size = new System.Drawing.Size(57, 21);
            this.combo_box_client_discount_card.TabIndex = 2;
            this.combo_box_client_discount_card.Text = "0";
            this.combo_box_client_discount_card.SelectedIndexChanged += new System.EventHandler(this.combo_box_client_discount_card_SelectedIndexChanged);
            this.combo_box_client_discount_card.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo_box_client_discount_card_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client Discount";
            // 
            // client_info_group_box
            // 
            this.client_info_group_box.Controls.Add(this.label6);
            this.client_info_group_box.Controls.Add(this.label5);
            this.client_info_group_box.Controls.Add(this.add_payment_button);
            this.client_info_group_box.Controls.Add(this.add_money_on_card_numericUpDown);
            this.client_info_group_box.Controls.Add(this.clients_money_left_textBox);
            this.client_info_group_box.Controls.Add(this.client_name_textBox);
            this.client_info_group_box.Controls.Add(this.label4);
            this.client_info_group_box.Controls.Add(this.label3);
            this.client_info_group_box.Controls.Add(this.label2);
            this.client_info_group_box.Enabled = false;
            this.client_info_group_box.Location = new System.Drawing.Point(321, 72);
            this.client_info_group_box.Name = "client_info_group_box";
            this.client_info_group_box.Size = new System.Drawing.Size(290, 147);
            this.client_info_group_box.TabIndex = 7;
            this.client_info_group_box.TabStop = false;
            this.client_info_group_box.Text = "Client info";
            // 
            // add_payment_button
            // 
            this.add_payment_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_payment_button.Location = new System.Drawing.Point(212, 120);
            this.add_payment_button.Name = "add_payment_button";
            this.add_payment_button.Size = new System.Drawing.Size(27, 23);
            this.add_payment_button.TabIndex = 7;
            this.add_payment_button.Text = ">";
            this.add_payment_button.UseVisualStyleBackColor = true;
            this.add_payment_button.Click += new System.EventHandler(this.add_payment_button_Click);
            // 
            // add_money_on_card_numericUpDown
            // 
            this.add_money_on_card_numericUpDown.DecimalPlaces = 2;
            this.add_money_on_card_numericUpDown.Location = new System.Drawing.Point(112, 123);
            this.add_money_on_card_numericUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.add_money_on_card_numericUpDown.Name = "add_money_on_card_numericUpDown";
            this.add_money_on_card_numericUpDown.Size = new System.Drawing.Size(70, 20);
            this.add_money_on_card_numericUpDown.TabIndex = 6;
            // 
            // clients_money_left_textBox
            // 
            this.clients_money_left_textBox.Location = new System.Drawing.Point(112, 50);
            this.clients_money_left_textBox.Name = "clients_money_left_textBox";
            this.clients_money_left_textBox.ReadOnly = true;
            this.clients_money_left_textBox.Size = new System.Drawing.Size(172, 20);
            this.clients_money_left_textBox.TabIndex = 4;
            // 
            // client_name_textBox
            // 
            this.client_name_textBox.Location = new System.Drawing.Point(112, 24);
            this.client_name_textBox.Name = "client_name_textBox";
            this.client_name_textBox.ReadOnly = true;
            this.client_name_textBox.Size = new System.Drawing.Size(172, 20);
            this.client_name_textBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Add money on card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Money left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Added money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total sum on card";
            // 
            // Add_client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 263);
            this.Controls.Add(this.client_info_group_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_box_client_discount_card);
            this.Controls.Add(this.current_time_label);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Add_client_form_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Add_client_form_KeyPress);
            this.deposit_payment_groupBox.ResumeLayout(false);
            this.deposit_payment_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_price_numeric_up_down)).EndInit();
            this.client_info_group_box.ResumeLayout(false);
            this.client_info_group_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.add_money_on_card_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table_num_label;
        private System.Windows.Forms.ComboBox table_num;
        private System.Windows.Forms.GroupBox deposit_payment_groupBox;
        private System.Windows.Forms.DateTimePicker client_TIME_out_field;
        private System.Windows.Forms.DateTimePicker client_DATE_out_field;
        private System.Windows.Forms.Label OR_text_label;
        private System.Windows.Forms.Label paid_sum_label;
        private System.Windows.Forms.Label client_time_out_label;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.Label current_time_label;
        private System.Windows.Forms.Timer current_time_timer;
        private System.Windows.Forms.NumericUpDown paid_price_numeric_up_down;
        private System.Windows.Forms.RadioButton radioButtonTimeOut;
        private System.Windows.Forms.RadioButton radioButtonPaidSum;
        private System.Windows.Forms.ComboBox combo_box_client_discount_card;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox client_info_group_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown add_money_on_card_numericUpDown;
        private System.Windows.Forms.TextBox clients_money_left_textBox;
        private System.Windows.Forms.TextBox client_name_textBox;
        private System.Windows.Forms.Button add_payment_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}