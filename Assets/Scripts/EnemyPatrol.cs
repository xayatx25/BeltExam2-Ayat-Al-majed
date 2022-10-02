using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    private GameObject Player;
    private bool detected = false;
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float playerDistance = (transform.position - Player.transform.position).magnitude;
        if (playerDistance <= 7)
        {
            transform.position = Vector3.Lerp(transform.position, Player.transform.position, Time.deltaTime);
            transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
        }

    }
}
