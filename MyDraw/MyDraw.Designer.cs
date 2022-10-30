namespace MyDraw
{
    partial class MyDraw
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSupport = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.picObjectMotion = new System.Windows.Forms.PictureBox();
            this.buttonObjectMotion = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(400, 400);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(0, 406);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(481, 111);
            this.textBoxConsole.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(406, 0);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 35);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.Location = new System.Drawing.Point(406, 41);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(75, 35);
            this.buttonSupport.TabIndex = 3;
            this.buttonSupport.Text = "Support Line";
            this.buttonSupport.UseVisualStyleBackColor = true;
            this.buttonSupport.Click += new System.EventHandler(this.ButtonSupport_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStatus.Location = new System.Drawing.Point(0, 523);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(84, 19);
            this.textBoxStatus.TabIndex = 4;
            // 
            // picObjectMotion
            // 
            this.picObjectMotion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picObjectMotion.Location = new System.Drawing.Point(506, 0);
            this.picObjectMotion.Name = "picObjectMotion";
            this.picObjectMotion.Size = new System.Drawing.Size(400, 400);
            this.picObjectMotion.TabIndex = 5;
            this.picObjectMotion.TabStop = false;
            // 
            // buttonObjectMotion
            // 
            this.buttonObjectMotion.Location = new System.Drawing.Point(406, 167);
            this.buttonObjectMotion.Name = "buttonObjectMotion";
            this.buttonObjectMotion.Size = new System.Drawing.Size(75, 35);
            this.buttonObjectMotion.TabIndex = 6;
            this.buttonObjectMotion.Text = "Support Line";
            this.buttonObjectMotion.UseVisualStyleBackColor = true;
            this.buttonObjectMotion.Click += new System.EventHandler(this.ButtonObjectMotion_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(506, 407);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 541);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.buttonObjectMotion);
            this.Controls.Add(this.picObjectMotion);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.pic);
            this.Name = "MyDraw";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSupport;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox picObjectMotion;
        private System.Windows.Forms.Button buttonObjectMotion;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

