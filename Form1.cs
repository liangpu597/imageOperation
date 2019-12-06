using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace 仿照image
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        private Bitmap curImg;
        private Bitmap origin;
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                //将图片显示在imageBox上的几种方法
                fileName = file.FileName;
                //pictureBox1.Image = Image.FromFile(file.FileName);   //方法一： 从文件中进行显示
                 //注意 这样写是错误的 因为这里文件打开了没有进行关闭 后面的保存也会出现错误                                                    //pictureBox1.Image.Save(@"D:\1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);   这个可以进行保存

                //应该这样 从流中打开 这样 在打开完成后可以在流中进行关闭文件 后面才可以进行保存
                FileStream fs = File.OpenRead(fileName);
                origin = new Bitmap( Image.FromStream(fs));           //将其赋给一个bitmap 方便后续的修改操作
                fs.Close();
                pictureBox1.Image = origin;
                curImg = origin;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(fileName);
            //如果想要保存 需要知道文件的名字 所以在打开的时候 需要定义一个全局变量
            this.pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Saveas_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Jpg 图片|*.jpg|Bmp 图片|*.bmp|Gif 图片|*.gif|Png 图片|*.png|Wmf  图片|*.wmf";
            if (saveFile.ShowDialog() == DialogResult.OK)  //只有这一句才会打开文件选项框
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                
            }
        }

        private void button_Reduction_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = curImg;   //将其还原为先前保存的
                //curImg = new Bitmap(pictureBox1.Image);     //先前保存的改为现在的情况
            }
            else {
                MessageBox.Show("当前无图片", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Image temp = pictureBox1.Image;
            
            //temp.RotateFlip(RotateFlipType.Rotate90FlipNone);        //不能在pictureBox1 上面直接进行操作
            //pictureBox1.Image = temp;
            curImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = curImg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curImg.RotateFlip(RotateFlipType.Rotate270FlipNone);        //不能在pictureBox1 上面直接进行操作
            pictureBox1.Image = curImg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curImg.RotateFlip(RotateFlipType.Rotate180FlipX);        //不能在pictureBox1 上面直接进行操作
            pictureBox1.Image = curImg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curImg.RotateFlip(RotateFlipType.Rotate180FlipY);        //不能在pictureBox1 上面直接进行操作
            pictureBox1.Image = curImg;
        }

        private void button_RGB_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                ToGray(ref curImg);  //进行引用传递
                pictureBox1.Image = curImg;
            }
        }
        private void ToGray( ref Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; ++i)
                for (int j = 0; j < bmp.Height; ++j)
                {
                    Color color = bmp.GetPixel(i, j);
                    int gray = (int)(color.R * 0.30 + color.G * 0.58 + color.B * 0.12);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                }
        }
    }
}
