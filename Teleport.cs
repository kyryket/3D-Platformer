using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    public Transform player;
    void OnTriggerEnter(Collider other)
    {
    player.transform.position = teleportPoint.transform.position;
    }
}
