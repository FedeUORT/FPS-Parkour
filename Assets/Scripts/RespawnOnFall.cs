using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnOnFall : MonoBehaviour
{
    [SerializeField] float yForRespawn;
    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.y<= yForRespawn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
