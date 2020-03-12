using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    //skripta til að tracka líf spilarans
    //var að skoða mismunandi leiðir til að láta hann blikka til að sýna viðbrögð en þurfti að sleppa því í bili og commentaði það út

    //public Material[] Materials;
    public int startingHealth;
    public static int currentHealth = 3;
    public static bool gameOver;

    //public float feedbackLength;
    //private float feedbackCounter;

    //public Renderer rend;
    //private Color storedColor;//
    void Start()
    {
        currentHealth = startingHealth;
        //rend = GetComponent<Renderer>();
        //storedColor = rend.material.GetColor("_Color");


    }

    public void OnTriggerEnter(Collider other)
    {
        // Ef þetta gameobject klessir á gameobject með tag Enemy_Shot þá eyðist skotið og líf lækka
        if (other.gameObject.tag == "Enemy_Shot")
        {
            currentHealth--;
            Destroy(other.gameObject);
        }
    }


    void Update()
    {
        // Ef líf er minna eða samasem 0 þá eyðist þetta gameobect og leikurinn stoppar
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            Time.timeScale = 0;
            gameOver = true;

        }

        // if (feedbackCounter > 0)
        // {
        //  feedbackCounter -= Time.deltaTime;
        // if (feedbackCounter <= 0)
        //  {
        //rend.material.SetColor("_Color", storedColor);
        //  }
        // }
    }


}

