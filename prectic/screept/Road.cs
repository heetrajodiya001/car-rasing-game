using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Road : MonoBehaviour
{
    Material roadMat;
    Vector2 offset = Vector2.zero;

    void Start()
    {
        roadMat = GetComponent<MeshRenderer>().material;
    }
    void Update()
    {
        if (WinPage.isGameOver) return;
        offset.y += .5f * Time.deltaTime;
        roadMat.SetTextureOffset("_MainTex", offset);
    }   
}