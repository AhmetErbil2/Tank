using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ateş : MonoBehaviour
{
    public Camera Camera;
   // public ParticleSystem partical;
    




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
                Ates();
        }





    }
    public void Ates()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 rayOrigin = Camera.main.transform.position;
            Vector3 rayDirection = Camera.main.transform.forward;
            // Fare pozisyonunu ekran koordinatlarından dünya koordinatlarına çevir
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawRay(transform.position, Input.mousePosition,Color.red);
            Debug.DrawRay(transform.position,transform.forward ,Color.red);
            // Raycast yap ve çarpışmayı kontrol et
           
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.tag == "Hedef")
                {
                   
                    Debug.Log("görev tamam");
                    //partical.Play();
                }
                else
                {
                    Debug.Log("Görev Başarısız");
                }

                
            }








        }
    }
}
