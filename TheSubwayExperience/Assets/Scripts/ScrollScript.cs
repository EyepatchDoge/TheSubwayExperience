using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{

    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;

    public void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    public void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}

