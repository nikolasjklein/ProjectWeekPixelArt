using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DifficultySelectScreenController : MonoBehaviour
{
	public EventSystem ES;
	public GameObject StoreSelected;

	void Start ()
	{
		StoreSelected = ES.firstSelectedGameObject;
	}

	void Update ()
	{
		if (ES.currentSelectedGameObject != StoreSelected)
		{
			if (ES.currentSelectedGameObject == null)
			{
				ES.SetSelectedGameObject (StoreSelected);
			}
			else
			{
				StoreSelected = ES.currentSelectedGameObject;
			}
		}
	}

	public void BabyMode ()
	{
		SceneManager.LoadScene ("testscene");
	}

	public void NormalMode ()
	{
		SceneManager.LoadScene ("testscene");
	}

	public void HardMode ()
	{
		SceneManager.LoadScene ("testscene");
	}

	public void DeathMode ()
	{
		SceneManager.LoadScene ("testscene");
	}
}
