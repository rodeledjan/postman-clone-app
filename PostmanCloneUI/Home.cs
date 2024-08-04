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
            resultsText.Text = "";

            //validate the api url: https://jsonplaceholder.typicode.com/todos
            if (apiAccess.IsValidUrl(apiText.Text) == false)
            {
                systemStatus.Text = "Invalid URL";
                return;
            }

            HttpAction action;

            if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
            {
                systemStatus.Text = "Invalid HTTP Verb";
            }

            try
            {
                systemStatus.Text = "Calling API...";

                //Replace with actual API call later
                //await Task.Delay(2000);
                resultsText.Text = await apiAccess.CallApiAsync(apiText.Text, bodyText.Text, action);
                callData.SelectedTab = resultsTab;
                resultsTab.Focus();

                systemStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                resultsText.Text = "Error: " + ex.Message;
                systemStatus.Text = "Error: ";
            }

        }

        private void resultsText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
