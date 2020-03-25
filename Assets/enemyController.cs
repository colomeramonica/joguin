using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    float speed = 0.01f;
    float areaCone = 0.4f;
    float newX;
    float newY;
    float corridinha = 10f;
    float radius = 1f;
    

    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Recupera a posição de onde está o personagem
        float angulo = Mathf.Atan2(player.position.y - transform.position.y, player.position.x - transform.position.x) * Mathf.Rad2Deg;
        newX = radius * Mathf.Cos(transform.eulerAngles.z * Mathf.Deg2Rad);
        newY = radius * Mathf.Sin(transform.eulerAngles.z * Mathf.Deg2Rad);

        Vector3 playerDir = new Vector3(newX, newY, 0).normalized;

        // Recupera a direção para onde ir até o personagem
        Vector3 direcao = (player.position - transform.position).normalized;

        // Recupera o angulo entre a visão do inimigo e o personagem
        float dotValue = Vector3.Dot(direcao, playerDir);

        // Se o personagem estiver no ângulo de visão do inimigo, o inimigo avança
        if (dotValue > areaCone) //TODO
        {
            // Recupera a distância entre o personagem e o inimigo
            float distanciaInimigoAlvo = Vector3.Distance(player.position, transform.position);

            if (distanciaInimigoAlvo < corridinha) {
                follow(2);
            } else {
                follow(1);
            }            
        }
    }

     void follow(int faster)
    {
        Vector3 direction = player.position - this.transform.position;
        this.transform.position += direction.normalized * (speed * faster);
    }
}
