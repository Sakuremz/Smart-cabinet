namespace SmartBOX
{
    partial class Mainbody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainbody));
            this.save_open = new System.Windows.Forms.Button();
            this.get_open = new System.Windows.Forms.Button();
            this.welcome_tip = new System.Windows.Forms.Label();
            this.nowtime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.box1 = new System.Windows.Forms.Label();
            this.box2 = new System.Windows.Forms.Label();
            this.box3 = new System.Windows.Forms.Label();
            this.box4 = new System.Windows.Forms.Label();
            this.box5 = new System.Windows.Forms.Label();
            this.box6 = new System.Windows.Forms.Label();
            this.box7 = new System.Windows.Forms.Label();
            this.box8 = new System.Windows.Forms.Label();
            this.Nav = new System.Windows.Forms.Label();
            this.minForm = new System.Windows.Forms.PictureBox();
            this.maxForm = new System.Windows.Forms.PictureBox();
            this.closeForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // save_open
            // 
            this.save_open.Location = new System.Drawing.Point(315, 365);
            this.save_open.Name = "save_open";
            this.save_open.Size = new System.Drawing.Size(84, 34);
            this.save_open.TabIndex = 0;
            this.save_open.Text = "存入物品";
            this.save_open.UseVisualStyleBackColor = true;
            this.save_open.Click += new System.EventHandler(this.save_open_Click);
            // 
            // get_open
            // 
            this.get_open.Location = new System.Drawing.Point(315, 426);
            this.get_open.Name = "get_open";
            this.get_open.Size = new System.Drawing.Size(84, 34);
            this.get_open.TabIndex = 1;
            this.get_open.Text = "取出物品";
            this.get_open.UseVisualStyleBackColor = true;
            this.get_open.Click += new System.EventHandler(this.get_open_Click);
            // 
            // welcome_tip
            // 
            this.welcome_tip.AutoSize = true;
            this.welcome_tip.BackColor = System.Drawing.Color.Transparent;
            this.welcome_tip.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.welcome_tip.ForeColor = System.Drawing.Color.Yellow;
            this.welcome_tip.Location = new System.Drawing.Point(13, 83);
            this.welcome_tip.Name = "welcome_tip";
            this.welcome_tip.Size = new System.Drawing.Size(229, 28);
            this.welcome_tip.TabIndex = 2;
            this.welcome_tip.Text = "欢迎使用智能柜控制端!";
            // 
            // nowtime
            // 
            this.nowtime.AutoSize = true;
            this.nowtime.BackColor = System.Drawing.Color.Transparent;
            this.nowtime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nowtime.ForeColor = System.Drawing.Color.Violet;
            this.nowtime.Location = new System.Drawing.Point(13, 55);
            this.nowtime.Name = "nowtime";
            this.nowtime.Size = new System.Drawing.Size(0, 28);
            this.nowtime.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.PeachPuff;
            this.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box1.Location = new System.Drawing.Point(12, 120);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(118, 95);
            this.box1.TabIndex = 4;
            this.box1.Text = "智能柜1号";
            this.box1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.PeachPuff;
            this.box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box2.Location = new System.Drawing.Point(153, 120);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(118, 95);
            this.box2.TabIndex = 4;
            this.box2.Text = "智能柜2号";
            this.box2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.PeachPuff;
            this.box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box3.Location = new System.Drawing.Point(294, 120);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(118, 95);
            this.box3.TabIndex = 4;
            this.box3.Text = "智能柜3号";
            this.box3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.PeachPuff;
            this.box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box4.Location = new System.Drawing.Point(12, 242);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(118, 95);
            this.box4.TabIndex = 4;
            this.box4.Text = "智能柜4号";
            this.box4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.Color.PeachPuff;
            this.box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box5.Location = new System.Drawing.Point(153, 242);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(118, 95);
            this.box5.TabIndex = 4;
            this.box5.Text = "智能柜5号";
            this.box5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.Color.PeachPuff;
            this.box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box6.Location = new System.Drawing.Point(294, 242);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(118, 95);
            this.box6.TabIndex = 4;
            this.box6.Text = "智能柜6号";
            this.box6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.Color.PeachPuff;
            this.box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box7.Location = new System.Drawing.Point(12, 365);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(118, 95);
            this.box7.TabIndex = 4;
            this.box7.Text = "智能柜7号";
            this.box7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box8
            // 
            this.box8.BackColor = System.Drawing.Color.PeachPuff;
            this.box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.box8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.box8.Location = new System.Drawing.Point(153, 365);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(118, 95);
            this.box8.TabIndex = 4;
            this.box8.Text = "智能柜8号";
            this.box8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.Silver;
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(809, 37);
            this.Nav.TabIndex = 8;
            this.Nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nav_MouseDown);
            this.Nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Nav_MouseMove);
            // 
            // minForm
            // 
            this.minForm.BackColor = System.Drawing.Color.Transparent;
            this.minForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minForm.Image = global::SmartBOX.Properties.Resources.min;
            this.minForm.Location = new System.Drawing.Point(672, 0);
            this.minForm.Name = "minForm";
            this.minForm.Size = new System.Drawing.Size(41, 37);
            this.minForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minForm.TabIndex = 9;
            this.minForm.TabStop = false;
            this.minForm.Click += new System.EventHandler(this.minForm_Click);
            this.minForm.MouseEnter += new System.EventHandler(this.minForm_MouseEnter);
            this.minForm.MouseLeave += new System.EventHandler(this.minForm_MouseLeave);
            // 
            // maxForm
            // 
            this.maxForm.BackColor = System.Drawing.Color.Transparent;
            this.maxForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxForm.Image = global::SmartBOX.Properties.Resources.max;
            this.maxForm.Location = new System.Drawing.Point(713, 0);
            this.maxForm.Name = "maxForm";
            this.maxForm.Size = new System.Drawing.Size(48, 37);
            this.maxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxForm.TabIndex = 9;
            this.maxForm.TabStop = false;
            this.maxForm.Click += new System.EventHandler(this.maxForm_Click);
            this.maxForm.MouseEnter += new System.EventHandler(this.maxForm_MouseEnter);
            this.maxForm.MouseLeave += new System.EventHandler(this.maxForm_MouseLeave);
            // 
            // closeForm
            // 
            this.closeForm.BackColor = System.Drawing.Color.Transparent;
            this.closeForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeForm.Image = global::SmartBOX.Properties.Resources.close;
            this.closeForm.Location = new System.Drawing.Point(761, 0);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(48, 37);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 9;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            this.closeForm.MouseEnter += new System.EventHandler(this.closeForm_MouseEnter);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            // 
            // Mainbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartBOX.Properties.Resources.Backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 504);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.minForm);
            this.Controls.Add(this.maxForm);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.Nav);
            this.Controls.Add(this.box7);
            this.Controls.Add(this.nowtime);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.welcome_tip);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.get_open);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.save_open);
            this.Controls.Add(this.box6);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mainbody";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能柜控制端";
            this.Activated += new System.EventHandler(this.Mainbody_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainbody_FormClosing);
            this.Load += new System.EventHandler(this.Mainbody_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_open;
        private System.Windows.Forms.Button get_open;
        private System.Windows.Forms.Label welcome_tip;
        private System.Windows.Forms.Label nowtime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label box1;
        private System.Windows.Forms.Label box2;
        private System.Windows.Forms.Label box3;
        private System.Windows.Forms.Label box4;
        private System.Windows.Forms.Label box5;
        private System.Windows.Forms.Label box6;
        private System.Windows.Forms.Label box7;
        private System.Windows.Forms.Label box8;
        private System.Windows.Forms.Label Nav;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.PictureBox maxForm;
        private System.Windows.Forms.PictureBox minForm;
    }
}

