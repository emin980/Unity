using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject IsikKaynagi;//Konum elde etmek i�in
    public Vector3 eksen;//hangi eksende d�necek? x,y veya z.Program i�inden y ekseni etraf� olarak 0.25 ayarland�.
    public float aci; //d�n�� h�z�.
    // Update is called once per frame
    void Update()
    {
        //I���� x,y,z ekseninde d�nd�ren rotate k�sm�.
        transform.RotateAround(IsikKaynagi.transform.position, eksen, aci);
    }
}
