namespace Alarm
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboHour = new System.Windows.Forms.ComboBox();
            this.comboMinute = new System.Windows.Forms.ComboBox();
            this.comboSecond = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.numBoxInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHour.Location = new System.Drawing.Point(267, 38);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(50, 41);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMinute.Location = new System.Drawing.Point(354, 38);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(50, 41);
            this.lblMinute.TabIndex = 0;
            this.lblMinute.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecond.Location = new System.Drawing.Point(441, 38);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(50, 41);
            this.lblSecond.TabIndex = 0;
            this.lblSecond.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(323, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(410, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Hour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Minute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Second";
            // 
            // comboHour
            // 
            this.comboHour.FormattingEnabled = true;
            this.comboHour.Location = new System.Drawing.Point(323, 132);
            this.comboHour.Name = "comboHour";
            this.comboHour.Size = new System.Drawing.Size(151, 28);
            this.comboHour.TabIndex = 1;
            // 
            // comboMinute
            // 
            this.comboMinute.FormattingEnabled = true;
            this.comboMinute.Location = new System.Drawing.Point(323, 171);
            this.comboMinute.Name = "comboMinute";
            this.comboMinute.Size = new System.Drawing.Size(151, 28);
            this.comboMinute.TabIndex = 2;
            // 
            // comboSecond
            // 
            this.comboSecond.FormattingEnabled = true;
            this.comboSecond.Location = new System.Drawing.Point(323, 219);
            this.comboSecond.Name = "comboSecond";
            this.comboSecond.Size = new System.Drawing.Size(151, 28);
            this.comboSecond.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(267, 285);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(225, 64);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(267, 355);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(225, 64);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // numBoxInterval
            // 
            this.numBoxInterval.Location = new System.Drawing.Point(561, 215);
            this.numBoxInterval.Name = "numBoxInterval";
            this.numBoxInterval.Size = new System.Drawing.Size(150, 27);
            this.numBoxInterval.TabIndex = 5;
            this.numBoxInterval.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numBoxInterval);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.comboSecond);
            this.Controls.Add(this.comboMinute);
            this.Controls.Add(this.comboHour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBoxInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private Label lblHour;
        private Label lblMinute;
        private Label lblSecond;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboHour;
        private ComboBox comboMinute;
        private ComboBox comboSecond;
        private Button btnSet;
        private Button btnStop;
        private NumericUpDown numBoxInterval;
    }
}