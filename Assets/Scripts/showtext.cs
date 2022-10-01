using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showtext : MonoBehaviour
{ 
    public GameObject Object;
    // Start is called before the first frame update

     
    void Start()
    {
        Object.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        Object.SetActive(true);
    }
   void OnTriggerExit(){
        Object.SetActive(false);
     Destroy(Object);
    }
    
}
