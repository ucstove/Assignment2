namespace Assignment2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(txtYear.Text, out year))
            {
                year = int.Parse(txtYear.Text);
            }
            else
            {
                lblSummary.ForeColor= Color.Red;
                lblSummary.Text = "Please enter a valid year.";
            }
        }

        private void lstModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModels.SelectedItem != null)
            {
                string selectedModel = lstModels.SelectedItem.ToString();
                MessageBox.Show($"You selected: {selectedModel}");
            }
        }
    }
}
