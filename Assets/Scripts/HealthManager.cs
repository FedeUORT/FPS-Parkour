using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    public UIManager uiManager;
    public float health;
    void Start()
    {
        uiManager.UpdateHealthText(health);
    }

    void Update()
    {

    }


    public void Damage(float damage)
    {
        health -= damage;
        uiManager.UpdateHealthText(health);
        if (health <= 0) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}