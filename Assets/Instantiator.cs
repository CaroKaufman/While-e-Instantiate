using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CantVeces;
    

    public void CloneObject()
    {
        int counter = 10;
        while (CantVeces<=counter){
            Instantiate(objectToClone);
            counter --;
        }

            
       
    }
}
