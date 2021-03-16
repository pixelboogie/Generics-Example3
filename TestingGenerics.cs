using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingGenerics : MonoBehaviour
{

    // a couple of serialized fields to show in inspector
        // one holds strings, other holds ints
    [SerializeField] private List<string> words = new List<string>();
    [SerializeField] private List<int> numbers = new List<int>();
   
   
    void Start()
    {
        // display the reversed items in inspector
        words = ReverseItems(words);
         numbers = ReverseItems(numbers);
    }

    // a function that reverses the items in the lists
    private List<T> ReverseItems<T>(List<T> listToReverse)
    {
        List<T> reversedList = new List<T>();
        for(int i=listToReverse.Count - 1; i>=0; i--)
        {
            reversedList.Add(listToReverse[i]);
        }
        return reversedList;
    }

}
