using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneToEnd : MonoBehaviour
{
	public void SwitchSceneEnd()
	{
		SceneManager.LoadScene("climbscene");
	}
}
