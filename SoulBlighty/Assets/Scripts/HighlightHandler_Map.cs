using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlightHandler_Map : MonoBehaviour
{
	Image ItemImage;
	public Sprite IdleSprite;
	public Sprite HoverSprite;
	public GameObject MapPanel;
	public GameObject MenuPanel;

	void Start()
	{
		ItemImage = GetComponent<Image>();
	}

	public void Update()
	{
		if (ItemImage.sprite == HoverSprite && Input.GetButtonDown("Fire1"))
		{
			MapPanel.gameObject.SetActive(true);
			MenuPanel.gameObject.SetActive(false);
		}
	}

	public void HoverImage()
	{
		ItemImage.sprite = HoverSprite;
	}

	public void UnHoverImage()
	{
		ItemImage.sprite = IdleSprite;
	}
}