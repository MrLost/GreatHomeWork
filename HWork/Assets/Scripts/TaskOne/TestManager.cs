using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    [SerializeField] private int VectorOne;
    [SerializeField] private int VectorTwo;

    private void Start()
    {
        ObjecOne objecOne = new ObjecOne(VectorOne);
        ObjectTwo objectTwo = new ObjectTwo(VectorTwo);

        ShowMePerimetr(objecOne, objectTwo);
    }
   
    public void ShowMePerimetr(ObjecOne objecOne,ObjectTwo objectTwo)
    {
        var perimetr = Mathf.Sqrt(Mathf.Pow(objecOne.LenghtOfKatet, 2) + Mathf.Pow(objectTwo.LenghtOfKatet, 2)
                                            + objecOne.LenghtOfKatet + objectTwo.LenghtOfKatet);
        Debug.Log(perimetr);  
    }
}
