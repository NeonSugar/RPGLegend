using System.Collections.Generic;

public class ItemDataBase : Item
{
    public List<ItemStructure> ItemList = new List<ItemStructure>();

    public ItemStructure ItemGen(int win_id)
    {
        ItemStructure item = new ItemStructure();

        item.Name = ItemList[win_id].Name;
        item.Id = win_id;
        item.Sprite = ItemList[win_id].Sprite;
        item.ItemType = ItemList[win_id].ItemType;
        item.Description = ItemList[win_id].Description;

        return item;
    }
}
