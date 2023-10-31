using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField] private float topBound = 30f;
    [SerializeField] private float bottomBound = -10f;

    void Update()
    {

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }

    }
}
