using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float cost;
    public MoneyManager moneyManager;


    private void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        Debug.Log(gameObject.name);
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            if (moneyManager.UpdateMoney(-cost))
            {
                Destroy(gameObject);
            }
        }
    }
   
}
