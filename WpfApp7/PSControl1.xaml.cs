
using System.Collections.Generic;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для PSControl1.xaml
    /// </summary>
    using System.Windows.Controls;
    using Arction.Wpf.SemibindableCharting;
    using Arction.Wpf.SemibindableCharting.Axes;
    using Arction.Wpf.SemibindableCharting.Views.ViewPolar;
    public partial class PSControl1 : UserControl
    {
        //private LightningChartUltimate _chart = null;
        private readonly List<double> localList = new List<double>();
      
        // chart = new LightningChartUltimate();
        // (Content as Grid).Children.Add(_chart);
        /*private void CreateChart()
        {
            _chart = new LightningChartUltimate();
            
            (Content as Grid).Children.Add(_chart);
            _chart.BeginUpdate();
            _chart.EndUpdate();

        }*/
        public PSControl1()
            {
             InitializeComponent(); 
             string deploymentKey = "lgCAABW2ij + vBNQBJABVcGRhdGVhYmxlVGlsbD0yMDE5LTA2LTE1I1JldmlzaW9uPTACgD + BCRGnn7c6dwaDiJovCk5g5nFwvJ + G60VSdCrAJ + jphM8J45NmxWE1ZpK41lW1wuI4Hz3bPIpT7aP9zZdtXrb4379WlHowJblnk8jEGJQcnWUlcFnJSl6osPYvkxfq / B0dVcthh7ezOUzf1uXfOcEJ377 / 4rwUTR0VbNTCK601EN6 / ciGJmHars325FPaj3wXDAUIehxEfwiN7aa7HcXH6RqwOF6WcD8voXTdQEsraNaTYbIqSMErzg6HFsaY5cW4IkG6TJ3iBFzXCVfvPRZDxVYMuM + Q5vztCEz5k + Luaxs + S + OQD3ELg8 + y7a / Dv0OhSQkqMDrR / o7mjauDnZVt5VRwtvDYm6kDNOsNL38Ry / tAsPPY26Ff3PDl1ItpFWZCzNS / xfDEjpmcnJOW7hmZi6X17LM66whLUTiCWjj81lpDi + VhBSMI3a2I7jmiFONUKhtD91yrOyHrCWObCdWq + F5H4gjsoP0ffEKcx658a3ZF8VhtL8d9 + B0YtxFPNBQs =";
             LightningChartUltimate.SetDeploymentKey(deploymentKey);
             viewPolar.Sectors = new SectorCollection();
             axis.SupplyCustomAngleString += Axis_SupplyCustomAngleString;
             }

       // private Point firstPoint = new Point();
            
        /*public void INIT()
        {
            carImg.MouseLeftButtonDown += (ss, ee) =>
            {
                firstPoint = ee.GetPosition(this);
                carImg.CaptureMouse();
            };

            carImg.MouseWheel += (ss, ee) =>
            {
                Matrix mat = carImg.RenderTransform.Value;
                Point mouse = ee.GetPosition(carImg); 

                if (ee.RightButton == MouseButtonState.Pressed)
                {
                    if (ee.Delta > 0) mat.RotateAtPrepend(2, mouse.X, mouse.Y);
                    else mat.RotateAtPrepend(2,mouse.X,mouse.Y);
                } else
                {
                    if (ee.Delta > 0) mat.ScaleAtPrepend(1.15, 1.15, mouse.X, mouse.Y);
                    else mat.ScaleAtPrepend(1 / 1.15, 1 / 1.15, mouse.X, mouse.Y);
                }
                MatrixTransform mtf = new MatrixTransform(mat);
                carImg.RenderTransform = mtf;
            };
        }*/
        private void Axis_SupplyCustomAngleString(object sender, SupplyCustomAngleStringEventArgs e)
        {
            int degrees = (int)System.Math.Round(180f * e.Angle / System.Math.PI);

            switch (degrees)
            {
                case 0:
                    e.AngleAsString = "N";
                    break;

                case 90:
                    e.AngleAsString = "E";
                    break;

                case 180:
                    e.AngleAsString = "S";
                    break;

                case 270:
                    e.AngleAsString = "W";
                    break;

                default:
                    e.AngleAsString = degrees.ToString();
                    break;
            }
        }
       
       
       

        public void SetCountSectors(int countSectors)
        {
            if (countSectors < 2)
                countSectors = 2;
            axis.AngularAxisMajorDivCount = countSectors;
        }
     
        public void SetCarAngle(double angle)
        {
            rotatingCar.Angle = angle;
        }
     
        public void SetCountAerial(int countAerial)
        {
            if (countAerial < 1 || countAerial > 70)
                countAerial = 1;
            axis.MajorDivCount = countAerial;
        }
    }
}
