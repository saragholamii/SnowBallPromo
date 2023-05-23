using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private float speedZ = 6f;
    private float speedX = 5f;
    private Rigidbody rb;
    private Vector3 startPos;
    private float xForce = 10f;
    private float step;
    // Start is called before the first frame update
    void Start()
    {
        //previusePosition = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, 0f, -speedZ * 2);
        //rb.AddForce(new Vector3(additionalForce, additionalForce, 0f), ForceMode.Force); 
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(2, transform.position.y, transform.position.z - 1f), speedX);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-2, transform.position.y, transform.position.z - 1f), speedX);
        }
    }
}
