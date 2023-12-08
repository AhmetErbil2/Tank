using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Namlu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fare pozisyonunu al
        Vector3 mousePos = Input.mousePosition;

        // Fare pozisyonunu dünya koordinatlarýna çevir
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;
    }
}
