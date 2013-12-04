namespace BOOM_GAMEBAR
{
    partial class add_payment_on_card_form
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
            this.customer_id_label = new System.Windows.Forms.Label();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.customer_phone_label = new System.Windows.Forms.Label();
            this.money_left_label = new System.Windows.Forms.Label();
            this.put_money_on_card_label = new System.Windows.Forms.Label();
            this.customer_id_comboBox = new System.Windows.Forms.ComboBox();
            this.customer_name_textBox = new System.Windows.Forms.TextBox();
            this.customer_phone_textBox2 = new System.Windows.Forms.TextBox();
            this.customer_money_left_textBox3 = new System.Windows.Forms.TextBox();
            this.put_money_button = new System.Windows.Forms.Button();
            this.discount_textbox = new System.Windows.Forms.TextBox();
            this.discount_label = new System.Windows.Forms.Label();
            this.data_of_activation = new System.Windows.Forms.Label();
            this.data_of_activation_textbox = new System.Windows.Forms.TextBox();
            this.put_money_on_client_card_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.put_money_on_client_card_numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_id_label
            // 
            this.customer_id_label.AutoSize = true;
            this.customer_id_label.Location = new System.Drawing.Point(25, 23);
            this.customer_id_label.Name = "customer_id_label";
            this.customer_id_label.Size = new System.Drawing.Size(65, 13);
            this.customer_id_label.TabIndex = 0;
            this.customer_id_label.Text = "Customer ID";
            // 
            // customer_name_label
            // 
            this.customer_name_label.AutoSize = true;
            this.customer_name_label.Location = new System.Drawing.Point(25, 50);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.Size = new System.Drawing.Size(35, 13);
            this.customer_name_label.TabIndex = 0;
            this.customer_name_label.Text = "Name";
            // 
            // customer_phone_label
            // 
            this.customer_phone_label.AutoSize = true;
            this.customer_phone_label.Location = new System.Drawing.Point(25, 76);
            this.customer_phone_label.Name = "customer_phone_label";
            this.customer_phone_label.Size = new System.Drawing.Size(38, 13);
            this.customer_phone_label.TabIndex = 0;
            this.customer_phone_label.Text = "Phone";
            // 
            // money_left_label
            // 
            this.money_left_label.AutoSize = true;
            this.money_left_label.Location = new System.Drawing.Point(25, 102);
            this.money_left_label.Name = "money_left_label";
            this.money_left_label.Size = new System.Drawing.Size(56, 13);
            this.money_left_label.TabIndex = 0;
            this.money_left_label.Text = "Money left";
            // 
            // put_money_on_card_label
            // 
            this.put_money_on_card_label.AutoSize = true;
            this.put_money_on_card_label.Location = new System.Drawing.Point(25, 180);
            this.put_money_on_card_label.Name = "put_money_on_card_label";
            this.put_money_on_card_label.Size = new System.Drawing.Size(96, 13);
            this.put_money_on_card_label.TabIndex = 0;
            this.put_money_on_card_label.Text = "Put money on card";
            // 
            // customer_id_comboBox
            // 
            this.customer_id_comboBox.FormattingEnabled = true;
            this.customer_id_comboBox.Location = new System.Drawing.Point(145, 20);
            this.customer_id_comboBox.Name = "customer_id_comboBox";
            this.customer_id_comboBox.Size = new System.Drawing.Size(71, 21);
            this.customer_id_comboBox.TabIndex = 1;
            this.customer_id_comboBox.SelectedIndexChanged += new System.EventHandler(this.customer_id_comboBox_SelectedIndexChanged);
            this.customer_id_comboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // customer_name_textBox
            // 
            this.customer_name_textBox.Location = new System.Drawing.Point(145, 47);
            this.customer_name_textBox.Name = "customer_name_textBox";
            this.customer_name_textBox.ReadOnly = true;
            this.customer_name_textBox.Size = new System.Drawing.Size(147, 20);
            this.customer_name_textBox.TabIndex = 2;
            // 
            // customer_phone_textBox2
            // 
            this.customer_phone_textBox2.Location = new System.Drawing.Point(145, 73);
            this.customer_phone_textBox2.Name = "customer_phone_textBox2";
            this.customer_phone_textBox2.ReadOnly = true;
            this.customer_phone_textBox2.Size = new System.Drawing.Size(147, 20);
            this.customer_phone_textBox2.TabIndex = 2;
            // 
            // customer_money_left_textBox3
            // 
            this.customer_money_left_textBox3.Location = new System.Drawing.Point(145, 99);
            this.customer_money_left_textBox3.Name = "customer_money_left_textBox3";
            this.customer_money_left_textBox3.ReadOnly = true;
            this.customer_money_left_textBox3.Size = new System.Drawing.Size(147, 20);
            this.customer_money_left_textBox3.TabIndex = 2;
            // 
            // put_money_button
            // 
            this.put_money_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.put_money_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.put_money_button.Location = new System.Drawing.Point(0, 209);
            this.put_money_button.Name = "put_money_button";
            this.put_money_button.Size = new System.Drawing.Size(303, 33);
            this.put_money_button.TabIndex = 3;
            this.put_money_button.Text = "Put money";
            this.put_money_button.UseVisualStyleBackColor = true;
            this.put_money_button.Click += new System.EventHandler(this.put_money_button_Click);
            // 
            // discount_textbox
            // 
            this.discount_textbox.Location = new System.Drawing.Point(145, 125);
            this.discount_textbox.Name = "discount_textbox";
            this.discount_textbox.ReadOnly = true;
            this.discount_textbox.Size = new System.Drawing.Size(147, 20);
            this.discount_textbox.TabIndex = 4;
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Location = new System.Drawing.Point(25, 128);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(49, 13);
            this.discount_label.TabIndex = 5;
            this.discount_label.Text = "Discount";
            // 
            // data_of_activation
            // 
            this.data_of_activation.AutoSize = true;
            this.data_of_activation.Location = new System.Drawing.Point(25, 154);
            this.data_of_activation.Name = "data_of_activation";
            this.data_of_activation.Size = new System.Drawing.Size(91, 13);
            this.data_of_activation.TabIndex = 6;
            this.data_of_activation.Text = "Date of activation";
            // 
            // data_of_activation_textbox
            // 
            this.data_of_activation_textbox.Location = new System.Drawing.Point(145, 151);
            this.data_of_activation_textbox.Name = "data_of_activation_textbox";
            this.data_of_activation_textbox.ReadOnly = true;
            this.data_of_activation_textbox.Size = new System.Drawing.Size(147, 20);
            this.data_of_activation_textbox.TabIndex = 7;
            // 
            // put_money_on_client_card_numericUpDown1
            // 
            this.put_money_on_client_card_numericUpDown1.Location = new System.Drawing.Point(145, 178);
            this.put_money_on_client_card_numericUpDown1.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.put_money_on_client_card_numericUpDown1.Name = "put_money_on_client_card_numericUpDown1";
            this.put_money_on_client_card_numericUpDown1.Size = new System.Drawing.Size(147, 20);
            this.put_money_on_client_card_numericUpDown1.TabIndex = 8;
            // 
            // add_payment_on_card_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(303, 242);
            this.Controls.Add(this.put_money_on_client_card_numericUpDown1);
            this.Controls.Add(this.data_of_activation_textbox);
            this.Controls.Add(this.data_of_activation);
            this.Controls.Add(this.discount_label);
            this.Controls.Add(this.discount_textbox);
            this.Controls.Add(this.put_money_button);
            this.Controls.Add(this.customer_money_left_textBox3);
            this.Controls.Add(this.customer_phone_textBox2);
            this.Controls.Add(this.customer_name_textBox);
            this.Controls.Add(this.customer_id_comboBox);
            this.Controls.Add(this.put_money_on_card_label);
            this.Controls.Add(this.money_left_label);
            this.Controls.Add(this.customer_phone_label);
            this.Controls.Add(this.customer_name_label);
            this.Controls.Add(this.customer_id_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_payment_on_card_form";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Put money on card of customer";
            ((System.ComponentModel.ISupportInitialize)(this.put_money_on_client_card_numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_id_label;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.Label customer_phone_label;
        private System.Windows.Forms.Label money_left_label;
        private System.Windows.Forms.Label put_money_on_card_label;
        private System.Windows.Forms.ComboBox customer_id_comboBox;
        private System.Windows.Forms.TextBox customer_name_textBox;
        private System.Windows.Forms.TextBox customer_phone_textBox2;
        private System.Windows.Forms.TextBox customer_money_left_textBox3;
        private System.Windows.Forms.Button put_money_button;
        private System.Windows.Forms.TextBox discount_textbox;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label data_of_activation;
        private System.Windows.Forms.TextBox data_of_activation_textbox;
        private System.Windows.Forms.NumericUpDown put_money_on_client_card_numericUpDown1;
    }
}