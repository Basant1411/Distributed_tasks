namespace UDP_Connection
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtServierPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnStartServier = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(-1, -2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Servier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServierPort
            // 
            this.txtServierPort.Location = new System.Drawing.Point(98, 99);
            this.txtServierPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtServierPort.Name = "txtServierPort";
            this.txtServierPort.Size = new System.Drawing.Size(216, 20);
            this.txtServierPort.TabIndex = 1;
            this.txtServierPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servier Port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(23, 165);
            this.txtLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(292, 138);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "log";
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(192, 324);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(123, 52);
            this.btnNewClient.TabIndex = 5;
            this.btnNewClient.Text = "New Client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnStartServier
            // 
            this.btnStartServier.Location = new System.Drawing.Point(24, 324);
            this.btnStartServier.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartServier.Name = "btnStartServier";
            this.btnStartServier.Size = new System.Drawing.Size(121, 52);
            this.btnStartServier.TabIndex = 6;
            this.btnStartServier.Text = "Start Servier";
            this.btnStartServier.UseVisualStyleBackColor = true;
            this.btnStartServier.Click += new System.EventHandler(this.btnStartServier_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(91, 461);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(152, 52);
            this.btnSendMsg.TabIndex = 7;
            this.btnSendMsg.Text = "Send Message";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 427);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 402);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Send message To Client";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnStartServier);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServierPort);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Servier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtServierPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnStartServier;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

