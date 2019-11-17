using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LibraryApp.Search
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        List<string> Books;
        List<string> newlist = new List<string>() { };
        public SearchPage()
        {
            InitializeComponent();
            
            Books = new List<string> { "Book1", "Book2", "Search1", "Book4", "Book3", "Search2", "Book5", "Book6", "Search3", "Book7", "Book8", "Search4", "Book12", "Book22", "2Search1", "B2ook1", "B2ook2", "Se2arch1", };
            searchResults.ItemsSource = newlist;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            newlist.Clear();
            foreach (string s in Books)
            {

                // To check match second possibility 
                if (s.StartsWith(e.NewTextValue))
                {
                    newlist.Add(s);
                }
            }
            searchResults.ItemsSource = null;
            searchResults.ItemsSource = newlist;
        }

    }
}