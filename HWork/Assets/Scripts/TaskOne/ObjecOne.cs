using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjecOne : MonoBehaviour
{
    private int _LenghtOfKatet;
    public int LenghtOfKatet { get {return _LenghtOfKatet; } set {_LenghtOfKatet=value>0?value:1; } }

    public ObjecOne(int Lenght)
    {
        LenghtOfKatet = Lenght;
    }

}
