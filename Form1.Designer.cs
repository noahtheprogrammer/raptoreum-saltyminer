
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
            this.label1 = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.mining_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.dash_button = new System.Windows.Forms.Label();
            this.config_button = new System.Windows.Forms.Label();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.quit_button = new System.Windows.Forms.Label();
            this.min_button = new System.Windows.Forms.Label();
            this.panel_2.SuspendLayout();
            this.panel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Neue Montreal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.address_label.Location = new System.Drawing.Point(15, 17);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(169, 20);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Insert payout address:";
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.Gray;
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.set_box.Font = new System.Drawing.Font("Neue Montreal", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.SystemColors.Control;
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
            this.set_box.Location = new System.Drawing.Point(15, 160);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(259, 167);
            this.set_box.TabIndex = 5;
            this.set_box.SelectedIndexChanged += new System.EventHandler(this.set_box_SelectedIndexChanged);
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.Gray;
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pool_text.Font = new System.Drawing.Font("Neue Montreal Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.SystemColors.Control;
            this.pool_text.Location = new System.Drawing.Point(15, 101);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "  (ex. stratum+tcp://r-pool.net:3008)";
            this.pool_text.Size = new System.Drawing.Size(348, 22);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neue Montreal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Insert mining pool:";
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.Gray;
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_text.Font = new System.Drawing.Font("Neue Montreal Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.SystemColors.Control;
            this.address_text.Location = new System.Drawing.Point(15, 41);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "  (ex. RWXMEVTEJYNVP2HTJQ97DMYVWYTWUFTI8E)";
            this.address_text.Size = new System.Drawing.Size(348, 22);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // mining_button
            // 
            this.mining_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mining_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mining_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(235)))), ((int)(((byte)(98)))));
            this.mining_button.FlatAppearance.BorderSize = 5;
            this.mining_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(215)))), ((int)(((byte)(78)))));
            this.mining_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mining_button.Image = global::raptoreum_rtminer.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(383, 117);
            this.mining_button.Name = "mining_button";
            this.mining_button.Size = new System.Drawing.Size(117, 133);
            this.mining_button.TabIndex = 1;
            this.mining_button.UseVisualStyleBackColor = false;
            this.mining_button.Click += new System.EventHandler(this.mining_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neue Montreal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose instruction set:";
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 410);
            this.panel_2.TabIndex = 7;
            // 
            // dash_button
            // 
            this.dash_button.AutoSize = true;
            this.dash_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash_button.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dash_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dash_button.Location = new System.Drawing.Point(11, 15);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(87, 19);
            this.dash_button.TabIndex = 8;
            this.dash_button.Text = "Dashboard";
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.AutoSize = true;
            this.config_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.config_button.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.config_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.config_button.Location = new System.Drawing.Point(117, 15);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(114, 19);
            this.config_button.TabIndex = 9;
            this.config_button.Text = "Configurations";
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel_1.Controls.Add(this.label2);
            this.panel_1.Controls.Add(this.address_label);
            this.panel_1.Controls.Add(this.label1);
            this.panel_1.Controls.Add(this.address_text);
            this.panel_1.Controls.Add(this.pool_text);
            this.panel_1.Controls.Add(this.set_box);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 410);
            this.panel_1.TabIndex = 8;
            // 
            // quit_button
            // 
            this.quit_button.AutoSize = true;
            this.quit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_button.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.quit_button.Location = new System.Drawing.Point(815, 15);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(23, 23);
            this.quit_button.TabIndex = 10;
            this.quit_button.Text = "X";
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // min_button
            // 
            this.min_button.AutoSize = true;
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.Font = new System.Drawing.Font("Roboto Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min_button.ForeColor = System.Drawing.Color.Yellow;
            this.min_button.Location = new System.Drawing.Point(789, 12);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(20, 23);
            this.min_button.TabIndex = 11;
            this.min_button.Text = "_";
            // 
            // rtm_miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(850, 450);
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
            this.panel_2.ResumeLayout(false);
            this.panel_1.ResumeLayout(false);
            this.panel_1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.ListBox set_box;
        private System.Windows.Forms.TextBox pool_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Button mining_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_2;
        private System.Windows.Forms.Label dash_button;
        private System.Windows.Forms.Label config_button;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.Label quit_button;
        private System.Windows.Forms.Label min_button;
    }
}

