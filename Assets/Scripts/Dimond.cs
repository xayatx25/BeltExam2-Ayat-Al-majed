using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dimond : MonoBehaviour{
[SerializeField]private AudioSource collectsoundeffect;
    // Start is called before the first frame update
     
    [SerializeField] private Text dimondCounter;
    //[SerializeField] private string winnerscene;
    
    private int Collected =0;
    // Start is called before the first frame update
    void Start()
    {

     
    }
       void Update()
       {
        dimondCounter.text=(""+ Collected );
     
       }
    // Update is called once per frame
     void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Dimond"))
        {collectsoundeffect.Play();
            Collected+=1;

       Destroy(other.gameObject);
        }
         
         }
          
        
    }
  

