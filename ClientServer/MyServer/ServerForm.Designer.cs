namespace MyServer
{
    partial class ServerForm
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
            this.ListOfConnections = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ListOfCommands = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ListOfData = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of online users";
            // 
            // ListOfConnections
            // 
            this.ListOfConnections.FormattingEnabled = true;
            this.ListOfConnections.Location = new System.Drawing.Point(16, 30);
            this.ListOfConnections.Name = "ListOfConnections";
            this.ListOfConnections.Size = new System.Drawing.Size(137, 134);
            this.ListOfConnections.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incoming Commands";
            // 
            // ListOfCommands
            // 
            this.ListOfCommands.FormattingEnabled = true;
            this.ListOfCommands.Location = new System.Drawing.Point(182, 30);
            this.ListOfCommands.Name = "ListOfCommands";
            this.ListOfCommands.Size = new System.Drawing.Size(146, 134);
            this.ListOfCommands.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Incoming Data";
            // 
            // ListOfData
            // 
            this.ListOfData.FormattingEnabled = true;
            this.ListOfData.Location = new System.Drawing.Point(351, 30);
            this.ListOfData.Name = "ListOfData";
            this.ListOfData.Size = new System.Drawing.Size(234, 134);
            this.ListOfData.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(493, 170);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(92, 57);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(395, 170);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(92, 57);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 236);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ListOfData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListOfCommands);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListOfConnections);
            this.Controls.Add(this.label1);
            this.Name = "ServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListOfConnections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListOfCommands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ListOfData;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}

