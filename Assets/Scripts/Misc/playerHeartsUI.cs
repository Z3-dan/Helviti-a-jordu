using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHeartsUI : MonoBehaviour
{
    public Texture hearts0;
    public Texture hearts1;
    public Texture hearts2;
    public Texture hearts3;

    int playerHealth;

    RawImage m_RawImage;

    void Start()
    {
        // Ná í rawimage component á gameobjectinu
        m_RawImage = GetComponent<RawImage>();
    }

    void Update()
    {
        // breyta sem heldur utanum líf leikmanns
        playerHealth =  PlayerHealth.currentHealth;

        // Breyta mynd eftir hversu mörg líf leikmaður hefur
        if(playerHealth >= 3) m_RawImage.texture = hearts3;
        else if(playerHealth == 2) m_RawImage.texture = hearts2;
        else if(playerHealth == 1) m_RawImage.texture = hearts1;
        else m_RawImage.texture = hearts0;
    }
}
