using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovementDemo : MonoBehaviour
{
    [SerializeField]
    GameObject[] carPrefab;
    [SerializeField]
    GameObject coinPrefab;
    private void Start()
    {
        //Invoke("carGenerate", 2);
        Invoke("carGenerate", 2);
    }
    private void carGenerate()
    {
        float ranX = UnityEngine.Random.RandomRange(-1.77f, 1.77f);
        Vector3 pos = new Vector3(ranX, 6.5f, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        if (UnityEngine.Random.RandomRange(0, 3) == 0)
        {
            Instantiate(coinPrefab, pos, rotation);
        }
        else
        {
            Instantiate(carPrefab[0], pos, rotation);
        }
        Invoke("carGenerate", 1);
    }
}