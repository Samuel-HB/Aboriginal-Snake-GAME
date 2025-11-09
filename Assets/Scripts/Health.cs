using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject health_game1;
    Vector3 health_pos1 = new Vector3(40.65f, 22, -3);
    public GameObject health_game2;
    Vector3 health_pos2 = new Vector3(42.48f, 21.1f, -3);
    public GameObject health_game3;
    Vector3 health_pos3 = new Vector3(44.32f, 22, -3);

    private void Start()
    {
        health_game1 = Instantiate(health_game1, health_pos1, Quaternion.identity);
        health_game2 = Instantiate(health_game2, health_pos2, Quaternion.identity);
        health_game3 = Instantiate(health_game3, health_pos3, Quaternion.identity);
    }

    void Update()
    {
        if (SnakeManager.healthPoint == 2)
            Destroy(health_game1);
        if (SnakeManager.healthPoint == 1)
            Destroy(health_game2);
        if (SnakeManager.healthPoint == 0)
            Destroy(health_game3);
    }
}