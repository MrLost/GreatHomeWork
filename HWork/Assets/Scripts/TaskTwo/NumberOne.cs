using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
    public class NumberOne : MonoBehaviour
    {
        private int _numberOne;
        public int numberOne { get { return _numberOne; } set { _numberOne = value > 0 ? value : 1; } }

        public NumberOne(int Number)
        {
            numberOne = Number;
        }
    }
}
