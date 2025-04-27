﻿namespace Cinema_Management_System.Views.MovieManagement
{
    partial class MovieManagementView
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
            this.filterMovie_Cbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMovie_Btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.moviePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchMovie_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterMovie_Cbx
            // 
            this.filterMovie_Cbx.BackColor = System.Drawing.Color.Transparent;
            this.filterMovie_Cbx.BorderRadius = 10;
            this.filterMovie_Cbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterMovie_Cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterMovie_Cbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.filterMovie_Cbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.filterMovie_Cbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.filterMovie_Cbx.ForeColor = System.Drawing.Color.Gray;
            this.filterMovie_Cbx.ItemHeight = 30;
            this.filterMovie_Cbx.Items.AddRange(new object[] {
            "Tất cả",
            "Ngưng phát hành",
            "Đang phát hành",
            "Sắp phát hành"});
            this.filterMovie_Cbx.Location = new System.Drawing.Point(23, 96);
            this.filterMovie_Cbx.Name = "filterMovie_Cbx";
            this.filterMovie_Cbx.Size = new System.Drawing.Size(183, 36);
            this.filterMovie_Cbx.StartIndex = 0;
            this.filterMovie_Cbx.TabIndex = 1;
            this.filterMovie_Cbx.SelectedIndexChanged += new System.EventHandler(this.filterMovie_Cbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bộ lọc";
            // 
            // addMovie_Btn
            // 
            this.addMovie_Btn.Animated = true;
            this.addMovie_Btn.BackColor = System.Drawing.Color.Transparent;
            this.addMovie_Btn.BorderRadius = 10;
            this.addMovie_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMovie_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMovie_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMovie_Btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMovie_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMovie_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.addMovie_Btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.addMovie_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.addMovie_Btn.ForeColor = System.Drawing.Color.White;
            this.addMovie_Btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.addMovie_Btn.Location = new System.Drawing.Point(561, 12);
            this.addMovie_Btn.Name = "addMovie_Btn";
            this.addMovie_Btn.Size = new System.Drawing.Size(166, 39);
            this.addMovie_Btn.TabIndex = 3;
            this.addMovie_Btn.Text = "Thêm phim";
            this.addMovie_Btn.Click += new System.EventHandler(this.addMovie_Btn_Click);
            // 
            // moviePanel
            // 
            this.moviePanel.AutoScroll = true;
            this.moviePanel.Location = new System.Drawing.Point(27, 155);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(1278, 647);
            this.moviePanel.TabIndex = 5;
            this.moviePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.moviePanel_Paint);
            // 
            // searchMovie_Txt
            // 
            this.searchMovie_Txt.Animated = true;
            this.searchMovie_Txt.BorderRadius = 10;
            this.searchMovie_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchMovie_Txt.DefaultText = "";
            this.searchMovie_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchMovie_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchMovie_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchMovie_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchMovie_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.searchMovie_Txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchMovie_Txt.ForeColor = System.Drawing.Color.Black;
            this.searchMovie_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(45)))), ((int)(((byte)(62)))));
            this.searchMovie_Txt.Location = new System.Drawing.Point(23, 12);
            this.searchMovie_Txt.Name = "searchMovie_Txt";
            this.searchMovie_Txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchMovie_Txt.PlaceholderText = "Tìm kiếm phim";
            this.searchMovie_Txt.SelectedText = "";
            this.searchMovie_Txt.Size = new System.Drawing.Size(500, 45);
            this.searchMovie_Txt.TabIndex = 0;
            this.searchMovie_Txt.TextChanged += new System.EventHandler(this.searchMovie_Txt_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Red;
            this.guna2PictureBox1.Image = global::Cinema_Management_System.Properties.Resources.add_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(572, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 28);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 4;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // MovieManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.addMovie_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterMovie_Cbx);
            this.Controls.Add(this.searchMovie_Txt);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MovieManagementView";
            this.Size = new System.Drawing.Size(1329, 838);
            this.Load += new System.EventHandler(this.MovieManagementView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox searchMovie_Txt;
        private Guna.UI2.WinForms.Guna2ComboBox filterMovie_Cbx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton addMovie_Btn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel moviePanel;
    }
}
