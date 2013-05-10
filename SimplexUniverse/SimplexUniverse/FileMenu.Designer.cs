namespace SimplexUniverse
{
    partial class FileMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileMenu));
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem8 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTilePanel1.ForeColor = System.Drawing.Color.Black;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.itemContainer2});
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(625, 396);
            this.metroTilePanel1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            this.metroTilePanel1.ItemClick += new System.EventHandler(this.metroTilePanel1_ItemClick);
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.CanCustomize = false;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1,
            this.metroTileItem2,
            this.metroTileItem3,
            this.metroTileItem4});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "FILE";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.Symbol = "";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.SymbolSize = 35F;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "New Simulation";
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.Symbol = "";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.SymbolSize = 35F;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem2.TitleText = "Open Simulation";
            this.metroTileItem2.Click += new System.EventHandler(this.metroTileItem2_Click);
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.Symbol = "";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.SymbolSize = 35F;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem3.TitleText = "Save Simulation";
            this.metroTileItem3.Click += new System.EventHandler(this.metroTileItem3_Click);
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.CanCustomize = false;
            this.itemContainer2.MultiLine = true;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem5,
            this.metroTileItem6,
            this.metroTileItem7,
            this.metroTileItem8});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.TitleText = "NEW";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.Symbol = "";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.SymbolSize = 35F;
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem5.TitleText = "Universe From Scratch";
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.Symbol = "";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.SymbolSize = 35F;
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem6.TitleText = "Blank 2D Universe";
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.Symbol = "";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.SymbolSize = 35F;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem7.TitleText = "Blank 3D Universe";
            // 
            // metroTileItem8
            // 
            this.metroTileItem8.Name = "metroTileItem8";
            this.metroTileItem8.Symbol = "";
            this.metroTileItem8.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem8.SymbolSize = 35F;
            this.metroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.metroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem8.TitleText = "Blank Random Universe";
            // 
            // OFD
            // 
            this.OFD.Filter = "Simulation Files|*.sim";
            this.OFD.Title = "Open Simulation";
            // 
            // SFD
            // 
            this.SFD.Filter = "Simulation Files|*.sim";
            this.SFD.Title = "Save Simulation";
            // 
            // FileMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 396);
            this.Controls.Add(this.metroTilePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FILE";
            this.Load += new System.EventHandler(this.FileMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem8;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}