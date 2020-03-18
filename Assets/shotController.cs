using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotController : MonoBehaviour
{
    public GameObject shot;
    Vector3 directionToMove;
    Vector3 mousePosition;
    float angle;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        angle = Mathf.Atan2(mousePosition.y - this.transform.position.y, mousePosition.x - this.transform.position.x) * Mathf.Rad2Deg;

        if (Input.GetButtonDown("Fire1")) {
            Instantiate(shot, this.transform.position, Quaternion.Euler(0, 0, angle));
        }
    }
}
