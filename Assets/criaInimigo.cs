using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaInimigo : MonoBehaviour
{
    float timer = 5;
    float speed = 0.01f;
    public GameObject inimigo;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5) {
            newEnemy();
        }
    }

    void newEnemy()
    {
        Vector3 sortedPosition = new Vector3(Random.Range(-5,5),Random.Range(-5,5),0);
        float sortedAngle = Random.Range(0, 360);

        Instantiate(inimigo, sortedPosition, Quaternion.Euler(0, 0, sortedAngle));

        timer = 0;
    }
}
