using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JunretCar : MonoBehaviour
{
    [SerializeField]
     GameObject carprefeb;
    [SerializeField]
    GameObject CoinPrefab;
    private void Start()
    {
        Invoke("Generetcar",0.5f);
        Invoke("GeneratCoin", 4);
    }
    public void Generetcar()
    {
        if (WinPage.isGameOver) return;          
        float ran = Random.Range(-1.87f, 1.87f);
        Vector3 pos = new Vector3(ran, 5.9f, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        if (UnityEngine.Random.RandomRange(0, 5) == 0)
        {
            Instantiate(CoinPrefab, pos, rotation);
        }
        else
        {
            Instantiate(carprefeb, pos, rotation);
        }       
        Invoke("Generetcar", Random.Range(.5f, 1.5f));
        Invoke("GeneratCoin", 3);
    }  
    public void Restat()
    {
        Destroycar();
        Invoke("Generetcar", 2);
        GameObject car = GameObject.Find("Car");
        car.transform.position = new Vector3(0, -3.11f, 0);
    }
    public void restartGame()
    {
        DestroyallCoins();
        Invoke("GeneratCoin", 4);
        GameObject Coin = GameObject.Find("Car");
        Coin.transform.position = new Vector3(0, -3.11f, 0);
    }
    private void Destroycar()
    {
        GameObject[] car = GameObject.FindGameObjectsWithTag("Anime");
        foreach (var item in car)
        {
            Destroy(item);
        }
        print("==>" + car.Length);
    }
    private void DestroyallCoins()
    {
        GameObject[] Coins = GameObject.FindGameObjectsWithTag("AnimesCoin");
        foreach (var coin in Coins)
        {
            Destroy(coin);
        }
        print("AAAAA === >" + Coins.Length);
    }   
}