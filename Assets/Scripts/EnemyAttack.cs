using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private PlayerController playerScript;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            rb = player.GetComponent<Rigidbody>();
            playerScript = player.GetComponent<PlayerController>();
            PushPlayer();
        }

    }
    private void PushPlayer()
    {
        playerScript.enabled = false;
        rb.AddForce(Vector3.up * 250);

        if (player.transform.position.x < transform.position.x)
            rb.AddForce(Vector3.right * -500);
        else
            rb.AddForce(Vector3.right * 500);

        Invoke("MoveAgain", 1);
    }
    private void MoveAgain()
    {
        playerScript.enabled = true;
    }

}
