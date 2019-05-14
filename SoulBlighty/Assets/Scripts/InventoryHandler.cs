using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class InventoryHandler : MonoBehaviour
{
    public GameObject InventoryCanvas;
    private bool isActive;
    public bool paused;
    public StateCheck _checkInv;
    public Animator playerAnimator;

	// Use this for initialization
	void Start ()
    {
        _checkInv = this.GetComponent<StateCheck>();
        InventoryCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button3) && isActive == false)
        {
            //StartCoroutine("OpenBackpack"); 
            playerAnimator.Play("player_backpack");
            isActive = true;
        }

        if (Input.GetKeyDown(KeyCode.Joystick1Button3) && isActive == true)
        {
            //StartCoroutine("OpenBackpack"); 
            playerAnimator.Play("Idle Blend Tree");
            isActive = false;
        }
    }

    /*
    IEnumerator OpenBackpack()
    {
        playerAnimator.Play("player_backpack");
        yield return new WaitForSeconds(.5f);
        isActive = !isActive;
        InventoryCanvas.SetActive(isActive);
        paused = !paused;
    }
    */
}