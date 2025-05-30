using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txt_money;
    private void Start()
    {

    }
    public void UpdateMoneyText(string money)
    {
        txt_money.text = "$" + money;
    }
}
