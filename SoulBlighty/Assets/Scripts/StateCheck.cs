using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateCheck : MonoBehaviour
{
    [SerializeField]
    private Animator animController;
    public RuntimeAnimatorController BeginningAnim;
    public RuntimeAnimatorController MiddleAnim;
    public RuntimeAnimatorController EndAnim;
    public int OutfitState = 0;

    private void Start()
    {
        animController = GetComponent<Animator>();
    }

    public void Update()
    {
        if (OutfitState == 0)
            animController.runtimeAnimatorController = BeginningAnim;

        if (OutfitState == 1)
            animController.runtimeAnimatorController = MiddleAnim;

        if (OutfitState == 2)
            animController.runtimeAnimatorController = EndAnim;
    }
}