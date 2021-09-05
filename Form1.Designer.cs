
namespace alt_calc
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.totalimpulse = new System.Windows.Forms.TextBox();
            this.averagethrust = new System.Windows.Forms.TextBox();
            this.deadmass = new System.Windows.Forms.TextBox();
            this.propmass = new System.Windows.Forms.TextBox();
            this.drag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.diameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.peakaltitude = new System.Windows.Forms.TextBox();
            this.burnout = new System.Windows.Forms.TextBox();
            this.maxvelocity = new System.Windows.Forms.TextBox();
            this.apogeetime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.airresistance = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.thrusttime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.averageacelleration = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.maxacelleration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalimpulse
            // 
            this.totalimpulse.Location = new System.Drawing.Point(7, 58);
            this.totalimpulse.Name = "totalimpulse";
            this.totalimpulse.Size = new System.Drawing.Size(100, 23);
            this.totalimpulse.TabIndex = 1;
            // 
            // averagethrust
            // 
            this.averagethrust.Location = new System.Drawing.Point(7, 102);
            this.averagethrust.Name = "averagethrust";
            this.averagethrust.Size = new System.Drawing.Size(100, 23);
            this.averagethrust.TabIndex = 2;
            // 
            // deadmass
            // 
            this.deadmass.Location = new System.Drawing.Point(7, 191);
            this.deadmass.Name = "deadmass";
            this.deadmass.Size = new System.Drawing.Size(100, 23);
            this.deadmass.TabIndex = 3;
            // 
            // propmass
            // 
            this.propmass.Location = new System.Drawing.Point(7, 235);
            this.propmass.Name = "propmass";
            this.propmass.Size = new System.Drawing.Size(100, 23);
            this.propmass.TabIndex = 4;
            // 
            // drag
            // 
            this.drag.Location = new System.Drawing.Point(7, 281);
            this.drag.Name = "drag";
            this.drag.Size = new System.Drawing.Size(100, 23);
            this.drag.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Drag Coefficient (Cd)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(7, 325);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(100, 23);
            this.diameter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Impulse (Ns)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Average Thrust (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dead Mass (kg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Propellant Mass (kg)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max Body Diameter (cm)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 23);
            this.button4.TabIndex = 15;
            this.button4.TabStop = false;
            this.button4.Text = "?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // peakaltitude
            // 
            this.peakaltitude.Location = new System.Drawing.Point(143, 58);
            this.peakaltitude.Name = "peakaltitude";
            this.peakaltitude.ReadOnly = true;
            this.peakaltitude.Size = new System.Drawing.Size(100, 23);
            this.peakaltitude.TabIndex = 16;
            // 
            // burnout
            // 
            this.burnout.Location = new System.Drawing.Point(143, 103);
            this.burnout.Name = "burnout";
            this.burnout.ReadOnly = true;
            this.burnout.Size = new System.Drawing.Size(100, 23);
            this.burnout.TabIndex = 17;
            // 
            // maxvelocity
            // 
            this.maxvelocity.Location = new System.Drawing.Point(143, 147);
            this.maxvelocity.Name = "maxvelocity";
            this.maxvelocity.ReadOnly = true;
            this.maxvelocity.Size = new System.Drawing.Size(100, 23);
            this.maxvelocity.TabIndex = 18;
            // 
            // apogeetime
            // 
            this.apogeetime.Location = new System.Drawing.Point(143, 191);
            this.apogeetime.Name = "apogeetime";
            this.apogeetime.ReadOnly = true;
            this.apogeetime.Size = new System.Drawing.Size(100, 23);
            this.apogeetime.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Peak Altitude (m)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Burnout Altitude (m)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Max Velocity (m/s)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Time to apogee (s)";
            // 
            // airresistance
            // 
            this.airresistance.AutoSize = true;
            this.airresistance.Checked = true;
            this.airresistance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.airresistance.Location = new System.Drawing.Point(138, 327);
            this.airresistance.Name = "airresistance";
            this.airresistance.Size = new System.Drawing.Size(99, 19);
            this.airresistance.TabIndex = 24;
            this.airresistance.TabStop = false;
            this.airresistance.Text = "Air Resistance";
            this.airresistance.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(184, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 15);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Denneth.nl";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(144, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(23, 23);
            this.button5.TabIndex = 26;
            this.button5.TabStop = false;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Thrust Time (s)";
            // 
            // thrusttime
            // 
            this.thrusttime.Location = new System.Drawing.Point(7, 149);
            this.thrusttime.Name = "thrusttime";
            this.thrusttime.ReadOnly = true;
            this.thrusttime.Size = new System.Drawing.Size(100, 23);
            this.thrusttime.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(259, 28);
            this.label12.TabIndex = 29;
            this.label12.Text = "All results are estimations";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Average Accelleration";
            // 
            // averageacelleration
            // 
            this.averageacelleration.Location = new System.Drawing.Point(143, 238);
            this.averageacelleration.Name = "averageacelleration";
            this.averageacelleration.ReadOnly = true;
            this.averageacelleration.Size = new System.Drawing.Size(100, 23);
            this.averageacelleration.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(143, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Max acceleration?";
            // 
            // maxacelleration
            // 
            this.maxacelleration.Location = new System.Drawing.Point(143, 280);
            this.maxacelleration.Name = "maxacelleration";
            this.maxacelleration.ReadOnly = true;
            this.maxacelleration.Size = new System.Drawing.Size(100, 23);
            this.maxacelleration.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 384);
            this.Controls.Add(this.maxacelleration);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.averageacelleration);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.thrusttime);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.airresistance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.apogeetime);
            this.Controls.Add(this.maxvelocity);
            this.Controls.Add(this.burnout);
            this.Controls.Add(this.peakaltitude);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drag);
            this.Controls.Add(this.propmass);
            this.Controls.Add(this.deadmass);
            this.Controls.Add(this.averagethrust);
            this.Controls.Add(this.totalimpulse);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Altitude Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox totalimpulse;
        private System.Windows.Forms.TextBox averagethrust;
        private System.Windows.Forms.TextBox deadmass;
        private System.Windows.Forms.TextBox propmass;
        private System.Windows.Forms.TextBox drag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox peakaltitude;
        private System.Windows.Forms.TextBox burnout;
        private System.Windows.Forms.TextBox maxvelocity;
        private System.Windows.Forms.TextBox apogeetime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox airresistance;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox thrusttime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox averageacelleration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox maxacelleration;
    }
}

