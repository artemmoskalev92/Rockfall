using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipThrust : MonoBehaviour
{
    public float speed = 5f;

    // ѕеремещает корабль вперед с посто€нной скоростью
    void Update()
    {
        var offset = Vector3.forward * Time.deltaTime * speed;
        transform.Translate(offset);
    }
}
