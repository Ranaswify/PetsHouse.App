using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using PetsHouse.Models;


namespace PetsHouse
{
    public partial class DetailsPage : ContentPage
    {
        private Pets selectedPet;
        public DetailsPage()
        {
            InitializeComponent();
        }

        public DetailsPage(Pets selectedPet)
        {
            InitializeComponent();
            this.selectedPet = selectedPet;
            mypet.Source = selectedPet.ImagePet;
            petName.Text = selectedPet.Name;
            petDescription.Text = "This is my cute pet";
        }
    }
}