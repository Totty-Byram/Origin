using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplexUniverse
{
    public partial class MainForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        //FORMS
        FileMenu FILE = new FileMenu();
        Settings SETTINGS = new Settings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void metroShell1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPanel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabItem3_Click(object sender, EventArgs e)
        {

        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            FILE.ShowDialog();
        }

        private void mainMenu_SettingsButtonClick(object sender, EventArgs e)
        {
            SETTINGS.ShowDialog();
        }

        private void GenericUpdate_Tick(object sender, EventArgs e)
        {
            GenericUpdate.Stop();

            //MemChart.Paint();


            GenericUpdate.Start();
        }

        private void ShowSimGrid_Click(object sender, EventArgs e)
        {
            if (ShowSimGrid.Checked == true)
            {
                ShowSimGrid.Checked = false;
                SimGridTab.Visible = false;
            }
            else
            {
                ShowSimGrid.Checked = true;
                SimGridTab.Visible = true;
            }
        }

        private void ShowRawData_Click(object sender, EventArgs e)
        {
            if (ShowRawData.Checked == true)
            {
                ShowRawData.Checked = false;
                RawDataTab.Visible = false;
            }
            else
            {
                ShowRawData.Checked = true;
                RawDataTab.Visible = true;
            }
        }

        private void ShowGroupExplorer_Click(object sender, EventArgs e)
        {
            if (ShowGroupExplorer.Checked == true)
            {
                ShowGroupExplorer.Checked = false;
                GroupExplorerTab.Visible = false;
            }
            else
            {
                ShowGroupExplorer.Checked = true;
                GroupExplorerTab.Visible = true;
            }
        }

        private void metroTabPanel2_Click(object sender, EventArgs e)
        {

        }

        private void ShowGraphs_Click(object sender, EventArgs e)
        {
            if (ShowGraphs.Checked == true)
            {
                ShowGraphs.Checked = false;
                GraphsTab.Visible = false;
            }
            else
            {
                ShowGraphs.Checked = true;
                GraphsTab.Visible = true;
            }
        }

        private void PlayAroundForm_Click(object sender, EventArgs e)
        {
            PlayAroundForm x = new PlayAroundForm();
            x.Show();
        }
    }
}