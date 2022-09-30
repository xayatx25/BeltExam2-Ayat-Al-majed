using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    public float healthAmount;
   


    void Update()
    {
        healthBar.fillAmount = healthAmount;
        if (healthAmount <= 0)
            Die();
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            healthAmount -= 2.5f * Time.deltaTime;
            
          
          
        }
    }
}

