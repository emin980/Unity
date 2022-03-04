using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    public float hiz;
    public float acilma;
    public GameObject start;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(((transform.position.x - start.transform.position.x) * acilma - GetComponent<Rigidbody>().velocity.x), ((transform.position.y - start.transform.position.y) * acilma - GetComponent<Rigidbody>().velocity.y), 10f * (hiz - GetComponent<Rigidbody>().velocity.z)));
    }
}
