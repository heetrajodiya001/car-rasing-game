using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Practic : MonoBehaviour
{
    public GameObject  MoveToEndGame;
    Vector3 initPos;
    public Text Text;
    private int score = 0;

    private void Start()
    {
        initPos = transform.position;
        UpdateScore();
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Hsadkjfhgads");
        print("OnTriggerEnter2D:" + collision.tag);
        if (collision.tag == "Anime")
        {
            print("A =====>"+ collision.tag);
        }
        else if (collision.tag == "AnimesCoin")
        {
            collision.transform.DOMove(new Vector2(-1.68f, 4.38f), 0.5f);
            Destroy(collision.gameObject,0.51f);
            score++;
            UpdateScore();
        } 
    }
    private void UpdateScore()
    {
        Text.text = "" + score.ToString();
    }
    public void ResetScore() 
    {
        score = 0;
        UpdateScore();
    }
}