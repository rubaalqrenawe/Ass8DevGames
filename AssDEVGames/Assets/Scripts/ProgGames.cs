using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgGames : MonoBehaviour
{

   public bool objectOne = true;
   public bool objectTwo = false;
    void Start()
    {
        //Debug.Log("objectOne && objectOne: " + (objectOne && objectOne));        
        //Debug.Log("objectOne && objectTwo: " + (objectOne && objectTwo));        
        //Debug.Log("objectTwo && objectTwo: " + (objectTwo && objectTwo));        
        //Debug.Log("objectOne || objectTwo: " + (objectOne || objectTwo));        
        //Debug.Log("objectTwo || objectTwo: " + (objectTwo || objectTwo));        
        //Debug.Log("!objectOne: " + (!objectOne));                                
        //Debug.Log("!(objectTwo || objectOne): " + (!(objectTwo || objectOne)));

        //bool cond1 = (5 > 3) && (2 < 4);
        //bool cond2 = (10 == 10) || (5 != 5);
        //bool cond3 = (3 >= 2) && !(6 < 3);

        ////Debug.Log("(5 > 3) && (2 < 4): " + cond1);    
        ////Debug.Log("(10 == 10) || (5 != 5): " + cond2);
        ////Debug.Log("(3 >= 2) && !(6 < 3): " + cond3);   

        //Debug.Log("(5 + 3) * 2 - 4 / 2: " + ((5 + 3) * 2 - 4 / 2));  
        //Debug.Log("10 - 3 * 2 + 4: " + (10 - 3 * 2 + 4));           
        //Debug.Log("2 + 3 * 4 > 10 && 4 <= 4: " + ((2 + 3 * 4 > 10) && (4 <= 4))); 
        //Debug.Log("!(10 >= 5) || 7 != 3: " + (!(10 >= 5) || (7 != 3))); 
        //Debug.Log("(8 % 3 + 2) * 4 - 6: " + ((8 % 3 + 2) * 4 - 6)); 
        //Debug.Log("10 == 5 + 5 && 4 > 2 || 3 < 1: " + ((10 == 5 + 5) && (4 > 2) || (3 < 1)));

        //int x = 3;
        //int y = 5;
        //Debug.Log("++x * 2 - --y / 2: " + (++x * 2 - --y / 2));     

        //Debug.Log("(4 + 5 * 2) != 13 || (6 / 2 == 3): " + ((4 + 5 * 2) != 13 || (6 / 2 == 3))); 
        //Debug.Log("6 >= 3 * 2 && (5 % 2 == 1): " + ((6 >= 3 * 2) && (5 % 2 == 1)));

        int playerLives = 3; 

        while (playerLives > 0)
        {
            if (playerLives == 3)
            {
                Debug.Log("Many lives");
            }
            else if (playerLives == 1)
            {
                Debug.Log("The last life!");
            }

            playerLives--; 
        }

        Debug.Log("Game Over!"); 
    
}

    
  
}
