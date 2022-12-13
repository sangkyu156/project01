using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    


    void Move()
    {
        Vector3 movePosition = Vector3.zero;

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            movePosition = Vector3.left;
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            movePosition = Vector3.right;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        transform.position += movePosition * moveSpeed * Time.deltaTime;
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }
}
