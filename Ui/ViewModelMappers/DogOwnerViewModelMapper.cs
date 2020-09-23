using System.Collections.Generic;
using System.Linq;
using Ui.Models;
using Ui.Services;

namespace Ui.ViewModelMappers
{
    public class DogOwnerViewModelMapper
    {
        DogOwnerService dogOwnerService;
        public DogOwnerViewModelMapper(DogOwnerService dogOwnerService)
        {
            this.dogOwnerService = dogOwnerService;
        }


        public DogOwnerListViewModel GetAllDogOwners()
        {
            var dogOwners = dogOwnerService.GetAllDogOwners();
            var dogOwnerListViewModel = new DogOwnerListViewModel
            {
                DogOwnerViewModels = dogOwners.Select(e => new DogOwnerViewModel
                {
                    OwnerName = e.OwnerName,
                    DogNames = e.DogName
                }).ToList()
            };

            return dogOwnerListViewModel;
        }
    }
}