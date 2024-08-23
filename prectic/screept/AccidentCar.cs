using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccidentCar : MonoBehaviour
{

   

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
