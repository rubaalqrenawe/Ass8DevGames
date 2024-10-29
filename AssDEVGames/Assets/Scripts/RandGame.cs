using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        System.Random random = new System.Random();

        while (true)
        {
            int number = random.Next(1, 20); 
            if (number == 5)
            {
                continue; 
            }
            if (number == 15)
            {
                break; 
            }
            Debug.Log("Generated number: " + number);



        }

        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        System.Random random2 = new System.Random();
        string sentence = "";

        int wordCount = 0;
        while (wordCount < 7)
        {
            int index = random2.Next(words.Length); 
            sentence += words[index] + " ";
            wordCount++;
        }

        Debug.Log("Funny sentence: " + sentence);
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
