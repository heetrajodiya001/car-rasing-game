using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //collision.collider.gameObject.name

        print("OnCollisionEnter2D");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        print("OnCollisionStay2D");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print("OnCollisionExit2D");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameObject
        print("====> OnTriggerEnter2D");
    }

}
