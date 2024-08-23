using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movecoin : MonoBehaviour
{   
    private void Update()
    {
        if (WinPage.isGameOver) return;
        moveCoin();
    }
    public void moveCoin()
    {
        var pos = transform.position;
        pos.y = Mathf.Max(pos.y - 0.1f, -6.7f);
        transform.position = pos;
        if (pos.y <= -6.7f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {       
        Destroy(gameObject);
        print("hello");
    }
}