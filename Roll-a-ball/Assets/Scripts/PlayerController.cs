using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movmentX;
    private float movmentY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void OnMove(InputValue movmentValue)
    {
        Vector2 movmentVector = movmentValue.Get<Vector2>();

        movmentX = movmentVector.x;
        movmentY = movmentVector.y;
    }

    void FixedUpdate()
    {
        Vector3 movment = new Vector3(movmentX, 0.0f, movmentY);
        rb.AddForce(movment * speed);
    }
}
