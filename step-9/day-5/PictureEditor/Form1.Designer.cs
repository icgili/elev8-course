
namespace PictureEditor
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.selectPictureBtn = new System.Windows.Forms.Button();
            this.openSelectPicDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.undoBtn = new System.Windows.Forms.Button();
            this.redoBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectColorBtn = new System.Windows.Forms.Button();
            this.grayscaleBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saturationTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.brightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(319, 76);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(763, 478);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // selectPictureBtn
            // 
            this.selectPictureBtn.Location = new System.Drawing.Point(913, 12);
            this.selectPictureBtn.Name = "selectPictureBtn";
            this.selectPictureBtn.Size = new System.Drawing.Size(169, 58);
            this.selectPictureBtn.TabIndex = 1;
            this.selectPictureBtn.Text = "Select Picture";
            this.selectPictureBtn.UseVisualStyleBackColor = true;
            this.selectPictureBtn.Click += new System.EventHandler(this.selectPictureBtn_Click);
            // 
            // openSelectPicDialog
            // 
            this.openSelectPicDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "EasyEditor";
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(319, 9);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(169, 58);
            this.undoBtn.TabIndex = 4;
            this.undoBtn.Text = "Undo";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.Location = new System.Drawing.Point(494, 9);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(169, 58);
            this.redoBtn.TabIndex = 5;
            this.redoBtn.Text = "Redo";
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectColorBtn);
            this.panel1.Controls.Add(this.grayscaleBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.saturationTrackBar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.brightnessTrackBar);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 478);
            this.panel1.TabIndex = 7;
            // 
            // selectColorBtn
            // 
            this.selectColorBtn.Location = new System.Drawing.Point(21, 404);
            this.selectColorBtn.Name = "selectColorBtn";
            this.selectColorBtn.Size = new System.Drawing.Size(264, 46);
            this.selectColorBtn.TabIndex = 6;
            this.selectColorBtn.Text = "Color Filter";
            this.selectColorBtn.UseVisualStyleBackColor = true;
            this.selectColorBtn.Click += new System.EventHandler(this.selectColorBtn_Click);
            // 
            // grayscaleBtn
            // 
            this.grayscaleBtn.Location = new System.Drawing.Point(21, 324);
            this.grayscaleBtn.Name = "grayscaleBtn";
            this.grayscaleBtn.Size = new System.Drawing.Size(264, 46);
            this.grayscaleBtn.TabIndex = 4;
            this.grayscaleBtn.Text = "Grayscale";
            this.grayscaleBtn.UseVisualStyleBackColor = true;
            this.grayscaleBtn.Click += new System.EventHandler(this.grayscaleBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saturation";
            // 
            // saturationTrackBar
            // 
            this.saturationTrackBar.Location = new System.Drawing.Point(9, 217);
            this.saturationTrackBar.Name = "saturationTrackBar";
            this.saturationTrackBar.Size = new System.Drawing.Size(289, 56);
            this.saturationTrackBar.TabIndex = 2;
            this.saturationTrackBar.ValueChanged += new System.EventHandler(this.saturationTrackBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Brightness";
            // 
            // brightnessTrackBar
            // 
            this.brightnessTrackBar.Location = new System.Drawing.Point(9, 85);
            this.brightnessTrackBar.Name = "brightnessTrackBar";
            this.brightnessTrackBar.Size = new System.Drawing.Size(289, 56);
            this.brightnessTrackBar.TabIndex = 0;
            this.brightnessTrackBar.ValueChanged += new System.EventHandler(this.brightnessTrackBar_ValueChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(669, 9);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(169, 58);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear All";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 566);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.redoBtn);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPictureBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button selectPictureBtn;
        private System.Windows.Forms.OpenFileDialog openSelectPicDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button grayscaleBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar saturationTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar brightnessTrackBar;
        private System.Windows.Forms.Button selectColorBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button clearBtn;
    }
}

