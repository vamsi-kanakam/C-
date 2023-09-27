using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_Methods
{
    public partial class HeartRateTopDownAlt : Form
    {
        public HeartRateTopDownAlt()
        {
            InitializeComponent();
        }

        private void btnTrainingRate_Click(object sender, EventArgs e)
        {

            //call GetPersonalData
            float restingHeartRate = 0, age = 0;
            GetPersonalData(ref restingHeartRate,ref age);

            //call ComputeTrainingRate
            float trainingHeartRate = 0;
            ComputeTrainingRate(restingHeartRate,age,ref trainingHeartRate);

            //call DisplayResults
            DisplayResults(restingHeartRate,age,trainingHeartRate);

        }

        private void ComputeTrainingRate(float restingRate,float age, ref float trainingRate)
        {
            float maxRate;
            maxRate = 220 - age;
            trainingRate = 0.6f * (maxRate - restingRate) + restingRate;
        }

        private void GetPersonalData(ref float restingRate,ref float age)
        {
            restingRate = float.Parse(txtRestingRate.Text);
            age = float.Parse(txtAge.Text);
        }

        private void DisplayResults(float restingRate,float age, float trainingRate)
        {
            lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Resting Rate:", restingRate));
            lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Age:", age));
            lstOutput.Items.Add(string.Format("{0,20}{1,10}", "Training Heart Rate:", trainingRate.ToString("N0")));
        }
    }
}
