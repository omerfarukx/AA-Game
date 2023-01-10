using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject kucukCubuk;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KucukCubukSpawner();
        }
    }
    void KucukCubukSpawner()
    {
        Instantiate(kucukCubuk, transform.position, transform.rotation);
    }
}
