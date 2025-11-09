using UnityEngine;

class Fruit
{
    public Vector2 position = new Vector2(0, 0);

    public void FruitMove(Fruit a)
    {
        a.position = new Vector2(Random.Range(0, Level.width), Random.Range(0, Level.height));
    }
}
