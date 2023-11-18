using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Animator animator;

  
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