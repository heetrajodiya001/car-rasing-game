using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPage : MonoBehaviour
{
    public static bool isGameOver = false;
    public GameObject MoveToEndGame;
    public JunretCar junretCar;
    public JunretCoin junretCoin;
    public void MoveToplayGame()
    {
        isGameOver = false;
        MoveToEndGame.SetActive(false);
        junretCar.restartGame();
        junretCoin.restartGame();
    }
}