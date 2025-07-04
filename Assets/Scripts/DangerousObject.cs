using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerousObject : MonoBehaviour
{
    [SerializeField] float damage;
    HealthManager healthManager;
    private void Start()
    {
        healthManager = GameObject.FindObjectOfType<HealthManager>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            healthManager.Damage(damage);
            Destroy(gameObject);
        }
        else if (col.gameObject.CompareTag("PlayerSphere"))
        {
            Destroy(gameObject);
        }
    }
}