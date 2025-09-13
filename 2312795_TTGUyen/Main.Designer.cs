namespace _2312795_TTGUyen
{
    partial class Main
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn:\r\n";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(235, 68);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(312, 22);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(458, 113);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(76, 33);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Xử Lý";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bạn đã nhập:";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(235, 182);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(312, 22);
            this.txtSaoChep.TabIndex = 2;
            // 
            // btSaoChep
            // 
            this.btSaoChep.Location = new System.Drawing.Point(354, 113);
            this.btSaoChep.Name = "btSaoChep";
            this.btSaoChep.Size = new System.Drawing.Size(85, 33);
            this.btSaoChep.TabIndex = 3;
            this.btSaoChep.Text = "Sao Chép";
            this.btSaoChep.UseVisualStyleBackColor = true;
            this.btSaoChep.Click += new System.EventHandler(this.btSaoChep_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 326);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSaoChep);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Chương trình đầu tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btSaoChep;
    }
}

