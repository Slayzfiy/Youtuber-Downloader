namespace PlayerUI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.pgb_download = new System.Windows.Forms.ProgressBar();
            this.btn_5 = new System.Windows.Forms.Button();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pb_thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(415, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloader";
            // 
            // tb_input
            // 
            this.tb_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_input.Location = new System.Drawing.Point(108, 95);
            this.tb_input.Margin = new System.Windows.Forms.Padding(6);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(725, 44);
            this.tb_input.TabIndex = 1;
            this.tb_input.Text = "Insert Link or Video Name";
            this.tb_input.Enter += new System.EventHandler(this.tb_input_Enter);
            this.tb_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_input_KeyDown);
            this.tb_input.Leave += new System.EventHandler(this.tb_input_Leave);
            // 
            // btn_download
            // 
            this.btn_download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_download.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_download.FlatAppearance.BorderSize = 0;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_download.Location = new System.Drawing.Point(845, 464);
            this.btn_download.Margin = new System.Windows.Forms.Padding(6);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(300, 77);
            this.btn_download.TabIndex = 5;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.LightGray;
            this.btn_search.Location = new System.Drawing.Point(845, 78);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(300, 77);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lb_items
            // 
            this.lb_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.lb_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_items.ForeColor = System.Drawing.Color.White;
            this.lb_items.FormattingEnabled = true;
            this.lb_items.ItemHeight = 30;
            this.lb_items.Location = new System.Drawing.Point(95, 211);
            this.lb_items.Margin = new System.Windows.Forms.Padding(6);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(725, 330);
            this.lb_items.TabIndex = 8;
            this.lb_items.SelectedIndexChanged += new System.EventHandler(this.lb_items_SelectedIndexChanged);
            // 
            // pgb_download
            // 
            this.pgb_download.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.pgb_download.Location = new System.Drawing.Point(108, 614);
            this.pgb_download.Name = "pgb_download";
            this.pgb_download.Size = new System.Drawing.Size(712, 22);
            this.pgb_download.TabIndex = 11;
            // 
            // btn_5
            // 
            this.btn_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.LightGray;
            this.btn_5.Location = new System.Drawing.Point(1102, 17);
            this.btn_5.Margin = new System.Windows.Forms.Padding(6);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(57, 77);
            this.btn_5.TabIndex = 12;
            this.btn_5.Text = "X";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_click);
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.ForeColor = System.Drawing.Color.White;
            this.lbl_desc.Location = new System.Drawing.Point(-800, 394);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(0, 25);
            this.lbl_desc.TabIndex = 16;
            // 
            // pb_thumbnail
            // 
            this.pb_thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_thumbnail.Location = new System.Drawing.Point(961, 202);
            this.pb_thumbnail.Margin = new System.Windows.Forms.Padding(6);
            this.pb_thumbnail.Name = "pb_thumbnail";
            this.pb_thumbnail.Size = new System.Drawing.Size(300, 250);
            this.pb_thumbnail.TabIndex = 15;
            this.pb_thumbnail.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1174, 729);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.pb_thumbnail);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.pgb_download);
            this.Controls.Add(this.lb_items);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.ProgressBar pgb_download;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.PictureBox pb_thumbnail;
    }
}