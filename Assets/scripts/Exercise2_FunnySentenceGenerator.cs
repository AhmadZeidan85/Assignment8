using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class excercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string [] words={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        print (words.Length);
        int wordscounter =0;
        string santance="";
        while (wordscounter <7){

            int random_index=Random.Range(0,words.Length); //Generate a random number (index) between o and word array lenght

            santance=santance+" "+words[random_index]; // concatnate the santance with random word

           wordscounter++; 
        }

        Debug.Log("Funny Sentence: "+ santance);
        
    }

   
}
