using UnityEngine;

public class Segment : MonoBehaviour
{
    private void FixedUpdate()
    {
    if (SnakeManager.changeOpacity == true)
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.4f);

        if (SnakeManager.changeOpacity == false)
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }
}
