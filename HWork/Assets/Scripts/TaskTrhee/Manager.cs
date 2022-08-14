using System.Collections;
using System.Collections.Generic;
using UnityEngine;


enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednsday,
    Thorsday,
    Friday,
    Saturday,
    Sunday,
}
public class Manager : MonoBehaviour
{
    private int _NumberDayOfWeek;
    public int NumberDayOfWeek { get {return _NumberDayOfWeek; } set { _NumberDayOfWeek = value > 0 ? 
                                                                      (_NumberDayOfWeek = value > 7 ? 7 : value) : 1; } }

    void Start()
    {
        ChoseMeDay(90);
    }

    private void ChoseMeDay(int umberDayOfWeek)
    {
       NumberDayOfWeek = umberDayOfWeek;
        
        switch (NumberDayOfWeek)
        {
            case 1:
               Debug.Log(DaysOfWeek.Monday);
                break;
            case 2:
                Debug.Log(DaysOfWeek.Tuesday);
                break;
            case 3:
                Debug.Log(DaysOfWeek.Wednsday);
                break;
            case 4:
                Debug.Log(DaysOfWeek.Thorsday);
                break;
            case 5:
                Debug.Log(DaysOfWeek.Friday);
                break;
            case 6:
                Debug.Log(DaysOfWeek.Saturday);
                break;
            case 7:
                Debug.Log(DaysOfWeek.Sunday);
                break;
            default:
                break;
        }
    }
   
}
