namespace ows_core
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.holdlocation = new System.Windows.Forms.Timer(this.components);
            this.Coredeafult = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visable_true = new System.Windows.Forms.Timer(this.components);
            this.visable_false = new System.Windows.Forms.Timer(this.components);
            this.Delay_BeforeShoot = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.NumericUpDown();
            this.ultimatewait = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Shoot_delay = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rifle_shoot = new System.Windows.Forms.Timer(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Reaper = new System.Windows.Forms.Timer(this.components);
            this.Roadhog = new System.Windows.Forms.Timer(this.components);
            this.Pharah = new System.Windows.Forms.Timer(this.components);
            this.Solider_76 = new System.Windows.Forms.Timer(this.components);
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.Pharahh = new System.Windows.Forms.Timer(this.components);
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.delay_aftherShoot_OFF = new System.Windows.Forms.Timer(this.components);
            this.delay_aftherShoot_ON = new System.Windows.Forms.Timer(this.components);
            this.icon_1 = new System.Windows.Forms.Timer(this.components);
            this.icon_2 = new System.Windows.Forms.Timer(this.components);
            this.icon_3 = new System.Windows.Forms.Timer(this.components);
            this.Core_2 = new System.Windows.Forms.Timer(this.components);
            this.ambiance_CheckBox1 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot_delay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 10);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "OVERWATCH MATRIXBOT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MCREE",
            "WIDOWMAKER",
            "HANZO",
            "SOILDER76"});
            this.comboBox1.Location = new System.Drawing.Point(64, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "choose player";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(9, 283);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(120, 25);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "How to set up?";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // holdlocation
            // 
            this.holdlocation.Enabled = true;
            this.holdlocation.Interval = 1;
            this.holdlocation.Tick += new System.EventHandler(this.holdlocation_Tick);
            // 
            // Coredeafult
            // 
            this.Coredeafult.Enabled = true;
            this.Coredeafult.Interval = 1;
            this.Coredeafult.Tick += new System.EventHandler(this.Coredeafult_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 41);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ows_core.Properties.Resources.iconr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // visable_true
            // 
            this.visable_true.Enabled = true;
            this.visable_true.Interval = 200;
            this.visable_true.Tick += new System.EventHandler(this.visable_true_Tick);
            // 
            // visable_false
            // 
            this.visable_false.Interval = 200;
            this.visable_false.Tick += new System.EventHandler(this.visable_false_Tick);
            // 
            // Delay_BeforeShoot
            // 
            this.Delay_BeforeShoot.Interval = 200;
            this.Delay_BeforeShoot.Tick += new System.EventHandler(this.Delay_BeforeShoot_Tick);
            // 
            // Delay
            // 
            this.Delay.BackColor = System.Drawing.Color.White;
            this.Delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Delay.Location = new System.Drawing.Point(180, 118);
            this.Delay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(50, 16);
            this.Delay.TabIndex = 9;
            this.Delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delay per pixel search:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(11, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show aim location";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aim search size:";
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.White;
            this.size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.size.Location = new System.Drawing.Point(180, 140);
            this.size.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.size.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(50, 16);
            this.size.TabIndex = 12;
            this.size.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // ultimatewait
            // 
            this.ultimatewait.Enabled = true;
            this.ultimatewait.Interval = 5000;
            this.ultimatewait.Tick += new System.EventHandler(this.ultimatewait_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(11, 223);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(154, 24);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Ultimate detection";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "AimKey:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "L",
            "K",
            "J",
            "I",
            "U",
            "M",
            "N",
            "B",
            "G"});
            this.comboBox2.Location = new System.Drawing.Point(79, 202);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(50, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "L";
            // 
            // Shoot_delay
            // 
            this.Shoot_delay.BackColor = System.Drawing.Color.White;
            this.Shoot_delay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Shoot_delay.Location = new System.Drawing.Point(180, 166);
            this.Shoot_delay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Shoot_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Shoot_delay.Name = "Shoot_delay";
            this.Shoot_delay.Size = new System.Drawing.Size(50, 16);
            this.Shoot_delay.TabIndex = 17;
            this.Shoot_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(53, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Shooting Delay:";
            // 
            // rifle_shoot
            // 
            this.rifle_shoot.Interval = 120;
            this.rifle_shoot.Tick += new System.EventHandler(this.rifle_shoot_Tick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(90, 352);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 24);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Fast Reload";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "REAPER",
            "ROADHOG",
            "PHARAH",
            "SOILDER76"});
            this.comboBox3.Location = new System.Drawing.Point(84, 325);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.Text = "choose player";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "operator:";
            // 
            // Reaper
            // 
            this.Reaper.Interval = 280;
            this.Reaper.Tick += new System.EventHandler(this.Reaper_Tick);
            // 
            // Roadhog
            // 
            this.Roadhog.Interval = 1150;
            this.Roadhog.Tick += new System.EventHandler(this.Roadhog_Tick);
            // 
            // Pharah
            // 
            this.Pharah.Interval = 860;
            this.Pharah.Tick += new System.EventHandler(this.Pharah_Tick);
            // 
            // Solider_76
            // 
            this.Solider_76.Interval = 850;
            this.Solider_76.Tick += new System.EventHandler(this.Solider_76_Tick);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(6, 382);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(254, 24);
            this.checkBox4.TabIndex = 21;
            this.checkBox4.Text = "Pharah Holder \"Left Control\" key";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Pharahh
            // 
            this.Pharahh.Interval = 77;
            this.Pharahh.Tick += new System.EventHandler(this.Pharahh_Tick);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(6, 362);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 22;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // delay_aftherShoot_OFF
            // 
            this.delay_aftherShoot_OFF.Tick += new System.EventHandler(this.delay_aftherShoot_Tick);
            // 
            // delay_aftherShoot_ON
            // 
            this.delay_aftherShoot_ON.Interval = 1;
            this.delay_aftherShoot_ON.Tick += new System.EventHandler(this.delay_aftherShoot_ON_Tick);
            // 
            // icon_1
            // 
            this.icon_1.Enabled = true;
            this.icon_1.Interval = 1000;
            this.icon_1.Tick += new System.EventHandler(this.icon_1_Tick);
            // 
            // icon_2
            // 
            this.icon_2.Interval = 1000;
            this.icon_2.Tick += new System.EventHandler(this.icon_2_Tick);
            // 
            // icon_3
            // 
            this.icon_3.Interval = 1000;
            this.icon_3.Tick += new System.EventHandler(this.icon_3_Tick);
            // 
            // Core_2
            // 
            this.Core_2.Enabled = true;
            this.Core_2.Interval = 1;
            this.Core_2.Tick += new System.EventHandler(this.Core_2_Tick);
            // 
            // ambiance_CheckBox1
            // 
            this.ambiance_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_CheckBox1.Checked = true;
            this.ambiance_CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ambiance_CheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_CheckBox1.ForeColor = System.Drawing.Color.White;
            this.ambiance_CheckBox1.Location = new System.Drawing.Point(2, 56);
            this.ambiance_CheckBox1.Name = "ambiance_CheckBox1";
            this.ambiance_CheckBox1.Size = new System.Drawing.Size(182, 24);
            this.ambiance_CheckBox1.TabIndex = 23;
            this.ambiance_CheckBox1.Text = "Triggerbot";
            this.ambiance_CheckBox1.UseVisualStyleBackColor = false;
            this.ambiance_CheckBox1.CheckedChanged += new System.EventHandler(this.ambiance_CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(256, 415);
            this.Controls.Add(this.ambiance_CheckBox1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.Shoot_delay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shoot_delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Timer holdlocation;
        private System.Windows.Forms.Timer Coredeafult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer visable_true;
        private System.Windows.Forms.Timer visable_false;
        private System.Windows.Forms.Timer Delay_BeforeShoot;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown size;
        private System.Windows.Forms.Timer ultimatewait;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown Shoot_delay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer rifle_shoot;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Timer Reaper;
        internal System.Windows.Forms.Timer Roadhog;
        internal System.Windows.Forms.Timer Pharah;
        internal System.Windows.Forms.Timer Solider_76;
        private System.Windows.Forms.CheckBox checkBox4;
        internal System.Windows.Forms.Timer Pharahh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Timer delay_aftherShoot_OFF;
        private System.Windows.Forms.Timer delay_aftherShoot_ON;
        private System.Windows.Forms.Timer icon_1;
        private System.Windows.Forms.Timer icon_2;
        private System.Windows.Forms.Timer icon_3;
        private System.Windows.Forms.Timer Core_2;
        private System.Windows.Forms.CheckBox ambiance_CheckBox1;
    }
}

