using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleHUD_Pod : MonoBehaviour
{
	public GameObject Prompt;
	public ToggleHUD_Mission th_Mission;
	
	public void Start()
	{
		Prompt.gameObject.SetActive(false);
	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			if (th_Mission.b_MissionIsTriggered == true)
				Prompt.gameObject.SetActive(true);

			else
			{}

			if (Input.GetKey(KeyCode.Joystick1Button0))
			{
				SceneManager.LoadScene ("damagescene");
			}
		}
	}

	public void OnTriggerExit2D()
	{
		Prompt.gameObject.SetActive(false);
	}
}
