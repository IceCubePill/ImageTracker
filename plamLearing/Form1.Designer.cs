namespace plamLearing
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.img_imagebox = new Emgu.CV.UI.ImageBox();
            this.btn_cache = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reless = new System.Windows.Forms.Button();
            this.btn_openCapture = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_loadImage = new System.Windows.Forms.Button();
            this.btn_recoglizer = new System.Windows.Forms.Button();
            this.btn_faceClassfier = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_outLine = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_imagebox
            // 
            this.img_imagebox.Location = new System.Drawing.Point(4, 2);
            this.img_imagebox.Name = "img_imagebox";
            this.img_imagebox.Size = new System.Drawing.Size(367, 356);
            this.img_imagebox.TabIndex = 2;
            this.img_imagebox.TabStop = false;
            // 
            // btn_cache
            // 
            this.btn_cache.Location = new System.Drawing.Point(84, 3);
            this.btn_cache.Name = "btn_cache";
            this.btn_cache.Size = new System.Drawing.Size(75, 23);
            this.btn_cache.TabIndex = 3;
            this.btn_cache.Text = "捕捉";
            this.btn_cache.UseVisualStyleBackColor = true;
            this.btn_cache.Click += new System.EventHandler(this.btn_cache_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_reless);
            this.panel1.Controls.Add(this.btn_openCapture);
            this.panel1.Controls.Add(this.btn_cache);
            this.panel1.Location = new System.Drawing.Point(374, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 30);
            this.panel1.TabIndex = 4;
            // 
            // btn_reless
            // 
            this.btn_reless.Location = new System.Drawing.Point(165, 3);
            this.btn_reless.Name = "btn_reless";
            this.btn_reless.Size = new System.Drawing.Size(75, 23);
            this.btn_reless.TabIndex = 5;
            this.btn_reless.Text = "释放";
            this.btn_reless.UseVisualStyleBackColor = true;
            this.btn_reless.Click += new System.EventHandler(this.btn_reless_Click);
            // 
            // btn_openCapture
            // 
            this.btn_openCapture.Location = new System.Drawing.Point(3, 3);
            this.btn_openCapture.Name = "btn_openCapture";
            this.btn_openCapture.Size = new System.Drawing.Size(75, 23);
            this.btn_openCapture.TabIndex = 4;
            this.btn_openCapture.Text = "开启摄像头";
            this.btn_openCapture.UseVisualStyleBackColor = true;
            this.btn_openCapture.Click += new System.EventHandler(this.btn_openCapture_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_loadImage);
            this.panel2.Controls.Add(this.btn_recoglizer);
            this.panel2.Controls.Add(this.btn_faceClassfier);
            this.panel2.Location = new System.Drawing.Point(374, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 30);
            this.panel2.TabIndex = 6;
            // 
            // btn_loadImage
            // 
            this.btn_loadImage.Location = new System.Drawing.Point(165, 3);
            this.btn_loadImage.Name = "btn_loadImage";
            this.btn_loadImage.Size = new System.Drawing.Size(75, 23);
            this.btn_loadImage.TabIndex = 5;
            this.btn_loadImage.Text = "加载图片";
            this.btn_loadImage.UseVisualStyleBackColor = true;
            this.btn_loadImage.Click += new System.EventHandler(this.btn_loadImage_Click);
            // 
            // btn_recoglizer
            // 
            this.btn_recoglizer.Location = new System.Drawing.Point(3, 3);
            this.btn_recoglizer.Name = "btn_recoglizer";
            this.btn_recoglizer.Size = new System.Drawing.Size(75, 23);
            this.btn_recoglizer.TabIndex = 4;
            this.btn_recoglizer.Text = "识别";
            this.btn_recoglizer.UseVisualStyleBackColor = true;
            this.btn_recoglizer.Click += new System.EventHandler(this.btn_recoglizer_Click);
            // 
            // btn_faceClassfier
            // 
            this.btn_faceClassfier.Location = new System.Drawing.Point(84, 3);
            this.btn_faceClassfier.Name = "btn_faceClassfier";
            this.btn_faceClassfier.Size = new System.Drawing.Size(75, 23);
            this.btn_faceClassfier.TabIndex = 3;
            this.btn_faceClassfier.Text = "人脸识别";
            this.btn_faceClassfier.UseVisualStyleBackColor = true;
            this.btn_faceClassfier.Click += new System.EventHandler(this.btn_faceClassfier_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_outLine);
            this.panel3.Controls.Add(this.btn);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(374, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 30);
            this.panel3.TabIndex = 7;
            // 
            // btn_outLine
            // 
            this.btn_outLine.Location = new System.Drawing.Point(165, 3);
            this.btn_outLine.Name = "btn_outLine";
            this.btn_outLine.Size = new System.Drawing.Size(75, 23);
            this.btn_outLine.TabIndex = 5;
            this.btn_outLine.Text = "？？";
            this.btn_outLine.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(3, 3);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "??";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "边缘化";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_egde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_imagebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_imagebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox img_imagebox;
        private System.Windows.Forms.Button btn_cache;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reless;
        private System.Windows.Forms.Button btn_openCapture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_loadImage;
        private System.Windows.Forms.Button btn_recoglizer;
        private System.Windows.Forms.Button btn_faceClassfier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_outLine;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button3;
    }
}

