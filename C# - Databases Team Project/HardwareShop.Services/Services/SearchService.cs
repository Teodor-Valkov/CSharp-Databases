﻿namespace HardwareShop.Services.Services
{
    using AutoMapper;
    using Contracts;
    using Data;
    using Models.EntityModels;
    using Models.ViewModels.Items;
    using PagedList;
    using System.Collections.Generic;
    using System.Linq;

    public class SearchService : ISearchService
    {
        public IEnumerable<HomeItemsViewModel> SearchItems(string searchString, int? page)
        {
            using (var context = new HardwareShopContext())
            {
                searchString = searchString ?? string.Empty;

                var items = context.Items
                    .Where(i => (i.ManufacturerName.Contains(searchString) || i.Model.Contains(searchString)) && i.IsDeleted == false)
                    .Distinct()
                    .ToList();

                var model = Mapper.Map<IEnumerable<Item>, IEnumerable<HomeItemsViewModel>>(items);

                return model.ToPagedList(page ?? 1, 3);
            }
        }
    }
}