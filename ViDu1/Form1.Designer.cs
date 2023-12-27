
namespace ViDu1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMoAnh = new System.Windows.Forms.Button();
            this.btnGhiDL = new System.Windows.Forms.Button();
            this.btnAnhXam = new System.Windows.Forms.Button();
            this.btnLuuFileAnh = new System.Windows.Forms.Button();
            this.btnGhiGvaHg = new System.Windows.Forms.Button();
            this.btnChinhSangToi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnTaoVungTrang = new System.Windows.Forms.Button();
            this.btnAmBan = new System.Windows.Forms.Button();
            this.btnGianLuocDo = new System.Windows.Forms.Button();
            this.btnCanBangLuocDoXam = new System.Windows.Forms.Button();
            this.btnGhiHisAnh2 = new System.Windows.Forms.Button();
            this.btnTangTuongPhan = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTachNguong = new System.Windows.Forms.Button();
            this.btnTachNguongAnhXamAuto = new System.Windows.Forms.Button();
            this.btnNhanChap = new System.Windows.Forms.Button();
            this.btnLocTB = new System.Windows.Forms.Button();
            this.btnLocTrungVi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPrewitt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 469);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(431, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(356, 469);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnMoAnh
            // 
            this.btnMoAnh.Location = new System.Drawing.Point(26, 12);
            this.btnMoAnh.Name = "btnMoAnh";
            this.btnMoAnh.Size = new System.Drawing.Size(117, 46);
            this.btnMoAnh.TabIndex = 2;
            this.btnMoAnh.Text = "Mở ảnh";
            this.btnMoAnh.UseVisualStyleBackColor = true;
            this.btnMoAnh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGhiDL
            // 
            this.btnGhiDL.AutoSize = true;
            this.btnGhiDL.Location = new System.Drawing.Point(150, 12);
            this.btnGhiDL.Name = "btnGhiDL";
            this.btnGhiDL.Size = new System.Drawing.Size(166, 45);
            this.btnGhiDL.TabIndex = 3;
            this.btnGhiDL.Text = "Ghi dữ liệu ra file text";
            this.btnGhiDL.UseVisualStyleBackColor = true;
            this.btnGhiDL.Click += new System.EventHandler(this.btnGhiDL_Click);
            // 
            // btnAnhXam
            // 
            this.btnAnhXam.Location = new System.Drawing.Point(323, 12);
            this.btnAnhXam.Name = "btnAnhXam";
            this.btnAnhXam.Size = new System.Drawing.Size(180, 45);
            this.btnAnhXam.TabIndex = 4;
            this.btnAnhXam.Text = "Chuyển sang ảnh xám";
            this.btnAnhXam.UseVisualStyleBackColor = true;
            this.btnAnhXam.Click += new System.EventHandler(this.btnAnhXam_Click);
            // 
            // btnLuuFileAnh
            // 
            this.btnLuuFileAnh.Location = new System.Drawing.Point(510, 12);
            this.btnLuuFileAnh.Name = "btnLuuFileAnh";
            this.btnLuuFileAnh.Size = new System.Drawing.Size(155, 45);
            this.btnLuuFileAnh.TabIndex = 5;
            this.btnLuuFileAnh.Text = "Ghi ra file ảnh";
            this.btnLuuFileAnh.UseVisualStyleBackColor = true;
            this.btnLuuFileAnh.Click += new System.EventHandler(this.btnLuuFileAnh_Click);
            // 
            // btnGhiGvaHg
            // 
            this.btnGhiGvaHg.Location = new System.Drawing.Point(672, 12);
            this.btnGhiGvaHg.Name = "btnGhiGvaHg";
            this.btnGhiGvaHg.Size = new System.Drawing.Size(130, 45);
            this.btnGhiGvaHg.TabIndex = 6;
            this.btnGhiGvaHg.Text = "Ghi Histogram";
            this.btnGhiGvaHg.UseVisualStyleBackColor = true;
            this.btnGhiGvaHg.Click += new System.EventHandler(this.btnGhiGvaHg_Click);
            // 
            // btnChinhSangToi
            // 
            this.btnChinhSangToi.Location = new System.Drawing.Point(827, 70);
            this.btnChinhSangToi.Name = "btnChinhSangToi";
            this.btnChinhSangToi.Size = new System.Drawing.Size(184, 43);
            this.btnChinhSangToi.TabIndex = 7;
            this.btnChinhSangToi.Text = "Chính sáng tối";
            this.btnChinhSangToi.UseVisualStyleBackColor = true;
            this.btnChinhSangToi.Click += new System.EventHandler(this.btnChinhSangToi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập c:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(892, 22);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(119, 26);
            this.txtC.TabIndex = 9;
            // 
            // btnTaoVungTrang
            // 
            this.btnTaoVungTrang.Location = new System.Drawing.Point(827, 161);
            this.btnTaoVungTrang.Name = "btnTaoVungTrang";
            this.btnTaoVungTrang.Size = new System.Drawing.Size(184, 36);
            this.btnTaoVungTrang.TabIndex = 10;
            this.btnTaoVungTrang.Text = "Tạo vùng trắng";
            this.btnTaoVungTrang.UseVisualStyleBackColor = true;
            this.btnTaoVungTrang.Click += new System.EventHandler(this.btnTaoVungTrang_Click);
            // 
            // btnAmBan
            // 
            this.btnAmBan.Location = new System.Drawing.Point(827, 119);
            this.btnAmBan.Name = "btnAmBan";
            this.btnAmBan.Size = new System.Drawing.Size(184, 36);
            this.btnAmBan.TabIndex = 10;
            this.btnAmBan.Text = "Âm bản";
            this.btnAmBan.UseVisualStyleBackColor = true;
            this.btnAmBan.Click += new System.EventHandler(this.btnAmBan_Click);
            // 
            // btnGianLuocDo
            // 
            this.btnGianLuocDo.Location = new System.Drawing.Point(827, 203);
            this.btnGianLuocDo.Name = "btnGianLuocDo";
            this.btnGianLuocDo.Size = new System.Drawing.Size(184, 41);
            this.btnGianLuocDo.TabIndex = 11;
            this.btnGianLuocDo.Text = "Giãn lược đồ";
            this.btnGianLuocDo.UseVisualStyleBackColor = true;
            this.btnGianLuocDo.Click += new System.EventHandler(this.btnGianLuocDo_Click);
            // 
            // btnCanBangLuocDoXam
            // 
            this.btnCanBangLuocDoXam.Location = new System.Drawing.Point(827, 250);
            this.btnCanBangLuocDoXam.Name = "btnCanBangLuocDoXam";
            this.btnCanBangLuocDoXam.Size = new System.Drawing.Size(184, 41);
            this.btnCanBangLuocDoXam.TabIndex = 12;
            this.btnCanBangLuocDoXam.Text = "Cân bằng lược đồ xám";
            this.btnCanBangLuocDoXam.UseVisualStyleBackColor = true;
            this.btnCanBangLuocDoXam.Click += new System.EventHandler(this.btnCanBangLuocDoXam_Click);
            // 
            // btnGhiHisAnh2
            // 
            this.btnGhiHisAnh2.Location = new System.Drawing.Point(26, 573);
            this.btnGhiHisAnh2.Name = "btnGhiHisAnh2";
            this.btnGhiHisAnh2.Size = new System.Drawing.Size(167, 38);
            this.btnGhiHisAnh2.TabIndex = 13;
            this.btnGhiHisAnh2.Text = "Ghi Histogram ảnh 2";
            this.btnGhiHisAnh2.UseVisualStyleBackColor = true;
            this.btnGhiHisAnh2.Click += new System.EventHandler(this.btnGhiHisAnh2_Click);
            // 
            // btnTangTuongPhan
            // 
            this.btnTangTuongPhan.Location = new System.Drawing.Point(295, 573);
            this.btnTangTuongPhan.Name = "btnTangTuongPhan";
            this.btnTangTuongPhan.Size = new System.Drawing.Size(184, 37);
            this.btnTangTuongPhan.TabIndex = 14;
            this.btnTangTuongPhan.Text = "Tăng độ tương phản";
            this.btnTangTuongPhan.UseVisualStyleBackColor = true;
            this.btnTangTuongPhan.Click += new System.EventHandler(this.btnTangTuongPhan_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 649);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(223, 561);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(66, 26);
            this.txtA.TabIndex = 16;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(223, 593);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(65, 26);
            this.txtB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 593);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "b";
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(485, 579);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.Size = new System.Drawing.Size(100, 26);
            this.txtTheta.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Theta";
            // 
            // btnTachNguong
            // 
            this.btnTachNguong.Location = new System.Drawing.Point(600, 564);
            this.btnTachNguong.Name = "btnTachNguong";
            this.btnTachNguong.Size = new System.Drawing.Size(126, 55);
            this.btnTachNguong.TabIndex = 20;
            this.btnTachNguong.Text = "Tách ngưỡng ảnh xám";
            this.btnTachNguong.UseVisualStyleBackColor = true;
            this.btnTachNguong.Click += new System.EventHandler(this.btnTachNguong_Click);
            // 
            // btnTachNguongAnhXamAuto
            // 
            this.btnTachNguongAnhXamAuto.Location = new System.Drawing.Point(827, 298);
            this.btnTachNguongAnhXamAuto.Name = "btnTachNguongAnhXamAuto";
            this.btnTachNguongAnhXamAuto.Size = new System.Drawing.Size(184, 53);
            this.btnTachNguongAnhXamAuto.TabIndex = 21;
            this.btnTachNguongAnhXamAuto.Text = "Tách ngưỡng ảnh xám auto";
            this.btnTachNguongAnhXamAuto.UseVisualStyleBackColor = true;
            this.btnTachNguongAnhXamAuto.Click += new System.EventHandler(this.btnTachNguongAnhXamAuto_Click);
            // 
            // btnNhanChap
            // 
            this.btnNhanChap.Location = new System.Drawing.Point(827, 357);
            this.btnNhanChap.Name = "btnNhanChap";
            this.btnNhanChap.Size = new System.Drawing.Size(181, 46);
            this.btnNhanChap.TabIndex = 22;
            this.btnNhanChap.Text = "Nhân chập ";
            this.btnNhanChap.UseVisualStyleBackColor = true;
            this.btnNhanChap.Click += new System.EventHandler(this.btnNhanChap_Click);
            // 
            // btnLocTB
            // 
            this.btnLocTB.Location = new System.Drawing.Point(827, 409);
            this.btnLocTB.Name = "btnLocTB";
            this.btnLocTB.Size = new System.Drawing.Size(181, 41);
            this.btnLocTB.TabIndex = 23;
            this.btnLocTB.Text = "Lọc trung bình";
            this.btnLocTB.UseVisualStyleBackColor = true;
            this.btnLocTB.Click += new System.EventHandler(this.btnLocTB_Click);
            // 
            // btnLocTrungVi
            // 
            this.btnLocTrungVi.Location = new System.Drawing.Point(827, 465);
            this.btnLocTrungVi.Name = "btnLocTrungVi";
            this.btnLocTrungVi.Size = new System.Drawing.Size(181, 39);
            this.btnLocTrungVi.TabIndex = 24;
            this.btnLocTrungVi.Text = "Lọc trung vị";
            this.btnLocTrungVi.UseVisualStyleBackColor = true;
            this.btnLocTrungVi.Click += new System.EventHandler(this.btnLocTrungVi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Robert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPrewitt
            // 
            this.btnPrewitt.Location = new System.Drawing.Point(827, 560);
            this.btnPrewitt.Name = "btnPrewitt";
            this.btnPrewitt.Size = new System.Drawing.Size(181, 45);
            this.btnPrewitt.TabIndex = 26;
            this.btnPrewitt.Text = "Prewitt";
            this.btnPrewitt.UseVisualStyleBackColor = true;
            this.btnPrewitt.Click += new System.EventHandler(this.btnPrewitt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 649);
            this.Controls.Add(this.btnPrewitt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLocTrungVi);
            this.Controls.Add(this.btnLocTB);
            this.Controls.Add(this.btnNhanChap);
            this.Controls.Add(this.btnTachNguongAnhXamAuto);
            this.Controls.Add(this.btnTachNguong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTheta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnTangTuongPhan);
            this.Controls.Add(this.btnGhiHisAnh2);
            this.Controls.Add(this.btnCanBangLuocDoXam);
            this.Controls.Add(this.btnGianLuocDo);
            this.Controls.Add(this.btnAmBan);
            this.Controls.Add(this.btnTaoVungTrang);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChinhSangToi);
            this.Controls.Add(this.btnGhiGvaHg);
            this.Controls.Add(this.btnLuuFileAnh);
            this.Controls.Add(this.btnAnhXam);
            this.Controls.Add(this.btnGhiDL);
            this.Controls.Add(this.btnMoAnh);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMoAnh;
        private System.Windows.Forms.Button btnGhiDL;
        private System.Windows.Forms.Button btnAnhXam;
        private System.Windows.Forms.Button btnLuuFileAnh;
        private System.Windows.Forms.Button btnGhiGvaHg;
        private System.Windows.Forms.Button btnChinhSangToi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnTaoVungTrang;
        private System.Windows.Forms.Button btnAmBan;
        private System.Windows.Forms.Button btnGianLuocDo;
        private System.Windows.Forms.Button btnCanBangLuocDoXam;
        private System.Windows.Forms.Button btnGhiHisAnh2;
        private System.Windows.Forms.Button btnTangTuongPhan;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTachNguong;
        private System.Windows.Forms.Button btnTachNguongAnhXamAuto;
        private System.Windows.Forms.Button btnNhanChap;
        private System.Windows.Forms.Button btnLocTB;
        private System.Windows.Forms.Button btnLocTrungVi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPrewitt;
    }
}

