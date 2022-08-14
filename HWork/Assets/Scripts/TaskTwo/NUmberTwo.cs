using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
    public class NUmberTwo : MonoBehaviour
    {
        private int _numberTwo;
        public int numberTwo { get { return _numberTwo; } set { _numberTwo = value > 0 ? value : 1; } }

        public NUmberTwo(int Number)
        {
            numberTwo = Number;
        }
    }
}
