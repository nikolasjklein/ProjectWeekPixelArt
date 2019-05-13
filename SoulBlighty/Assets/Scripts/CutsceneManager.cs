using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
	public GameObject Player;
	public GameObject CutSceneBedroom;

	void Start ()
	{
		Player.gameObject.SetActive(false);
		CutSceneBedroom.gameObject.SetActive(true);
	}

	void TriggerOtherBedAndPlayer()
	{
		Player.gameObject.SetActive(true);
		CutSceneBedroom.gameObject.SetActive(false);
	}
}
