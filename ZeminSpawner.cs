using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{
    public GameObject son_zemin;
    void Start()
    {
        for (int i = 0; i < 35; i++)
        {
            zemin_olu�tur();
            i++;
        }
    }


    void Update()
    {
       
    }
    public void zemin_olu�tur()
    {

        Vector3 y�n;

        if (Random.Range(0, 2) == 0)
        {

            y�n = Vector3.left;

        }
        else
        {
            y�n = Vector3.forward;
        }

       son_zemin= Instantiate(son_zemin, son_zemin.transform.position + y�n, son_zemin.transform.rotation);

    }
        
        
}