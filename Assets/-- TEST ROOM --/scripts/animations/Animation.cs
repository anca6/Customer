using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator Animator;

    // Method to open the door
    public void Open()
    {
        Animator.SetBool("Open", true);
    }

    // Method to close the door
    public void Close()
    {
        Animator.SetBool("Open", false);
    }
}
