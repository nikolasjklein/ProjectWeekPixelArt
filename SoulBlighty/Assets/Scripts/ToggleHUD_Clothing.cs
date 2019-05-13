using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHUD_Clothing : MonoBehaviour
{
	public GameObject Prompt;
	public bool b_ClothingEquipped = false;
	public GameObject Clothing;
	public GameObject Gloves;
	public GameObject Backpack;
	public StateCheck sCheck;
	
	public void Start()
	{
		Prompt.gameObject.SetActive(false);
	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player")
			if (b_ClothingEquipped == false)
				Prompt.gameObject.SetActive(true);

			else
			{}

		if (Input.GetKey(KeyCode.Joystick1Button0))
			if (b_ClothingEquipped == false)
			{
				b_ClothingEquipped = true;
				Clothing.gameObject.SetActive(false);
				Gloves.gameObject.SetActive(false);
				Backpack.gameObject.SetActive(false);
				sCheck.OutfitState = 1;
			}
	}

	public void OnTriggerExit2D()
	{
		Prompt.gameObject.SetActive(false);
	}
}