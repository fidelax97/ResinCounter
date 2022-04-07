
namespace Resin_Counter
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
            this.label1 = new System.Windows.Forms.Label();
            this.resinCounter = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.completedTime = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new Resin_Counter.RoundButton();
            this.btnSetAlarm = new Resin_Counter.RoundButton();
            this.add40 = new Resin_Counter.RoundButton();
            this.sub40 = new Resin_Counter.RoundButton();
            this.sub90 = new Resin_Counter.RoundButton();
            this.sub160 = new Resin_Counter.RoundButton();
            this.add60 = new Resin_Counter.RoundButton();
            this.add120 = new Resin_Counter.RoundButton();
            this.add160 = new Resin_Counter.RoundButton();
            this.sub20 = new Resin_Counter.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.resinCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resin :";
            // 
            // resinCounter
            // 
            this.resinCounter.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resinCounter.Location = new System.Drawing.Point(111, 32);
            this.resinCounter.Margin = new System.Windows.Forms.Padding(0);
            this.resinCounter.Maximum = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.resinCounter.Name = "resinCounter";
            this.resinCounter.Size = new System.Drawing.Size(140, 33);
            this.resinCounter.TabIndex = 1;
            this.resinCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(434, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Current Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Completed Time :";
            // 
            // currentTime
            // 
            this.currentTime.BackColor = System.Drawing.Color.Transparent;
            this.currentTime.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(409, 114);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(223, 25);
            this.currentTime.TabIndex = 7;
            this.currentTime.Text = "    ";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedTime
            // 
            this.completedTime.BackColor = System.Drawing.Color.Transparent;
            this.completedTime.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedTime.Location = new System.Drawing.Point(407, 232);
            this.completedTime.Name = "completedTime";
            this.completedTime.Size = new System.Drawing.Size(209, 25);
            this.completedTime.TabIndex = 8;
            this.completedTime.Text = "     \r\n";
            this.completedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Resin Counter";
            this.notifyIcon1.Visible = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("HYWenHei-85W", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "/ 160";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnReset.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 2;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("HYWenHei-85W", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(39, 235);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 40);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.Black;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSetAlarm.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnSetAlarm.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSetAlarm.BorderRadius = 20;
            this.btnSetAlarm.BorderSize = 2;
            this.btnSetAlarm.FlatAppearance.BorderSize = 0;
            this.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAlarm.Font = new System.Drawing.Font("HYWenHei-85W", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnSetAlarm.Location = new System.Drawing.Point(168, 236);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(148, 40);
            this.btnSetAlarm.TabIndex = 19;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.TextColor = System.Drawing.Color.Black;
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // add40
            // 
            this.add40.BackColor = System.Drawing.Color.Lime;
            this.add40.BackgroundColor = System.Drawing.Color.Lime;
            this.add40.BorderColor = System.Drawing.Color.Black;
            this.add40.BorderRadius = 20;
            this.add40.BorderSize = 2;
            this.add40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add40.FlatAppearance.BorderSize = 0;
            this.add40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add40.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add40.ForeColor = System.Drawing.Color.Black;
            this.add40.Location = new System.Drawing.Point(38, 99);
            this.add40.Name = "add40";
            this.add40.Size = new System.Drawing.Size(64, 40);
            this.add40.TabIndex = 6;
            this.add40.Text = "+40";
            this.add40.TextColor = System.Drawing.Color.Black;
            this.add40.UseVisualStyleBackColor = false;
            this.add40.Click += new System.EventHandler(this.add40_Click);
            // 
            // sub40
            // 
            this.sub40.BackColor = System.Drawing.Color.Red;
            this.sub40.BackgroundColor = System.Drawing.Color.Red;
            this.sub40.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub40.BorderRadius = 20;
            this.sub40.BorderSize = 2;
            this.sub40.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub40.FlatAppearance.BorderSize = 0;
            this.sub40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub40.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub40.ForeColor = System.Drawing.Color.Black;
            this.sub40.Location = new System.Drawing.Point(111, 157);
            this.sub40.Name = "sub40";
            this.sub40.Size = new System.Drawing.Size(64, 40);
            this.sub40.TabIndex = 18;
            this.sub40.Text = "-40";
            this.sub40.TextColor = System.Drawing.Color.Black;
            this.sub40.UseVisualStyleBackColor = false;
            this.sub40.Click += new System.EventHandler(this.sub40_Click);
            // 
            // sub90
            // 
            this.sub90.BackColor = System.Drawing.Color.Red;
            this.sub90.BackgroundColor = System.Drawing.Color.Red;
            this.sub90.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub90.BorderRadius = 20;
            this.sub90.BorderSize = 2;
            this.sub90.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub90.FlatAppearance.BorderSize = 0;
            this.sub90.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub90.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub90.ForeColor = System.Drawing.Color.Black;
            this.sub90.Location = new System.Drawing.Point(181, 157);
            this.sub90.Name = "sub90";
            this.sub90.Size = new System.Drawing.Size(64, 40);
            this.sub90.TabIndex = 17;
            this.sub90.Text = "-90";
            this.sub90.TextColor = System.Drawing.Color.Black;
            this.sub90.UseVisualStyleBackColor = false;
            this.sub90.Click += new System.EventHandler(this.sub90_Click);
            // 
            // sub160
            // 
            this.sub160.BackColor = System.Drawing.Color.Red;
            this.sub160.BackgroundColor = System.Drawing.Color.Red;
            this.sub160.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub160.BorderRadius = 20;
            this.sub160.BorderSize = 2;
            this.sub160.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub160.FlatAppearance.BorderSize = 0;
            this.sub160.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub160.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub160.ForeColor = System.Drawing.Color.Black;
            this.sub160.Location = new System.Drawing.Point(253, 157);
            this.sub160.Name = "sub160";
            this.sub160.Size = new System.Drawing.Size(64, 40);
            this.sub160.TabIndex = 16;
            this.sub160.Text = "-160";
            this.sub160.TextColor = System.Drawing.Color.Black;
            this.sub160.UseVisualStyleBackColor = false;
            this.sub160.Click += new System.EventHandler(this.sub160_Click);
            // 
            // add60
            // 
            this.add60.BackColor = System.Drawing.Color.Lime;
            this.add60.BackgroundColor = System.Drawing.Color.Lime;
            this.add60.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add60.BorderRadius = 20;
            this.add60.BorderSize = 2;
            this.add60.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add60.FlatAppearance.BorderSize = 0;
            this.add60.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add60.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add60.ForeColor = System.Drawing.Color.Black;
            this.add60.Location = new System.Drawing.Point(111, 99);
            this.add60.Name = "add60";
            this.add60.Size = new System.Drawing.Size(64, 40);
            this.add60.TabIndex = 15;
            this.add60.Text = "+60";
            this.add60.TextColor = System.Drawing.Color.Black;
            this.add60.UseVisualStyleBackColor = false;
            this.add60.Click += new System.EventHandler(this.add60_Click);
            // 
            // add120
            // 
            this.add120.BackColor = System.Drawing.Color.Lime;
            this.add120.BackgroundColor = System.Drawing.Color.Lime;
            this.add120.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add120.BorderRadius = 20;
            this.add120.BorderSize = 2;
            this.add120.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add120.FlatAppearance.BorderSize = 0;
            this.add120.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add120.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add120.ForeColor = System.Drawing.Color.Black;
            this.add120.Location = new System.Drawing.Point(181, 99);
            this.add120.Name = "add120";
            this.add120.Size = new System.Drawing.Size(64, 40);
            this.add120.TabIndex = 14;
            this.add120.Text = "+120";
            this.add120.TextColor = System.Drawing.Color.Black;
            this.add120.UseVisualStyleBackColor = false;
            this.add120.Click += new System.EventHandler(this.add120_Click);
            // 
            // add160
            // 
            this.add160.BackColor = System.Drawing.Color.Lime;
            this.add160.BackgroundColor = System.Drawing.Color.Lime;
            this.add160.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add160.BorderRadius = 20;
            this.add160.BorderSize = 2;
            this.add160.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add160.FlatAppearance.BorderSize = 0;
            this.add160.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add160.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add160.ForeColor = System.Drawing.Color.Black;
            this.add160.Location = new System.Drawing.Point(252, 99);
            this.add160.Name = "add160";
            this.add160.Size = new System.Drawing.Size(64, 40);
            this.add160.TabIndex = 13;
            this.add160.Text = "+160";
            this.add160.TextColor = System.Drawing.Color.Black;
            this.add160.UseVisualStyleBackColor = false;
            this.add160.Click += new System.EventHandler(this.add160_Click);
            // 
            // sub20
            // 
            this.sub20.BackColor = System.Drawing.Color.Red;
            this.sub20.BackgroundColor = System.Drawing.Color.Red;
            this.sub20.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub20.BorderRadius = 20;
            this.sub20.BorderSize = 2;
            this.sub20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub20.FlatAppearance.BorderSize = 0;
            this.sub20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub20.Font = new System.Drawing.Font("HYWenHei-85W", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub20.ForeColor = System.Drawing.Color.Black;
            this.sub20.Location = new System.Drawing.Point(39, 157);
            this.sub20.Name = "sub20";
            this.sub20.Size = new System.Drawing.Size(64, 40);
            this.sub20.TabIndex = 11;
            this.sub20.Text = "-20";
            this.sub20.TextColor = System.Drawing.Color.Black;
            this.sub20.UseVisualStyleBackColor = false;
            this.sub20.Click += new System.EventHandler(this.sub20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 330);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.add40);
            this.Controls.Add(this.sub40);
            this.Controls.Add(this.sub90);
            this.Controls.Add(this.sub160);
            this.Controls.Add(this.add60);
            this.Controls.Add(this.add120);
            this.Controls.Add(this.add160);
            this.Controls.Add(this.sub20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.completedTime);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resinCounter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("HYWenHei-85W", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Resin Counter";
            ((System.ComponentModel.ISupportInitialize)(this.resinCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown resinCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Label completedTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private RoundButton sub20;
        private RoundButton add160;
        private RoundButton add120;
        private RoundButton add60;
        private RoundButton sub160;
        private RoundButton sub90;
        private RoundButton sub40;
        private RoundButton add40;
        private RoundButton btnSetAlarm;
        private RoundButton btnReset;
    }
}

