using UnityEngine;
using System.Collections.Generic;

public class Listknowledge2: MonoBehaviour
{
    public List<int> firstList;
    public List<int> secondList;

    void Start()
    {
        firstList.Add(1);
        firstList.Add(2);
        firstList.Add(3);

        firstList[0] = 0;
        firstList[2] = 25;
        firstList.Insert(0, 605);
        firstList.Remove(605);
        firstList.RemoveRange(0, 1); // ici de l'index 0 jusqu'à 1
        //firstList.Clear();

        //---------------------------------

        for (int i = 0; i < 5; i++)
        {
            secondList[i] = 0;
        }
        secondList[secondList.Count+1] = secondList.Count+1;

    }
}
