using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // �������� ����������� ���������.
    public float speed = 10.0f;

    void Start()
    {
        // ���������� �������� ����������� �������� ����
        GetComponent<Rigidbody>().velocity = transform.forward * speed;

        // ������� ������� ��������� ��� ������� ���������
        var indicator = IndicatorManager.instance.AddIndicator(gameObject, Color.red);
    }
}