using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagSlot : Item {

    public GameObject Image;
    public bool isEmpty = true;
    public ItemStructure Item;

    public void Start()
    {
        Check();
    }
    public void Check()
    {
        if (Item.Id != -1) { isEmpty = false; Image.active = true; }
        if (!isEmpty) Image.GetComponent<Image>().sprite = Item.Sprite;
        if (isEmpty) Image.active = false;
    }
    
}
