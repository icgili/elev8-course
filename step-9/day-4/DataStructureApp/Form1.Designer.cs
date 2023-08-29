
namespace DataStructureApp
{
    partial class Form1
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
            this.stackPanel = new System.Windows.Forms.Panel();
            this.downBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.stackListBox2 = new System.Windows.Forms.ListBox();
            this.stackListBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.enqueueBtn = new System.Windows.Forms.Button();
            this.dequeueBtn = new System.Windows.Forms.Button();
            this.queueListBox2 = new System.Windows.Forms.ListBox();
            this.queueListBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stackPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel
            // 
            this.stackPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stackPanel.Controls.Add(this.downBtn);
            this.stackPanel.Controls.Add(this.upBtn);
            this.stackPanel.Controls.Add(this.stackListBox2);
            this.stackPanel.Controls.Add(this.stackListBox1);
            this.stackPanel.Controls.Add(this.label1);
            this.stackPanel.Location = new System.Drawing.Point(12, 12);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(376, 426);
            this.stackPanel.TabIndex = 0;
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(74, 216);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(105, 38);
            this.downBtn.TabIndex = 5;
            this.downBtn.Text = "Arrow Down";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.StackTransferButton_Click);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(185, 216);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(105, 38);
            this.upBtn.TabIndex = 4;
            this.upBtn.Text = "Arrow Up";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.StackTransferButton_Click);
            // 
            // stackListBox2
            // 
            this.stackListBox2.FormattingEnabled = true;
            this.stackListBox2.ItemHeight = 16;
            this.stackListBox2.Location = new System.Drawing.Point(18, 278);
            this.stackListBox2.Name = "stackListBox2";
            this.stackListBox2.Size = new System.Drawing.Size(340, 132);
            this.stackListBox2.TabIndex = 2;
            // 
            // stackListBox1
            // 
            this.stackListBox1.FormattingEnabled = true;
            this.stackListBox1.ItemHeight = 16;
            this.stackListBox1.Location = new System.Drawing.Point(18, 61);
            this.stackListBox1.Name = "stackListBox1";
            this.stackListBox1.Size = new System.Drawing.Size(340, 132);
            this.stackListBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stack";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.enqueueBtn);
            this.panel2.Controls.Add(this.dequeueBtn);
            this.panel2.Controls.Add(this.queueListBox2);
            this.panel2.Controls.Add(this.queueListBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(412, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 426);
            this.panel2.TabIndex = 1;
            // 
            // enqueueBtn
            // 
            this.enqueueBtn.Location = new System.Drawing.Point(77, 219);
            this.enqueueBtn.Name = "enqueueBtn";
            this.enqueueBtn.Size = new System.Drawing.Size(105, 38);
            this.enqueueBtn.TabIndex = 10;
            this.enqueueBtn.Text = "Arrow Down";
            this.enqueueBtn.UseVisualStyleBackColor = true;
            this.enqueueBtn.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // dequeueBtn
            // 
            this.dequeueBtn.Location = new System.Drawing.Point(188, 219);
            this.dequeueBtn.Name = "dequeueBtn";
            this.dequeueBtn.Size = new System.Drawing.Size(105, 38);
            this.dequeueBtn.TabIndex = 9;
            this.dequeueBtn.Text = "Arrow Up";
            this.dequeueBtn.UseVisualStyleBackColor = true;
            this.dequeueBtn.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // queueListBox2
            // 
            this.queueListBox2.FormattingEnabled = true;
            this.queueListBox2.ItemHeight = 16;
            this.queueListBox2.Location = new System.Drawing.Point(21, 281);
            this.queueListBox2.Name = "queueListBox2";
            this.queueListBox2.Size = new System.Drawing.Size(340, 132);
            this.queueListBox2.TabIndex = 8;
            // 
            // queueListBox1
            // 
            this.queueListBox1.FormattingEnabled = true;
            this.queueListBox1.ItemHeight = 16;
            this.queueListBox1.Location = new System.Drawing.Point(21, 64);
            this.queueListBox1.Name = "queueListBox1";
            this.queueListBox1.Size = new System.Drawing.Size(340, 132);
            this.queueListBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Queue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stackPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stackPanel.ResumeLayout(false);
            this.stackPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel stackPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.ListBox stackListBox2;
        private System.Windows.Forms.ListBox stackListBox1;
        private System.Windows.Forms.Button enqueueBtn;
        private System.Windows.Forms.Button dequeueBtn;
        private System.Windows.Forms.ListBox queueListBox2;
        private System.Windows.Forms.ListBox queueListBox1;
        private System.Windows.Forms.Label label2;
    }
}

