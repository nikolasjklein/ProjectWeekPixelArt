using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowRoom : MonoBehaviour
{
	public GameObject Room;

	public void Start()
	{
		Room.gameObject.SetActive(false);
	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag == "Player")
			Room.gameObject.SetActive(true);
	}

	public void OnTriggerExit2D()
	{
		Room.gameObject.SetActive(false);
	}
}
