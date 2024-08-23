/*using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Rode : MonoBehaviour
{
    Material rodemat;
    Vector2 offset = Vector2.zero;
    void Start()
    {
        rodemat = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        offset.y += .5f*Time.deltaTime;
        rodemat.SetTextureOffset("_MainTex", offset);
    }
}*/