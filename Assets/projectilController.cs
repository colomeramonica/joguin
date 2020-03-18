using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilController : MonoBehaviour
{
    Vector3 directionToMove;
    public float speed = 1;
    public float lifeTime = 5;
    public float initialTimer = 5;
    public GameObject shot;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        directionToMove = (mousePosition - this.transform.position).normalized * speed;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += directionToMove;

        lifeTime -= Time.deltaTime;
        if (lifeTime < 0)
            Destroy(this.gameObject);

    }
}
