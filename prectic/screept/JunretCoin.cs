using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunretCoin : MonoBehaviour
{
    [SerializeField]
    GameObject CoinPrefab;
    private void Start()
    {
        Invoke("GeneratCoin", 2);
    }
    public void GeneratCoin()
    {
        //if (WinPage.isGameOver) return;
        float ran = Random.Range(-1.87f, 1.87f);
        Vector3 pos = new Vector3(ran, 5.9f, 0);
        Quaternion rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(CoinPrefab, pos, rotation);
        print("===-==-----------=");
        Invoke("GeneratCoin", 1);
    }  
    public void restartGame()
    {
        DestroyallCoins();
        Invoke("GeneratCoin", 2);
        GameObject Coin = GameObject.Find("Car");
        Coin.transform.position = new Vector3(0, -3.11f, 0);
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