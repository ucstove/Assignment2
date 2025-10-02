using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Assignment2
{
    public partial class MainForm : Form
    {
        string selectedModel, yearst, features;
        int year;

        public MainForm()
        {
            InitializeComponent();
        }
        private enum Colors
        {
            red, blue, black, white
        }
        private Colors currentColor;

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

            if (radRed.Checked)
            {
                currentColor = Colors.red;
            }
            else if (radBlue.Checked)
            {
                currentColor = Colors.blue;
            }
            else if (radBlack.Checked)
            {
                currentColor = Colors.black;
            }
            else if (radWhite.Checked)
            {
                currentColor = Colors.white;
            }
            else
            {
                lblSummary.ForeColor = Color.Red;
                lblSummary.Text = "Please select a color.";
                return;
            }

            if (grpFeatures.Controls.OfType<CheckBox>().Any(c => c.Checked))
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
                features = features.TrimEnd(',', ' ');
            }
            else
            {
                features = "";
                lblSummary.ForeColor = Color.Black;
            }
            lblSummary.Text = $"You have purchased a {currentColor} {year} {selectedModel} {features}";
        }


    }
}
