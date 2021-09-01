
namespace raptoreum_rtminer
{
    partial class rtm_miner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rtm_miner));
            this.address_label = new System.Windows.Forms.Label();
            this.set_box = new System.Windows.Forms.ListBox();
            this.pool_text = new System.Windows.Forms.TextBox();
            this.pool_label = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.instruction_set_label = new System.Windows.Forms.Label();
            this.dash_button = new System.Windows.Forms.Label();
            this.config_button = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.donate_label = new System.Windows.Forms.Label();
            this.roundedPanel2 = new raptoreum_rtminer.RoundedPanel();
            this.extra_params_text = new System.Windows.Forms.TextBox();
            this.extra_params_label = new System.Windows.Forms.Label();
            this.seperation_line = new System.Windows.Forms.Label();
            this.roundedPanel1 = new raptoreum_rtminer.RoundedPanel();
            this.threads_label = new System.Windows.Forms.Label();
            this.threads_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.credit_text = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.Label();
            this.min_button = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mining_button = new System.Windows.Forms.PictureBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.mining_label = new System.Windows.Forms.Label();
            this.panel_1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).BeginInit();
            this.panel_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.address_label.Location = new System.Drawing.Point(17, 17);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(167, 20);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Insert payout address:";
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.set_box.FormattingEnabled = true;
            this.set_box.ItemHeight = 15;
            this.set_box.Items.AddRange(new object[] {
            "AVX",
            "AVX2",
            "AVX512",
            "AVX512-SHA",
            "AVX512-SHA-VAES",
            "SSE2",
            "SSE42",
            "SSSE3",
            "ZEN",
            "ZEN2",
            "ZEN3"});
            this.set_box.Location = new System.Drawing.Point(22, 49);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(278, 150);
            this.set_box.TabIndex = 5;
            this.set_box.SelectedIndexChanged += new System.EventHandler(this.set_box_SelectedIndexChanged);
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pool_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pool_text.Location = new System.Drawing.Point(17, 136);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "  (ex. stratum+tcp://r-pool.net:3008)";
            this.pool_text.Size = new System.Drawing.Size(348, 14);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // pool_label
            // 
            this.pool_label.AutoSize = true;
            this.pool_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pool_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.pool_label.Location = new System.Drawing.Point(17, 102);
            this.pool_label.Name = "pool_label";
            this.pool_label.Size = new System.Drawing.Size(138, 20);
            this.pool_label.TabIndex = 4;
            this.pool_label.Text = "Insert mining pool:";
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.address_text.Location = new System.Drawing.Point(11, 49);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "  (ex. RWXMEVTEJYNVP2HTJQ97DMYVWYTWUFTI8E)";
            this.address_text.Size = new System.Drawing.Size(348, 14);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // instruction_set_label
            // 
            this.instruction_set_label.AutoSize = true;
            this.instruction_set_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.instruction_set_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instruction_set_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.instruction_set_label.Location = new System.Drawing.Point(24, 17);
            this.instruction_set_label.Name = "instruction_set_label";
            this.instruction_set_label.Size = new System.Drawing.Size(171, 20);
            this.instruction_set_label.TabIndex = 6;
            this.instruction_set_label.Text = "Choose instruction set:";
            // 
            // dash_button
            // 
            this.dash_button.AutoSize = true;
            this.dash_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dash_button.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dash_button.Location = new System.Drawing.Point(548, 15);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(88, 20);
            this.dash_button.TabIndex = 8;
            this.dash_button.Text = "Dashboard";
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.AutoSize = true;
            this.config_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.config_button.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.config_button.Location = new System.Drawing.Point(641, 15);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(112, 20);
            this.config_button.TabIndex = 9;
            this.config_button.Text = "Configurations";
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel_1.Controls.Add(this.donate_label);
            this.panel_1.Controls.Add(this.roundedPanel2);
            this.panel_1.Controls.Add(this.roundedPanel1);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 410);
            this.panel_1.TabIndex = 8;
            // 
            // donate_label
            // 
            this.donate_label.AutoSize = true;
            this.donate_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.donate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.donate_label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.donate_label.Location = new System.Drawing.Point(245, 379);
            this.donate_label.Name = "donate_label";
            this.donate_label.Size = new System.Drawing.Size(403, 16);
            this.donate_label.TabIndex = 7;
            this.donate_label.Text = "Donation address: RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Controls.Add(this.extra_params_text);
            this.roundedPanel2.Controls.Add(this.extra_params_label);
            this.roundedPanel2.Controls.Add(this.seperation_line);
            this.roundedPanel2.Controls.Add(this.set_box);
            this.roundedPanel2.Controls.Add(this.instruction_set_label);
            this.roundedPanel2.Location = new System.Drawing.Point(473, 50);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel2.Size = new System.Drawing.Size(321, 285);
            this.roundedPanel2.TabIndex = 8;
            // 
            // extra_params_text
            // 
            this.extra_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_params_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.extra_params_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.extra_params_text.Location = new System.Drawing.Point(24, 248);
            this.extra_params_text.Name = "extra_params_text";
            this.extra_params_text.PlaceholderText = "  (ex. --tune-full)";
            this.extra_params_text.Size = new System.Drawing.Size(275, 14);
            this.extra_params_text.TabIndex = 9;
            this.extra_params_text.TextChanged += new System.EventHandler(this.extra_params_TextChanged);
            // 
            // extra_params_label
            // 
            this.extra_params_label.AutoSize = true;
            this.extra_params_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_params_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_params_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.extra_params_label.Location = new System.Drawing.Point(24, 228);
            this.extra_params_label.Name = "extra_params_label";
            this.extra_params_label.Size = new System.Drawing.Size(107, 20);
            this.extra_params_label.TabIndex = 9;
            this.extra_params_label.Text = "Extra params:";
            // 
            // seperation_line
            // 
            this.seperation_line.AutoSize = true;
            this.seperation_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.seperation_line.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.seperation_line.Location = new System.Drawing.Point(22, 202);
            this.seperation_line.Name = "seperation_line";
            this.seperation_line.Size = new System.Drawing.Size(280, 15);
            this.seperation_line.TabIndex = 9;
            this.seperation_line.Text = "_______________________________________";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.threads_label);
            this.roundedPanel1.Controls.Add(this.threads_text);
            this.roundedPanel1.Controls.Add(this.label6);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.pool_label);
            this.roundedPanel1.Controls.Add(this.pool_text);
            this.roundedPanel1.Controls.Add(this.address_label);
            this.roundedPanel1.Controls.Add(this.address_text);
            this.roundedPanel1.Location = new System.Drawing.Point(59, 50);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel1.Size = new System.Drawing.Size(408, 285);
            this.roundedPanel1.TabIndex = 7;
            // 
            // threads_label
            // 
            this.threads_label.AutoSize = true;
            this.threads_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threads_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.threads_label.Location = new System.Drawing.Point(17, 197);
            this.threads_label.Name = "threads_label";
            this.threads_label.Size = new System.Drawing.Size(148, 20);
            this.threads_label.TabIndex = 8;
            this.threads_label.Text = "Insert thread count:";
            // 
            // threads_text
            // 
            this.threads_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threads_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.threads_text.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.threads_text.Location = new System.Drawing.Point(17, 231);
            this.threads_text.Name = "threads_text";
            this.threads_text.PlaceholderText = "  (ex. 24)";
            this.threads_text.Size = new System.Drawing.Size(348, 14);
            this.threads_text.TabIndex = 7;
            this.threads_text.TextChanged += new System.EventHandler(this.threads_text_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(17, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "______________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "______________________________________________";
            // 
            // credit_text
            // 
            this.credit_text.AutoSize = true;
            this.credit_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.credit_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.credit_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.credit_text.Location = new System.Drawing.Point(237, 379);
            this.credit_text.Name = "credit_text";
            this.credit_text.Size = new System.Drawing.Size(414, 16);
            this.credit_text.TabIndex = 9;
            this.credit_text.Text = "This miner was created by OKprogrammer and is open-source for all.";
            // 
            // quit_button
            // 
            this.quit_button.AutoSize = true;
            this.quit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.Location = new System.Drawing.Point(815, 15);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(25, 24);
            this.quit_button.TabIndex = 10;
            this.quit_button.Text = "X";
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // min_button
            // 
            this.min_button.AutoSize = true;
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min_button.ForeColor = System.Drawing.Color.Yellow;
            this.min_button.Location = new System.Drawing.Point(789, 12);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(21, 24);
            this.min_button.TabIndex = 11;
            this.min_button.Text = "_";
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(12, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "SALTYMINER";
            // 
            // mining_button
            // 
            this.mining_button.Image = global::raptoreum_rtminer.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(346, 67);
            this.mining_button.Name = "mining_button";
            this.mining_button.Size = new System.Drawing.Size(200, 200);
            this.mining_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mining_button.TabIndex = 0;
            this.mining_button.TabStop = false;
            this.mining_button.Click += new System.EventHandler(this.mining_button_Click_1);
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel_2.Controls.Add(this.mining_label);
            this.panel_2.Controls.Add(this.credit_text);
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 410);
            this.panel_2.TabIndex = 7;
            // 
            // mining_label
            // 
            this.mining_label.AutoSize = true;
            this.mining_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mining_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mining_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.mining_label.Location = new System.Drawing.Point(395, 80);
            this.mining_label.Name = "mining_label";
            this.mining_label.Size = new System.Drawing.Size(98, 20);
            this.mining_label.TabIndex = 7;
            this.mining_label.Text = "Start Mining.";
            // 
            // rtm_miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.dash_button);
            this.Controls.Add(this.panel_2);
            this.Controls.Add(this.panel_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(850, 450);
            this.Name = "rtm_miner";
            this.Text = "SaltyMiner";
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).EndInit();
            this.panel_2.ResumeLayout(false);
            this.panel_2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.ListBox set_box;
        private System.Windows.Forms.TextBox pool_text;
        private System.Windows.Forms.Label pool_label;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label instruction_set_label;
        private System.Windows.Forms.Label dash_button;
        private System.Windows.Forms.Label config_button;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label quit_button;
        private System.Windows.Forms.Label min_button;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label donate_label;
        private System.Windows.Forms.Label credit_text;
        private System.Windows.Forms.PictureBox mining_button;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Label mining_label;
        private System.Windows.Forms.Label threads_label;
        private System.Windows.Forms.TextBox threads_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label seperation_line;
        private System.Windows.Forms.TextBox extra_params_text;
        private System.Windows.Forms.Label extra_params_label;
    }
}

