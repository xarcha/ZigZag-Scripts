using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    public Transform topunKonumu;
    Vector3 fark;


    void Start()
    {
        fark = transform.position - topunKonumu.position;
    }

    void Update()
    {if(TopHareketi.d��t�_m�== false)
        {
            transform.position = topunKonumu.position + fark;
        }
        
    }
}
