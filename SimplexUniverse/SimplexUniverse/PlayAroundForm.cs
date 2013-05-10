using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexUniverse
{
    public partial class PlayAroundForm : Form
    {
        Particle ModelParticle = new Particle(-1, 2, 2);
        List<Particle> ParticleList;
        int GenerationCount = 0;
        int GlobalInterval = 50;
        double ELECCONSTANT = 8.988e9;
        double GRAVCONSTANT = 6.67e-11;

        Random gen = new Random();

        public PlayAroundForm()
        {
            InitializeComponent();
        }

        private void basicParticleInitializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Basic Particle Initialization Test:" + Environment.NewLine;
            TB.Text += "-------------------------------------------" + Environment.NewLine;
            TB.Text += "Creating a basic particle with ID 1234, NDimensions 2, and NProperties 3..." + Environment.NewLine;

            Particle test = new Particle(1234, 2, 3);

            TB.Text += Environment.NewLine;
            TB.Text += test.ParticleToString();
            TB.Text += Environment.NewLine;
            TB.Text += "Testing changing the value of Properties[0] to 5678..." + Environment.NewLine;
            test.Properties[0] = 5678;
            TB.Text += "Properties[0] Value = " + test.Properties[0].ToString() + Environment.NewLine;
            TB.Text += Environment.NewLine;
            TB.Text += "Basic particle initialization test complete...";
        }

        private void dSimpleMassParticleInitializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running 2D Simple Mass Particle Initialization Test:" + Environment.NewLine;
            TB.Text += "----------------------------------------------------" + Environment.NewLine;
            TB.Text += "Creating a 2D simple mass particle with ID 4321 at a random position (without nulls) on a size 100 grid..." + Environment.NewLine;

            Particle test = Generic2D.CreateSimpleMassParticle(4321, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(100), false));

            TB.Text += Environment.NewLine;
            TB.Text += Generic2D.ParticleToString(test);

            TB.Text += Environment.NewLine;
            TB.Text += "2D simple mass particle initialization test complete...";
        }

        private void PlayAroundForm_Load(object sender, EventArgs e)
        {

        }

        private void getRandomParticleSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Get Random Particle Set Test:" + Environment.NewLine;
            TB.Text += "-------------------------------------" + Environment.NewLine;
            TB.Text += "Creating a list of 5 2D simple mass particles with indexes starting at 1000 on a size 50 grid..." + Environment.NewLine;
            TB.Text += Environment.NewLine;
            TB.Text += Environment.NewLine;
            Particle ModelParticle = new Particle(-1, 2, 2);
            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);

            List<Particle> ParticleList = Simulation.GetRandomParticleSet(1000, 5, 2, Generic2D.CreateBasicSizeList(50), ModelParticle.Properties, true);

            foreach (Particle x in ParticleList)
            {
                TB.Text += "-------------------------" + Environment.NewLine;
                TB.Text += x.ParticleToString();
                TB.Text += "-------------------------" + Environment.NewLine;
            }
            TB.Text += Environment.NewLine;
            TB.Text += "2D simple mass particle initialization test complete...";
        }

        private void simple2DParticlePlotTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Simple 2D Particle Plot Test:" + Environment.NewLine;
            TB.Text += "-------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting a 2D simple mass particle with ID 4321 at a random position (without nulls) on a size 50 grid..." + Environment.NewLine;
            
            Particle test = Generic2D.CreateSimpleMassParticle(4321, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(50), false));
            TB.Text += Environment.NewLine;
            TB.Text += "Particle To String:" + Environment.NewLine;
            TB.Text += test.ParticleToString();
            TB.Text += Environment.NewLine;

            TB.Text += "Plotting particle..." + Environment.NewLine;
            SimGrid.Series[0].Points.Clear();
            SimGrid.Series[0].Points.AddXY(test.Position[0], test.Position[1]);


            TB.Text += "2D simple particle plot test complete (check grid)...";
        }

        private void multiple2DParticlePlotTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Multiple 2D Particle Plot Test:" + Environment.NewLine;
            TB.Text += "---------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting 100 2D simple mass particles at a random position (without nulls) on a size 100 grid..." + Environment.NewLine;

            Particle ModelParticle = new Particle(-1, 2, 2);
            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);
            List<Particle> ParticleList = Simulation.GetRandomParticleSet(0, 100, 2, Generic2D.CreateBasicSizeList(100), ModelParticle.Properties, false);

            TB.Text += "Plotting particles..." + Environment.NewLine;
            SimGrid.Series[0].Points.Clear();
            foreach (Particle test in ParticleList)
            {
                SimGrid.Series[0].Points.AddXY(test.Position[0], test.Position[1]);
            }
            
            TB.Text += "2D multiple particle plot test complete (check grid)...";
        }

        private void highEnd2DParticlePlotTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running High-End 2D Particle Plot Test:" + Environment.NewLine;
            TB.Text += "---------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting 100000 2D simple mass particles at a random position (without nulls) on a size 15000 grid..." + Environment.NewLine;

            Particle ModelParticle = new Particle(-1, 2, 2);
            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);
            List<Particle> ParticleList = Simulation.GetRandomParticleSet(0, 100000, 2, Generic2D.CreateBasicSizeList(15000), ModelParticle.Properties, false);

            TB.Text += "Plotting particles..." + Environment.NewLine;
            SimGrid.Series[0].Points.Clear();
            foreach (Particle test in ParticleList)
            {
                SimGrid.Series[0].Points.AddXY(test.Position[0], test.Position[1]);
            }

            TB.Text += "2D high-end particle plot test complete (check grid)...";
        }

        private void randomPositionPlotSpeedTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Random Position Plot Speed Test:" + Environment.NewLine;
            TB.Text += "----------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting 10000 2D simple mass particles at a random position (without nulls) on a size 1500 grid every 50 msecs..." + Environment.NewLine;

            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);
            ParticleList = Simulation.GetRandomParticleSet(0, 10000, 2, Generic2D.CreateBasicSizeList(1500), ModelParticle.Properties, false);
            GenerationCount = 0;
            RandomPositionPlotTest.Start();
        }

        private void RandomPositionPlotTest_Tick(object sender, EventArgs e)
        {
            RandomPositionPlotTest.Stop();
            RandomPositionPlotTest.Interval = GlobalInterval;
            SimGrid.Series[0].Points.Clear();
            foreach (Particle x in ParticleList)
            {
                x.Position = Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(1500), false);
                SimGrid.Series[0].Points.AddXY(x.Position[0], x.Position[1]);
            }
            GenerationCount++;
            SimGrid.Titles[0].Text = "Generation " + GenerationCount.ToString();
            RandomPositionPlotTest.Start();
        }

        private void sTOPTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomPositionPlotTest.Stop();
        }

        private void sTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Random Walk Test:" + Environment.NewLine;
            TB.Text += "-------------------------" + Environment.NewLine;
            TB.Text += "Plotting 10000 2D simple mass particles at a random position (without nulls) on a size 1500 grid with random walk (5, 10)..." + Environment.NewLine;

            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);
            ParticleList = Simulation.GetRandomParticleSet(0, 10000, 2, Generic2D.CreateBasicSizeList(1500), ModelParticle.Properties, false);
            GenerationCount = 0;
            RandomWalkTest.Start();
        }

        private void sTOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomWalkTest.Stop();
        }

        private void RandomWalkTest_Tick(object sender, EventArgs e)
        {
            RandomWalkTest.Stop();
            RandomWalkTest.Interval = GlobalInterval;
            SimGrid.Series[0].Points.Clear();
            foreach (Particle x in ParticleList)
            {
                x.Position = Simulation.RandomWalk(x.Position, 5, 10);
                SimGrid.Series[0].Points.AddXY(x.Position[0], x.Position[1]);
            }
            GenerationCount++;
            SimGrid.Titles[0].Text = "Generation " + GenerationCount.ToString();
            RandomWalkTest.Start();
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
        }

        private void barToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void polarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
        }

        private void radarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = Double.NaN;
            SimGrid.ChartAreas[0].Axes[0].Maximum = Double.NaN;
            SimGrid.ChartAreas[0].Axes[1].Minimum = Double.NaN;
            SimGrid.ChartAreas[0].Axes[1].Maximum = Double.NaN;
        }

        private void fixed1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -1000;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 1000;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -1000;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 1000;
        }

        private void fixed3000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -3000;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 3000;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -3000;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 3000;
        }

        private void fixed2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -2000;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 2000;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -2000;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 2000;
        }

        private void SimGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void fixed250ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -250;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 250;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -250;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 250;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GlobalInterval = 50;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            GlobalInterval = 100;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            GlobalInterval = 500;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            GlobalInterval = 1000;
        }

        private void fastest1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInterval = 1;
        }

        private void bubbleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
        }

        private void stepLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
        }

        private void curveLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        }

        private void pieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
        }

        private void candleStickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
        }

        private void renkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Renko;
        }

        private void kagiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Kagi;
        }

        private void errorBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
            SimGrid.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.ErrorBar;
        }

        private void fixed100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -100;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 100;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -100;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 100;
        }

        private void zeroRandomWalkTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Random Walk Test:" + Environment.NewLine;
            TB.Text += "-------------------------" + Environment.NewLine;
            TB.Text += "Plotting 10000 2D simple mass particles at position 0 with random walk (5, 10)..." + Environment.NewLine;

            ModelParticle = Generic2D.CreateSimpleMassParticle(-1, ModelParticle.Position);
            ParticleList = Simulation.GetRandomParticleSet(0, 10000, 2, Generic2D.CreateBasicSizeList(0), ModelParticle.Properties, false);
            GenerationCount = 0;
            RandomWalkTest.Start();
        }

        private void sTOPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SimpleGravityTest.Stop();
        }

        private void sTARTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Simple Gravity Test:" + Environment.NewLine;
            TB.Text += "----------------------------" + Environment.NewLine;
            TB.Text += "Plotting 200 2D simple mass particles at a random position (without nulls) on a size 100 grid with gravity active..." + Environment.NewLine;
            Particle WorkingParticle = ModelParticle;
            ParticleList = new List<Particle>(200);
            int i;
            for (i = 0; i < 200; i++)
            {
                if (i < 1) //Create Heavy Objects
                {
                    WorkingParticle = Generic2D.CreateSimpleMassParticle(i, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(100), false));
                    WorkingParticle.Properties[0] = 1000;
                    WorkingParticle.Position[0] = 0;
                    WorkingParticle.Position[1] = 0;
                    ParticleList.Add(WorkingParticle);
                }
                else //Create Light Objects
                {
                    ParticleList.Add(Generic2D.CreateSimpleMassParticle(i, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(100), false)));
                }
            }
            GenerationCount = 0;
            SimpleGravityTest.Start();
        }

        private void SimpleGravityTest_Tick(object sender, EventArgs e)
        {
            SimpleGravityTest.Stop();
            SimpleGravityTest.Interval = GlobalInterval;
            SimGrid.Series[0].Points.Clear();
            SimGrid.Series[1].Points.Clear();
            List<Particle> newlist = new List<Particle>(ParticleList.Capacity);
            int i;
            for (i = 0; i < ParticleList.Capacity; i++)
            {
                newlist.Add(Simulation.UpdateParticle_BasicGravity(ParticleList[i], ParticleList, 0, 100, (GRAVCONSTANT * 10000000), 10));
                SimGrid.Series[0].Points.AddXY(newlist[i].Position[0], newlist[i].Position[1]);
            }
            ParticleList = newlist;
            GenerationCount++;
            SimGrid.Titles[0].Text = "Generation " + GenerationCount.ToString();
            TB.Text = "";
            TB.Text += "WATCHING PARTICLE ID 0" + Environment.NewLine;
            TB.Text += ParticleList[0].ParticleToString();
            SimpleGravityTest.Start();
        }

        private void fixed10000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -10000;
            SimGrid.ChartAreas[0].Axes[0].Maximum = 10000;
            SimGrid.ChartAreas[0].Axes[1].Minimum = -10000;
            SimGrid.ChartAreas[0].Axes[1].Maximum = 10000;
        }

        private void sTOPToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SimpleElecMagTest.Stop();
        }

        private void SimpleElecMagTest_Tick(object sender, EventArgs e)
        {
            SimpleElecMagTest.Stop();
            SimpleElecMagTest.Interval = GlobalInterval;
            SimGrid.Series[0].Points.Clear();
            SimGrid.Series[1].Points.Clear();
            Charts.Series[0].Points.Clear();
            Charts.Series[1].Points.Clear();
            int i;
            List<Particle> newlist = new List<Particle>(ParticleList.Capacity);
            for (i = 0; i < ParticleList.Capacity; i++)
            {
                newlist.Add(Simulation.UpdateParticle_BasicElecMag(ParticleList[i], ParticleList, 1, 0, 1, (ELECCONSTANT * 1000000000000), (GRAVCONSTANT * 10000000), 10));
                if (newlist[i].Properties[1] < 0)
                {
                    SimGrid.Series[0].Points.AddXY(newlist[i].Position[0], newlist[i].Position[1]);
                }
                else
                {
                    SimGrid.Series[1].Points.AddXY(newlist[i].Position[0], newlist[i].Position[1]);
                }
                Charts.Series[0].Points.AddXY(newlist[i].Acceleration[0], newlist[i].Acceleration[1]);
                Charts.Series[1].Points.AddXY(newlist[i].Velocity[0], newlist[i].Velocity[1]);
            }
            ParticleList = newlist;
            GenerationCount++;
            SimGrid.Titles[0].Text = "Generation " + GenerationCount.ToString();
            Charts.Titles[0].Text = "Generation " + GenerationCount.ToString();
            TB.Text = "";
            TB.Text += "Running Simple Electromagnetism Test:" + Environment.NewLine;
            TB.Text += "-------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting 200 2D random proton and electron particles at a random position on a size 100 grid with gravity and electromagnetism active..." + Environment.NewLine;
            TB.Text += Environment.NewLine;
            TB.Text += "WATCHING PARTICLE ID 0" + Environment.NewLine;
            TB.Text += ParticleList[0].ParticleToString();
            SimpleElecMagTest.Start();
        }

        private void sTARTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TB.Clear();
            TB.Text += "Running Simple Electromagnetism Test:" + Environment.NewLine;
            TB.Text += "-------------------------------------" + Environment.NewLine;
            TB.Text += "Plotting 200 2D random proton and electron particles at a random position on a size 100 grid with gravity and electromagnetism active..." + Environment.NewLine;
            ParticleList = new List<Particle>(200);
            int i;
            for (i = 0; i < 200; i++)
            {
                if (i < gen.Next(1, 200)) //Create Protons
                {
                    ModelParticle = Generic2D.CreateProton(i, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(100), false));
                    ModelParticle.Properties[0] = 10;
                    ParticleList.Add(ModelParticle);
                }
                else //Create Electrons
                {
                    ModelParticle = Generic2D.CreateElectron(i, Simulation.GetRandomCoordinates(2, Generic2D.CreateBasicSizeList(100), false));
                    ModelParticle.Properties[0] = 1;
                    ParticleList.Add(ModelParticle);
                }
            }
            GenerationCount = 0;
            SimpleElecMagTest.Start();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void aPPLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = -Convert.ToInt32(toolStripTextBox1.Text);
            SimGrid.ChartAreas[0].Axes[0].Maximum = Convert.ToInt32(toolStripTextBox1.Text);
            SimGrid.ChartAreas[0].Axes[1].Minimum = -Convert.ToInt32(toolStripTextBox1.Text);
            SimGrid.ChartAreas[0].Axes[1].Maximum = Convert.ToInt32(toolStripTextBox1.Text);
        }

        private void SimGrid_MouseClick(object sender, MouseEventArgs e)
        {
            SimGrid.ChartAreas[0].Axes[0].Minimum = SimGrid.ChartAreas[0].AxisX.PixelPositionToValue(e.X) - 500;
            SimGrid.ChartAreas[0].Axes[0].Maximum = SimGrid.ChartAreas[0].AxisX.PixelPositionToValue(e.X) + 500;
            SimGrid.ChartAreas[0].Axes[1].Minimum = SimGrid.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) - 500;
            SimGrid.ChartAreas[0].Axes[1].Maximum = SimGrid.ChartAreas[0].AxisY.PixelPositionToValue(e.Y) + 500;
        }

        private void mASTERSTOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomPositionPlotTest.Stop();
            RandomWalkTest.Stop();
            SimpleGravityTest.Stop();
            SimpleElecMagTest.Stop();
        }
    }
}
