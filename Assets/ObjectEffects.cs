
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectEffects : MonoBehaviour
{
    public Gradient colorGradient;

    public float maxHeight = 100f;

    void Start()
    {

    }

    void Update()
    {
        // Zadanie 1 i 2
        // Zmiana koloru obiektu w zale¿noœci od pozycji Y

        float height = transform.position.y;

        float gradientValue = Mathf.Clamp01(height / maxHeight);

        GetComponent<Renderer>().material.color =
            colorGradient.Evaluate(gradientValue);


        // Zadanie 3
        // Obracanie obiektu 3D w osi X zale¿nie od pozycji X

        float rotationSpeed = transform.position.x;

        transform.Rotate(rotationSpeed * Time.deltaTime, 0f, 0f);
    }
}
