using System;
using System.Collections.Generic;
using MoqExampleBackEnd.DbModel;

namespace MoqExampleBackEnd
{
    public class CatalogItemManagerFake : CatalogItemManager
    {
        public CatalogItemManagerFake()
        {
            this._catalogItemList = new List<CatalogItem>
            {
                new CatalogItem() {CatalogItemId = 1, Brand = "Acme", Name = "Teaset", Price = 20.00m},
                new CatalogItem() {CatalogItemId = 2, Brand = "BigShot", Name = "Filofax", Price = 10.00m},
                new CatalogItem() {CatalogItemId = 3, Brand = "Fluffy Friends", Name = "Cuddly Toy", Price = 15.00m},
                new CatalogItem() {CatalogItemId = 4, Brand = "Dinarama", Name = "Record Player", Price = 60.00m},
            };
        }
    }
}
