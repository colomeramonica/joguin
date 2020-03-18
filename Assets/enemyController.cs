using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    float speed = 0.01f;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

     void follow()
    {
        Vector3 direction = player.position - this.transform.position;
        this.transform.position += direction.normalized * speed;
    }
}
