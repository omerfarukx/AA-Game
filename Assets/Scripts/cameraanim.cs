using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraanim : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (KucukCubuk.OyunBitti == true)
        {
            anim.SetBool("OyunBitti", true);
        }
        
    }
}
