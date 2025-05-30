using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    void Start()
    {
    }

    void Update()
    {
        
    }

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No podes comprar ñeri, falta money");
        }
        else
        {
            money += amount;
        }
        money += amount;

    }
}
