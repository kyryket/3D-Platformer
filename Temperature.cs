using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float temperatureNormal =36.6f;
    public int temperatureCritical = 32;
    public float temperatureCurrent = 36.6f;
    public float freezeSpeed = 0.1f;
    public int damage = 1;
    public Health health;
    public float freezeDamageTimer = 1;
	public float freezeDamageDelay = 2;
    void Update()
    {
        temperatureCurrent -= freezeSpeed * Time.deltaTime;
        if(temperatureCurrent <= temperatureCritical)
        {
            health.TakeDamage(damage);
            freezeDamageTimer += freezeDamageDelay;
        }
        else
        {
            freezeDamageTimer -= Time.deltaTime;
        }
    }
}
