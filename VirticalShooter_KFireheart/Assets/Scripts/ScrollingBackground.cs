using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;

    [SerializeField] private Renderer bgRenderer;
   
   //on update it makes the backgroudn loop on the y axis
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
    }
}
