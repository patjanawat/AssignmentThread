namespace WindowsFormsApp1
{
    partial class frmNonBlocking
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
            this.txtUrl1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.btnGetcontent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.txtResponse1 = new System.Windows.Forms.TextBox();
            this.txtResponse2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUrl1
            // 
            this.txtUrl1.Location = new System.Drawing.Point(12, 36);
            this.txtUrl1.Name = "txtUrl1";
            this.txtUrl1.Size = new System.Drawing.Size(235, 20);
            this.txtUrl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Url2";
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(253, 36);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(240, 20);
            this.txtUrl2.TabIndex = 3;
            // 
            // btnGetcontent
            // 
            this.btnGetcontent.Location = new System.Drawing.Point(418, 431);
            this.btnGetcontent.Name = "btnGetcontent";
            this.btnGetcontent.Size = new System.Drawing.Size(75, 23);
            this.btnGetcontent.TabIndex = 6;
            this.btnGetcontent.Text = "Get Content";
            this.btnGetcontent.UseVisualStyleBackColor = true;
            this.btnGetcontent.Click += new System.EventHandler(this.btnGetcontent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Content";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear1
            // 
            this.btnClear1.Location = new System.Drawing.Point(16, 431);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 8;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = true;
            this.btnClear1.Click += new System.EventHandler(this.btnClear1_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(253, 431);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(75, 23);
            this.btnClear2.TabIndex = 9;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // txtResponse1
            // 
            this.txtResponse1.Location = new System.Drawing.Point(12, 62);
            this.txtResponse1.Multiline = true;
            this.txtResponse1.Name = "txtResponse1";
            this.txtResponse1.ReadOnly = true;
            this.txtResponse1.Size = new System.Drawing.Size(235, 363);
            this.txtResponse1.TabIndex = 10;
            // 
            // txtResponse2
            // 
            this.txtResponse2.Location = new System.Drawing.Point(253, 62);
            this.txtResponse2.Multiline = true;
            this.txtResponse2.Name = "txtResponse2";
            this.txtResponse2.ReadOnly = true;
            this.txtResponse2.Size = new System.Drawing.Size(240, 363);
            this.txtResponse2.TabIndex = 11;
            // 
            // frmNonBlocking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 467);
            this.Controls.Add(this.txtResponse2);
            this.Controls.Add(this.txtResponse1);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnClear1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetcontent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl1);
            this.Name = "frmNonBlocking";
            this.Text = "Non blocking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Button btnGetcontent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.TextBox txtResponse1;
        private System.Windows.Forms.TextBox txtResponse2;
    }
}

