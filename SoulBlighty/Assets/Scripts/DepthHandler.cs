using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public int depthPrecision = 1000;
    public static DepthHandler depthHandler;

	void Start ()
    {
        depthHandler = this;
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	void Update ()
    {
        spriteRenderer.sortingOrder = (int)(-transform.position.y * depthPrecision);
	}
}