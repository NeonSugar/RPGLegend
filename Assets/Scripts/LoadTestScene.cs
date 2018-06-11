//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTestScene : MonoBehaviour {

    [SerializeField]
    GameObject Grass_01;
    [SerializeField]
    GameObject Grass_02;
    [SerializeField]
    GameObject Grass_03;
    [SerializeField]
    GameObject Grass_04;
    Vector3 position;
    float x = -8.5f, y = 7.5f;
    int n = 25;
	// Use this for initialization
	void Start () {
        position = new Vector2(x, y);
        for (int i = 0;i<n;i++)
            for (int j = 0; j < n; j++)
            {
                int rand = Random.Range(1, 4);
                position = new Vector2(x+(1f*j), y-(1f*i));//1f*i change 1f on 0.95
                if (rand == 1)
                Instantiate(Grass_01,position,Quaternion.identity);
                if (rand == 2)
                    Instantiate(Grass_02, position, Quaternion.identity);
                if (rand == 3)
                    Instantiate(Grass_03, position, Quaternion.identity);
                if (rand == 4)
                    Instantiate(Grass_04, position, Quaternion.identity);
            }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
