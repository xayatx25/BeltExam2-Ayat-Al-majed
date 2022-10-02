using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorPass : MonoBehaviour
{
    public Animator[] animLR;
    public bool IsPass;
    public bool IsPanleShow;
   
    public GameObject passPanle;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Open_()
    {
        animLR[0].SetBool("opening" , true);
        animLR[1].SetBool("opening" , true);
        passPanle.SetActive(false); Debug.Log("pass is TRUE X22");
    }

      void Close_()
    {
        animLR[0].SetBool("opening" , false);
        animLR[1].SetBool("opening" , false);
    }


    public void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.tag == "Player")
        {
            
            Debug.Log("player here");
            if(!IsPass)
            {
               passPanle.SetActive(true);
               IsPanleShow = true;
            }
            else
            {
                //open door
                Open_();
                IsPanleShow = false;
            }
        }
    }


     public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
          
          passPanle.SetActive(false);
          Close_();
          IsPanleShow = false;
           
        }
    }


}
