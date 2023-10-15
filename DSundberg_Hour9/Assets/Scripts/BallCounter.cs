using UnityEngine;

public class BallCounter : MonoBehaviour
{
    private int collisionCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball")) 
        {
            collisionCount++;
            Debug.Log("collided with the cube." + collisionCount);
        }
    }
}
