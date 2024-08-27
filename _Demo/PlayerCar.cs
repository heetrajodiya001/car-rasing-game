using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{

    public float speed;

    private void Update()
    {
        var pos = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("OnTriggerEnter2D:" + collision.tag);
        if (collision.tag == "Anime")
        {

        }
        else if (collision.tag == "AnimesCoin")
        {
            Destroy(collision.gameObject);
        }
    }
}
