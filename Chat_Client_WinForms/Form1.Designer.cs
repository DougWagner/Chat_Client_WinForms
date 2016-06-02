namespace Chat_Client_WinForms
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
            this.ChatText = new System.Windows.Forms.TextBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.IPInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.Users = new System.Windows.Forms.ListBox();
            this.SendToAll = new System.Windows.Forms.RadioButton();
            this.SendToOne = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChatText
            // 
            this.ChatText.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatText.Location = new System.Drawing.Point(300, 107);
            this.ChatText.Multiline = true;
            this.ChatText.Name = "ChatText";
            this.ChatText.ReadOnly = true;
            this.ChatText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatText.Size = new System.Drawing.Size(1226, 465);
            this.ChatText.TabIndex = 0;
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(300, 578);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(977, 208);
            this.InputText.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(1283, 578);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(243, 208);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // IPInput
            // 
            this.IPInput.Location = new System.Drawing.Point(428, 41);
            this.IPInput.Name = "IPInput";
            this.IPInput.Size = new System.Drawing.Size(270, 31);
            this.IPInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(1367, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(159, 89);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(826, 41);
            this.UsernameInput.MaxLength = 32;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(535, 31);
            this.UsernameInput.TabIndex = 7;
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.ItemHeight = 25;
            this.Users.Location = new System.Drawing.Point(12, 107);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(282, 679);
            this.Users.TabIndex = 8;
            // 
            // SendToAll
            // 
            this.SendToAll.AutoSize = true;
            this.SendToAll.Checked = true;
            this.SendToAll.Location = new System.Drawing.Point(12, 12);
            this.SendToAll.Name = "SendToAll";
            this.SendToAll.Size = new System.Drawing.Size(154, 29);
            this.SendToAll.TabIndex = 9;
            this.SendToAll.TabStop = true;
            this.SendToAll.Text = "Send To All";
            this.SendToAll.UseVisualStyleBackColor = true;
            // 
            // SendToOne
            // 
            this.SendToOne.AutoSize = true;
            this.SendToOne.Location = new System.Drawing.Point(12, 47);
            this.SendToOne.Name = "SendToOne";
            this.SendToOne.Size = new System.Drawing.Size(170, 29);
            this.SendToOne.TabIndex = 10;
            this.SendToOne.TabStop = true;
            this.SendToOne.Text = "Send To One";
            this.SendToOne.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Users Online";
            // 
            // Form1
            // 
            this.AcceptButton = this.SendButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1538, 797);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SendToOne);
            this.Controls.Add(this.SendToAll);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPInput);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ChatText);
            this.Name = "Form1";
            this.Text = "BDDBMSA Chat Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ChatText;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox IPInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.RadioButton SendToAll;
        private System.Windows.Forms.RadioButton SendToOne;
        private System.Windows.Forms.Label label3;
    }
}

