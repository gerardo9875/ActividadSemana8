using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    Player_Movement mov;

    private void Awake()
    {
        
        rb = GetComponent<Rigidbody2D>();
        mov = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Movement>();

        mov = 
    }


    // Update is called once per frame
    void Update()
    {

        Move();

    }

    void Move()
    {

        //rb.velocity =
    }
}
