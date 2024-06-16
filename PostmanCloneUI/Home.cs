using PostmanCloneLibrary;

namespace PostmanCloneUI
{
    public partial class Home : Form
    {
        private readonly IApiAccess apiAccess = new ApiAccess();
        public Home()
        {
            InitializeComponent();
            httpVerbSelection.SelectedItem = "GET";
        }

        private async void callAPI_Click(object sender, EventArgs e)
        {
            systemStatus.Text = "";
            resultsTextx.Text = "";

            //validate the api url: https://jsonplaceholder.typicode.com/todos

            if (apiAccess.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Invalid URL";

                return;
            }

            try
            {
                systemStatus.Text = "Calling API...";

                //Replace with actual API call later
                //await Task.Delay(2000);
                resultsTextx.Text = await apiAccess.CallApiAsync(apiText.Text);
                callData.SelectedTab = resultsTab;
                resultsTab.Focus();

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsTextx.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error: ";
            }

        }
    }
}
