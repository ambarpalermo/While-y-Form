using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TocaAca()
    {
        if (num2 >= num1 )
        {
            Debug.Log("Error, revisar los numeros ingresados");
        }
        else
        {
            while (num1 <= num2)
            {
                Debug.Log(num2);
                num2--;
            }
        }
    }
}
