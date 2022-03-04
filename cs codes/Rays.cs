using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rays : MonoBehaviour
{
    static public float dif;
    public Camera kamera;
    public Vector2 num;

    // Start is called before the first frame update
    void Start()
    {
        kamera.rect = new Rect(0.4f + num.x * 0.1f / 2f, 0.4f + num.y * 0.1f / 2f, 0.05f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        if (num.x==0&& num.y == 1)
        {
            dif = transform.position.y;
        }
        kamera.orthographicSize = 0.035f + dif / 10f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            kamera.enabled = true;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
