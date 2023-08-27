
namespace EmployeeForm
{
    partial class EmployeeForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeePicBox = new System.Windows.Forms.PictureBox();
            this.doePicker = new System.Windows.Forms.DateTimePicker();
            this.departmentCombo = new System.Windows.Forms.ComboBox();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteIdTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 224);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(18, 147);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(310, 22);
            this.nameTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Employee Informations";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(193, 405);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(135, 56);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Employment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role:";
            // 
            // employeePicBox
            // 
            this.employeePicBox.Location = new System.Drawing.Point(385, 75);
            this.employeePicBox.Name = "employeePicBox";
            this.employeePicBox.Size = new System.Drawing.Size(263, 182);
            this.employeePicBox.TabIndex = 13;
            this.employeePicBox.TabStop = false;
            // 
            // doePicker
            // 
            this.doePicker.Location = new System.Drawing.Point(18, 211);
            this.doePicker.Name = "doePicker";
            this.doePicker.Size = new System.Drawing.Size(310, 22);
            this.doePicker.TabIndex = 14;
            // 
            // departmentCombo
            // 
            this.departmentCombo.FormattingEnabled = true;
            this.departmentCombo.Items.AddRange(new object[] {
            "Application Dev",
            "Human Resources",
            "Marketing"});
            this.departmentCombo.Location = new System.Drawing.Point(18, 274);
            this.departmentCombo.Name = "departmentCombo";
            this.departmentCombo.Size = new System.Drawing.Size(310, 24);
            this.departmentCombo.TabIndex = 15;
            // 
            // roleCombo
            // 
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Items.AddRange(new object[] {
            "Front-end Developer",
            "Back-end Developer",
            "Data Analyst",
            "Test Engineer"});
            this.roleCombo.Location = new System.Drawing.Point(18, 338);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(310, 24);
            this.roleCombo.TabIndex = 16;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(18, 405);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(135, 56);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(18, 91);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(310, 22);
            this.idTxtBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Id:";
            // 
            // deleteIdTxtBox
            // 
            this.deleteIdTxtBox.Location = new System.Drawing.Point(385, 339);
            this.deleteIdTxtBox.Name = "deleteIdTxtBox";
            this.deleteIdTxtBox.Size = new System.Drawing.Size(263, 22);
            this.deleteIdTxtBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Id:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(447, 405);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(135, 56);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 503);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.deleteIdTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.departmentCombo);
            this.Controls.Add(this.doePicker);
            this.Controls.Add(this.employeePicBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.employeePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox employeePicBox;
        private System.Windows.Forms.DateTimePicker doePicker;
        private System.Windows.Forms.ComboBox departmentCombo;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deleteIdTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteBtn;
    }
}

