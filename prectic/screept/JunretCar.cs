using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JunretCar : MonoBehaviour
{
    [SerializeField]
    GameObject carPrefab;
    private void Start()
    {
        Invoke("Generatcar", 1);       
    }
    public void Generatcar()
    {
        if (WinPage.isGameOver) return;

        float ran = Random.Range(-1.87f, 1.87f);
        Vector3 pos = new Vector3(ran, 5.9f, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(carPrefab, pos, rotation);
        print("===-===");
        Invoke("Generatcar", 2);
    }
    public void  restartGame()
    {
        DestroyAllCars();
        Invoke("Generatcar", 1);
        GameObject car = GameObject.Find("Car");
        car.transform.position = new Vector3(0, -3.11f, 0);
    }
    private void DestroyAllCars()
    {
        GameObject[] cars = GameObject.FindGameObjectsWithTag("Anime");
        foreach (var item in cars)
        {
            Destroy(item);
        }
        print("===> " + cars.Length);
    }
}