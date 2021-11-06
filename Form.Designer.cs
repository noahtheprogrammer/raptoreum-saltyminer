namespace salty
{
    partial class saltyminer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(saltyminer));
            this.pool_text = new System.Windows.Forms.TextBox();
            this.address_text = new System.Windows.Forms.TextBox();
            this.panel_1 = new System.Windows.Forms.Panel();
            this.cpu_panel = new salty.RoundedPanel();
            this.gpu_cmd_output = new System.Windows.Forms.TextBox();
            this.seperation_line_5 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new salty.RoundedPanel();
            this.mini_gpu = new System.Windows.Forms.PictureBox();
            this.gpu_name_text = new System.Windows.Forms.TextBox();
            this.gpu_enabled_text = new System.Windows.Forms.Label();
            this.cpu_cmd_output = new System.Windows.Forms.TextBox();
            this.seperation_line_4 = new System.Windows.Forms.Panel();
            this.mini_cpu_holder = new salty.RoundedPanel();
            this.mini_cpu = new System.Windows.Forms.PictureBox();
            this.cpu_name_text = new System.Windows.Forms.TextBox();
            this.cpu_enabled_text = new System.Windows.Forms.Label();
            this.roundedPanel3 = new salty.RoundedPanel();
            this.address_label = new System.Windows.Forms.Label();
            this.seperation_line_3 = new System.Windows.Forms.Panel();
            this.set_box = new System.Windows.Forms.TextBox();
            this.enabled_text = new System.Windows.Forms.Label();
            this.enabled_count = new System.Windows.Forms.Label();
            this.extra_gpu_params_text = new System.Windows.Forms.TextBox();
            this.extra_cpu_params_text = new System.Windows.Forms.TextBox();
            this.threads_text = new System.Windows.Forms.TextBox();
            this.mining_button = new System.Windows.Forms.PictureBox();
            this.panel_2 = new System.Windows.Forms.Panel();
            this.roundedPanel2 = new salty.RoundedPanel();
            this.performance_label = new System.Windows.Forms.Label();
            this.seperation_line_2 = new System.Windows.Forms.Panel();
            this.seperation_line_1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.arch_count = new System.Windows.Forms.Label();
            this.cpu_count = new System.Windows.Forms.Label();
            this.arch_text = new System.Windows.Forms.Label();
            this.gpu_text = new System.Windows.Forms.Label();
            this.usage_text = new System.Windows.Forms.Label();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.gpu_count = new System.Windows.Forms.Label();
            this.quit_button = new System.Windows.Forms.PictureBox();
            this.min_button = new System.Windows.Forms.PictureBox();
            this.dash_button = new System.Windows.Forms.PictureBox();
            this.config_button = new System.Windows.Forms.PictureBox();
            this.sm_banner = new System.Windows.Forms.PictureBox();
            this.panel_1.SuspendLayout();
            this.cpu_panel.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_gpu)).BeginInit();
            this.mini_cpu_holder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mini_cpu)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).BeginInit();
            this.panel_2.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // pool_text
            // 
            this.pool_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pool_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pool_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pool_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pool_text.Location = new System.Drawing.Point(175, 90);
            this.pool_text.Name = "pool_text";
            this.pool_text.PlaceholderText = "Insert pool network";
            this.pool_text.Size = new System.Drawing.Size(300, 17);
            this.pool_text.TabIndex = 2;
            this.pool_text.TextChanged += new System.EventHandler(this.pool_text_TextChanged);
            // 
            // address_text
            // 
            this.address_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.address_text.Location = new System.Drawing.Point(175, 53);
            this.address_text.Name = "address_text";
            this.address_text.PlaceholderText = "Insert custom address";
            this.address_text.Size = new System.Drawing.Size(300, 17);
            this.address_text.TabIndex = 0;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // panel_1
            // 
            this.panel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_1.Controls.Add(this.cpu_panel);
            this.panel_1.Controls.Add(this.roundedPanel3);
            this.panel_1.Location = new System.Drawing.Point(-4, 47);
            this.panel_1.Name = "panel_1";
            this.panel_1.Size = new System.Drawing.Size(860, 454);
            this.panel_1.TabIndex = 8;
            // 
            // cpu_panel
            // 
            this.cpu_panel.BackColor = System.Drawing.Color.Transparent;
            this.cpu_panel.Controls.Add(this.gpu_cmd_output);
            this.cpu_panel.Controls.Add(this.seperation_line_5);
            this.cpu_panel.Controls.Add(this.roundedPanel1);
            this.cpu_panel.Controls.Add(this.gpu_name_text);
            this.cpu_panel.Controls.Add(this.gpu_enabled_text);
            this.cpu_panel.Controls.Add(this.cpu_cmd_output);
            this.cpu_panel.Controls.Add(this.seperation_line_4);
            this.cpu_panel.Controls.Add(this.mini_cpu_holder);
            this.cpu_panel.Controls.Add(this.cpu_name_text);
            this.cpu_panel.Controls.Add(this.cpu_enabled_text);
            this.cpu_panel.Location = new System.Drawing.Point(22, 191);
            this.cpu_panel.Name = "cpu_panel";
            this.cpu_panel.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_panel.Size = new System.Drawing.Size(820, 274);
            this.cpu_panel.TabIndex = 22;
            // 
            // gpu_cmd_output
            // 
            this.gpu_cmd_output.AcceptsReturn = true;
            this.gpu_cmd_output.AcceptsTab = true;
            this.gpu_cmd_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_cmd_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpu_cmd_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpu_cmd_output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_cmd_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gpu_cmd_output.Location = new System.Drawing.Point(29, 174);
            this.gpu_cmd_output.Multiline = true;
            this.gpu_cmd_output.Name = "gpu_cmd_output";
            this.gpu_cmd_output.ReadOnly = true;
            this.gpu_cmd_output.Size = new System.Drawing.Size(746, 36);
            this.gpu_cmd_output.TabIndex = 29;
            // 
            // seperation_line_5
            // 
            this.seperation_line_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_5.Location = new System.Drawing.Point(13, 166);
            this.seperation_line_5.Name = "seperation_line_5";
            this.seperation_line_5.Size = new System.Drawing.Size(779, 2);
            this.seperation_line_5.TabIndex = 25;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.mini_gpu);
            this.roundedPanel1.Location = new System.Drawing.Point(720, 118);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.roundedPanel1.Size = new System.Drawing.Size(67, 88);
            this.roundedPanel1.TabIndex = 28;
            // 
            // mini_gpu
            // 
            this.mini_gpu.Image = global::salty.Properties.Resources.mini_start;
            this.mini_gpu.Location = new System.Drawing.Point(13, 12);
            this.mini_gpu.Name = "mini_gpu";
            this.mini_gpu.Size = new System.Drawing.Size(25, 25);
            this.mini_gpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini_gpu.TabIndex = 25;
            this.mini_gpu.TabStop = false;
            this.mini_gpu.Click += new System.EventHandler(this.mini_gpu_Click);
            // 
            // gpu_name_text
            // 
            this.gpu_name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpu_name_text.Enabled = false;
            this.gpu_name_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_name_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gpu_name_text.Location = new System.Drawing.Point(31, 143);
            this.gpu_name_text.Name = "gpu_name_text";
            this.gpu_name_text.PlaceholderText = "GPU Information";
            this.gpu_name_text.ReadOnly = true;
            this.gpu_name_text.Size = new System.Drawing.Size(300, 17);
            this.gpu_name_text.TabIndex = 27;
            // 
            // gpu_enabled_text
            // 
            this.gpu_enabled_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_enabled_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_enabled_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gpu_enabled_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gpu_enabled_text.Location = new System.Drawing.Point(29, 121);
            this.gpu_enabled_text.Name = "gpu_enabled_text";
            this.gpu_enabled_text.Size = new System.Drawing.Size(207, 15);
            this.gpu_enabled_text.TabIndex = 26;
            this.gpu_enabled_text.Text = "GPU: Disabled";
            this.gpu_enabled_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gpu_enabled_text.UseCompatibleTextRendering = true;
            // 
            // cpu_cmd_output
            // 
            this.cpu_cmd_output.AcceptsReturn = true;
            this.cpu_cmd_output.AcceptsTab = true;
            this.cpu_cmd_output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_cmd_output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpu_cmd_output.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpu_cmd_output.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_cmd_output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_cmd_output.Location = new System.Drawing.Point(24, 74);
            this.cpu_cmd_output.Multiline = true;
            this.cpu_cmd_output.Name = "cpu_cmd_output";
            this.cpu_cmd_output.ReadOnly = true;
            this.cpu_cmd_output.Size = new System.Drawing.Size(746, 36);
            this.cpu_cmd_output.TabIndex = 11;
            // 
            // seperation_line_4
            // 
            this.seperation_line_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_4.Location = new System.Drawing.Point(11, 68);
            this.seperation_line_4.Name = "seperation_line_4";
            this.seperation_line_4.Size = new System.Drawing.Size(779, 2);
            this.seperation_line_4.TabIndex = 21;
            // 
            // mini_cpu_holder
            // 
            this.mini_cpu_holder.Controls.Add(this.mini_cpu);
            this.mini_cpu_holder.Location = new System.Drawing.Point(718, 20);
            this.mini_cpu_holder.Name = "mini_cpu_holder";
            this.mini_cpu_holder.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mini_cpu_holder.Size = new System.Drawing.Size(69, 88);
            this.mini_cpu_holder.TabIndex = 24;
            // 
            // mini_cpu
            // 
            this.mini_cpu.Image = global::salty.Properties.Resources.mini_start;
            this.mini_cpu.Location = new System.Drawing.Point(13, 12);
            this.mini_cpu.Name = "mini_cpu";
            this.mini_cpu.Size = new System.Drawing.Size(25, 25);
            this.mini_cpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mini_cpu.TabIndex = 25;
            this.mini_cpu.TabStop = false;
            this.mini_cpu.Click += new System.EventHandler(this.mini_cpu_Click);
            // 
            // cpu_name_text
            // 
            this.cpu_name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpu_name_text.Enabled = false;
            this.cpu_name_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_name_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cpu_name_text.Location = new System.Drawing.Point(29, 45);
            this.cpu_name_text.Name = "cpu_name_text";
            this.cpu_name_text.PlaceholderText = "CPU Information";
            this.cpu_name_text.ReadOnly = true;
            this.cpu_name_text.Size = new System.Drawing.Size(300, 17);
            this.cpu_name_text.TabIndex = 22;
            // 
            // cpu_enabled_text
            // 
            this.cpu_enabled_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_enabled_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_enabled_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_enabled_text.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cpu_enabled_text.Location = new System.Drawing.Point(27, 23);
            this.cpu_enabled_text.Name = "cpu_enabled_text";
            this.cpu_enabled_text.Size = new System.Drawing.Size(207, 15);
            this.cpu_enabled_text.TabIndex = 21;
            this.cpu_enabled_text.Text = "CPU: Disabled";
            this.cpu_enabled_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cpu_enabled_text.UseCompatibleTextRendering = true;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel3.Controls.Add(this.address_label);
            this.roundedPanel3.Controls.Add(this.seperation_line_3);
            this.roundedPanel3.Controls.Add(this.set_box);
            this.roundedPanel3.Controls.Add(this.enabled_text);
            this.roundedPanel3.Controls.Add(this.enabled_count);
            this.roundedPanel3.Controls.Add(this.extra_gpu_params_text);
            this.roundedPanel3.Controls.Add(this.extra_cpu_params_text);
            this.roundedPanel3.Controls.Add(this.pool_text);
            this.roundedPanel3.Controls.Add(this.threads_text);
            this.roundedPanel3.Controls.Add(this.address_text);
            this.roundedPanel3.Location = new System.Drawing.Point(22, 10);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel3.Size = new System.Drawing.Size(820, 221);
            this.roundedPanel3.TabIndex = 19;
            // 
            // address_label
            // 
            this.address_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.address_label.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.address_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.address_label.Location = new System.Drawing.Point(175, 22);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(157, 15);
            this.address_label.TabIndex = 21;
            this.address_label.Text = "Miner Instructions:";
            this.address_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.address_label.UseCompatibleTextRendering = true;
            // 
            // seperation_line_3
            // 
            this.seperation_line_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_3.Location = new System.Drawing.Point(147, 12);
            this.seperation_line_3.Name = "seperation_line_3";
            this.seperation_line_3.Size = new System.Drawing.Size(2, 160);
            this.seperation_line_3.TabIndex = 20;
            // 
            // set_box
            // 
            this.set_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.set_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.set_box.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.set_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.set_box.Location = new System.Drawing.Point(484, 126);
            this.set_box.Name = "set_box";
            this.set_box.PlaceholderText = "Insert instruction set";
            this.set_box.Size = new System.Drawing.Size(225, 17);
            this.set_box.TabIndex = 20;
            this.set_box.TextChanged += new System.EventHandler(this.set_box_TextChanged);
            // 
            // enabled_text
            // 
            this.enabled_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.enabled_text.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enabled_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.enabled_text.Location = new System.Drawing.Point(24, 107);
            this.enabled_text.Name = "enabled_text";
            this.enabled_text.Size = new System.Drawing.Size(104, 27);
            this.enabled_text.TabIndex = 17;
            this.enabled_text.Text = "ENABLED";
            this.enabled_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enabled_text.UseCompatibleTextRendering = true;
            // 
            // enabled_count
            // 
            this.enabled_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.enabled_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enabled_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.enabled_count.Location = new System.Drawing.Point(13, 51);
            this.enabled_count.Name = "enabled_count";
            this.enabled_count.Size = new System.Drawing.Size(128, 56);
            this.enabled_count.TabIndex = 17;
            this.enabled_count.Text = "2/2";
            this.enabled_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enabled_count.UseCompatibleTextRendering = true;
            // 
            // extra_gpu_params_text
            // 
            this.extra_gpu_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_gpu_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_gpu_params_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_gpu_params_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.extra_gpu_params_text.Location = new System.Drawing.Point(484, 90);
            this.extra_gpu_params_text.Name = "extra_gpu_params_text";
            this.extra_gpu_params_text.PlaceholderText = "Insert GPU parameters";
            this.extra_gpu_params_text.Size = new System.Drawing.Size(300, 17);
            this.extra_gpu_params_text.TabIndex = 18;
            this.extra_gpu_params_text.TextChanged += new System.EventHandler(this.extra_gpu_params_TextChanged);
            // 
            // extra_cpu_params_text
            // 
            this.extra_cpu_params_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.extra_cpu_params_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.extra_cpu_params_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.extra_cpu_params_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.extra_cpu_params_text.Location = new System.Drawing.Point(484, 51);
            this.extra_cpu_params_text.Name = "extra_cpu_params_text";
            this.extra_cpu_params_text.PlaceholderText = "Insert CPU parameters";
            this.extra_cpu_params_text.Size = new System.Drawing.Size(300, 17);
            this.extra_cpu_params_text.TabIndex = 9;
            this.extra_gpu_params_text.TextChanged += new System.EventHandler(this.extra_cpu_params_TextChanged);
            // 
            // threads_text
            // 
            this.threads_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.threads_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.threads_text.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threads_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.threads_text.Location = new System.Drawing.Point(175, 126);
            this.threads_text.Name = "threads_text";
            this.threads_text.PlaceholderText = "Insert usable cores";
            this.threads_text.Size = new System.Drawing.Size(300, 17);
            this.threads_text.TabIndex = 7;
            this.threads_text.TextChanged += new System.EventHandler(this.threads_text_TextChanged);
            // 
            // mining_button
            // 
            this.mining_button.Image = global::salty.Properties.Resources.mine_start;
            this.mining_button.Location = new System.Drawing.Point(331, 5);
            this.mining_button.Name = "mining_button";
            this.mining_button.Size = new System.Drawing.Size(200, 200);
            this.mining_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mining_button.TabIndex = 0;
            this.mining_button.TabStop = false;
            this.mining_button.Click += new System.EventHandler(this.mining_button_Click);
            // 
            // panel_2
            // 
            this.panel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel_2.Controls.Add(this.roundedPanel2);
            this.panel_2.Controls.Add(this.mining_button);
            this.panel_2.Location = new System.Drawing.Point(-4, 47);
            this.panel_2.Name = "panel_2";
            this.panel_2.Size = new System.Drawing.Size(860, 457);
            this.panel_2.TabIndex = 7;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.roundedPanel2.Controls.Add(this.performance_label);
            this.roundedPanel2.Controls.Add(this.seperation_line_2);
            this.roundedPanel2.Controls.Add(this.seperation_line_1);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.arch_count);
            this.roundedPanel2.Controls.Add(this.cpu_count);
            this.roundedPanel2.Controls.Add(this.arch_text);
            this.roundedPanel2.Controls.Add(this.gpu_text);
            this.roundedPanel2.Controls.Add(this.usage_text);
            this.roundedPanel2.Controls.Add(this.cpu_usage);
            this.roundedPanel2.Controls.Add(this.gpu_count);
            this.roundedPanel2.Location = new System.Drawing.Point(101, 211);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.panel_color = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.roundedPanel2.Size = new System.Drawing.Size(658, 212);
            this.roundedPanel2.TabIndex = 11;
            // 
            // performance_label
            // 
            this.performance_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.performance_label.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.performance_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.performance_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.performance_label.Location = new System.Drawing.Point(322, 30);
            this.performance_label.Name = "performance_label";
            this.performance_label.Size = new System.Drawing.Size(169, 26);
            this.performance_label.TabIndex = 22;
            this.performance_label.Text = "Performance:";
            this.performance_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.performance_label.UseCompatibleTextRendering = true;
            // 
            // seperation_line_2
            // 
            this.seperation_line_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_2.Location = new System.Drawing.Point(301, 12);
            this.seperation_line_2.Name = "seperation_line_2";
            this.seperation_line_2.Size = new System.Drawing.Size(2, 150);
            this.seperation_line_2.TabIndex = 16;
            // 
            // seperation_line_1
            // 
            this.seperation_line_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.seperation_line_1.Location = new System.Drawing.Point(150, 12);
            this.seperation_line_1.Name = "seperation_line_1";
            this.seperation_line_1.Size = new System.Drawing.Size(2, 150);
            this.seperation_line_1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(188, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "CPU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // arch_count
            // 
            this.arch_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.arch_count.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arch_count.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.arch_count.Location = new System.Drawing.Point(477, 121);
            this.arch_count.Name = "arch_count";
            this.arch_count.Size = new System.Drawing.Size(107, 32);
            this.arch_count.TabIndex = 7;
            this.arch_count.Text = "X64";
            this.arch_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.arch_count.UseCompatibleTextRendering = true;
            // 
            // cpu_count
            // 
            this.cpu_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cpu_count.Location = new System.Drawing.Point(187, 47);
            this.cpu_count.Name = "cpu_count";
            this.cpu_count.Size = new System.Drawing.Size(81, 56);
            this.cpu_count.TabIndex = 13;
            this.cpu_count.Text = "1";
            this.cpu_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpu_count.UseCompatibleTextRendering = true;
            // 
            // arch_text
            // 
            this.arch_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.arch_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.arch_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.arch_text.Location = new System.Drawing.Point(322, 121);
            this.arch_text.Name = "arch_text";
            this.arch_text.Size = new System.Drawing.Size(147, 27);
            this.arch_text.TabIndex = 8;
            this.arch_text.Text = "ARCHITECTURE:";
            this.arch_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arch_text.UseCompatibleTextRendering = true;
            // 
            // gpu_text
            // 
            this.gpu_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_text.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gpu_text.Location = new System.Drawing.Point(35, 98);
            this.gpu_text.Name = "gpu_text";
            this.gpu_text.Size = new System.Drawing.Size(80, 27);
            this.gpu_text.TabIndex = 12;
            this.gpu_text.Text = "GPU";
            this.gpu_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gpu_text.UseCompatibleTextRendering = true;
            // 
            // usage_text
            // 
            this.usage_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.usage_text.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usage_text.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usage_text.Location = new System.Drawing.Point(322, 77);
            this.usage_text.Name = "usage_text";
            this.usage_text.Size = new System.Drawing.Size(135, 27);
            this.usage_text.TabIndex = 10;
            this.usage_text.Text = "CPU USAGE:";
            this.usage_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usage_text.UseCompatibleTextRendering = true;
            // 
            // cpu_usage
            // 
            this.cpu_usage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.cpu_usage.Font = new System.Drawing.Font("Roboto Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_usage.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cpu_usage.Location = new System.Drawing.Point(515, 75);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(69, 28);
            this.cpu_usage.TabIndex = 9;
            this.cpu_usage.Text = "0%";
            this.cpu_usage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cpu_usage.UseCompatibleTextRendering = true;
            // 
            // gpu_count
            // 
            this.gpu_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.gpu_count.Font = new System.Drawing.Font("Roboto Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpu_count.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.gpu_count.Location = new System.Drawing.Point(35, 47);
            this.gpu_count.Name = "gpu_count";
            this.gpu_count.Size = new System.Drawing.Size(80, 56);
            this.gpu_count.TabIndex = 12;
            this.gpu_count.Text = "1";
            this.gpu_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gpu_count.UseCompatibleTextRendering = true;
            // 
            // quit_button
            // 
            this.quit_button.Image = global::salty.Properties.Resources.exit_icon_dark;
            this.quit_button.Location = new System.Drawing.Point(808, 1);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(40, 40);
            this.quit_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quit_button.TabIndex = 12;
            this.quit_button.TabStop = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // min_button
            // 
            this.min_button.Image = global::salty.Properties.Resources.minimize_icon_dark;
            this.min_button.Location = new System.Drawing.Point(762, 1);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(40, 40);
            this.min_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min_button.TabIndex = 13;
            this.min_button.TabStop = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // dash_button
            // 
            this.dash_button.Image = global::salty.Properties.Resources.home_button_dark;
            this.dash_button.Location = new System.Drawing.Point(670, 1);
            this.dash_button.Name = "dash_button";
            this.dash_button.Size = new System.Drawing.Size(40, 40);
            this.dash_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dash_button.TabIndex = 14;
            this.dash_button.TabStop = false;
            this.dash_button.Click += new System.EventHandler(this.dash_button_Click);
            // 
            // config_button
            // 
            this.config_button.Image = global::salty.Properties.Resources.config_button_dark;
            this.config_button.Location = new System.Drawing.Point(716, 1);
            this.config_button.Name = "config_button";
            this.config_button.Size = new System.Drawing.Size(40, 40);
            this.config_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.config_button.TabIndex = 15;
            this.config_button.TabStop = false;
            this.config_button.Click += new System.EventHandler(this.config_button_Click);
            // 
            // sm_banner
            // 
            this.sm_banner.Image = global::salty.Properties.Resources.sm_banner_dark;
            this.sm_banner.Location = new System.Drawing.Point(-4, 1);
            this.sm_banner.Name = "sm_banner";
            this.sm_banner.Size = new System.Drawing.Size(150, 50);
            this.sm_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sm_banner.TabIndex = 16;
            this.sm_banner.TabStop = false;
            // 
            // saltyminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.sm_banner);
            this.Controls.Add(this.config_button);
            this.Controls.Add(this.dash_button);
            this.Controls.Add(this.min_button);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.panel_1);
            this.Controls.Add(this.panel_2);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 500);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "saltyminer";
            this.Text = "SaltyMiner";
            this.panel_1.ResumeLayout(false);
            this.cpu_panel.ResumeLayout(false);
            this.cpu_panel.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mini_gpu)).EndInit();
            this.mini_cpu_holder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mini_cpu)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mining_button)).EndInit();
            this.panel_2.ResumeLayout(false);
            this.roundedPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sm_banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox pool_text;
        public System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Panel panel_1;
        private System.Windows.Forms.PictureBox mining_button;
        private System.Windows.Forms.Panel panel_2;
        public System.Windows.Forms.TextBox threads_text;
        public System.Windows.Forms.TextBox extra_cpu_params_text;
        private System.Windows.Forms.PictureBox quit_button;
        private System.Windows.Forms.PictureBox min_button;
        private System.Windows.Forms.PictureBox dash_button;
        private System.Windows.Forms.PictureBox config_button;
        private System.Windows.Forms.PictureBox sm_banner;
        private System.Windows.Forms.TextBox cpu_cmd_output;
        private System.Windows.Forms.Label arch_count;
        private System.Windows.Forms.Label arch_text;
        public System.Windows.Forms.Label cpu_usage;
        private System.Windows.Forms.Label usage_text;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label gpu_count;
        private System.Windows.Forms.Label gpu_text;
        private System.Windows.Forms.Label cpu_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel seperation_line_1;
        private System.Windows.Forms.Panel seperation_line_2;
        public System.Windows.Forms.TextBox extra_gpu_params_text;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label enabled_text;
        private System.Windows.Forms.Label enabled_count;
        private System.Windows.Forms.Panel seperation_line_3;
        public System.Windows.Forms.TextBox set_box;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label performance_label;
        private RoundedPanel cpu_panel;
        private System.Windows.Forms.Label cpu_enabled_text;
        public System.Windows.Forms.TextBox cpu_name_text;
        private System.Windows.Forms.Panel seperation_line_4;
        private RoundedPanel mini_cpu_holder;
        private System.Windows.Forms.PictureBox mini_cpu;
        private System.Windows.Forms.Panel seperation_line_5;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox mini_gpu;
        public System.Windows.Forms.TextBox gpu_name_text;
        private System.Windows.Forms.Label gpu_enabled_text;
        private System.Windows.Forms.TextBox gpu_cmd_output;
    }
}

