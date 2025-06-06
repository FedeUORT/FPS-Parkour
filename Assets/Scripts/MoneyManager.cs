using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uiManager;
    void Start()
    {

    }

    void Update()
    {

    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("No podes comprar ñeri, falta money");
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }

    }
}
