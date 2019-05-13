using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHUD_Mission : MonoBehaviour
{
	public GameObject Prompt;
	public bool b_MissionIsTriggered = false;
	public GameObject go_Console;
	public Sprite s_ConsolePassive;
	public Sprite s_ConsoleActive;
	public ToggleHUD_Clothing th_Clothing;
	
	public void Start()
	{
		Prompt.gameObject.SetActive(false);
		go_Console.GetComponent<SpriteRenderer>().sprite = s_ConsolePassive;
	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (th_Clothing.b_ClothingEquipped == true)
				if (b_MissionIsTriggered == false)
					Prompt.gameObject.SetActive(true);

			else
			{}
		}
		
		if (th_Clothing.b_ClothingEquipped == true)
			if (Input.GetKey(KeyCode.Joystick1Button0))
			{
				if (b_MissionIsTriggered == false)
					b_MissionIsTriggered = true;

				else
					b_MissionIsTriggered = true;
		}

		if (b_MissionIsTriggered == true)
			go_Console.GetComponent<SpriteRenderer>().sprite = s_ConsoleActive;
	}

	public void OnTriggerExit2D()
	{
		Prompt.gameObject.SetActive(false);
	}
}
