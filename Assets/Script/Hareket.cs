using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    float moveSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
            // "Vertical" ve "Horizontal" eksenlerindeki giriþleri al
            float verticalInput = Input.GetAxis("Vertical");
            float horizontalInput = Input.GetAxis("Horizontal");

            // Yeni pozisyonu hesapla ve nesneyi hareket ettir
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        
    }
}
