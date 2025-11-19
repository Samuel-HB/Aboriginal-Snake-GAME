using UnityEngine;

public class Transition : MonoBehaviour
{
    float transparency = 0f;
    float i = 0f;

    private void FixedUpdate()
    {
        if (SnakeManager.lose == true)
        {
            i = i + 0.5f;
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, transparency+i);
        }
        if (SnakeManager.lose == false)
        {
            transparency = 0f;
        }
    }
}
