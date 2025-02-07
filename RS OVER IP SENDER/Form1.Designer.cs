namespace RS_OVER_IP_SENDER
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
            buttonSendRsOverIP = new Button();
            richTextBoxHexCommand = new RichTextBox();
            textBoxIpAdress = new TextBox();
            textBoxPortNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBoxStatus = new RichTextBox();
            checkBoxHumanAnswer = new CheckBox();
            richTextBoxASCII = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // buttonSendRsOverIP
            // 
            buttonSendRsOverIP.BackColor = Color.ForestGreen;
            buttonSendRsOverIP.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSendRsOverIP.Location = new Point(341, 603);
            buttonSendRsOverIP.Name = "buttonSendRsOverIP";
            buttonSendRsOverIP.Size = new Size(273, 96);
            buttonSendRsOverIP.TabIndex = 0;
            buttonSendRsOverIP.Text = "SEND";
            buttonSendRsOverIP.UseVisualStyleBackColor = false;
            buttonSendRsOverIP.Click += buttonSendRsOverIP_Click;
            // 
            // richTextBoxHexCommand
            // 
            richTextBoxHexCommand.Location = new Point(534, 119);
            richTextBoxHexCommand.Name = "richTextBoxHexCommand";
            richTextBoxHexCommand.Size = new Size(396, 91);
            richTextBoxHexCommand.TabIndex = 1;
            richTextBoxHexCommand.Text = "25 31 50 4f 57 52 20 3f 0d";
            richTextBoxHexCommand.TextChanged += richTextBoxHexCommand_TextChanged;
            // 
            // textBoxIpAdress
            // 
            textBoxIpAdress.Location = new Point(136, 22);
            textBoxIpAdress.Name = "textBoxIpAdress";
            textBoxIpAdress.Size = new Size(316, 31);
            textBoxIpAdress.TabIndex = 3;
            textBoxIpAdress.Text = "192.168.001.100";
            // 
            // textBoxPortNumber
            // 
            textBoxPortNumber.Location = new Point(617, 25);
            textBoxPortNumber.Name = "textBoxPortNumber";
            textBoxPortNumber.Size = new Size(121, 31);
            textBoxPortNumber.TabIndex = 4;
            textBoxPortNumber.Text = "4352";
            textBoxPortNumber.TextChanged += textBoxPortNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 5;
            label1.Text = "IP adress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(506, 25);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 6;
            label2.Text = "PORT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(652, 76);
            label3.Name = "label3";
            label3.Size = new Size(139, 25);
            label3.TabIndex = 7;
            label3.Text = "Command(HEX)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 231);
            label4.Name = "label4";
            label4.Size = new Size(407, 25);
            label4.TabIndex = 8;
            label4.Text = "The default command queries the projector status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 292);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 9;
            label5.Text = "Command status";
            label5.Click += label5_Click;
            // 
            // richTextBoxStatus
            // 
            richTextBoxStatus.Location = new Point(30, 351);
            richTextBoxStatus.Name = "richTextBoxStatus";
            richTextBoxStatus.Size = new Size(876, 225);
            richTextBoxStatus.TabIndex = 10;
            richTextBoxStatus.Text = "";
            // 
            // checkBoxHumanAnswer
            // 
            checkBoxHumanAnswer.AutoSize = true;
            checkBoxHumanAnswer.Checked = true;
            checkBoxHumanAnswer.CheckState = CheckState.Checked;
            checkBoxHumanAnswer.Location = new Point(585, 254);
            checkBoxHumanAnswer.Name = "checkBoxHumanAnswer";
            checkBoxHumanAnswer.Size = new Size(193, 29);
            checkBoxHumanAnswer.TabIndex = 11;
            checkBoxHumanAnswer.Text = "Get human answers";
            checkBoxHumanAnswer.UseVisualStyleBackColor = true;
            // 
            // richTextBoxASCII
            // 
            richTextBoxASCII.Location = new Point(56, 119);
            richTextBoxASCII.Name = "richTextBoxASCII";
            richTextBoxASCII.Size = new Size(396, 91);
            richTextBoxASCII.TabIndex = 13;
            richTextBoxASCII.Text = "%1POWR ?";
            richTextBoxASCII.TextChanged += textBoxPortNumber_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 76);
            label6.Name = "label6";
            label6.Size = new Size(144, 25);
            label6.TabIndex = 14;
            label6.Text = "Command(ASCI)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 727);
            Controls.Add(label6);
            Controls.Add(richTextBoxASCII);
            Controls.Add(checkBoxHumanAnswer);
            Controls.Add(richTextBoxStatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPortNumber);
            Controls.Add(textBoxIpAdress);
            Controls.Add(richTextBoxHexCommand);
            Controls.Add(buttonSendRsOverIP);
            Name = "Form1";
            Text = "RS232 PJlink command tester";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSendRsOverIP;
        private RichTextBox richTextBoxHexCommand;
        private TextBox textBoxIpAdress;
        private TextBox textBoxPortNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBoxStatus;
        private CheckBox checkBoxHumanAnswer;
        private RichTextBox richTextBoxASCII;
        private Label label6;
    }
}
