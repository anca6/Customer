using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isInteractingHash;

    public PlayerControls controls;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controls = GameObject.FindObjectOfType<PlayerControls>();

        // increases performance
        isWalkingHash = Animator.StringToHash("isWalking");
        isInteractingHash = Animator.StringToHash("isInteracting");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isInteracting = animator.GetBool(isInteractingHash);

        bool mvmtKeyPressed;

        //larryYRotation = controls.gameObject.transform.rotation;

        // get player input
        if ((Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")))
        {
            mvmtKeyPressed = true;
        }
        else
        {
            mvmtKeyPressed = false;
        }

        // if player presses wasd key
        if (!isWalking && mvmtKeyPressed)
        {
            // then set the isWalking boolean to be true
            animator.SetBool(isWalkingHash, true);
        }

        // if player is not pressing wasd key
        if (isWalking && !mvmtKeyPressed)
        {

            // then set the isWalking boolean to be false
            animator.SetBool(isWalkingHash, false);

            // transform.rotation = larryYRotation;
        }


        //get player input
        bool fPressed;

        if (Input.GetKey("f"))
        {
            fPressed = true;
        }
        else
        {
            fPressed = false;
        }

        // if player is not interacting and presses/holds? f key
        if (!isInteracting && fPressed)
        {
            // then set isInteracting to true
            animator.SetBool(isInteractingHash, true);
        }

        // if player lets go f key
        if (!fPressed)
        {
            // then set isInteracting to false
            animator.SetBool(isInteractingHash, false);
        }
    }
}
