namespace 仿照image
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Reduction = new System.Windows.Forms.Button();
            this.button_Saveas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_RGB = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Saveas);
            this.groupBox1.Controls.Add(this.button_Reduction);
            this.groupBox1.Controls.Add(this.button_Save);
            this.groupBox1.Controls.Add(this.button_Open);
            this.groupBox1.Location = new System.Drawing.Point(571, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存取操作";
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(22, 20);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(58, 25);
            this.button_Open.TabIndex = 0;
            this.button_Open.Text = "打开";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(127, 20);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(58, 25);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "保存";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Reduction
            // 
            this.button_Reduction.Location = new System.Drawing.Point(22, 62);
            this.button_Reduction.Name = "button_Reduction";
            this.button_Reduction.Size = new System.Drawing.Size(58, 25);
            this.button_Reduction.TabIndex = 2;
            this.button_Reduction.Text = "还原";
            this.button_Reduction.UseVisualStyleBackColor = true;
            this.button_Reduction.Click += new System.EventHandler(this.button_Reduction_Click);
            // 
            // button_Saveas
            // 
            this.button_Saveas.Location = new System.Drawing.Point(127, 62);
            this.button_Saveas.Name = "button_Saveas";
            this.button_Saveas.Size = new System.Drawing.Size(58, 25);
            this.button_Saveas.TabIndex = 3;
            this.button_Saveas.Text = "另存为";
            this.button_Saveas.UseVisualStyleBackColor = true;
            this.button_Saveas.Click += new System.EventHandler(this.button_Saveas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(571, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "旋转与反转";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "左右";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "上下";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(127, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 25);
            this.button3.TabIndex = 1;
            this.button3.Text = "逆时针90";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 25);
            this.button4.TabIndex = 0;
            this.button4.Text = "顺时针90";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Confirm);
            this.groupBox3.Controls.Add(this.textBox_B);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_G);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_R);
            this.groupBox3.Controls.Add(this.button_RGB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(571, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图片处理";
            // 
            // button_RGB
            // 
            this.button_RGB.Location = new System.Drawing.Point(64, 10);
            this.button_RGB.Name = "button_RGB";
            this.button_RGB.Size = new System.Drawing.Size(75, 23);
            this.button_RGB.TabIndex = 0;
            this.button_RGB.Text = "灰度化";
            this.button_RGB.UseVisualStyleBackColor = true;
            this.button_RGB.Click += new System.EventHandler(this.button_RGB_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(64, 63);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 4;
            this.button_Confirm.Text = "确定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(27, 35);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.Size = new System.Drawing.Size(33, 21);
            this.textBox_R.TabIndex = 3;
            this.textBox_R.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "R";
            // 
            // textBox_G
            // 
            this.textBox_G.Location = new System.Drawing.Point(96, 36);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.Size = new System.Drawing.Size(33, 21);
            this.textBox_G.TabIndex = 5;
            this.textBox_G.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(74, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "G";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(160, 35);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(33, 21);
            this.textBox_B.TabIndex = 7;
            this.textBox_B.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(139, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Saveas;
        private System.Windows.Forms.Button button_Reduction;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_RGB;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.Label label3;
    }
}

