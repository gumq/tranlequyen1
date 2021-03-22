namespace TranLeQuyen_5951071088_
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsRecordData = new System.Windows.Forms.DataGridView();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtRoll = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtNName = new System.Windows.Forms.TextBox();
            this.TxtHName = new System.Windows.Forms.TextBox();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRecordData)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Tên sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Số báo danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Họ sinh viên:";
            // 
            // StudentsRecordData
            // 
            this.StudentsRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsRecordData.Location = new System.Drawing.Point(18, 374);
            this.StudentsRecordData.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsRecordData.Name = "StudentsRecordData";
            this.StudentsRecordData.RowHeadersWidth = 51;
            this.StudentsRecordData.Size = new System.Drawing.Size(980, 185);
            this.StudentsRecordData.TabIndex = 32;
            this.StudentsRecordData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsRecordData_CellContentClick_1);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(184, 138);
            this.TxtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(368, 27);
            this.TxtAddress.TabIndex = 27;
            // 
            // TxtRoll
            // 
            this.TxtRoll.Location = new System.Drawing.Point(184, 90);
            this.TxtRoll.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRoll.Multiline = true;
            this.TxtRoll.Name = "TxtRoll";
            this.TxtRoll.Size = new System.Drawing.Size(175, 27);
            this.TxtRoll.TabIndex = 28;
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(760, 126);
            this.TxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPhone.Multiline = true;
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(175, 27);
            this.TxtPhone.TabIndex = 29;
            // 
            // TxtNName
            // 
            this.TxtNName.Location = new System.Drawing.Point(760, 69);
            this.TxtNName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNName.Multiline = true;
            this.TxtNName.Name = "TxtNName";
            this.TxtNName.Size = new System.Drawing.Size(175, 27);
            this.TxtNName.TabIndex = 30;
            // 
            // TxtHName
            // 
            this.TxtHName.Location = new System.Drawing.Point(184, 46);
            this.TxtHName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHName.Multiline = true;
            this.TxtHName.Name = "TxtHName";
            this.TxtHName.Size = new System.Drawing.Size(175, 27);
            this.TxtHName.TabIndex = 31;
            this.TxtHName.TextChanged += new System.EventHandler(this.TxtHName_TextChanged);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(805, 287);
            this.Exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(115, 57);
            this.Exitbutton.TabIndex = 22;
            this.Exitbutton.Text = "Thoát";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(622, 287);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(115, 57);
            this.Deletebutton.TabIndex = 23;
            this.Deletebutton.Text = "Xoá";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(425, 287);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 57);
            this.button3.TabIndex = 24;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(244, 287);
            this.Updatebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(115, 57);
            this.Updatebutton.TabIndex = 25;
            this.Updatebutton.Text = "Cập nhật";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(35, 287);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(115, 57);
            this.Addbutton.TabIndex = 26;
            this.Addbutton.Text = "Thêm";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1017, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentsRecordData);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtRoll);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.TxtNName);
            this.Controls.Add(this.TxtHName);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Addbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRecordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView StudentsRecordData;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtRoll;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtNName;
        private System.Windows.Forms.TextBox TxtHName;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Addbutton;
    }
}

