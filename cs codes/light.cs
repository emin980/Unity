using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public GameObject IsikKaynagi;//Konum elde etmek için
    public Vector3 eksen;//hangi eksende dönecek? x,y veya z.Program içinden y ekseni etrafý olarak 0.25 ayarlandý.
    public float aci; //dönüþ hýzý.
    // Update is called once per frame
    void Update()
    {
        //Iþýðý x,y,z ekseninde döndüren rotate kýsmý.
        transform.RotateAround(IsikKaynagi.transform.position, eksen, aci);
    }
}
