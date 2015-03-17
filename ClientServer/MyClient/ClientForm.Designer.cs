namespace MyClient
{
    partial class ClientForm
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
            this.DataPort = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectionStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PortNumber = new System.Windows.Forms.TextBox();
            this.ServerIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverMessages = new System.Windows.Forms.ListBox();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersOnLineList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataPort
            // 
            this.DataPort.Location = new System.Drawing.Point(151, 52);
            this.DataPort.Name = "DataPort";
            this.DataPort.Size = new System.Drawing.Size(44, 20);
            this.DataPort.TabIndex = 35;
            this.DataPort.Text = "8090";
            this.DataPort.TextChanged += new System.EventHandler(this.DataPort_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 208);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(91, 52);
            this.SendButton.TabIndex = 34;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(395, 208);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(89, 52);
            this.DisconnectButton.TabIndex = 33;
            this.DisconnectButton.Text = "DISCONNECT";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Location = new System.Drawing.Point(264, 26);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.ReadOnly = true;
            this.ConnectionStatus.Size = new System.Drawing.Size(220, 20);
            this.ConnectionStatus.TabIndex = 32;
            this.ConnectionStatus.Text = "Not Connected";
            this.ConnectionStatus.TextChanged += new System.EventHandler(this.ConnectionStatus_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Connection Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(201, 38);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(38, 23);
            this.ConnectButton.TabIndex = 30;
            this.ConnectButton.Text = "GO";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PortNumber
            // 
            this.PortNumber.Location = new System.Drawing.Point(151, 26);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(44, 20);
            this.PortNumber.TabIndex = 29;
            this.PortNumber.Text = "8080";
            this.PortNumber.TextChanged += new System.EventHandler(this.PortNumber_TextChanged);
            // 
            // ServerIPAddress
            // 
            this.ServerIPAddress.Location = new System.Drawing.Point(12, 27);
            this.ServerIPAddress.Name = "ServerIPAddress";
            this.ServerIPAddress.Size = new System.Drawing.Size(125, 20);
            this.ServerIPAddress.TabIndex = 28;
            this.ServerIPAddress.Text = "127.0.0.1";
            this.ServerIPAddress.TextChanged += new System.EventHandler(this.ServerIPAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port #";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Remote Server Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverMessages
            // 
            this.serverMessages.FormattingEnabled = true;
            this.serverMessages.Location = new System.Drawing.Point(264, 84);
            this.serverMessages.Name = "serverMessages";
            this.serverMessages.Size = new System.Drawing.Size(220, 95);
            this.serverMessages.TabIndex = 36;
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(12, 182);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(245, 20);
            this.TextMessage.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Text Message";
            // 
            // UsersOnLineList
            // 
            this.UsersOnLineList.FormattingEnabled = true;
            this.UsersOnLineList.Location = new System.Drawing.Point(12, 94);
            this.UsersOnLineList.Name = "UsersOnLineList";
            this.UsersOnLineList.Size = new System.Drawing.Size(146, 69);
            this.UsersOnLineList.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "List of online users";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 52);
            this.button1.TabIndex = 41;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 52);
            this.button2.TabIndex = 42;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 52);
            this.button3.TabIndex = 43;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 404);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsersOnLineList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.serverMessages);
            this.Controls.Add(this.DataPort);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectionStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.ServerIPAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "TCP/IP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataPort;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox ConnectionStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PortNumber;
        private System.Windows.Forms.TextBox ServerIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox serverMessages;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox UsersOnLineList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

