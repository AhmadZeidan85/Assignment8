using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
        int randomenumber=0;
        while (true){
         randomenumber=Random.Range(1,21);
         
         if (randomenumber==5){
            continue; // Skip printing genrated random number if the number is 5
         }
         else if (randomenumber==15){
            break; // Exit the loop if the genrated random number  is 15

         }
            // Print the genrated random number  
            Debug.Log("Random Number Generated is: "+ randomenumber);
         
        }
        
    }

   
}
