using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
//public GameObject youwintext;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        //youwintext.SetActive(false);
    }
  void OnTriggerEnter(Collider other){

    if(other.gameObject.tag=="Player"){
      //  youwintext.SetActive(true);
        StartCoroutine(Countdown());

    }
}
IEnumerator Countdown(){
    yield return new WaitForSeconds(delay);
    SceneManager.LoadScene(0);
}
}
