using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            //transform.Rotate(0f, 90.0f, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
            //transform.Rotate(0f, 90.0f, 0.0f, Space.World);
        }
        else
        {
            //transform.Rotate(0f, 0.0f, 0.0f, Space.World);
        }
    }

}
