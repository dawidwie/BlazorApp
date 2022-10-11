using BlazorApp.Models;




namespace BlazorApp.Pages
{
    public partial class Index
    {
        private List<Contact> contacts { get; set; }

        private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>
    {
        { "disabled", "disabled"},
        { "placeholder", "Contact Name"},
        { "type", "text"}
    };

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            contacts = new List<Contact>
        {
            new Contact
            {
                FirstName = "Dawid",
                LastName = "Wieczorek",
                Email = "dawid@gmail.com"
            },
            new Contact
            {
                FirstName = "Cp",
                LastName = "Cakelov",
                Email = "cp@gmail.com"
            },
            new Contact
            {
                FirstName = "Patrick",
                LastName = "Haugland",
                Email = "patrick@gmail.com"
            }
        };
            base.OnInitializedAsync();
        }
    }
}
