using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ezekielar : MonoBehaviour
{
    public float speed = 10.0f;

    public float shotDelay = 2;
    private float timer;

    public GameObject bullet;

    int index;
    public GameObject[] points;

    private GameObject playerObject;
    private Transform player;
    int health = 3;

    void Start()
    {
        // Finna object með tag Player
        playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<Transform>();

        index = Random.Range(0, 4);
        // Finna object með tag Ezekiel_Point
        points = GameObject.FindGameObjectsWithTag("Ezekiel_Point");
    }

    public void OnTriggerEnter(Collider other)
    {
        // Ef þetta gameobject collidar við tag Player_Shot þá minkar lífið og eyðir skotinu
        if (other.gameObject.tag == "Player_Shot")
        {
            health = health - fireballController.damageDealt;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        // Ef lífin eru minni eða samasem 0 þá eyðist þetta gameobject
        if (health <= 0)
        {

            Destroy(this.gameObject);

        }
        // Breyta sem heldur utanum núverandi stöðu
        transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, Time.deltaTime * speed);
        // Ef núverandi staða er sama og point í arrayinu þá finnur það nýtt point til að fara á
        if (transform.position == points[index].transform.position)
        {

            index = Random.Range(0, 4);
            transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, Time.deltaTime * speed);

        }
        // Breyta sem heldur utanum stöðu leikmanns
        Vector3 playerPos = new Vector3(player.position.x, transform.position.y + 1, player.position.z);

        // klukka sem telur tíman á milli skota
        timer += Time.deltaTime;
        if(timer > shotDelay)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            timer = 0;
        }
        // Horfa á stöðu leikmanns
        transform.LookAt(playerPos);
    }
}
