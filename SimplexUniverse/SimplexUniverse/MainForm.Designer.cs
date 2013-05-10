namespace SimplexUniverse
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new DevComponents.DotNetBar.Metro.MetroShell();
            this.metroTabPanel1 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.TimerSpeed = new DevComponents.DotNetBar.SliderItem();
            this.StepsPerPlay = new DevComponents.DotNetBar.SliderItem();
            this.INFINATELOOP = new DevComponents.DotNetBar.CheckBoxItem();
            this.TimeRB = new DevComponents.DotNetBar.RibbonBar();
            this.metroTabPanel5 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.DebugButtons1 = new DevComponents.DotNetBar.RibbonBar();
            this.CreateRandomParticles = new DevComponents.DotNetBar.ButtonItem();
            this.metroTabPanel2 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.ShowSimGrid = new DevComponents.DotNetBar.ButtonItem();
            this.ShowGraphs = new DevComponents.DotNetBar.ButtonItem();
            this.ShowRawData = new DevComponents.DotNetBar.ButtonItem();
            this.ShowGroupExplorer = new DevComponents.DotNetBar.ButtonItem();
            this.metroTabPanel4 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.metroTabPanel3 = new DevComponents.DotNetBar.Metro.MetroTabPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.FileButton = new DevComponents.DotNetBar.Metro.MetroAppButton();
            this.Tab_Home = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Tab_Analysis = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Tab_Properties = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.Tab_View = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.DebugTab = new DevComponents.DotNetBar.Metro.MetroTabItem();
            this.SM = new DevComponents.DotNetBar.StyleManager(this.components);
            this.statusBar = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.Label_MainStatus = new DevComponents.DotNetBar.LabelItem();
            this.MemChart = new DevComponents.DotNetBar.MicroChartItem();
            this.SimulationTabs = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.SimGrid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SimGridTab = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel4 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.GraphsTab = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.GroupExplorerTab = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MASS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POSITION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VELOCITY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ACCELERATION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RawDataTab = new DevComponents.DotNetBar.SuperTabItem();
            this.GenericUpdate = new System.Windows.Forms.Timer(this.components);
            this.galleryContainer2 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.sliderItem1 = new DevComponents.DotNetBar.SliderItem();
            this.sliderItem2 = new DevComponents.DotNetBar.SliderItem();
            this.POS_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.POS_Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MasterStep = new System.Windows.Forms.Timer(this.components);
            this.PlayAroundForm = new DevComponents.DotNetBar.ButtonItem();
            this.RESETBUTTON = new DevComponents.DotNetBar.ButtonItem();
            this.STOP = new DevComponents.DotNetBar.ButtonItem();
            this.PLAY = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.mainMenu.SuspendLayout();
            this.metroTabPanel1.SuspendLayout();
            this.metroTabPanel5.SuspendLayout();
            this.metroTabPanel2.SuspendLayout();
            this.metroTabPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTabs)).BeginInit();
            this.SimulationTabs.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimGrid)).BeginInit();
            this.superTabControlPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.mainMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mainMenu.CanCustomize = false;
            this.mainMenu.CaptionVisible = true;
            this.mainMenu.Controls.Add(this.metroTabPanel5);
            this.mainMenu.Controls.Add(this.metroTabPanel1);
            this.mainMenu.Controls.Add(this.metroTabPanel2);
            this.mainMenu.Controls.Add(this.metroTabPanel4);
            this.mainMenu.Controls.Add(this.metroTabPanel3);
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenu.ForeColor = System.Drawing.Color.Black;
            this.mainMenu.HelpButtonText = null;
            this.mainMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.FileButton,
            this.Tab_Home,
            this.Tab_Analysis,
            this.Tab_Properties,
            this.Tab_View,
            this.DebugTab});
            this.mainMenu.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.mainMenu.Location = new System.Drawing.Point(0, 1);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(694, 125);
            this.mainMenu.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.mainMenu.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.mainMenu.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.mainMenu.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.mainMenu.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.mainMenu.SystemText.QatDialogAddButton = "&Add >>";
            this.mainMenu.SystemText.QatDialogCancelButton = "Cancel";
            this.mainMenu.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.mainMenu.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.mainMenu.SystemText.QatDialogOkButton = "OK";
            this.mainMenu.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.mainMenu.SystemText.QatDialogRemoveButton = "&Remove";
            this.mainMenu.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.mainMenu.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.mainMenu.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.mainMenu.TabIndex = 0;
            this.mainMenu.TabStripFont = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.UseCustomizeDialog = false;
            this.mainMenu.SettingsButtonClick += new System.EventHandler(this.mainMenu_SettingsButtonClick);
            this.mainMenu.Click += new System.EventHandler(this.metroShell1_Click);
            // 
            // metroTabPanel1
            // 
            this.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel1.Controls.Add(this.ribbonBar1);
            this.metroTabPanel1.Controls.Add(this.TimeRB);
            this.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTabPanel1.Name = "metroTabPanel1";
            this.metroTabPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel1.Size = new System.Drawing.Size(694, 125);
            // 
            // 
            // 
            this.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel1.TabIndex = 1;
            this.metroTabPanel1.Visible = false;
            this.metroTabPanel1.Click += new System.EventHandler(this.metroTabPanel1_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TimerSpeed,
            this.StepsPerPlay,
            this.INFINATELOOP});
            this.ribbonBar1.Location = new System.Drawing.Point(223, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(374, 122);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 1;
            this.ribbonBar1.Text = "Step Options";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // TimerSpeed
            // 
            this.TimerSpeed.DecreaseTooltip = "Slower";
            this.TimerSpeed.IncreaseTooltip = "Faster";
            this.TimerSpeed.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Top;
            this.TimerSpeed.LabelWidth = 100;
            this.TimerSpeed.Maximum = 2000;
            this.TimerSpeed.Minimum = 50;
            this.TimerSpeed.Name = "TimerSpeed";
            this.TimerSpeed.Step = 100;
            this.TimerSpeed.Text = "Update Speed";
            this.TimerSpeed.Value = 500;
            // 
            // StepsPerPlay
            // 
            this.StepsPerPlay.DecreaseTooltip = "Less";
            this.StepsPerPlay.IncreaseTooltip = "More";
            this.StepsPerPlay.LabelPosition = DevComponents.DotNetBar.eSliderLabelPosition.Top;
            this.StepsPerPlay.LabelWidth = 100;
            this.StepsPerPlay.Maximum = 250;
            this.StepsPerPlay.Minimum = 1;
            this.StepsPerPlay.Name = "StepsPerPlay";
            this.StepsPerPlay.Step = 10;
            this.StepsPerPlay.Text = "Number Steps / Play";
            this.StepsPerPlay.Value = 100;
            // 
            // INFINATELOOP
            // 
            this.INFINATELOOP.Name = "INFINATELOOP";
            this.INFINATELOOP.Text = "Keep Playing";
            // 
            // TimeRB
            // 
            this.TimeRB.AutoOverflowEnabled = false;
            this.TimeRB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.TimeRB.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.TimeRB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TimeRB.ContainerControlProcessDialogKey = true;
            this.TimeRB.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeRB.ForeColor = System.Drawing.Color.Black;
            this.TimeRB.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.RESETBUTTON,
            this.STOP,
            this.PLAY});
            this.TimeRB.Location = new System.Drawing.Point(3, 0);
            this.TimeRB.Name = "TimeRB";
            this.TimeRB.Size = new System.Drawing.Size(220, 122);
            this.TimeRB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TimeRB.TabIndex = 0;
            this.TimeRB.Text = "Step Controls";
            // 
            // 
            // 
            this.TimeRB.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.TimeRB.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TimeRB.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // metroTabPanel5
            // 
            this.metroTabPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel5.Controls.Add(this.DebugButtons1);
            this.metroTabPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel5.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel5.Name = "metroTabPanel5";
            this.metroTabPanel5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel5.Size = new System.Drawing.Size(694, 74);
            // 
            // 
            // 
            this.metroTabPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel5.TabIndex = 5;
            // 
            // DebugButtons1
            // 
            this.DebugButtons1.AutoOverflowEnabled = false;
            this.DebugButtons1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.DebugButtons1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.DebugButtons1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DebugButtons1.ContainerControlProcessDialogKey = true;
            this.DebugButtons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugButtons1.ForeColor = System.Drawing.Color.Black;
            this.DebugButtons1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.PlayAroundForm,
            this.CreateRandomParticles});
            this.DebugButtons1.Location = new System.Drawing.Point(3, 0);
            this.DebugButtons1.Name = "DebugButtons1";
            this.DebugButtons1.Size = new System.Drawing.Size(688, 71);
            this.DebugButtons1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DebugButtons1.TabIndex = 1;
            this.DebugButtons1.Text = "DEBUG TESTS";
            // 
            // 
            // 
            this.DebugButtons1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.DebugButtons1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.DebugButtons1.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // CreateRandomParticles
            // 
            this.CreateRandomParticles.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.CreateRandomParticles.CanCustomize = false;
            this.CreateRandomParticles.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.CreateRandomParticles.Name = "CreateRandomParticles";
            this.CreateRandomParticles.SubItemsExpandWidth = 14;
            this.CreateRandomParticles.Symbol = "";
            this.CreateRandomParticles.Text = "Create Random Particles";
            // 
            // metroTabPanel2
            // 
            this.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel2.Controls.Add(this.ribbonBar3);
            this.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel2.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel2.Name = "metroTabPanel2";
            this.metroTabPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel2.Size = new System.Drawing.Size(694, 74);
            // 
            // 
            // 
            this.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel2.TabIndex = 2;
            this.metroTabPanel2.Visible = false;
            this.metroTabPanel2.Click += new System.EventHandler(this.metroTabPanel2_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = false;
            this.ribbonBar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar3.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ShowSimGrid,
            this.ShowGraphs,
            this.ShowRawData,
            this.ShowGroupExplorer});
            this.ribbonBar3.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Size = new System.Drawing.Size(370, 71);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar3.TabIndex = 1;
            this.ribbonBar3.Tag = "";
            this.ribbonBar3.Text = "Simulation Tabs";
            // 
            // 
            // 
            this.ribbonBar3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar3.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar3.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // ShowSimGrid
            // 
            this.ShowSimGrid.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ShowSimGrid.CanCustomize = false;
            this.ShowSimGrid.Checked = true;
            this.ShowSimGrid.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.ShowSimGrid.Name = "ShowSimGrid";
            this.ShowSimGrid.SubItemsExpandWidth = 14;
            this.ShowSimGrid.Symbol = "";
            this.ShowSimGrid.Text = "Simulation Grid";
            this.ShowSimGrid.Click += new System.EventHandler(this.ShowSimGrid_Click);
            // 
            // ShowGraphs
            // 
            this.ShowGraphs.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ShowGraphs.CanCustomize = false;
            this.ShowGraphs.Checked = true;
            this.ShowGraphs.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.ShowGraphs.Name = "ShowGraphs";
            this.ShowGraphs.SubItemsExpandWidth = 14;
            this.ShowGraphs.Symbol = "";
            this.ShowGraphs.Text = "Graphs";
            this.ShowGraphs.Click += new System.EventHandler(this.ShowGraphs_Click);
            // 
            // ShowRawData
            // 
            this.ShowRawData.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ShowRawData.CanCustomize = false;
            this.ShowRawData.Checked = true;
            this.ShowRawData.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.ShowRawData.Name = "ShowRawData";
            this.ShowRawData.SubItemsExpandWidth = 14;
            this.ShowRawData.Symbol = "";
            this.ShowRawData.Text = "Raw Data";
            this.ShowRawData.Click += new System.EventHandler(this.ShowRawData_Click);
            // 
            // ShowGroupExplorer
            // 
            this.ShowGroupExplorer.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.ShowGroupExplorer.CanCustomize = false;
            this.ShowGroupExplorer.Checked = true;
            this.ShowGroupExplorer.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.ShowGroupExplorer.Name = "ShowGroupExplorer";
            this.ShowGroupExplorer.SubItemsExpandWidth = 14;
            this.ShowGroupExplorer.Symbol = "";
            this.ShowGroupExplorer.Text = "Group Explorer";
            this.ShowGroupExplorer.Click += new System.EventHandler(this.ShowGroupExplorer_Click);
            // 
            // metroTabPanel4
            // 
            this.metroTabPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel4.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel4.Name = "metroTabPanel4";
            this.metroTabPanel4.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel4.Size = new System.Drawing.Size(694, 74);
            // 
            // 
            // 
            this.metroTabPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel4.TabIndex = 4;
            this.metroTabPanel4.Visible = false;
            // 
            // metroTabPanel3
            // 
            this.metroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.metroTabPanel3.Controls.Add(this.ribbonBar2);
            this.metroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabPanel3.Location = new System.Drawing.Point(0, 51);
            this.metroTabPanel3.Name = "metroTabPanel3";
            this.metroTabPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.metroTabPanel3.Size = new System.Drawing.Size(694, 74);
            // 
            // 
            // 
            this.metroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.metroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTabPanel3.TabIndex = 3;
            this.metroTabPanel3.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.ForeColor = System.Drawing.Color.Black;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem3,
            this.buttonItem4});
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(213, 71);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 1;
            this.ribbonBar2.Text = "Step Controls";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // FileButton
            // 
            this.FileButton.AutoExpandOnClick = true;
            this.FileButton.CanCustomize = false;
            this.FileButton.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.FileButton.ImagePaddingHorizontal = 0;
            this.FileButton.ImagePaddingVertical = 0;
            this.FileButton.Name = "FileButton";
            this.FileButton.ShowSubItems = false;
            this.FileButton.Text = "&File";
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // Tab_Home
            // 
            this.Tab_Home.Name = "Tab_Home";
            this.Tab_Home.Panel = this.metroTabPanel1;
            this.Tab_Home.Text = "&HOME";
            // 
            // Tab_Analysis
            // 
            this.Tab_Analysis.Name = "Tab_Analysis";
            this.Tab_Analysis.Panel = this.metroTabPanel3;
            this.Tab_Analysis.Text = "ANALYSIS";
            this.Tab_Analysis.Click += new System.EventHandler(this.metroTabItem3_Click);
            // 
            // Tab_Properties
            // 
            this.Tab_Properties.Name = "Tab_Properties";
            this.Tab_Properties.Panel = this.metroTabPanel4;
            this.Tab_Properties.Text = "PROPERTIES";
            // 
            // Tab_View
            // 
            this.Tab_View.Name = "Tab_View";
            this.Tab_View.Panel = this.metroTabPanel2;
            this.Tab_View.Text = "&VIEW";
            // 
            // DebugTab
            // 
            this.DebugTab.Checked = true;
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.Panel = this.metroTabPanel5;
            this.DebugTab.Text = "DEBUG";
            // 
            // SM
            // 
            this.SM.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.SM.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198))))));
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.statusBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.statusBar.ContainerControlProcessDialogKey = true;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.ForeColor = System.Drawing.Color.Black;
            this.statusBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Label_MainStatus,
            this.MemChart});
            this.statusBar.Location = new System.Drawing.Point(0, 564);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(694, 21);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "metroStatusBar1";
            // 
            // Label_MainStatus
            // 
            this.Label_MainStatus.Name = "Label_MainStatus";
            this.Label_MainStatus.Stretch = true;
            this.Label_MainStatus.Text = "READY";
            this.Label_MainStatus.Width = 200;
            // 
            // MemChart
            // 
            this.MemChart.BarChartStyle.MinBarSize = 5;
            this.MemChart.CanCustomize = false;
            this.MemChart.DataMinValue = 0D;
            this.MemChart.MouseOverDataPointTooltipEnabled = false;
            this.MemChart.Name = "MemChart";
            this.MemChart.Text = "MEM";
            this.MemChart.TrackChartPoints = false;
            // 
            // SimulationTabs
            // 
            this.SimulationTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.SimulationTabs.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.SimulationTabs.ControlBox.MenuBox.Name = "";
            this.SimulationTabs.ControlBox.Name = "";
            this.SimulationTabs.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SimulationTabs.ControlBox.MenuBox,
            this.SimulationTabs.ControlBox.CloseBox});
            this.SimulationTabs.Controls.Add(this.superTabControlPanel1);
            this.SimulationTabs.Controls.Add(this.superTabControlPanel4);
            this.SimulationTabs.Controls.Add(this.superTabControlPanel2);
            this.SimulationTabs.Controls.Add(this.superTabControlPanel3);
            this.SimulationTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimulationTabs.ForeColor = System.Drawing.Color.Black;
            this.SimulationTabs.Location = new System.Drawing.Point(0, 126);
            this.SimulationTabs.Name = "SimulationTabs";
            this.SimulationTabs.ReorderTabsEnabled = true;
            this.SimulationTabs.SelectedTabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SimulationTabs.SelectedTabIndex = 0;
            this.SimulationTabs.Size = new System.Drawing.Size(694, 438);
            this.SimulationTabs.TabFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulationTabs.TabIndex = 2;
            this.SimulationTabs.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SimGridTab,
            this.GraphsTab,
            this.RawDataTab,
            this.GroupExplorerTab});
            this.SimulationTabs.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.VisualStudio2008Dock;
            this.SimulationTabs.Text = "Simulation Grid";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.SimGrid);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 27);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(694, 411);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.SimGridTab;
            // 
            // SimGrid
            // 
            this.SimGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.Title = "Y";
            chartArea1.Name = "MainChartArea";
            this.SimGrid.ChartAreas.Add(chartArea1);
            this.SimGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SimGrid.Location = new System.Drawing.Point(0, 0);
            this.SimGrid.Name = "SimGrid";
            series1.ChartArea = "MainChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series1.Name = "MainSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.SimGrid.Series.Add(series1);
            this.SimGrid.Size = new System.Drawing.Size(694, 411);
            this.SimGrid.SuppressExceptions = true;
            this.SimGrid.TabIndex = 3;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "GenerationCount";
            title1.Text = "Generation 0";
            this.SimGrid.Titles.Add(title1);
            // 
            // SimGridTab
            // 
            this.SimGridTab.AttachedControl = this.superTabControlPanel1;
            this.SimGridTab.GlobalItem = false;
            this.SimGridTab.Name = "SimGridTab";
            this.SimGridTab.Text = "Simulation Grid";
            // 
            // superTabControlPanel4
            // 
            this.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel4.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel4.Name = "superTabControlPanel4";
            this.superTabControlPanel4.Size = new System.Drawing.Size(694, 438);
            this.superTabControlPanel4.TabIndex = 0;
            this.superTabControlPanel4.TabItem = this.GraphsTab;
            // 
            // GraphsTab
            // 
            this.GraphsTab.AttachedControl = this.superTabControlPanel4;
            this.GraphsTab.GlobalItem = false;
            this.GraphsTab.Name = "GraphsTab";
            this.GraphsTab.Text = "Graphs";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(694, 438);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.GroupExplorerTab;
            // 
            // GroupExplorerTab
            // 
            this.GroupExplorerTab.AttachedControl = this.superTabControlPanel2;
            this.GroupExplorerTab.GlobalItem = false;
            this.GroupExplorerTab.Name = "GroupExplorerTab";
            this.GroupExplorerTab.Text = "Group Explorer";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.listView1);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(694, 438);
            this.superTabControlPanel3.TabIndex = 0;
            this.superTabControlPanel3.TabItem = this.RawDataTab;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.MASS,
            this.POSITION,
            this.VELOCITY,
            this.ACCELERATION});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.ForeColor = System.Drawing.Color.Black;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 438);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "ID";
            this.PID.Width = 75;
            // 
            // MASS
            // 
            this.MASS.Text = "Mass";
            this.MASS.Width = 75;
            // 
            // POSITION
            // 
            this.POSITION.Text = "Position (X, Y, Z)";
            this.POSITION.Width = 100;
            // 
            // VELOCITY
            // 
            this.VELOCITY.Text = "Velocity";
            this.VELOCITY.Width = 75;
            // 
            // ACCELERATION
            // 
            this.ACCELERATION.Text = "Acceleration";
            this.ACCELERATION.Width = 75;
            // 
            // RawDataTab
            // 
            this.RawDataTab.AttachedControl = this.superTabControlPanel3;
            this.RawDataTab.GlobalItem = false;
            this.RawDataTab.Name = "RawDataTab";
            this.RawDataTab.Text = "Raw Data";
            // 
            // GenericUpdate
            // 
            this.GenericUpdate.Enabled = true;
            this.GenericUpdate.Interval = 1000;
            this.GenericUpdate.Tick += new System.EventHandler(this.GenericUpdate_Tick);
            // 
            // galleryContainer2
            // 
            // 
            // 
            // 
            this.galleryContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer2.EnableGalleryPopup = false;
            this.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer2.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer2.MultiLine = false;
            this.galleryContainer2.Name = "galleryContainer2";
            this.galleryContainer2.PopupUsesStandardScrollbars = false;
            // 
            // 
            // 
            this.galleryContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem1
            // 
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.CanCustomize = false;
            this.labelItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelItem1.Name = "labelItem1";
            // 
            // sliderItem1
            // 
            this.sliderItem1.DecreaseTooltip = "Slower";
            this.sliderItem1.IncreaseTooltip = "Faster";
            this.sliderItem1.LabelWidth = 100;
            this.sliderItem1.Maximum = 2000;
            this.sliderItem1.Minimum = 50;
            this.sliderItem1.Name = "sliderItem1";
            this.sliderItem1.Step = 100;
            this.sliderItem1.Text = "Update Speed";
            this.sliderItem1.Value = 500;
            // 
            // sliderItem2
            // 
            this.sliderItem2.DecreaseTooltip = "Slower";
            this.sliderItem2.IncreaseTooltip = "Faster";
            this.sliderItem2.LabelWidth = 100;
            this.sliderItem2.Maximum = 2000;
            this.sliderItem2.Minimum = 50;
            this.sliderItem2.Name = "sliderItem2";
            this.sliderItem2.Step = 100;
            this.sliderItem2.Text = "Update Speed";
            this.sliderItem2.Value = 500;
            // 
            // POS_Y
            // 
            this.POS_Y.Text = "Pos Y";
            // 
            // POS_Z
            // 
            this.POS_Z.Text = "Pos Z";
            // 
            // PlayAroundForm
            // 
            this.PlayAroundForm.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.PlayAroundForm.CanCustomize = false;
            this.PlayAroundForm.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.PlayAroundForm.Name = "PlayAroundForm";
            this.PlayAroundForm.SubItemsExpandWidth = 14;
            this.PlayAroundForm.Symbol = "";
            this.PlayAroundForm.Text = "Play Around Form";
            this.PlayAroundForm.Click += new System.EventHandler(this.PlayAroundForm_Click);
            // 
            // RESETBUTTON
            // 
            this.RESETBUTTON.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.RESETBUTTON.CanCustomize = false;
            this.RESETBUTTON.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.RESETBUTTON.Enabled = false;
            this.RESETBUTTON.Image = global::SimplexUniverse.Properties.Resources._1320171997_button_begin_basic_red;
            this.RESETBUTTON.Name = "RESETBUTTON";
            this.RESETBUTTON.SubItemsExpandWidth = 14;
            this.RESETBUTTON.Text = "RESET";
            // 
            // STOP
            // 
            this.STOP.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.STOP.CanCustomize = false;
            this.STOP.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.STOP.Enabled = false;
            this.STOP.Image = global::SimplexUniverse.Properties.Resources._1319998047_button_stop_basic_red;
            this.STOP.Name = "STOP";
            this.STOP.SubItemsExpandWidth = 14;
            this.STOP.Text = "STOP";
            // 
            // PLAY
            // 
            this.PLAY.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.PLAY.CanCustomize = false;
            this.PLAY.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.PLAY.Image = global::SimplexUniverse.Properties.Resources._1319997973_button_play_basic_green;
            this.PLAY.Name = "PLAY";
            this.PLAY.SubItemsExpandWidth = 14;
            this.PLAY.Text = "PLAY";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.CanCustomize = false;
            this.buttonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem1.Enabled = false;
            this.buttonItem1.Image = global::SimplexUniverse.Properties.Resources._1320171997_button_begin_basic_red;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItemsExpandWidth = 14;
            this.buttonItem1.Text = "RESET";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.CanCustomize = false;
            this.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem3.Enabled = false;
            this.buttonItem3.Image = global::SimplexUniverse.Properties.Resources._1319998047_button_stop_basic_red;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 14;
            this.buttonItem3.Text = "STOP";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.CanCustomize = false;
            this.buttonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.buttonItem4.Image = global::SimplexUniverse.Properties.Resources._1319997973_button_play_basic_green;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 14;
            this.buttonItem4.Text = "PLAY";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 586);
            this.Controls.Add(this.SimulationTabs);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simplex Universe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.metroTabPanel1.ResumeLayout(false);
            this.metroTabPanel5.ResumeLayout(false);
            this.metroTabPanel2.ResumeLayout(false);
            this.metroTabPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimulationTabs)).EndInit();
            this.SimulationTabs.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimGrid)).EndInit();
            this.superTabControlPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroShell mainMenu;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel1;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel2;
        private DevComponents.DotNetBar.Metro.MetroAppButton FileButton;
        private DevComponents.DotNetBar.Metro.MetroTabItem Tab_Home;
        private DevComponents.DotNetBar.Metro.MetroTabItem Tab_View;
        private DevComponents.DotNetBar.StyleManager SM;
        private DevComponents.DotNetBar.Metro.MetroStatusBar statusBar;
        private DevComponents.DotNetBar.LabelItem Label_MainStatus;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel3;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel4;
        private DevComponents.DotNetBar.Metro.MetroTabItem Tab_Analysis;
        private DevComponents.DotNetBar.Metro.MetroTabItem Tab_Properties;
        private DevComponents.DotNetBar.SuperTabControl SimulationTabs;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SimGrid;
        private DevComponents.DotNetBar.SuperTabItem SimGridTab;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem GroupExplorerTab;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private DevComponents.DotNetBar.SuperTabItem RawDataTab;
        private DevComponents.DotNetBar.MicroChartItem MemChart;
        private System.Windows.Forms.Timer GenericUpdate;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.RibbonBar TimeRB;
        private DevComponents.DotNetBar.ButtonItem STOP;
        private DevComponents.DotNetBar.ButtonItem PLAY;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.SliderItem sliderItem1;
        private DevComponents.DotNetBar.SliderItem sliderItem2;
        private DevComponents.DotNetBar.SliderItem TimerSpeed;
        private DevComponents.DotNetBar.CheckBoxItem INFINATELOOP;
        private DevComponents.DotNetBar.SliderItem StepsPerPlay;
        private DevComponents.DotNetBar.ButtonItem RESETBUTTON;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader POSITION;
        private System.Windows.Forms.ColumnHeader POS_Y;
        private System.Windows.Forms.ColumnHeader POS_Z;
        private System.Windows.Forms.ColumnHeader VELOCITY;
        private System.Windows.Forms.ColumnHeader MASS;
        private System.Windows.Forms.ColumnHeader ACCELERATION;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem ShowSimGrid;
        private DevComponents.DotNetBar.ButtonItem ShowRawData;
        private DevComponents.DotNetBar.ButtonItem ShowGroupExplorer;
        private DevComponents.DotNetBar.ButtonItem ShowGraphs;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel4;
        private DevComponents.DotNetBar.SuperTabItem GraphsTab;
        private DevComponents.DotNetBar.Metro.MetroTabPanel metroTabPanel5;
        private DevComponents.DotNetBar.RibbonBar DebugButtons1;
        private DevComponents.DotNetBar.ButtonItem CreateRandomParticles;
        private DevComponents.DotNetBar.Metro.MetroTabItem DebugTab;
        private System.Windows.Forms.Timer MasterStep;
        private DevComponents.DotNetBar.ButtonItem PlayAroundForm;

    }
}

