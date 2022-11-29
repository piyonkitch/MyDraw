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
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.picObjectMotion = new System.Windows.Forms.PictureBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonFill = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonHeat = new System.Windows.Forms.RadioButton();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxAutoSort = new System.Windows.Forms.CheckBox();
            this.checkBoxSupport = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panel2.SuspendLayout();
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
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(4, 15);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(86, 20);
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
            this.radioButtonFill.Size = new System.Drawing.Size(49, 20);
            this.radioButtonFill.TabIndex = 8;
            this.radioButtonFill.TabStop = true;
            this.radioButtonFill.Text = "Fill";
            this.radioButtonFill.UseVisualStyleBackColor = true;
            this.radioButtonFill.CheckedChanged += new System.EventHandler(this.radioButtonFill_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonHeat);
            this.panel1.Controls.Add(this.radioButtonSim);
            this.panel1.Controls.Add(this.radioButtonFill);
            this.panel1.Location = new System.Drawing.Point(675, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 138);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonHeat
            // 
            this.radioButtonHeat.AutoSize = true;
            this.radioButtonHeat.Location = new System.Drawing.Point(4, 67);
            this.radioButtonHeat.Name = "radioButtonHeat";
            this.radioButtonHeat.Size = new System.Drawing.Size(92, 20);
            this.radioButtonHeat.TabIndex = 14;
            this.radioButtonHeat.TabStop = true;
            this.radioButtonHeat.Text = "Heat Map";
            this.radioButtonHeat.UseVisualStyleBackColor = true;
            this.radioButtonHeat.CheckedChanged += new System.EventHandler(this.radioButtonHeat_CheckedChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(11, 3);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(105, 69);
            this.trackBarSpeed.TabIndex = 10;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(122, 18);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(124, 22);
            this.textBoxSpeed.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxAutoSort);
            this.panel2.Controls.Add(this.trackBarSpeed);
            this.panel2.Controls.Add(this.textBoxSpeed);
            this.panel2.Location = new System.Drawing.Point(873, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 101);
            this.panel2.TabIndex = 12;
            // 
            // checkBoxAutoSort
            // 
            this.checkBoxAutoSort.AutoSize = true;
            this.checkBoxAutoSort.Location = new System.Drawing.Point(21, 68);
            this.checkBoxAutoSort.Name = "checkBoxAutoSort";
            this.checkBoxAutoSort.Size = new System.Drawing.Size(95, 21);
            this.checkBoxAutoSort.TabIndex = 14;
            this.checkBoxAutoSort.Text = "Auto Sort";
            this.checkBoxAutoSort.UseVisualStyleBackColor = true;
            this.checkBoxAutoSort.CheckedChanged += new System.EventHandler(this.checkBoxAutoSort_CheckedChanged);
            // 
            // checkBoxSupport
            // 
            this.checkBoxSupport.AutoSize = true;
            this.checkBoxSupport.Location = new System.Drawing.Point(540, 154);
            this.checkBoxSupport.Name = "checkBoxSupport";
            this.checkBoxSupport.Size = new System.Drawing.Size(114, 21);
            this.checkBoxSupport.TabIndex = 13;
            this.checkBoxSupport.Text = "Support Line";
            this.checkBoxSupport.UseVisualStyleBackColor = true;
            this.checkBoxSupport.CheckedChanged += new System.EventHandler(this.checkBoxSupport_CheckedChanged);
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 676);
            this.Controls.Add(this.checkBoxSupport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picObjectMotion);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyDraw";
            this.Text = "MyDraw";
            this.Load += new System.EventHandler(this.MyDraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox picObjectMotion;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.RadioButton radioButtonFill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxSupport;
        private System.Windows.Forms.RadioButton radioButtonHeat;
        private System.Windows.Forms.CheckBox checkBoxAutoSort;
    }
}

