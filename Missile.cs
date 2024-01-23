using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 3;
    void Start()
    {
        Destroy(gameObject, 3);
    }
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
