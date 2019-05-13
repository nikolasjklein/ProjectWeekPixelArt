using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	public float moveSpeed;

	private Animator anim;

	private bool isMoving;
	//private Vector2 lastMove;

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
	{
		isMoving = false;

		if (Input.GetAxisRaw("Horizontal") > 0f)
		{
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			isMoving = true;
			//lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
			anim.SetFloat("LastX", 1);
		}

		if (Input.GetAxisRaw("Horizontal") < 0f)
		{
			transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
			isMoving = true;
			//lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
			anim.SetFloat("LastX", -1);
		}

		if (Input.GetAxisRaw("Vertical") > 0f)
		{
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
			isMoving = true;
			//lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
			anim.SetFloat("LastY", 1);
		}

		if (Input.GetAxisRaw("Vertical") < 0f)
		{
			transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
			isMoving = true;
			//lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
			anim.SetFloat("LastY", -1);
		}

		anim.SetFloat("Xspeed", Input.GetAxisRaw("Horizontal"));
		anim.SetFloat("Yspeed", Input.GetAxisRaw("Vertical"));
		anim.SetBool("isMoving", isMoving);
		//anim.SetFloat("LastX", lastMove.x);
		//anim.SetFloat("LastY", lastMove.y);
	}
}
