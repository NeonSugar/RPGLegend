using UnityEngine;
using UnityEngine.UI;

public class ItemInCharacterSlot : MonoBehaviour {

    [SerializeField]
    public string SlotType;
    [SerializeField]
    public int id = -1;
    [SerializeField]
    public Item.ItemStructure itemInfo = new Item.ItemStructure();
    [SerializeField]
    public GameObject Image;
    [SerializeField]
    public bool isEmpty = true;
    [SerializeField]
    public Sprite EmptySlot;

    public void Start()
    {
        Check();
    }

    public void Check()
    {
        if (itemInfo.Id != -1) isEmpty = false;
        if (isEmpty) Image.active = false;
        else
        {
            Image.active = true;
            Image.GetComponent<Image>().sprite = itemInfo.Sprite;
        }
        
    }
}
