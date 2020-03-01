using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numHearts;
    public Image[] hearts;
    public Sprite redHeart;
    public Sprite blackHeart;

    void Update()
    {

        if( health > numHearts)
        {
            health = numHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {

            if(i < health)
            {
                hearts[i].sprite = redHeart;


            }
            else
            {
                hearts[i].sprite = blackHeart;

            }

            if(i< numHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            } 

        }
    }



}