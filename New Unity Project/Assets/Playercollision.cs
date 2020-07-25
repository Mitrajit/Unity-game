using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public cube1behavior movement;
   void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
