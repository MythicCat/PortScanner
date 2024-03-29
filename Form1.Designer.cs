﻿
namespace PortScanner
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
            this.scanButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.maskedEndPort = new System.Windows.Forms.MaskedTextBox();
            this.maskedStartPort = new System.Windows.Forms.MaskedTextBox();
            this.statusDisplay = new System.Windows.Forms.TextBox();
            this.portResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetIpInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.allPortsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanButton
            // 
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanButton.Location = new System.Drawing.Point(674, 6);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(104, 30);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 512);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.maskedEndPort);
            this.tabPage1.Controls.Add(this.maskedStartPort);
            this.tabPage1.Controls.Add(this.statusDisplay);
            this.tabPage1.Controls.Add(this.portResult);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.targetIpInput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.allPortsLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.scanButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // maskedEndPort
            // 
            this.maskedEndPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedEndPort.Location = new System.Drawing.Point(523, 5);
            this.maskedEndPort.Mask = "00000";
            this.maskedEndPort.Name = "maskedEndPort";
            this.maskedEndPort.PromptChar = ' ';
            this.maskedEndPort.Size = new System.Drawing.Size(144, 30);
            this.maskedEndPort.TabIndex = 14;
            this.maskedEndPort.Text = "65535";
            this.maskedEndPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedEndPort.ValidatingType = typeof(int);
            // 
            // maskedStartPort
            // 
            this.maskedStartPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedStartPort.Location = new System.Drawing.Point(346, 6);
            this.maskedStartPort.Mask = "00000";
            this.maskedStartPort.Name = "maskedStartPort";
            this.maskedStartPort.PromptChar = ' ';
            this.maskedStartPort.Size = new System.Drawing.Size(145, 30);
            this.maskedStartPort.TabIndex = 13;
            this.maskedStartPort.Text = "0";
            this.maskedStartPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedStartPort.ValidatingType = typeof(int);
            this.maskedStartPort.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // statusDisplay
            // 
            this.statusDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDisplay.Location = new System.Drawing.Point(156, 47);
            this.statusDisplay.Multiline = true;
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.ReadOnly = true;
            this.statusDisplay.Size = new System.Drawing.Size(622, 72);
            this.statusDisplay.TabIndex = 12;
            // 
            // portResult
            // 
            this.portResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portResult.Location = new System.Drawing.Point(8, 150);
            this.portResult.Multiline = true;
            this.portResult.Name = "portResult";
            this.portResult.ReadOnly = true;
            this.portResult.Size = new System.Drawing.Size(770, 330);
            this.portResult.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // targetIpInput
            // 
            this.targetIpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetIpInput.Location = new System.Drawing.Point(6, 5);
            this.targetIpInput.Name = "targetIpInput";
            this.targetIpInput.Size = new System.Drawing.Size(309, 30);
            this.targetIpInput.TabIndex = 9;
            this.targetIpInput.Text = "127.0.0.1";
            this.targetIpInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // allPortsLabel
            // 
            this.allPortsLabel.AutoSize = true;
            this.allPortsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPortsLabel.Location = new System.Drawing.Point(6, 122);
            this.allPortsLabel.Name = "allPortsLabel";
            this.allPortsLabel.Size = new System.Drawing.Size(146, 25);
            this.allPortsLabel.TabIndex = 4;
            this.allPortsLabel.Text = "Available ports:";
            this.allPortsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Help";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 528);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "PortScanner";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label allPortsLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetIpInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portResult;
        private System.Windows.Forms.TextBox statusDisplay;
        private System.Windows.Forms.MaskedTextBox maskedStartPort;
        private System.Windows.Forms.MaskedTextBox maskedEndPort;
    }
}

