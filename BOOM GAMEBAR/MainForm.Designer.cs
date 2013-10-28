namespace BOOM_GAMEBAR
{
    partial class BOOM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.close_client_button = new System.Windows.Forms.Button();
            this.add_client_button = new System.Windows.Forms.Button();
            this.clients_table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clients_table)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.close_client_button);
            this.splitContainer1.Panel1.Controls.Add(this.add_client_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clients_table);
            this.splitContainer1.Size = new System.Drawing.Size(963, 297);
            this.splitContainer1.SplitterDistance = 106;
            this.splitContainer1.TabIndex = 0;
            // 
            // close_client_button
            // 
            this.close_client_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.close_client_button.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_client_button.Location = new System.Drawing.Point(0, 46);
            this.close_client_button.Name = "close_client_button";
            this.close_client_button.Size = new System.Drawing.Size(106, 46);
            this.close_client_button.TabIndex = 1;
            this.close_client_button.Text = "Close client";
            this.close_client_button.UseVisualStyleBackColor = true;
            this.close_client_button.Click += new System.EventHandler(this.close_client_button_Click);
            // 
            // add_client_button
            // 
            this.add_client_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_client_button.Font = new System.Drawing.Font("Trajan Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_client_button.Location = new System.Drawing.Point(0, 0);
            this.add_client_button.Name = "add_client_button";
            this.add_client_button.Size = new System.Drawing.Size(106, 46);
            this.add_client_button.TabIndex = 0;
            this.add_client_button.Text = "Add client";
            this.add_client_button.UseVisualStyleBackColor = true;
            this.add_client_button.Click += new System.EventHandler(this.add_client_button_Click);
            // 
            // clients_table
            // 
            this.clients_table.AccessibleName = "clients_table";
            this.clients_table.AllowUserToAddRows = false;
            this.clients_table.AllowUserToDeleteRows = false;
            this.clients_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen;
            this.clients_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.clients_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clients_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.clients_table.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.clients_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clients_table.CausesValidation = false;
            this.clients_table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clients_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.clients_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clients_table.DefaultCellStyle = dataGridViewCellStyle6;
            this.clients_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clients_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clients_table.Location = new System.Drawing.Point(0, 0);
            this.clients_table.MultiSelect = false;
            this.clients_table.Name = "clients_table";
            this.clients_table.ReadOnly = true;
            this.clients_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.clients_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clients_table.Size = new System.Drawing.Size(853, 297);
            this.clients_table.TabIndex = 0;
            this.clients_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clients_table_CellContentClick);
            // 
            // BOOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 297);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BOOM";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BOOM GAMEBAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BOOM_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clients_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView clients_table;
        private System.Windows.Forms.Button add_client_button;
        private System.Windows.Forms.Button close_client_button;

    }
}

