using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager_Player : MonoBehaviour
{
    public GameObject Player;
    public SpriteRenderer playerSprite;

    public int playerHealth;
    public int playerMana;

    public void Start()
    {
        playerSprite = Player.GetComponent<SpriteRenderer>();

        playerHealth = 100;
        playerMana = 100;
    }

    public void Update()
    {
        
    }
}
