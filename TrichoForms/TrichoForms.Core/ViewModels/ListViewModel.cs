using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
            Items = new MvxObservableCollection<ListItem>();
        }

        public override async Task Initialize()
        {
            await Task.Run(() =>
            {
                IsBusy = true;

                Items.Clear();
                var items = _itemService.GetItems();
                Items.AddRange(items);

                IsBusy = false;
            });
        }


    }
}
