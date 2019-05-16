using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClimbController : MonoBehaviour
{
    private GameObject Player;
    public GameObject Prompt_Left;
    public GameObject Prompt_Right;
    public int ClimbState;
    public Animator playerAnimator;
    public bool canClimbLeft;
    public bool canClimbRight;
    public bool canReachTop;
    public Animator Shine;
    public Camera Cam;
    public Camera SecondCam;
    public Animator CamAnim;

    public void Start()
    {
        SecondCam.gameObject.SetActive(false);
        Player = this.gameObject;
        canClimbLeft = false;
        canClimbRight = true;
        canReachTop = true;
        Prompt_Right.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (canClimbRight == true && Input.GetKey(KeyCode.Joystick1Button0))
        {
            if (ClimbState < 16)
            {
                Prompt_Left.gameObject.SetActive(false);
                ClimbState += 1;
                playerAnimator.Play("player_climb_lefttoright");
                StartCoroutine("PlayLeftClimbAnim");
                canClimbRight = false;
                canClimbLeft = true;
            }
        }

        if (canClimbLeft == true && Input.GetKey(KeyCode.Joystick1Button2))
        {
            if (ClimbState < 16)
            {
                Prompt_Right.gameObject.SetActive(false);
                ClimbState += 1;
                playerAnimator.Play("player_climb_righttoleft");
                StartCoroutine("PlayRightClimbAnim");
                canClimbLeft = false;
                canClimbRight = true;
            }
        }

        //When Player reaches the Top
        if (ClimbState == 16)
        {
            if (canReachTop == true)
            {
                canClimbLeft = false;
                canClimbRight = false;
                Destroy(Prompt_Left);
                Destroy(Prompt_Right);

                this.transform.Translate(Vector3.up * Time.smoothDeltaTime * .6625f);
                canReachTop = false;

                playerAnimator.Play("player_rise");
                StartCoroutine("PlayShine");
            }
        }
    }

    IEnumerator PlayLeftClimbAnim()
    {
        yield return new WaitForSeconds(.5f);
        this.transform.Translate(Vector3.up * Time.smoothDeltaTime * .375f);
        yield return new WaitForSeconds(.2f);
        if (ClimbState < 16)
            Prompt_Right.gameObject.SetActive(true);
    }

    IEnumerator PlayRightClimbAnim()
    {
        yield return new WaitForSeconds(.5f);
        this.transform.Translate(Vector3.up * Time.smoothDeltaTime * .375f);
        yield return new WaitForSeconds(.2f);
        if (ClimbState < 16)
            Prompt_Left.gameObject.SetActive(true);
    }

    IEnumerator PlayShine()
    {
        yield return new WaitForSeconds(2.6f);
        Shine.Play("shine_glow");
        StartCoroutine("End");
    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(5f);
        Cam.gameObject.SetActive(false);
        SecondCam.gameObject.SetActive(true);
        CamAnim.Play("cam_end");
    }
}
