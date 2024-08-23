using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveCar : MonoBehaviour
{    
    private void Update()
    {
        if (WinPage.isGameOver) return;
        moveCar();
    }
    public void moveCar()
    {
        var pos = transform.position;
        pos.y = Mathf.Max(pos.y - 0.1f, -6.7f);
        transform.position = pos;         
        if (pos.y <= -6.7f)
        {
            Destroy(gameObject);
        }           
    }
}