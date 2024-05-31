using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Home : Form
    {
        private readonly ApiAccess apiAccess = new();
        public Home()
        {
            InitializeComponent();
        }

        private async void callAPI_Click(object sender, EventArgs e)
        {
            try
            {
                systemStatus.Text = "Calling API...";

                //Replace with actual API call later
                //await Task.Delay(2000);
                resultsText.Text = await apiAccess.CallApiAsync(apiText.Text);


                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error: ";
            }

        }
    }
}
