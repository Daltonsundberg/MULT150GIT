using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Reference to the Animator component
    private Animator animator;

    // Define the key you want to use as a trigger
    public KeyCode triggerKey = KeyCode.Space;

    void Start()
    {
      
        animator = GetComponent<Animator>();
    }

    void Update()
    {
       
        if (Input.GetKeyDown(triggerKey))
        {
            
            animator.SetTrigger("Rotation");
        }
    }
}