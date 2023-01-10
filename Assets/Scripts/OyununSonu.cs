using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyununSonu : MonoBehaviour
{

    public GameObject donenBuyukCember;
    public GameObject SpawnLokasyonu;
    private void Start()
    {
        
    }
    public void OyunuBitir()
    {
        donenBuyukCember.GetComponent<DonenBuyukCember>().enabled = false;
        SpawnLokasyonu.GetComponent<Spawner>().enabled = false;
        
    }
}
