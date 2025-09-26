namespace Assignment2
{
    public partial class MainForm : Form
    {
        string selectedModel, yearst, features;
        int year, color;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            yearst = txtYear.Text;
        }

        private void lstModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedModel = lstModels.SelectedItem.ToString();
        }

        private enum Colors
        {
            Red = 1, Blue = 2, Black = 3, White = 4
        }
        private void radColor_CheckedChanged(object sender, EventArgs e)
        {
            switch(color)
            {
                case 1:
                    color = (int)Colors.Red;
                    break;
                case 2:
                    color = (int)Colors.Blue;
                    break;
                case 3:
                    color = (int)Colors.Black;
                    break;
                case 4:
                    color = (int)Colors.White;
                    break;
                default:
                    lblSummary.ForeColor = Color.Red;
                    lblSummary.Text = "Please select a color.";
                    break;
            }
        }

        private void chkFeatures_CheckedChanged(object sender, EventArgs e)
        {
            features = "with the following features: ";
            if (chkAC.Checked)
            {
                features += "AC, ";
            }
            if (chkPowerWindows.Checked)
            {
                features += "Power Windows, ";
            }
            if (chkSyriusRadio.Checked)
            {
                features += "Syrius Radio, ";
            }
            if (chkLaneAssist.Checked)
            {
                features += "Lane Assist, ";
            }
            lblSummary.Text = features.TrimEnd(' ', ',');
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (lstModels.SelectedItem != null)
            {
                selectedModel = lstModels.SelectedItem.ToString();
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please select a car model.";
                return;
            }
            if (int.TryParse(txtYear.Text, out year))
            {
                year = int.Parse(txtYear.Text);
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please enter a valid year.";
                return;
            }
            lblSummary.Text = $"You have purchased a {year} {selectedModel} {features}";
        }


    }
}
