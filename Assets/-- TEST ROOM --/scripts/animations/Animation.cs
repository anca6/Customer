using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator Animator; // animator instance to reference

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
