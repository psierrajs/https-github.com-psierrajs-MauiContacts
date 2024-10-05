
namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = new List<Contact>()
        {
        new Contact { Name = "John Doe", Email = "JohnDoe@gmail.com" },
        new Contact { Name = "Jane Doe", Email = "JaneDoe@yahoo.com" },
        new Contact { Name = "Tom Hanks", Email = "TomHanks@hollywood.com" },
        new Contact { Name = "Frank Liu", Email = "FrankLiu@gmail.com" },
        new Contact { Name = "Emily Clark", Email = "EmilyC@gmail.com" },
        new Contact { Name = "Michael Smith", Email = "MichaelS@outlook.com" },
        new Contact { Name = "Sophia Williams", Email = "SophiaW@yahoo.com" },
        new Contact { Name = "David Johnson", Email = "DavidJ@gmail.com" },
        new Contact { Name = "Linda Brown", Email = "LindaB@gmail.com" },
        new Contact { Name = "James White", Email = "JamesWhite@company.com" }
        };


        listContacts.ItemsSource = contacts;
    }

    public class Contact
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }

    private void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        DisplayAlert("test", "test", "OK");
        listContacts.SelectedItem = null;
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}