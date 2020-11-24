namespace TrafficColorSocket_Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIPAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonMerahOn = new System.Windows.Forms.RadioButton();
            this.radioButtonMerahOff = new System.Windows.Forms.RadioButton();
            this.radioButtonKuningOn = new System.Windows.Forms.RadioButton();
            this.radioButtonKuningOff = new System.Windows.Forms.RadioButton();
            this.radioButtonHijauOn = new System.Windows.Forms.RadioButton();
            this.radioButtonHijauOff = new System.Windows.Forms.RadioButton();
            this.groupBoxMerah = new System.Windows.Forms.GroupBox();
            this.groupBoxKuning = new System.Windows.Forms.GroupBox();
            this.groupBoxHijau = new System.Windows.Forms.GroupBox();
            this.groupBoxMerah.SuspendLayout();
            this.groupBoxKuning.SuspendLayout();
            this.groupBoxHijau.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBoxIPAddress
            // 
            this.textBoxIPAddress.Location = new System.Drawing.Point(103, 12);
            this.textBoxIPAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxIPAddress.Name = "textBoxIPAddress";
            this.textBoxIPAddress.Size = new System.Drawing.Size(132, 22);
            this.textBoxIPAddress.TabIndex = 2;
            this.textBoxIPAddress.Text = "192.168.0.100";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(103, 46);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 22);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "16344";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hidup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Merah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kuning";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hijau";
            // 
            // radioButtonMerahOn
            // 
            this.radioButtonMerahOn.AutoSize = true;
            this.radioButtonMerahOn.Location = new System.Drawing.Point(0, 0);
            this.radioButtonMerahOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMerahOn.Name = "radioButtonMerahOn";
            this.radioButtonMerahOn.Size = new System.Drawing.Size(17, 16);
            this.radioButtonMerahOn.TabIndex = 9;
            this.radioButtonMerahOn.UseVisualStyleBackColor = true;
            this.radioButtonMerahOn.CheckedChanged += new System.EventHandler(this.radioButtonMerahOn_CheckedChanged);
            // 
            // radioButtonMerahOff
            // 
            this.radioButtonMerahOff.AutoSize = true;
            this.radioButtonMerahOff.Checked = true;
            this.radioButtonMerahOff.Location = new System.Drawing.Point(97, 0);
            this.radioButtonMerahOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonMerahOff.Name = "radioButtonMerahOff";
            this.radioButtonMerahOff.Size = new System.Drawing.Size(17, 16);
            this.radioButtonMerahOff.TabIndex = 10;
            this.radioButtonMerahOff.TabStop = true;
            this.radioButtonMerahOff.UseVisualStyleBackColor = true;
            this.radioButtonMerahOff.CheckedChanged += new System.EventHandler(this.radioButtonMerahOff_CheckedChanged);
            // 
            // radioButtonKuningOn
            // 
            this.radioButtonKuningOn.AutoSize = true;
            this.radioButtonKuningOn.Location = new System.Drawing.Point(4, 0);
            this.radioButtonKuningOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonKuningOn.Name = "radioButtonKuningOn";
            this.radioButtonKuningOn.Size = new System.Drawing.Size(17, 16);
            this.radioButtonKuningOn.TabIndex = 11;
            this.radioButtonKuningOn.UseVisualStyleBackColor = true;
            this.radioButtonKuningOn.CheckedChanged += new System.EventHandler(this.radioButtonKuningOn_CheckedChanged);
            // 
            // radioButtonKuningOff
            // 
            this.radioButtonKuningOff.AutoSize = true;
            this.radioButtonKuningOff.Checked = true;
            this.radioButtonKuningOff.Location = new System.Drawing.Point(101, 0);
            this.radioButtonKuningOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonKuningOff.Name = "radioButtonKuningOff";
            this.radioButtonKuningOff.Size = new System.Drawing.Size(17, 16);
            this.radioButtonKuningOff.TabIndex = 12;
            this.radioButtonKuningOff.TabStop = true;
            this.radioButtonKuningOff.UseVisualStyleBackColor = true;
            this.radioButtonKuningOff.CheckedChanged += new System.EventHandler(this.radioButtonKuningOff_CheckedChanged);
            // 
            // radioButtonHijauOn
            // 
            this.radioButtonHijauOn.AutoSize = true;
            this.radioButtonHijauOn.Location = new System.Drawing.Point(4, 0);
            this.radioButtonHijauOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHijauOn.Name = "radioButtonHijauOn";
            this.radioButtonHijauOn.Size = new System.Drawing.Size(17, 16);
            this.radioButtonHijauOn.TabIndex = 13;
            this.radioButtonHijauOn.UseVisualStyleBackColor = true;
            this.radioButtonHijauOn.CheckedChanged += new System.EventHandler(this.radioButtonHijauOn_CheckedChanged);
            // 
            // radioButtonHijauOff
            // 
            this.radioButtonHijauOff.AutoSize = true;
            this.radioButtonHijauOff.Checked = true;
            this.radioButtonHijauOff.Location = new System.Drawing.Point(101, 0);
            this.radioButtonHijauOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHijauOff.Name = "radioButtonHijauOff";
            this.radioButtonHijauOff.Size = new System.Drawing.Size(17, 16);
            this.radioButtonHijauOff.TabIndex = 14;
            this.radioButtonHijauOff.TabStop = true;
            this.radioButtonHijauOff.UseVisualStyleBackColor = true;
            this.radioButtonHijauOff.CheckedChanged += new System.EventHandler(this.radioButtonHijauOff_CheckedChanged);
            // 
            // groupBoxMerah
            // 
            this.groupBoxMerah.Controls.Add(this.radioButtonMerahOn);
            this.groupBoxMerah.Controls.Add(this.radioButtonMerahOff);
            this.groupBoxMerah.Location = new System.Drawing.Point(107, 133);
            this.groupBoxMerah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMerah.Name = "groupBoxMerah";
            this.groupBoxMerah.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMerah.Size = new System.Drawing.Size(129, 16);
            this.groupBoxMerah.TabIndex = 15;
            this.groupBoxMerah.TabStop = false;
            // 
            // groupBoxKuning
            // 
            this.groupBoxKuning.Controls.Add(this.radioButtonKuningOn);
            this.groupBoxKuning.Controls.Add(this.radioButtonKuningOff);
            this.groupBoxKuning.Location = new System.Drawing.Point(103, 169);
            this.groupBoxKuning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKuning.Name = "groupBoxKuning";
            this.groupBoxKuning.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKuning.Size = new System.Drawing.Size(133, 16);
            this.groupBoxKuning.TabIndex = 16;
            this.groupBoxKuning.TabStop = false;
            // 
            // groupBoxHijau
            // 
            this.groupBoxHijau.Controls.Add(this.radioButtonHijauOn);
            this.groupBoxHijau.Controls.Add(this.radioButtonHijauOff);
            this.groupBoxHijau.Location = new System.Drawing.Point(103, 209);
            this.groupBoxHijau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHijau.Name = "groupBoxHijau";
            this.groupBoxHijau.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxHijau.Size = new System.Drawing.Size(133, 16);
            this.groupBoxHijau.TabIndex = 17;
            this.groupBoxHijau.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(571, 353);
            this.Controls.Add(this.groupBoxHijau);
            this.Controls.Add(this.groupBoxKuning);
            this.Controls.Add(this.groupBoxMerah);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Traffic Color Socket Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMerah.ResumeLayout(false);
            this.groupBoxMerah.PerformLayout();
            this.groupBoxKuning.ResumeLayout(false);
            this.groupBoxKuning.PerformLayout();
            this.groupBoxHijau.ResumeLayout(false);
            this.groupBoxHijau.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIPAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonMerahOn;
        private System.Windows.Forms.RadioButton radioButtonMerahOff;
        private System.Windows.Forms.RadioButton radioButtonKuningOn;
        private System.Windows.Forms.RadioButton radioButtonKuningOff;
        private System.Windows.Forms.RadioButton radioButtonHijauOn;
        private System.Windows.Forms.RadioButton radioButtonHijauOff;
        private System.Windows.Forms.GroupBox groupBoxMerah;
        private System.Windows.Forms.GroupBox groupBoxKuning;
        private System.Windows.Forms.GroupBox groupBoxHijau;
    }
}

