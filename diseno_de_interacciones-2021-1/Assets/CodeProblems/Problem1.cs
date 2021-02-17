using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Arreglo
        int[] nums = {8,1,2,2,3};
        int[] output = NumbersLessThan(nums);

       //recorre cada numero del arreglo 
       foreach (var num in output)
       {
            Debug.Log(num);//imprime el arreglo
       }
       
    }

    private int[] NumbersLessThan(int[] nums)
    {
        
        //Matrices auxiliares 
        int[] aux= nums; 
        int[] aux2 = {0,0,0,0,0};
       
        for ( int i = 0; i < nums.Length; i++) { 
            
            for (int j = 0; j < aux.Length; j++) 
            {
                if (aux[j] < nums[i]){
                    aux2[i]++;
                    }
            }
    
        } 


      return aux2;  
    } 
         
}
