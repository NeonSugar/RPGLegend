using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    [SerializeField]
    int ChestLvl;
    [SerializeField]
    Sprite OpenChest;
    bool canOpen = false;
    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag=="Player")
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Chest OPEN!!!");
                gameObject.GetComponent<SpriteRenderer>().sprite = OpenChest;
            }
        }
    }
    private void Nagrada()
    {
        int rnd = Random.Range(0, 2);
        //Nagrada(ChestLvl+rnd);
    }
}
