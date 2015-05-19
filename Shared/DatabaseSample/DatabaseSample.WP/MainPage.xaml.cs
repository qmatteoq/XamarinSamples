using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using DatabaseSample.PCL;
using DatabaseSample.PCL.Entities;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace DatabaseSample.WP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DatabaseHelper helper = new DatabaseHelper();
            helper.CreateDatabase();
        }

        public void OnAddItemClicked(object sender, RoutedEventArgs e)
        {
            DatabaseHelper helper = new DatabaseHelper();
            Person person = new Person
            {
                Name = UserName.Text,
                Surname = UserSurname.Text
            };

            helper.Add(person);
        }

        public void OnGetItemsClicked(object sender, RoutedEventArgs e)
        {
            DatabaseHelper helper = new DatabaseHelper();
            List<Person> persons = helper.GetUsers();
            PeopleList.ItemsSource = persons;
        }
    }
}
