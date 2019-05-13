using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuSelectController : MonoBehaviour
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

	public void Play ()
	{
		SceneManager.LoadScene ("introscene");
	}

	public void Options ()
	{
		
	}

	public void Exit ()
	{
		Application.Quit();
	}
}
