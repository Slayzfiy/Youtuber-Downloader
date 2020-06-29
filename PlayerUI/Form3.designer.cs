namespace PlayerUI
{
    partial class Form3
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
            this.button5 = new System.Windows.Forms.Button();
            this.btn_savechanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_downloadpath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(1303, 15);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_savechanges
            // 
            this.btn_savechanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savechanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.btn_savechanges.FlatAppearance.BorderSize = 0;
            this.btn_savechanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savechanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savechanges.ForeColor = System.Drawing.Color.LightGray;
            this.btn_savechanges.Location = new System.Drawing.Point(878, 687);
            this.btn_savechanges.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_savechanges.Name = "btn_savechanges";
            this.btn_savechanges.Size = new System.Drawing.Size(300, 77);
            this.btn_savechanges.TabIndex = 15;
            this.btn_savechanges.Text = "Save Changes";
            this.btn_savechanges.UseVisualStyleBackColor = false;
            this.btn_savechanges.Click += new System.EventHandler(this.btn_savechanges_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(545, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "Preferences";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 46);
            this.label1.TabIndex = 19;
            this.label1.Text = "Download-Path";
            // 
            // tb_downloadpath
            // 
            this.tb_downloadpath.Location = new System.Drawing.Point(520, 201);
            this.tb_downloadpath.Multiline = true;
            this.tb_downloadpath.Name = "tb_downloadpath";
            this.tb_downloadpath.Size = new System.Drawing.Size(690, 57);
            this.tb_downloadpath.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1347, 815);
            this.Controls.Add(this.tb_downloadpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_savechanges);
            this.Controls.Add(this.button5);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_savechanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_downloadpath;
    }
}