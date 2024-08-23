using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementDemo : MonoBehaviour
{
    [SerializeField]
    GameObject carPrefab;
    private void Start()
    {
        //Invoke("carGenerate", 2);
        InvokeRepeating("carGenerate" , 2 , 1);
    }
    private void carGenerate()
    {
        Vector3 pos = new Vector3(0, 6.5f, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(carPrefab, pos, rotation);
        //Invoke("carGenerate", 1);
    }
}