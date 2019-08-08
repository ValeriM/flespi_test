namespace flespi_test
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
            this.txtTopicSubscribe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTopicPublish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic";
            // 
            // txtTopicSubscribe
            // 
            this.txtTopicSubscribe.Location = new System.Drawing.Point(106, 5);
            this.txtTopicSubscribe.Name = "txtTopicSubscribe";
            this.txtTopicSubscribe.Size = new System.Drawing.Size(100, 20);
            this.txtTopicSubscribe.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Subscribe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(106, 63);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(100, 20);
            this.txtReceived.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Received";
            // 
            // txtTopicPublish
            // 
            this.txtTopicPublish.Location = new System.Drawing.Point(106, 117);
            this.txtTopicPublish.Name = "txtTopicPublish";
            this.txtTopicPublish.Size = new System.Drawing.Size(100, 20);
            this.txtTopicPublish.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Topic Publish";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Publish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTopicPublish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTopicSubscribe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopicSubscribe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTopicPublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

