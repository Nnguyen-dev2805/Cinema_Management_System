﻿namespace Cinema_Management_System.Views.ShowTimeManagement
{
    partial class ShowTimeManagementyForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.FLP_Auditorium = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AddShowTimeMovie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DTP_SearchTimeMovie = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FLP_ShowTimeMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ticketExchange = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.Controls.Add(this.FLP_Auditorium);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1295, 63);
            this.guna2Panel1.TabIndex = 0;
            // 
            // FLP_Auditorium
            // 
            this.FLP_Auditorium.AutoScroll = true;
            this.FLP_Auditorium.Location = new System.Drawing.Point(3, 4);
            this.FLP_Auditorium.Name = "FLP_Auditorium";
            this.FLP_Auditorium.Size = new System.Drawing.Size(730, 55);
            this.FLP_Auditorium.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.btn_ticketExchange);
            this.guna2Panel3.Controls.Add(this.btn_AddShowTimeMovie);
            this.guna2Panel3.Controls.Add(this.DTP_SearchTimeMovie);
            this.guna2Panel3.Location = new System.Drawing.Point(739, 4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(553, 55);
            this.guna2Panel3.TabIndex = 1;
            // 
            // btn_AddShowTimeMovie
            // 
            this.btn_AddShowTimeMovie.Animated = true;
            this.btn_AddShowTimeMovie.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddShowTimeMovie.BorderRadius = 5;
            this.btn_AddShowTimeMovie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddShowTimeMovie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddShowTimeMovie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddShowTimeMovie.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddShowTimeMovie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddShowTimeMovie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.btn_AddShowTimeMovie.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.btn_AddShowTimeMovie.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_AddShowTimeMovie.ForeColor = System.Drawing.Color.White;
            this.btn_AddShowTimeMovie.Image = global::Cinema_Management_System.Properties.Resources.add_icon;
            this.btn_AddShowTimeMovie.Location = new System.Drawing.Point(96, 3);
            this.btn_AddShowTimeMovie.Name = "btn_AddShowTimeMovie";
            this.btn_AddShowTimeMovie.Size = new System.Drawing.Size(163, 42);
            this.btn_AddShowTimeMovie.TabIndex = 109;
            this.btn_AddShowTimeMovie.Text = "Thêm xuất chiếu";
            this.btn_AddShowTimeMovie.Click += new System.EventHandler(this.btn_AddShowTimeMovie_Click_1);
            // 
            // DTP_SearchTimeMovie
            // 
            this.DTP_SearchTimeMovie.Animated = true;
            this.DTP_SearchTimeMovie.Checked = true;
            this.DTP_SearchTimeMovie.CustomFormat = "\'Chọn ngày\'";
            this.DTP_SearchTimeMovie.FillColor = System.Drawing.Color.White;
            this.DTP_SearchTimeMovie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_SearchTimeMovie.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_SearchTimeMovie.Location = new System.Drawing.Point(434, 3);
            this.DTP_SearchTimeMovie.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DTP_SearchTimeMovie.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DTP_SearchTimeMovie.Name = "DTP_SearchTimeMovie";
            this.DTP_SearchTimeMovie.Size = new System.Drawing.Size(116, 42);
            this.DTP_SearchTimeMovie.TabIndex = 1;
            this.DTP_SearchTimeMovie.Value = new System.DateTime(2025, 3, 28, 20, 58, 16, 329);
            this.DTP_SearchTimeMovie.ValueChanged += new System.EventHandler(this.DTP_SearchTimeMovie_ValueChanged);
            // 
            // FLP_ShowTimeMovie
            // 
            this.FLP_ShowTimeMovie.AutoScroll = true;
            this.FLP_ShowTimeMovie.Location = new System.Drawing.Point(6, 72);
            this.FLP_ShowTimeMovie.Name = "FLP_ShowTimeMovie";
            this.FLP_ShowTimeMovie.Size = new System.Drawing.Size(1292, 748);
            this.FLP_ShowTimeMovie.TabIndex = 1;
            // 
            // btn_ticketExchange
            // 
            this.btn_ticketExchange.Animated = true;
            this.btn_ticketExchange.BackColor = System.Drawing.Color.Transparent;
            this.btn_ticketExchange.BorderRadius = 5;
            this.btn_ticketExchange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ticketExchange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ticketExchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ticketExchange.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ticketExchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ticketExchange.FillColor = System.Drawing.Color.Black;
            this.btn_ticketExchange.FillColor2 = System.Drawing.Color.LightSlateGray;
            this.btn_ticketExchange.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_ticketExchange.ForeColor = System.Drawing.Color.White;
            this.btn_ticketExchange.Image = global::Cinema_Management_System.Properties.Resources.add_icon;
            this.btn_ticketExchange.Location = new System.Drawing.Point(265, 3);
            this.btn_ticketExchange.Name = "btn_ticketExchange";
            this.btn_ticketExchange.Size = new System.Drawing.Size(163, 42);
            this.btn_ticketExchange.TabIndex = 110;
            this.btn_ticketExchange.Text = "Đổi/Trả vé ";
            this.btn_ticketExchange.Click += new System.EventHandler(this.btn_ticketExchange_Click);
            // 
            // ShowTimeManagementyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FLP_ShowTimeMovie);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShowTimeManagementyForm";
            this.Size = new System.Drawing.Size(1329, 838);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker DTP_SearchTimeMovie;
        private System.Windows.Forms.FlowLayoutPanel FLP_Auditorium;
        private System.Windows.Forms.FlowLayoutPanel FLP_ShowTimeMovie;
        private Guna.UI2.WinForms.Guna2GradientButton btn_AddShowTimeMovie;
        private Guna.UI2.WinForms.Guna2GradientButton btn_ticketExchange;
    }
}
