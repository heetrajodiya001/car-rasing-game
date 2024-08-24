using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScripts : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
    }

}
