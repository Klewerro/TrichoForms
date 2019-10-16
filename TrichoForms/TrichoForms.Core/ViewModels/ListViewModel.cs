using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using TrichoForms.Core.Interfaces;
using TrichoForms.Core.Models;
using TrichoForms.Core.Services;

namespace TrichoForms.Core.ViewModels
{
    public class ListViewModel : ViewModelBase
    {
        private readonly IItemService _itemService;
        private MvxObservableCollection<ListItem> _items;
        private bool _isBusy;

        public MvxObservableCollection<ListItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }


        public ListViewModel(IMvxNavigationService navigationService, IItemService itemsService) : base(navigationService)
        {
            _itemService = itemsService;
        }

        public override async void ViewAppeared()
        {
            Items = await GetItemsAsync();
        }

        public IMvxAsyncCommand RefreshCommand => new MvxAsyncCommand(async ()
            => Items = await GetItemsAsync());

        public ICommand ItemSelectedCommand => new MvxCommand<ListItem>(item 
            => UserDialogs.Instance.Toast(item.Title, TimeSpan.FromSeconds(5)));


        private async Task<MvxObservableCollection<ListItem>> GetItemsAsync()
        {
            try
            {
                IsBusy = true;

                var items = await _itemService.GetItemsAsync();
                return new MvxObservableCollection<ListItem>(items);
            }
            catch (System.IO.IOException ex)
            {
                await UserDialogs.Instance.AlertAsync(ex.Message, "Error", "Ok");
                await NavigationService.Close(this).ConfigureAwait(false);
            }
            finally
            {
                IsBusy = false;
            }

            return new MvxObservableCollection<ListItem>();
        }




    }
}
