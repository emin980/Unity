using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public GameObject ray;
    public GameObject sphare;
    public int sizex;
    public int sizey;

    private GameObject rayI;
    private GameObject spherel;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<= sizex; i++)
        {
            for (int j = 0; j <= sizey; j++)
            {
                if (!(i == 0 && j == 0))
                {
                    if (i != 0)
                    {
                        rayI = Instantiate(ray, new Vector3(i * 0.01f, j * 0.01f, 0f), Quaternion.identity);
                        spherel = Instantiate(sphare, new Vector3(i * 0.01f, j * 0.01f, 0f), Quaternion.identity);
                        rayI.GetComponent<Rays>().num = new Vector2(i, j);
                        rayI.GetComponent<Rays>().enabled = false;
                        rayI.GetComponent<Hareket>().enabled = false;
                        rayI.transform.parent = gameObject.transform;
                        spherel.transform.parent = gameObject.transform;
                        rayI.GetComponent<Hareket>().start = gameObject;
                        spherel.GetComponent<Hareket>().start = gameObject;
                        rayI = Instantiate(ray, new Vector3(-i * 0.01f, -j * 0.01f, 0f), Quaternion.identity);
                        spherel = Instantiate(sphare, new Vector3(-i * 0.01f, -j * 0.01f, 0f), Quaternion.identity);
                        rayI.GetComponent<Rays>().num = new Vector2(-i, -j);
                        rayI.GetComponent<Rays>().enabled = false;
                        rayI.GetComponent<Hareket>().enabled = false;
                        rayI.transform.parent = gameObject.transform;
                        spherel.transform.parent = gameObject.transform;
                        rayI.GetComponent<Hareket>().start = gameObject;
                        spherel.GetComponent<Hareket>().start = gameObject;
                    }
                    if (j != 0)
                    {
                        rayI = Instantiate(ray, new Vector3(i * 0.01f, -j * 0.01f, 0f), Quaternion.identity);
                        spherel = Instantiate(sphare, new Vector3(i * 0.01f, -j * 0.01f, 0f), Quaternion.identity);
                        rayI.GetComponent<Rays>().num = new Vector2(i, -j);
                        rayI.GetComponent<Rays>().enabled = false;
                        rayI.GetComponent<Hareket>().enabled = false;
                        rayI.transform.parent = gameObject.transform;
                        spherel.transform.parent = gameObject.transform;
                        rayI.GetComponent<Hareket>().start = gameObject;
                        spherel.GetComponent<Hareket>().start = gameObject;
                        rayI = Instantiate(ray, new Vector3(-i * 0.01f, j * 0.01f, 0f), Quaternion.identity);
                        spherel = Instantiate(sphare, new Vector3(-i * 0.01f, j * 0.01f, 0f), Quaternion.identity);
                        rayI.GetComponent<Rays>().num = new Vector2(-i, j);
                        rayI.GetComponent<Rays>().enabled = false;
                        rayI.GetComponent<Hareket>().enabled = false;
                        rayI.transform.parent = gameObject.transform;
                        spherel.transform.parent = gameObject.transform;
                        rayI.GetComponent<Hareket>().start = gameObject;
                        spherel.GetComponent<Hareket>().start = gameObject;
                    }
                }
            }
        }

        GetComponent<Rays>().enabled = false;
        GetComponent<Hareket>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
