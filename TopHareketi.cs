using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{
    Vector3 yön;
    public float hýz;
    public ZeminSpawner zeminspawnerscripti;
    public static bool düþtü_mü;
    public float eklenecekhýz;

    void Start()
    {
        yön = Vector3.forward;
        düþtü_mü = false;
    }

    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            düþtü_mü = true;
        }


        if (düþtü_mü == true)
        {
            return;
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            if (yön.x == 0)
            {
                yön = Vector3.left;
            }
            else
            {
                yön = Vector3.forward;

            }
            hýz =hýz += eklenecekhýz * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yön * Time.deltaTime * hýz;
        transform.position += hareket;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Skor.skor++;
            collision.gameObject.AddComponent<Rigidbody>();
            zeminspawnerscripti.zemin_oluþtur();
            StartCoroutine(ZeminiSil(collision.gameObject));


        }
    }
    IEnumerator ZeminiSil(GameObject SilinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(SilinecekZemin);
    }



}
