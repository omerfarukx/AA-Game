using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCubuk : MonoBehaviour
{
    Rigidbody2D rb;
    public float hiz;
    public bool hareketkisitlimi;
    OyununSonu oyununsonuScripti;
    public GameObject yonetici;
    public static bool OyunBitti;

    void Start()
    {
        yonetici = GameObject.FindGameObjectWithTag("Yonetici");
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hareketkisitlimi == false)
        {
            rb.MovePosition(rb.position + Vector2.up*hiz*Time.deltaTime);
        }
        
    }

    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "BuyukCember")
        {
            transform.SetParent(col.gameObject.transform);
            
            hareketkisitlimi = true;
        }
        if (col.gameObject.tag == "Cember")
        {
            OyunBitti = true;
            yonetici.GetComponent<OyununSonu>().OyunuBitir();
        }
    }


}
