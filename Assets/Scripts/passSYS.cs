using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class passSYS : MonoBehaviour
{
 public Text DisplayPass;
  
 public string a;
 public string b;
 public string c;
 public string d;

 string passShow;

 int numTry;
 bool passWrong;

  doorPass dp;

  void Start()
  {
    dp = FindObjectOfType<doorPass>().GetComponent<doorPass>();
  }

  void OnEnable()
  {
    numTry = 0;
    passWrong = false;
    DisplayPass.text = "Enter PIN";
  }

  public void takeNextNumPass(string num)
  {
        if(numTry < 4)
        {
        
              if(num != a && numTry == 0) {passWrong = true;} 
          
              if(num != b && numTry == 1) {passWrong = true;} 
            
              if(num != c && numTry == 2) {passWrong = true;} 
           
              if(num != d && numTry == 3) {passWrong = true;} 
               passShow = passShow + num;
               DisplayPass.text = passShow ;

        }
  
        numTry++;
        if(numTry >3 && !passWrong)
        {
           OpenDoor();
        }else if(numTry >3 && passWrong)
        {
           TryAgain();
        }
    }
  

  void OpenDoor()
  {
    Debug.Log("pass is TRUE");
    dp.Open_();
    dp.IsPass = true;
  }
  void TryAgain()
  {
    numTry = 0;
    Debug.Log("pass is FALSE");
    passWrong = false;
    DisplayPass.text = "Wrong";
    passShow = "";
  }

  
}
