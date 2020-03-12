using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kerub : MonoBehaviour
{
    public Transform player;
    public float speed = 5.0f;
    public float howHigh = 1.0f;

    void Update()
    {
        Vector3 playerPos = new Vector3(player.position.x, howHigh, player.position.z);
        Vector3 currentPos = new Vector3(transform.position.x, howHigh, transform.position.z);
        transform.position = Vector3.MoveTowards(currentPos, playerPos, speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
