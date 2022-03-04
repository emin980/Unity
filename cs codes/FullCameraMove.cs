using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullCameraMove : MonoBehaviour
{
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 1.0f;
    float speed = 10.0f;
    void Update()
    {
        // Get the mouse delta. This is not in the range -1...1
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);
        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed * verticalSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed * horizontalSpeed);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalSpeed);
        }



    }

}
