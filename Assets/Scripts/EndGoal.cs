using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
   
    public GameObject particle;
    public int TimeToWin;

    [SerializeField] private string WinScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           Invoke( "Winner" , TimeToWin);
           particle.SetActive(true);
        }
    }

    void Winner()
    {
        SceneManager.LoadScene(WinScene);
        Debug.Log("You are a winner!");
    }
}

