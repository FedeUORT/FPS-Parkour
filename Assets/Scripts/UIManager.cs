using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_money;
    public TextMeshProUGUI txt_health;
    private void Start()
    {

    }
    public void UpdateMoneyText(string money)
    {
        txt_money.text = "$" + money;
    }
    public void UpdateHealthText(float health)
    {
        txt_health.text = "VIDA: " + health.ToString();
    }
}
