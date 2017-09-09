using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _2_Quote_Slider
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public String[] Quotes;
        private int _index;

        public QuotesPage()
        {
            _index = 0;
            Quotes = new[]
            {
                "Quote 1",
                "Quote 2",
                "Quote 3",
                "Quote 4",
                "Quote 5",
                "Quote 6"
            };

            InitializeComponent();

            Label.Text = Quotes[0];


        }

        private void Next_OnClicked(object sender, EventArgs e)
        {
            _index++;
            if (_index >= Quotes.Length)
                _index = 0;
            Label.Text = String.Format("{0}",  Quotes[_index]);
        }
    }
}