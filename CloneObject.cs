using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneObject : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject,3f );
    }
    void Update()
    {
        transform.Translate(Vector3.forward);
    }
}
