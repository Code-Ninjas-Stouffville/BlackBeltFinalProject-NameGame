using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
     public float speed;

    [SerializeField]
    private Renderer bgRenderer;
    void Start()
    {


    }

    void Update()
    {

        //Vector2 offset = new Vector2(Time.time * Vertical_speed,0);
       // re.material.mainTextureOffset = offset;

         bgRenderer.material.mainTextureOffset += new Vector2(200 * Time.deltaTime, 200 * Time.deltaTime);
    }
}
