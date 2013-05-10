using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace SimplexUniverse
{
    public partial class FileMenu : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FileMenu()
        {
            InitializeComponent();
        }

        private void FileMenu_Load(object sender, EventArgs e)
        {

        }

        private void metroTilePanel1_ItemClick(object sender, EventArgs e)
        {

        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }

        private void metroTileItem3_Click(object sender, EventArgs e)
        {
            SFD.ShowDialog();
        }
    }
}