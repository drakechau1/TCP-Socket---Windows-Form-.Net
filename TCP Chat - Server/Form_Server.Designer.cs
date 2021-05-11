
namespace TCP_Chat___Server
{
    partial class TCPServer
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
            this.btn_listen = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_clearmessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listen
            // 
            this.btn_listen.AutoSize = true;
            this.btn_listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listen.Location = new System.Drawing.Point(45, 22);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(153, 51);
            this.btn_listen.TabIndex = 0;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // lb_message
            // 
            this.lb_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 25;
            this.lb_message.Location = new System.Drawing.Point(45, 92);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(611, 429);
            this.lb_message.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Enabled = false;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(239, 22);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(151, 51);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clearmessage
            // 
            this.btn_clearmessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clearmessage.AutoSize = true;
            this.btn_clearmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearmessage.Location = new System.Drawing.Point(45, 540);
            this.btn_clearmessage.Name = "btn_clearmessage";
            this.btn_clearmessage.Size = new System.Drawing.Size(218, 51);
            this.btn_clearmessage.TabIndex = 3;
            this.btn_clearmessage.Text = "Clear message";
            this.btn_clearmessage.UseVisualStyleBackColor = true;
            this.btn_clearmessage.Click += new System.EventHandler(this.btn_clearmessage_Click);
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 614);
            this.Controls.Add(this.btn_clearmessage);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_listen);
            this.Name = "TCPServer";
            this.Text = "TCP Chat - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clearmessage;
    }
}

