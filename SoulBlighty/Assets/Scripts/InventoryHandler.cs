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

	// Use this for initialization
	void Start ()
    {
        _checkInv = this.GetComponent<StateCheck>();
        InventoryCanvas.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            //_checkInv.UpdateInventory();
            isActive = !isActive;
            InventoryCanvas.SetActive(isActive);
            paused = !paused;
        }

        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
}