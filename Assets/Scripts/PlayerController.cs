using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed=4f;
    Rigidbody2D rigidbody2D;
    //private Animator animator;
    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
    }
	
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(moveX * Speed, moveY * Speed);
        //AnimateMovement(moveX, moveY);
    }
	//  Это п****ц, позже доделаю анимацию!
    //public void AnimateMovement(float moveX, float moveY)
    //{
        //animator.SetFloat("x", moveX);
        //animator.SetFloat("y", moveY);
    //}
}
