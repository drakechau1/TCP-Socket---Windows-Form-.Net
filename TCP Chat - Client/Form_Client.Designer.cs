
namespace TCP_Chat___Client
{
    partial class Form_Client
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_remoteIP = new System.Windows.Forms.TextBox();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_attachFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_remotePort = new System.Windows.Forms.TextBox();
            this.btn_clearMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remote IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remote port";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(675, 32);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(141, 49);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_remoteIP
            // 
            this.txt_remoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remoteIP.Location = new System.Drawing.Point(163, 41);
            this.txt_remoteIP.Name = "txt_remoteIP";
            this.txt_remoteIP.Size = new System.Drawing.Size(235, 30);
            this.txt_remoteIP.TabIndex = 3;
            // 
            // lb_message
            // 
            this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 25;
            this.lb_message.Location = new System.Drawing.Point(41, 227);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(775, 304);
            this.lb_message.TabIndex = 5;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_disconnect.AutoSize = true;
            this.btn_disconnect.Enabled = false;
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(675, 553);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(141, 49);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // txt_message
            // 
            this.txt_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_message.Location = new System.Drawing.Point(163, 104);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(494, 30);
            this.txt_message.TabIndex = 3;
            // 
            // btn_attachFile
            // 
            this.btn_attachFile.Enabled = false;
            this.btn_attachFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attachFile.Location = new System.Drawing.Point(50, 156);
            this.btn_attachFile.Name = "btn_attachFile";
            this.btn_attachFile.Size = new System.Drawing.Size(141, 49);
            this.btn_attachFile.TabIndex = 2;
            this.btn_attachFile.Text = "Attach file";
            this.btn_attachFile.UseVisualStyleBackColor = true;
            this.btn_attachFile.Click += new System.EventHandler(this.btn_attachFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "No file attached curently";
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(675, 95);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(141, 49);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_remotePort
            // 
            this.txt_remotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remotePort.Location = new System.Drawing.Point(564, 40);
            this.txt_remotePort.Name = "txt_remotePort";
            this.txt_remotePort.Size = new System.Drawing.Size(93, 30);
            this.txt_remotePort.TabIndex = 3;
            // 
            // btn_clearMessage
            // 
            this.btn_clearMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearMessage.AutoSize = true;
            this.btn_clearMessage.Enabled = false;
            this.btn_clearMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearMessage.Location = new System.Drawing.Point(41, 553);
            this.btn_clearMessage.Name = "btn_clearMessage";
            this.btn_clearMessage.Size = new System.Drawing.Size(190, 48);
            this.btn_clearMessage.TabIndex = 8;
            this.btn_clearMessage.Text = "Clear message";
            this.btn_clearMessage.UseVisualStyleBackColor = true;
            this.btn_clearMessage.Click += new System.EventHandler(this.txt_clearMessage_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 627);
            this.Controls.Add(this.btn_clearMessage);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_remotePort);
            this.Controls.Add(this.txt_remoteIP);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_attachFile);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_remoteIP;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_attachFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_remotePort;
        private System.Windows.Forms.Button btn_clearMessage;
    }
}

