using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer bgRenderer;
    public bool rollingOnX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rollingOnX){
            bgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime , 0);
        }else{
            bgRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
        }
    }
}
