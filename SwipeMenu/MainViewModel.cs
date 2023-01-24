using System;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SwipeMenu
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel()
		{
			Items = new List<string>()
			{
				"Gibson",
				"Fender",
				"Rickenbacker",
				"Höfner",
				"Hagström",
				"Ibanez",
				"Jackson",
				"PRS",
				"Gretsch",
				"Epiphone"
			};
		}

		[ObservableProperty]
		private List<string> items;

		[RelayCommand]
		public void Remove()
		{
		}

        [RelayCommand]
        public void Flag()
        {
        }
    }
}

