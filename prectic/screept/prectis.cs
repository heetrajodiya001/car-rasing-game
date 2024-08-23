using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject  MoveToEndGame;
    Vector3 initPos;
    private void Start()
    {
        initPos = transform.position;
    }
    private void Update()
    {
        if (WinPage.isGameOver) return;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            var pos = transform.position;
            pos.x = Mathf.Max(pos.x - 0.1f, -1.87f);
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {         
            var pos = transform.position;
            pos.x = Mathf.Min(pos.x + 0.1f, 1.87f);
            transform.position = pos;
        }        
       /* else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            var pos = transform.position;
            pos.y += .1f;
            transform.position = pos;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            var pos = transform.position;
            pos.y -= .1f;
            transform.position = pos;
        }  */      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        WinPage.isGameOver = true;       
        //collision.collider.gameObject.name
        MoveToEndGame.SetActive(true);
        print("OnCollisionEnter2D");
    }
}