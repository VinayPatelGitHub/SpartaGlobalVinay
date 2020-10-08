using MoqExampleBackEnd.DbModel;

namespace MoqExampleBackEnd
{
    public interface ICatalogItemManager
    {
        string Find(string text);
        CatalogItem FindItem(string text);
        decimal GetPrice(string selectedItem);
    }
}