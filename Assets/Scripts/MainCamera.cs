using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

    public float Z=-10f;
    public float Speed=3.0f;
    [SerializeField]
    GameObject Player;
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 Move = new Vector3(Player.transform.position.x, Player.transform.position.y,Player.transform.position.z-15f);
        transform.position = Vector3.MoveTowards(transform.position, Move, Speed * Time.deltaTime);
    }
    void SetHeight(float z)
    {
        Z = z*-1;
    }
}
