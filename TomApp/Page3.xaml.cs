using Microsoft.Maui.Controls;
using System;

namespace TomApp
{
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void OnValidateButtonClicked(object sender, EventArgs e)
        {
            var country = new Country
            {
                Name = TitleEntry.Text,
                Media = new Media { Flag = ImageEntry.Text },
                Capital = DescriptionEntry.Text,
                IsManuallyAdded = true
            };

            MessagingCenter.Send(this, "AddCountry", country);
        }
    }
}