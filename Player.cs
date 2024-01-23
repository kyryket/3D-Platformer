using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform attackPoint;
    void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        } 
    }
}
