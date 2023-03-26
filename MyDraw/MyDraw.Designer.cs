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
            this.pictureBoxPallete = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonAddPoint = new System.Windows.Forms.RadioButton();
            this.radioButtonChangePoint = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObjectMotion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPallete)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(666, 600);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(0, 610);
            this.textBoxConsole.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(799, 165);
            this.textBoxConsole.TabIndex = 1;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(676, 0);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(125, 53);
            this.buttonSort.TabIndex = 2;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStatus.Location = new System.Drawing.Point(0, 785);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(138, 25);
            this.textBoxStatus.TabIndex = 4;
            // 
            // picObjectMotion
            // 
            this.picObjectMotion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picObjectMotion.Location = new System.Drawing.Point(844, 0);
            this.picObjectMotion.Margin = new System.Windows.Forms.Padding(5);
            this.picObjectMotion.Name = "picObjectMotion";
            this.picObjectMotion.Size = new System.Drawing.Size(666, 600);
            this.picObjectMotion.TabIndex = 5;
            this.picObjectMotion.TabStop = false;
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Checked = true;
            this.radioButtonSim.Location = new System.Drawing.Point(5, 18);
            this.radioButtonSim.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(98, 22);
            this.radioButtonSim.TabIndex = 7;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "Simulate";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // radioButtonFill
            // 
            this.radioButtonFill.AutoSize = true;
            this.radioButtonFill.Location = new System.Drawing.Point(5, 49);
            this.radioButtonFill.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFill.Name = "radioButtonFill";
            this.radioButtonFill.Size = new System.Drawing.Size(55, 22);
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
            this.panel1.Location = new System.Drawing.Point(844, 610);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 166);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonHeat
            // 
            this.radioButtonHeat.AutoSize = true;
            this.radioButtonHeat.Location = new System.Drawing.Point(5, 80);
            this.radioButtonHeat.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHeat.Name = "radioButtonHeat";
            this.radioButtonHeat.Size = new System.Drawing.Size(105, 22);
            this.radioButtonHeat.TabIndex = 14;
            this.radioButtonHeat.TabStop = true;
            this.radioButtonHeat.Text = "Heat Map";
            this.radioButtonHeat.UseVisualStyleBackColor = true;
            this.radioButtonHeat.CheckedChanged += new System.EventHandler(this.radioButtonHeat_CheckedChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(14, 4);
            this.trackBarSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(131, 69);
            this.trackBarSpeed.TabIndex = 10;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.TrackBarScroll);
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(152, 22);
            this.textBoxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(154, 25);
            this.textBoxSpeed.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBoxAutoSort);
            this.panel2.Controls.Add(this.trackBarSpeed);
            this.panel2.Controls.Add(this.textBoxSpeed);
            this.panel2.Location = new System.Drawing.Point(1091, 610);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 121);
            this.panel2.TabIndex = 12;
            // 
            // checkBoxAutoSort
            // 
            this.checkBoxAutoSort.AutoSize = true;
            this.checkBoxAutoSort.Location = new System.Drawing.Point(26, 82);
            this.checkBoxAutoSort.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoSort.Name = "checkBoxAutoSort";
            this.checkBoxAutoSort.Size = new System.Drawing.Size(106, 22);
            this.checkBoxAutoSort.TabIndex = 14;
            this.checkBoxAutoSort.Text = "Auto Sort";
            this.checkBoxAutoSort.UseVisualStyleBackColor = true;
            this.checkBoxAutoSort.CheckedChanged += new System.EventHandler(this.checkBoxAutoSort_CheckedChanged);
            // 
            // checkBoxSupport
            // 
            this.checkBoxSupport.AutoSize = true;
            this.checkBoxSupport.Location = new System.Drawing.Point(692, 339);
            this.checkBoxSupport.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxSupport.Name = "checkBoxSupport";
            this.checkBoxSupport.Size = new System.Drawing.Size(130, 22);
            this.checkBoxSupport.TabIndex = 13;
            this.checkBoxSupport.Text = "Support Line";
            this.checkBoxSupport.UseVisualStyleBackColor = true;
            this.checkBoxSupport.CheckedChanged += new System.EventHandler(this.checkBoxSupport_CheckedChanged);
            // 
            // pictureBoxPallete
            // 
            this.pictureBoxPallete.Location = new System.Drawing.Point(1091, 738);
            this.pictureBoxPallete.Name = "pictureBoxPallete";
            this.pictureBoxPallete.Size = new System.Drawing.Size(419, 38);
            this.pictureBoxPallete.TabIndex = 14;
            this.pictureBoxPallete.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonChangePoint);
            this.panel3.Controls.Add(this.radioButtonAddPoint);
            this.panel3.Location = new System.Drawing.Point(675, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 92);
            this.panel3.TabIndex = 15;
            // 
            // radioButtonAddPoint
            // 
            this.radioButtonAddPoint.AutoSize = true;
            this.radioButtonAddPoint.Checked = true;
            this.radioButtonAddPoint.Location = new System.Drawing.Point(17, 19);
            this.radioButtonAddPoint.Name = "radioButtonAddPoint";
            this.radioButtonAddPoint.Size = new System.Drawing.Size(106, 22);
            this.radioButtonAddPoint.TabIndex = 0;
            this.radioButtonAddPoint.TabStop = true;
            this.radioButtonAddPoint.Text = "Add Point";
            this.radioButtonAddPoint.UseVisualStyleBackColor = true;
            this.radioButtonAddPoint.CheckedChanged += new System.EventHandler(this.radioButtonAddPoint_CheckedChanged);
            // 
            // radioButtonChangePoint
            // 
            this.radioButtonChangePoint.AutoSize = true;
            this.radioButtonChangePoint.Location = new System.Drawing.Point(17, 47);
            this.radioButtonChangePoint.Name = "radioButtonChangePoint";
            this.radioButtonChangePoint.Size = new System.Drawing.Size(133, 22);
            this.radioButtonChangePoint.TabIndex = 1;
            this.radioButtonChangePoint.Text = "Change Point";
            this.radioButtonChangePoint.UseVisualStyleBackColor = true;
            this.radioButtonChangePoint.CheckedChanged += new System.EventHandler(this.radioButtonChangePoint_CheckedChanged);
            // 
            // MyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 811);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBoxPallete);
            this.Controls.Add(this.checkBoxSupport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picObjectMotion);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(5);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPallete)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBoxPallete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonChangePoint;
        private System.Windows.Forms.RadioButton radioButtonAddPoint;
    }
}

