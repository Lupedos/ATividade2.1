using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asas : MonoBehaviour
{
    int num = 10;
    int resultado = 5;
    void Start()
    {
      num = num + num; 
      resultado = num - resultado;

      if(num == 20)
      {
    num = -80 +40 - num;
      }
    }

    
    void Update()
    {
        
    }
}
