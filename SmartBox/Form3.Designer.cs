namespace SmartBOX
{
    partial class get_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(get_item));
            this.get_item_tip = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.TextBox();
            this.getitem = new System.Windows.Forms.Button();
            this.all_items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // get_item_tip
            // 
            this.get_item_tip.AutoSize = true;
            this.get_item_tip.Location = new System.Drawing.Point(6, 28);
            this.get_item_tip.Name = "get_item_tip";
            this.get_item_tip.Size = new System.Drawing.Size(208, 24);
            this.get_item_tip.TabIndex = 0;
            this.get_item_tip.Text = "请输入你想取出的物品：";
            // 
            // item_name
            // 
            this.item_name.Location = new System.Drawing.Point(152, 25);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(196, 31);
            this.item_name.TabIndex = 1;
            // 
            // getitem
            // 
            this.getitem.Location = new System.Drawing.Point(366, 23);
            this.getitem.Name = "getitem";
            this.getitem.Size = new System.Drawing.Size(101, 31);
            this.getitem.TabIndex = 2;
            this.getitem.Text = "取出";
            this.getitem.UseVisualStyleBackColor = true;
            this.getitem.Click += new System.EventHandler(this.getitem_Click);
            // 
            // all_items
            // 
            this.all_items.FormattingEnabled = true;
            this.all_items.ItemHeight = 24;
            this.all_items.Location = new System.Drawing.Point(9, 71);
            this.all_items.Name = "all_items";
            this.all_items.Size = new System.Drawing.Size(339, 244);
            this.all_items.TabIndex = 3;
            this.all_items.SelectedIndexChanged += new System.EventHandler(this.all_items_SelectedIndexChanged_1);
            // 
            // get_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 372);
            this.Controls.Add(this.all_items);
            this.Controls.Add(this.getitem);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.get_item_tip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "get_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "取出";
            this.Load += new System.EventHandler(this.get_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label get_item_tip;
        private System.Windows.Forms.TextBox item_name;
        private System.Windows.Forms.Button getitem;
        public System.Windows.Forms.ListBox all_items;
    }
}