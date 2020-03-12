using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EzekielarBullet : MonoBehaviour
{
    //skripta sem stýrir skotunum

    //public AudioSource clank;
    public float speed;
    public float lifeTime;
    public int damageDealt;

    void Update()
    {
        // skot fara altaf áfram
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Ef líftími á skoti er minna eða samasem 0 þá eyðist það
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}