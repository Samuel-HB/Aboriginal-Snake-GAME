using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SnakeManager : MonoBehaviour
{

    public static Vector2 direction = Vector2.right;
    private List<Transform> segments;
    public Transform segment_game;
    public Transform head;
    public Transform firstSegment_game;
    public bool isFirstSegment = false;

    int delay = 0;
    public static int healthPoint = 3;
    int delayHit = 0;
    bool delayStart = false;
    public static bool isFruitTaken = false;
    public static bool changeOpacity = false;
    public static bool lose = false; // peut etre à enlever


    private void Start()
    {
        segments = new List<Transform>();
        segments.Add(this.transform);

        Transform head = Instantiate(this.head);
        head.position = segments[segments.Count - 1].position;
        segments.Add(head);
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Z)) && direction != Vector2.down)
            direction = Vector2.up;
        if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && direction != Vector2.up)
            direction = Vector2.down;
        if ((Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && direction != Vector2.left)
            direction = Vector2.right;
        if ((Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Q)) && direction != Vector2.right)
            direction = Vector2.left;

        if (direction == Vector2.up)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        if (direction == Vector2.down)
            transform.rotation = Quaternion.Euler(0, 0, 180);
        if (direction == Vector2.right)
            transform.rotation = Quaternion.Euler(0, 0, 270);
        if (direction == Vector2.left)
            transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(
            Mathf.Round(transform.position.x) + direction.x, // x
            Mathf.Round(transform.position.y) + direction.y, // y
            0f);                                             // z

        delay++;
        if (delay >= 2)
        {
            for (int i = segments.Count - 1; i > 0; i--)
            {
                segments[i].position = segments[i - 1].position;
                segments[i].rotation = segments[i - 1].rotation;
            }
            delay = 0;
        }

        if (healthPoint <= 0)
        {
            lose = true;
            Lose();
        }


        if (delayStart == true)
        {
            changeOpacity = true;
            delayHit--;
        }

        if (delayHit <= 0)
        {
            delayStart = false;
            changeOpacity = false;
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0); // retour aux couleurs d'avant
        }

        if (changeOpacity == true)
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.9f);

        if (changeOpacity == false)
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    private void Grow()
    {
        if (isFirstSegment == true)
        {
            Transform segment = Instantiate(this.segment_game); // instantie et garde une reference de l'instantiation
            segment.position = segments[segments.Count - 1].position;
            segments.Add(segment); // ajoute la le segment à la liste grâce à sa reference
        }
        if (isFirstSegment == false)
        {
            Transform segment1 = Instantiate(this.firstSegment_game); // instantie et garde une reference de l'instantiation
            segment1.position = segments[segments.Count - 1].position;
            segments.Add(segment1); // ajoute la le segment à la liste grâce à sa reference
            isFirstSegment = true;
        }
    }

    private void Lose()
    {
        Debug.Log("You lose dummy !");
        //isDefeated = true;
        SceneManager.LoadScene("Defeat");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Apple")
        {
            isFruitTaken = true;
            Grow();
        }
        if (collision.tag == "Obstacle")
        {
            if (delayHit <= 0)
            {
                healthPoint--;
                delayHit = 7;
                delayStart = true;
            }
        }
        if (collision.tag == "VeryObstacle")
        {
            healthPoint-=3;
        }
    }
}
