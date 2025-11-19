using UnityEngine;

public class Arrayknowledge: MonoBehaviour
{
    class SimplePower
    {
        int attack = 10;
        float attackMultiplier = 15f;
    }

    int[] intArray = new int[4] { 11, 22, 33, 44 };

    private void Start()
    {
        Debug.Log(intArray[2]);
    }

}
