using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusController : MonoBehaviour {
    [SerializeField]
    private GameObject InvMenu;
    [SerializeField]
    private GameObject BagMenu;
    //[SerializeField]
    //private GameObject PauseMenu;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.I)) InvMenu.active = !InvMenu.active;
        if (Input.GetKeyDown(KeyCode.B)) BagMenu.active = !BagMenu.active;
    }
}
