using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kerub : MonoBehaviour
{
    public float speed = 5.0f;

    private GameObject playerObject;
    private Transform player;

    void Start()
    {
        // Finna gameobject með tag Player
        playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<Transform>();
       
    }

    void Update()
    {
        // Breytur sem halda utanum stöðu kerub og leikmanns
        Vector3 playerPos = new Vector3(player.position.x, transform.position.y, player.position.z);
        Vector3 currentPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        // breyta núverandi stöðu í átt að leikmanninum
        transform.position = Vector3.MoveTowards(currentPos, playerPos, speed * Time.deltaTime);
        transform.LookAt(playerPos);
    }
}
