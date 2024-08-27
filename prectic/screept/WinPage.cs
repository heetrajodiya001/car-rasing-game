using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPage : MonoBehaviour
{
    public static bool isGameOver = false;
    public GameObject MoveToEndGame;
    public JunretCar junretCar;
    public JunretCoin junretCoin;
    public Practic ResetScore;
    private void Start()
    {
        if (ResetScore == null)
        {
            ResetScore = FindObjectOfType<Practic>();
        }
        if(junretCoin == null)
        {
            junretCoin = FindObjectOfType<JunretCoin>();
        }
    }
    public void MoveToplayGame()
    {
       
        MoveToEndGame.SetActive(false);
        junretCar.Restat();
        ResetScore.ResetScore();
        junretCoin.restartGame();
        isGameOver = false;
    }
}