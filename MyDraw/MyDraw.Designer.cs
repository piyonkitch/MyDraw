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
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonFill = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(533, 500);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(0, 508);
            this.textBoxConsole.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(640, 138);
            this.textBoxConsole.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(541, 0);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(100, 44);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // buttonSupport
            // 
            this.buttonSupport.Location = new System.Drawing.Point(541, 51);
            this.buttonSupport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSupport.Name = "buttonSupport";
            this.buttonSupport.Size = new System.Drawing.Size(100, 44);
            this.buttonSupport.TabIndex = 3;
            this.buttonSupport.Text = "Support Line";
            this.buttonSupport.UseVisualStyleBackColor = true;
            this.buttonSupport.Click += new System.EventHandler(this.ButtonSupport_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStatus.Location = new System.Drawing.Point(0, 654);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(111, 22);
            this.textBoxStatus.TabIndex = 4;
            // 
            // picObjectMotion
            // 
            this.picObjectMotion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picObjectMotion.Location = new System.Drawing.Point(675, 0);
            this.picObjectMotion.Margin = new System.Windows.Forms.Padding(4);
            this.picObjectMotion.Name = "picObjectMotion";
            this.picObjectMotion.Size = new System.Drawing.Size(533, 500);
            this.picObjectMotion.TabIndex = 5;
            this.picObjectMotion.TabStop = false;
            // 
            // buttonObjectMotion
            // 
            this.buttonObjectMotion.Location = new System.Drawing.Point(541, 209);
            this.buttonObjectMotion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObjectMotion.Name = "buttonObjectMotion";
            this.buttonObjectMotion.Size = new System.Drawing.Size(100, 44);
            this.buttonObjectMotion.TabIndex = 6;
            this.buttonObjectMotion.Text = "Support Line";
            this.buttonObjectMotion.UseVisualStyleBackColor = true;
            this.buttonObjectMotion.Click += new System.EventHandler(this.ButtonObjectMotion_Click);
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(4, 15);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(82, 19);
            this.radioButtonSim.TabIndex = 7;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Simulate";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // radioButtonFill
            // 
            this.radioButtonFill.AutoSize = true;
            this.radioButtonFill.Location = new System.Drawing.Point(4, 41);
            this.radioButtonFill.Name = "radioButtonFill";
            this.radioButtonFill.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFill.TabIndex = 8;
            this.radioButtonFill.TabStop = true;
            this.radioButtonFill.Text = "Fill";
            this.radioButtonFill.UseVisualStyleBackColor = true;
            this.radioButtonFill.CheckedChanged += new System.EventHandler(this.radioButtonFill_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonSim);
            this.panel1.Controls.Add(this.radioButtonFill);
            this.panel1.Location = new System.Drawing.Point(675, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 138);
            this.panel1.TabIndex = 9;
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonObjectMotion);
            this.Controls.Add(this.picObjectMotion);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSupport);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyDraw";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.RadioButton radioButtonFill;
        private System.Windows.Forms.Panel panel1;
    }
}

