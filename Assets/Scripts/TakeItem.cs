using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItem : MonoBehaviour {

    public bool isColliding;
    public Item.ItemStructure Item;
    GameObject GameController;
    public string[] allowedItems = {
        "Coin",
        "Sword",
        "Helment"
    };


    private void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
    }
    private void Update()
    { 
        isColliding = false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin" && !isColliding)
        {
            isColliding = true;
            GameController.GetComponent<Coins>().CountCoins++;
            GameController.GetComponent<Coins>().CUpdate();
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (isColliding) return;
        isColliding = true;
        /* When you acquire an item */
        if (other.gameObject.tag == "Item" && Input.GetKeyDown(KeyCode.E))
        {
            Take(other.gameObject.GetComponent<ItemForTake>().Id);
            Destroy(other.gameObject);
            Debug.Log("Try Take");
        }
    }
    public void Take(int Id)
    {
        Item = GameObject.FindGameObjectWithTag("GameController")
                         .GetComponent<ItemDataBase>()
                         .ItemGen(Id);

        SlotsInCharacter Inv = GameObject.FindGameObjectWithTag("PanelInv").GetComponent<SlotsInCharacter>();

        if (Item.ItemType == "Body")
        {
            if (Inv.Body.GetComponent<ItemInCharacterSlot>().isEmpty)
            {
                Inv.Body.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
                //Inv.Body.GetComponent<ItemInCharacterSlot>().Image.GetComponent<Color>().
                Inv.Body.GetComponent<ItemInCharacterSlot>().Check();
            }
            else DropInInv(Id);
        }
        else if (Item.ItemType == "Helment")
        {
            if (Inv.Helment.GetComponent<ItemInCharacterSlot>().isEmpty)
            {
                Inv.Helment.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
                Inv.Helment.GetComponent<ItemInCharacterSlot>().Check();
            }
            else DropInInv(Id);
        }
        else if (Item.ItemType == "Ring")
        {
            if (Inv.Ring_01.GetComponent<ItemInCharacterSlot>().isEmpty)
                Inv.Ring_01.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
            else if (Inv.Ring_02.GetComponent<ItemInCharacterSlot>().isEmpty)
                Inv.Ring_02.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
            else DropInInv(Id);
        }
        else if (Item.ItemType == "Braslet")
        {
            if (Inv.Braslet_01.GetComponent<ItemInCharacterSlot>().isEmpty)
                Inv.Braslet_01.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
            else if (Inv.Braslet_02.GetComponent<ItemInCharacterSlot>().isEmpty)
                Inv.Braslet_02.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
            else DropInInv(Id);
        }
        else if (Item.ItemType == "Boots")
        {
            if (Inv.Boots.GetComponent<ItemInCharacterSlot>().isEmpty)
                Inv.Boots.GetComponent<ItemInCharacterSlot>().itemInfo = Item;
            else DropInInv(Id);
        }
        else DropInInv(Id);
    }
    public void DropInInv(int Id)
    {
        List<GameObject> BagSlots = GameObject.FindGameObjectWithTag("PanelForSlots").GetComponent<InventorySlots>().Slots;
        foreach (GameObject Slot in BagSlots)
        {
            if (Slot.GetComponent<BagSlot>().isEmpty)
            {
                Slot.GetComponent<BagSlot>().Item = Item;
                Slot.GetComponent<BagSlot>().Check();
                break;
            }
        }
    }
}
