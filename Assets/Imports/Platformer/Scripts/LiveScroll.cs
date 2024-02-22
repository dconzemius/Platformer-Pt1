using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveScroll : MonoBehaviour
{
    public float start = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateEverySecond", 0, 1.0f);
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.mainTextureOffset = new Vector2(0f, start);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateEverySecond()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        if(mr.material.mainTextureOffset.y == 1 || mr.material.mainTextureOffset.y > 1)
        {
            mr.material.mainTextureOffset = new Vector2(0f,start);
        }
        mr.material.mainTextureOffset += new Vector2(0f, mr.material.mainTextureOffset.y);
    }
}
