namespace AutoShutdown
{
    partial class AutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoForm));
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ShutRadio = new System.Windows.Forms.RadioButton();
            this.RebootRadio = new System.Windows.Forms.RadioButton();
            this.TimeLabelSec = new System.Windows.Forms.Label();
            this.TimeLabelMin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeLabelHr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(12, 41);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(201, 22);
            this.TimeBox.TabIndex = 0;
            this.TimeBox.Text = "(Only Integer Numbers, Please)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time in Minutes:";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Lime;
            this.StartButton.Location = new System.Drawing.Point(15, 94);
            this.StartButton.MaximumSize = new System.Drawing.Size(110, 25);
            this.StartButton.MinimumSize = new System.Drawing.Size(110, 25);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(110, 25);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.Crimson;
            this.StopButton.Location = new System.Drawing.Point(15, 125);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(110, 25);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ShutRadio
            // 
            this.ShutRadio.AutoSize = true;
            this.ShutRadio.Checked = true;
            this.ShutRadio.Location = new System.Drawing.Point(227, 21);
            this.ShutRadio.Name = "ShutRadio";
            this.ShutRadio.Size = new System.Drawing.Size(91, 21);
            this.ShutRadio.TabIndex = 4;
            this.ShutRadio.TabStop = true;
            this.ShutRadio.Text = "Shutdown";
            this.ShutRadio.UseVisualStyleBackColor = true;
            // 
            // RebootRadio
            // 
            this.RebootRadio.AutoSize = true;
            this.RebootRadio.Location = new System.Drawing.Point(227, 48);
            this.RebootRadio.Name = "RebootRadio";
            this.RebootRadio.Size = new System.Drawing.Size(75, 21);
            this.RebootRadio.TabIndex = 5;
            this.RebootRadio.Text = "Reboot";
            this.RebootRadio.UseVisualStyleBackColor = true;
            // 
            // TimeLabelSec
            // 
            this.TimeLabelSec.AutoSize = true;
            this.TimeLabelSec.Location = new System.Drawing.Point(294, 111);
            this.TimeLabelSec.Name = "TimeLabelSec";
            this.TimeLabelSec.Size = new System.Drawing.Size(24, 17);
            this.TimeLabelSec.TabIndex = 6;
            this.TimeLabelSec.Text = "00";
            // 
            // TimeLabelMin
            // 
            this.TimeLabelMin.AutoSize = true;
            this.TimeLabelMin.Location = new System.Drawing.Point(264, 111);
            this.TimeLabelMin.Name = "TimeLabelMin";
            this.TimeLabelMin.Size = new System.Drawing.Size(24, 17);
            this.TimeLabelMin.TabIndex = 7;
            this.TimeLabelMin.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // TimeLabelHr
            // 
            this.TimeLabelHr.AutoSize = true;
            this.TimeLabelHr.Location = new System.Drawing.Point(234, 111);
            this.TimeLabelHr.Name = "TimeLabelHr";
            this.TimeLabelHr.Size = new System.Drawing.Size(24, 17);
            this.TimeLabelHr.TabIndex = 10;
            this.TimeLabelHr.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Time:";
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 169);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeLabelHr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TimeLabelMin);
            this.Controls.Add(this.TimeLabelSec);
            this.Controls.Add(this.RebootRadio);
            this.Controls.Add(this.ShutRadio);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoForm";
            this.Text = "AutoShutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.RadioButton ShutRadio;
        private System.Windows.Forms.RadioButton RebootRadio;
        private System.Windows.Forms.Label TimeLabelSec;
        private System.Windows.Forms.Label TimeLabelMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TimeLabelHr;
        private System.Windows.Forms.Label label5;
    }
}