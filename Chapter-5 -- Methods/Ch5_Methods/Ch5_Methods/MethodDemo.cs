    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Ch5_Methods
    {
        public partial class MethodDemo : Form
        {
            public MethodDemo()
            {
                InitializeComponent();
            }

            private void btnAbout_Click(object sender, EventArgs e)
            {
                DisplayInfo();

            }

            private void DisplayInfo()
            {
                string greeting;
                if (DateTime.Now < DateTime.Parse("12:00 PM"))
                    greeting = "Good Morning!";
                else if (DateTime.Now < DateTime.Parse("6:00 PM"))
                    greeting = "Good Afternoon!";
                else
                    greeting = "Good Evening!";

                MessageBox.Show(greeting + "Tis form computes training heart rate" + ": 0.6*(220-Age-RestingRate) + RestingRate");

            }
        
            private void btnTrainingRate_Click(object sender, EventArgs e)
            {
                //Get personal data
                //float restingRate = float.Parse(txtRestingRate.Text);
                //float age = float.Parse(txtAge.Text);
                //var personalData = PersonalData();
                //float restingRate = personalData.restingRate;
                //float age = personalData.age;
                float restingRate, age;
                (restingRate, age) = PersonalData();
                //Compute training rate
                float trainingRate = ComputeTrainingRate(restingRate,age);

                //Display results
                DisplayResults(restingRate,age,trainingRate);
            }

            private float ComputeTrainingRate(float restingRate, float age)
            {
                float maxRate = 220 - age;
                return 0.6f * (maxRate - restingRate) + restingRate;

            }

            private (float, float) PersonalData()
            {
                float restingRate, age;
                restingRate = float.Parse(txtRestingRate.Text);
                age = float.Parse(txtAge.Text);

                return (restingRate, age);
            }

            private void DisplayResults(float restingRate, float age,float trainingRate)
            {
                lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Resting Heart Rate:", restingRate));
                lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Age:", age));
                lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Training Rate:", trainingRate.ToString("N0")));
            }
        }
    }
