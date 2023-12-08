using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taret : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public Camera amera;

    void Update()
    {
        // Fare pozisyonunu al
        Vector3 mousePos = Input.mousePosition;

        // Fare pozisyonunu d�nya koordinatlar�na �evir
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Fare pozisyonuna do�ru d�nme i�lemi
            RotateTurret(hit.point);
        }
    }

    void RotateTurret(Vector3 targetPosition)
    {
        // Turret pozisyonunu hedefe do�ru �evir
        Vector3 turretDir = targetPosition - transform.position;
        turretDir.y = 0f; // Y eksenini s�f�rlayarak sadece yatay d�zlemde d�nd�r

        Quaternion newRotation = Quaternion.LookRotation(turretDir);
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
    }

}
