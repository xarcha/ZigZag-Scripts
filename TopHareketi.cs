using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 y�n;
    public float h�z;
    public ZeminSpawner zeminspawnerscripti;
    public static bool d��t�_m�;
    public float eklenecekh�z;

    void Start()
    {
        y�n = Vector3.forward;
        d��t�_m� = false;
    }

    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            d��t�_m� = true;
        }


        if (d��t�_m� == true)
        {
            return;
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            if (y�n.x == 0)
            {
                y�n = Vector3.left;
            }
            else
            {
                y�n = Vector3.forward;

            }
            h�z =h�z += eklenecekh�z * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = y�n * Time.deltaTime * h�z;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspawnerscripti.zemin_olu�tur();
            StartCoroutine(ZeminiSil(collision.gameObject));


        }
    }
    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }



}
