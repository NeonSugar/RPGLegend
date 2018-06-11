using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coins : MonoBehaviour {

    [SerializeField]
    GameObject Text;
    public int CountCoins;
	public void CUpdate () {
        Text.GetComponent<Text>().text = CountCoins.ToString();
	}
}
