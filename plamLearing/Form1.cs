using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace plamLearing
{
    public partial class Form1 : Form
    {
        //字段
        #region
        //是否打开摄像机
        private bool capturIsOpen = false;
        //是否暂停摄像机
        private bool isStop = true;
        
        private VideoCapture capture;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        //UI事件函数
        #region
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (capturIsOpen&&!isStop)
            {
                img_imagebox.Image = capture.QueryFrame();
            }
        }

      

        private void btn_openCapture_Click(object sender, EventArgs e)
        {
            openCammer();
        }

        private void btn_reless_Click(object sender, EventArgs e)
        {
            if (capturIsOpen && isStop)
            {
                isStop = false;

            }
        }

        private void btn_cache_Click(object sender, EventArgs e)
        {
            isStop = true;
        }

        private void btn_recoglizer_Click(object sender, EventArgs e)
        {
            if (img_imagebox.Image!=null && isStop)
            {
                gestureRecoglizer();
            }
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "bmp文件|*.bmp|jpg文件|*.jpg|png文件|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string str_imagePath = fd.FileName;
                img_imagebox.Image = new Image<Bgr, Byte>(str_imagePath);
            }

        }

        private void btn_egde_Click(object sender, EventArgs e)
        {
            if (isStop && img_imagebox.Image != null)
            {
                img_imagebox.Image = new Image<Gray, Byte>(img_imagebox.Image.Bitmap).Canny(60, 120);

            }
        }

      

        #endregion

        //自定义函数
        #region
        /// <summary>
        /// 打开摄像机
        /// </summary>
        private void openCammer()
        {
            capture = new VideoCapture();
            if (capture == null)
            {
                MessageBox.Show("请链接一台摄像机");
                return;
            }
            capturIsOpen = true;
            isStop = false;
        }
        /// <summary>
        /// 手势识别
        /// </summary>
        private void gestureRecoglizer()
        {
            if (img_imagebox.Image==null)
            {
                MessageBox.Show("请选择加载要识别的图片");
                return;
            }
            CascadeClassifier plamClassifier = new CascadeClassifier(@"data\palm.dat");
            CascadeClassifier fistcClassifier = new CascadeClassifier(@"data\fist.dat");

            Image<Gray,Byte> grayImage=new Image<Gray, byte>(img_imagebox.Image.Bitmap);
            Rectangle[] plamRectangles = plamClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
            Rectangle[] fistRectangles = fistcClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

            //测试程序
            Image<Bgr, Byte> outPutImage = new Image<Bgr, byte>(img_imagebox.Image.Bitmap);
            if (plamRectangles.Length == 0)
                MessageBox.Show("no plam");
            if (fistRectangles.Length == 0)
                MessageBox.Show("no fist");
            foreach (Rectangle rect in plamRectangles)
            {
                outPutImage.Draw(rect,new Bgr(0,0,255));
            }
            foreach (Rectangle rect in fistRectangles)
            {
                outPutImage.Draw(rect, new Bgr(0,255,0));
            }
            img_imagebox.Image = outPutImage;
        }

        #endregion

        private void btn_faceClassfier_Click(object sender, EventArgs e)
        {
            CascadeClassifier faceClassifier = new CascadeClassifier(@"data\haarcascade_frontalface_default.xml");
            Image<Gray, Byte> grayImage = new Image<Gray, byte>(img_imagebox.Image.Bitmap);
            Image<Bgr,Byte> outPutImage= new Image<Bgr, byte>(img_imagebox.Image.Bitmap);
            Rectangle[] faceRectangles = faceClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
            if (faceRectangles.Length == 0)
                MessageBox.Show("no face");
            foreach (Rectangle rect in faceRectangles)
            {
                outPutImage.Draw(rect, new Bgr(255, 0, 0));
            }
            img_imagebox.Image = outPutImage;
        }
    }
}
