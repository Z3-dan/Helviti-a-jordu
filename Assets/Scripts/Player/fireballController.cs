using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballController : MonoBehaviour
{
    //skripta sem stýrir skotunum

    //public AudioSource clank;
    public float speed;
    public float lifeTime;
    public static int damageDealt = 1;

    void Start()
    {

    }

    void Update()
    {
        // Skotið færist altaf áframm
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Ef líftími skots er minni eða samasem 0
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HITTIR");
            Ezekielar.health=;
            Destroy(gameObject);
        }
    }
    */
}