using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using PetsHouse.Models;
using PetsHouse.ViewModel;

namespace PetsHouse
{
	public partial class MainPage : ContentPage
	{
		ObservableCollection<Pets> pets = new ObservableCollection<Pets>();
		Pets selectedPet = new Pets();

		public MainPage()
		{
			InitializeComponent();
			allPets.SelectedItem = selectedPet;
			allPets.SelectionMode = SelectionMode.Single;
			pets.Add(new Pets { Name = "Cute Cat", Id = 1, ImagePet="cat.jpg" });
			pets.Add(new Pets { Name = "Amazing Dog", Id = 2, ImagePet = "dog1.jpg" });
			pets.Add(new Pets { Name = "Wonderfull Kitten", Id = 3, ImagePet = "kitten" });
			pets.Add(new Pets { Name = "Puppy", Id = 4, ImagePet = "puppy" });
			allPets.ItemsSource = pets;
			//petsViewModel.pets = selectedPet;
		}
		private void OnPetSelected(object sender, EventArgs e)
		{
			var i = allPets.SelectedItem as Pets;
			if (i.Name != null)
            {
				Navigation.PushAsync(new DetailsPage(allPets.SelectedItem as Pets));
			}

		}

	}
}