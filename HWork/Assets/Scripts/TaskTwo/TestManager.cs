using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Task2
{
 public class TestManager : MonoBehaviour
    {
  
        [SerializeField] private int FirstNumber;
        [SerializeField] private int SecondNumber;
        private bool HasntOstatok;


        void Start()
        {
            NumberOne number1 = new NumberOne(FirstNumber);
            NUmberTwo number2 = new NUmberTwo(SecondNumber);

            FindAnswer(number1,number2);
        }

        public void FindAnswer(NumberOne numberOne,NUmberTwo nUmberTwo)
        {
            var Delitelb = numberOne.numberOne % nUmberTwo.numberTwo;
            if (Delitelb == 0)
            {
                HasntOstatok = true;
            }
            Debug.Log($"Число {numberOne.numberOne} делиться на {nUmberTwo.numberTwo} без отстатка? Ответ:{HasntOstatok}");
        }
       
    }
}

