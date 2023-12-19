namespace SmartBOX
{
    partial class save_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(save_item));
            this.save = new System.Windows.Forms.Button();
            this.save_item_tip = new System.Windows.Forms.Label();
            this.desc_tip = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.desc_item = new System.Windows.Forms.TextBox();
            this.item_icon = new System.Windows.Forms.PictureBox();
            this.icon_tip = new System.Windows.Forms.Label();
            this.savebox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.item_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(217, 139);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 38);
            this.save.TabIndex = 0;
            this.save.Text = "存入";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // save_item_tip
            // 
            this.save_item_tip.AutoSize = true;
            this.save_item_tip.Location = new System.Drawing.Point(11, 12);
            this.save_item_tip.Name = "save_item_tip";
            this.save_item_tip.Size = new System.Drawing.Size(226, 24);
            this.save_item_tip.TabIndex = 1;
            this.save_item_tip.Text = "请输入你想要存入的物品：";
            // 
            // desc_tip
            // 
            this.desc_tip.AutoSize = true;
            this.desc_tip.Location = new System.Drawing.Point(11, 48);
            this.desc_tip.Name = "desc_tip";
            this.desc_tip.Size = new System.Drawing.Size(154, 24);
            this.desc_tip.TabIndex = 2;
            this.desc_tip.Text = "请添加物品描述：";
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(156, 12);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(161, 31);
            this.item_name.TabIndex = 3;
            // 
            // desc_item
            // 
            this.desc_item.Location = new System.Drawing.Point(156, 45);
            this.desc_item.Multiline = true;
            this.desc_item.Name = "desc_item";
            this.desc_item.Size = new System.Drawing.Size(161, 88);
            this.desc_item.TabIndex = 4;
            // 
            // item_icon
            // 
            this.item_icon.Image = global::SmartBOX.Properties.Resources.未标题_1;
            this.item_icon.Location = new System.Drawing.Point(15, 103);
            this.item_icon.Name = "item_icon";
            this.item_icon.Size = new System.Drawing.Size(120, 107);
            this.item_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.item_icon.TabIndex = 5;
            this.item_icon.TabStop = false;
            this.item_icon.Click += new System.EventHandler(this.item_icon_Click);
            // 
            // icon_tip
            // 
            this.icon_tip.AutoSize = true;
            this.icon_tip.ForeColor = System.Drawing.Color.SandyBrown;
            this.icon_tip.Location = new System.Drawing.Point(11, 77);
            this.icon_tip.Name = "icon_tip";
            this.icon_tip.Size = new System.Drawing.Size(184, 24);
            this.icon_tip.TabIndex = 2;
            this.icon_tip.Text = "请添加物品图标(弃坑)";
            // 
            // savebox
            // 
            this.savebox.FormattingEnabled = true;
            this.savebox.Location = new System.Drawing.Point(156, 139);
            this.savebox.MaxLength = 1;
            this.savebox.Name = "savebox";
            this.savebox.Size = new System.Drawing.Size(55, 32);
            this.savebox.Sorted = true;
            this.savebox.TabIndex = 6;
            // 
            // save_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.savebox);
            this.Controls.Add(this.item_icon);
            this.Controls.Add(this.desc_item);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.icon_tip);
            this.Controls.Add(this.desc_tip);
            this.Controls.Add(this.save_item_tip);
            this.Controls.Add(this.save);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "save_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "存入物品";
            this.Load += new System.EventHandler(this.save_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.item_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label save_item_tip;
        private System.Windows.Forms.Label desc_tip;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.TextBox desc_item;
        private System.Windows.Forms.PictureBox item_icon;
        private System.Windows.Forms.Label icon_tip;
        private System.Windows.Forms.ComboBox savebox;
    }
}