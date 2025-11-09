using UnityEngine;

public class FruitMove : MonoBehaviour
{
    public static bool isOnOstacle = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            isOnOstacle = true;
        }       
    }
}
