using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    //skripta sem sér um að skjóta

    public bool isFiring;
    public fireballController MagicMissle;
    public float missleSpeed;
    public float delay;
    private float counter;

    public Transform Spawn;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButton("R1"))
        {
            // Klukka sem skoðar tíma á milli skota og skýtur ef counter er minni eða samasem 0
            counter -= Time.deltaTime;
            if (counter <= 0)
            {
                counter = delay;
                fireballController newFireball = Instantiate(MagicMissle, Spawn.position, Spawn.rotation);
                newFireball.speed = missleSpeed;
            }
        }

        else
        {
            counter = 0;
        }
    }
}