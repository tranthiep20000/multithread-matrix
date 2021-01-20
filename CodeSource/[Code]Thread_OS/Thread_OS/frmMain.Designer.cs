namespace Thread_OS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.Grp_input1 = new System.Windows.Forms.GroupBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.btnSinh1 = new System.Windows.Forms.Button();
            this.btnGetData1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCot1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHang1 = new System.Windows.Forms.TextBox();
            this.Grp_input2 = new System.Windows.Forms.GroupBox();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.btnRead2 = new System.Windows.Forms.Button();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.btnSinh2 = new System.Windows.Forms.Button();
            this.btnGetData2 = new System.Windows.Forms.Button();
            this.txtHang2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCot2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSinh3 = new System.Windows.Forms.Button();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveKQ = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Grp_input1.SuspendLayout();
            this.Grp_input2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(88, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Star";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Grp_input1
            // 
            this.Grp_input1.Controls.Add(this.btnSave1);
            this.Grp_input1.Controls.Add(this.btnRead1);
            this.Grp_input1.Controls.Add(this.check1);
            this.Grp_input1.Controls.Add(this.btnSinh1);
            this.Grp_input1.Controls.Add(this.btnGetData1);
            this.Grp_input1.Controls.Add(this.label2);
            this.Grp_input1.Controls.Add(this.txtCot1);
            this.Grp_input1.Controls.Add(this.label1);
            this.Grp_input1.Controls.Add(this.txtHang1);
            this.Grp_input1.Location = new System.Drawing.Point(0, 1);
            this.Grp_input1.Name = "Grp_input1";
            this.Grp_input1.Size = new System.Drawing.Size(500, 87);
            this.Grp_input1.TabIndex = 2;
            this.Grp_input1.TabStop = false;
            this.Grp_input1.Text = "Ma Trận 1";
            // 
            // btnSave1
            // 
            this.btnSave1.Enabled = false;
            this.btnSave1.Location = new System.Drawing.Point(245, 45);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 8;
            this.btnSave1.Text = "Lưu ra File";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(328, 45);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(75, 23);
            this.btnRead1.TabIndex = 7;
            this.btnRead1.Text = "Đọc từ File";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Checked = true;
            this.check1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check1.Location = new System.Drawing.Point(184, 20);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(96, 17);
            this.check1.TabIndex = 6;
            this.check1.Text = "Random Giá trị";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // btnSinh1
            // 
            this.btnSinh1.Location = new System.Drawing.Point(284, 15);
            this.btnSinh1.Name = "btnSinh1";
            this.btnSinh1.Size = new System.Drawing.Size(36, 23);
            this.btnSinh1.TabIndex = 5;
            this.btnSinh1.Text = "OK";
            this.btnSinh1.UseVisualStyleBackColor = true;
            this.btnSinh1.Click += new System.EventHandler(this.btnsinh1_Click);
            // 
            // btnGetData1
            // 
            this.btnGetData1.Enabled = false;
            this.btnGetData1.Location = new System.Drawing.Point(328, 15);
            this.btnGetData1.Name = "btnGetData1";
            this.btnGetData1.Size = new System.Drawing.Size(75, 23);
            this.btnGetData1.TabIndex = 4;
            this.btnGetData1.Text = "Lấy giá trị";
            this.btnGetData1.UseVisualStyleBackColor = true;
            this.btnGetData1.Click += new System.EventHandler(this.btnlay1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số Cột";
            // 
            // txtCot1
            // 
            this.txtCot1.Location = new System.Drawing.Point(141, 17);
            this.txtCot1.Name = "txtCot1";
            this.txtCot1.Size = new System.Drawing.Size(40, 20);
            this.txtCot1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Hàng";
            // 
            // txtHang1
            // 
            this.txtHang1.Location = new System.Drawing.Point(58, 17);
            this.txtHang1.Name = "txtHang1";
            this.txtHang1.Size = new System.Drawing.Size(40, 20);
            this.txtHang1.TabIndex = 0;
            // 
            // Grp_input2
            // 
            this.Grp_input2.Controls.Add(this.btnSave2);
            this.Grp_input2.Controls.Add(this.btnRead2);
            this.Grp_input2.Controls.Add(this.check2);
            this.Grp_input2.Controls.Add(this.btnSinh2);
            this.Grp_input2.Controls.Add(this.btnGetData2);
            this.Grp_input2.Controls.Add(this.txtHang2);
            this.Grp_input2.Controls.Add(this.label3);
            this.Grp_input2.Controls.Add(this.label4);
            this.Grp_input2.Controls.Add(this.txtCot2);
            this.Grp_input2.Location = new System.Drawing.Point(509, 1);
            this.Grp_input2.Name = "Grp_input2";
            this.Grp_input2.Size = new System.Drawing.Size(500, 87);
            this.Grp_input2.TabIndex = 3;
            this.Grp_input2.TabStop = false;
            this.Grp_input2.Text = "Ma Trận 2";
            // 
            // btnSave2
            // 
            this.btnSave2.Enabled = false;
            this.btnSave2.Location = new System.Drawing.Point(245, 45);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 9;
            this.btnSave2.Text = "Lưu ra File";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // btnRead2
            // 
            this.btnRead2.Location = new System.Drawing.Point(328, 45);
            this.btnRead2.Name = "btnRead2";
            this.btnRead2.Size = new System.Drawing.Size(75, 23);
            this.btnRead2.TabIndex = 8;
            this.btnRead2.Text = "Đọc từ File";
            this.btnRead2.UseVisualStyleBackColor = true;
            this.btnRead2.Click += new System.EventHandler(this.btnRead2_Click);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Checked = true;
            this.check2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check2.Location = new System.Drawing.Point(186, 19);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(96, 17);
            this.check2.TabIndex = 7;
            this.check2.Text = "Random Giá trị";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // btnSinh2
            // 
            this.btnSinh2.AutoSize = true;
            this.btnSinh2.Location = new System.Drawing.Point(284, 16);
            this.btnSinh2.Name = "btnSinh2";
            this.btnSinh2.Size = new System.Drawing.Size(36, 23);
            this.btnSinh2.TabIndex = 6;
            this.btnSinh2.Text = "OK";
            this.btnSinh2.UseVisualStyleBackColor = true;
            this.btnSinh2.Click += new System.EventHandler(this.btnsinh2_Click);
            // 
            // btnGetData2
            // 
            this.btnGetData2.Enabled = false;
            this.btnGetData2.Location = new System.Drawing.Point(328, 16);
            this.btnGetData2.Name = "btnGetData2";
            this.btnGetData2.Size = new System.Drawing.Size(75, 23);
            this.btnGetData2.TabIndex = 9;
            this.btnGetData2.Text = "Lấy giá trị";
            this.btnGetData2.UseVisualStyleBackColor = true;
            this.btnGetData2.Click += new System.EventHandler(this.btnlay2_Click);
            // 
            // txtHang2
            // 
            this.txtHang2.Enabled = false;
            this.txtHang2.Location = new System.Drawing.Point(56, 17);
            this.txtHang2.Name = "txtHang2";
            this.txtHang2.Size = new System.Drawing.Size(40, 20);
            this.txtHang2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số Cột";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Hàng";
            // 
            // txtCot2
            // 
            this.txtCot2.Location = new System.Drawing.Point(140, 17);
            this.txtCot2.Name = "txtCot2";
            this.txtCot2.Size = new System.Drawing.Size(40, 20);
            this.txtCot2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(509, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 300);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(284, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 300);
            this.panel3.TabIndex = 8;
            // 
            // btnSinh3
            // 
            this.btnSinh3.Location = new System.Drawing.Point(6, 19);
            this.btnSinh3.Name = "btnSinh3";
            this.btnSinh3.Size = new System.Drawing.Size(75, 23);
            this.btnSinh3.TabIndex = 3;
            this.btnSinh3.Text = "Khởi tạo";
            this.btnSinh3.UseVisualStyleBackColor = true;
            this.btnSinh3.Click += new System.EventHandler(this.btnSinh3_Click);
            // 
            // txtSleep
            // 
            this.txtSleep.Location = new System.Drawing.Point(88, 58);
            this.txtSleep.Name = "txtSleep";
            this.txtSleep.Size = new System.Drawing.Size(77, 20);
            this.txtSleep.TabIndex = 2;
            this.txtSleep.Text = "100";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveKQ);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSinh3);
            this.groupBox1.Controls.Add(this.txtSleep);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Location = new System.Drawing.Point(0, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả";
            // 
            // btnSaveKQ
            // 
            this.btnSaveKQ.Enabled = false;
            this.btnSaveKQ.Location = new System.Drawing.Point(6, 93);
            this.btnSaveKQ.Name = "btnSaveKQ";
            this.btnSaveKQ.Size = new System.Drawing.Size(75, 23);
            this.btnSaveKQ.TabIndex = 9;
            this.btnSaveKQ.Text = "Lưu ra File";
            this.btnSaveKQ.UseVisualStyleBackColor = true;
            this.btnSaveKQ.Click += new System.EventHandler(this.btnSaveKQ_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sleep Time";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1015, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grp_input2);
            this.Controls.Add(this.Grp_input1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân 2 Ma trận dùng nhiều thread";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Grp_input1.ResumeLayout(false);
            this.Grp_input1.PerformLayout();
            this.Grp_input2.ResumeLayout(false);
            this.Grp_input2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox Grp_input1;
        private System.Windows.Forms.GroupBox Grp_input2;
        private System.Windows.Forms.Button btnSinh1;
        private System.Windows.Forms.Button btnGetData1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCot1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHang1;
        private System.Windows.Forms.Button btnSinh2;
        private System.Windows.Forms.Button btnGetData2;
        private System.Windows.Forms.TextBox txtHang2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCot2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.Button btnSinh3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Button btnRead2;
        private System.Windows.Forms.Button btnSaveKQ;
    }
}

