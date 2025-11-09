using UnityEngine;

class InstantiateObjects2 : MonoBehaviour
{

    public GameObject circle_game_1;
    public GameObject circle_game_2;
    public GameObject circle_game_3;
    public GameObject circle_game_4;

    public GameObject apple_game;
    public GameObject light_game;
    public Fruit simpleApple = new Fruit(); 
    public Fruit rareApple = new Fruit();

    void ObstacleInstantiation(GameObject a, int x, int y)
    {
        a = Instantiate(a, a.transform.position, Quaternion.identity);
    }

    public void Start()
    {
        SnakeManager.isFruitTaken = false;

        ObstacleInstantiation(circle_game_1, 33, 5);
        ObstacleInstantiation(circle_game_2, 20, 10);
        ObstacleInstantiation(circle_game_3, 33, 5);
        ObstacleInstantiation(circle_game_4, 20, 10);

        simpleApple.position = new Vector2(Random.Range(0, Level.width), Random.Range(0, Level.height));
        simpleApple.FruitMove(simpleApple);
        apple_game = Instantiate(apple_game, simpleApple.position, Quaternion.identity);

        light_game = Instantiate(light_game, simpleApple.position, Quaternion.identity);

        //rareApple.position = new Vector2(Random.Range(0, Level.width), Random.Range(0, Level.height));
    }

    public void Update()
    {
        if (SnakeManager.isFruitTaken == true)
        {
            simpleApple.FruitMove(simpleApple);
            apple_game.transform.position = simpleApple.position;
            ScoringSystem.score++;
            SnakeManager.isFruitTaken = false;
        }

        if (FruitMove.isOnOstacle == true)
        {
            simpleApple.FruitMove(simpleApple);
            apple_game.transform.position = simpleApple.position;
            FruitMove.isOnOstacle = false;
        }

        Vector3 light_pos = new Vector3(simpleApple.position.x, simpleApple.position.y, 0.6f);
        light_game.transform.position = light_pos;
    }
}
