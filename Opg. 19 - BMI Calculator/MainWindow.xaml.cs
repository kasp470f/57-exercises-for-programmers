using System;
using System.Windows;

namespace BMI_Calculator
{
    public partial class MainWindow : Window
    {
        public double slValueHeightCode
        {
            get
            {
                return slValueHeight.Value;
            }

            set
            {
                slValueHeight.Value = value;
            }
        }

        public double slValueWeightCode
        {
            get
            {
                return slValueWeight.Value;
            }

            set
            {
                slValueWeight.Value = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BMI_Calculate(object sender, RoutedEventArgs e)
        {
            string system = WhichSystem.Text;
            double result;
            if (system == "Metric")
            {
                result = slValueWeightCode / Math.Pow(slValueHeightCode / 100, 2);
            }
            else if (system == "Imperial")
            {
                result = 703 * slValueWeightCode / Math.Pow(slValueHeightCode, 2);
            }
            else
            {
                result = 0;
            }

            BMI_Result.Text = string.Format("Your BMI is {0:0.00}.", result);
            if (result > 18.5 && result < 25)
            {
                BMI_Response.Text = "You are within the ideal weight range.";
            }
            else if (result < 18.5)
            {
                BMI_Response.Text = "You are underweight. You should see your doctor.";
            } 
            else
            {
                BMI_Response.Text = "You are overweight. You should see your doctor.";
            }
        }

        private void WhichSystem_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string system = WhichSystem.SelectedValue.ToString();
            string s = system.Split(' ')[1];
            try
            {
                switch (s)
                {
                    case "Metric":
                        Unit1.Text = "cm";
                        Unit2.Text = "kg";
                        slValueWeight.Maximum = 500;
                        slValueHeight.Maximum = 300;
                        break;
                    case "Imperial":
                        Unit1.Text = "in";
                        Unit2.Text = "lbs";
                        slValueWeight.Maximum = 700;
                        slValueHeight.Maximum = 12000;
                        break;
                }
            }
            catch (Exception)
            {
               
            }
            
        }
    }
}

