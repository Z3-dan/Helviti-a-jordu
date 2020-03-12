
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //bý til transform sem tekur staðsetningu spilarans og hversu langt frá henni myndavélin ætti að vera
    public Vector3 offset;
    private Transform player;
    private GameObject playerObject;

   
    void Start()
    {
        //er að binda myndavélina við staðsetningu spilarans
        playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<Transform>();
    }

    void Update()
    {
        //er að binda myndavélina við staðsetningu spilarans
        transform.position = player.position + offset;
    }
}