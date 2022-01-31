using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapons : MonoBehaviour
{
    // ������ ��� �������� ��������
    public GameObject shotPrefab;
    // ������ ����� ��� ��������
    public Transform[] firePoints;
    // ������ � firePoints, ����������� �� ��������� �����
    private int firePointIndex;
    // ���������� ����������� ����� InputManager.

    public void Awake()
    {
        // ����� ������ ������ �����������, �������� ���������� �����, ����� ������������ ��� ��� ������� �������� ���������� �������
        InputManager.instance.SetWeapons(this);
    }

    // ���������� ��� �������� �������
    public void OnDestroy()
    {
        // ������ �� ������, ���� ���������� �� � ������ ����
        if (Application.isPlaying == true)
        {
            InputManager.instance.RemoveWeapons(this);
        }
    }
    public void Fire()
    {
        // ���� ����� �����������, �����
        if (firePoints.Length == 0)
            return;
        // ���������� ��������� ����� ��� ��������
        var firePointToUse = firePoints[firePointIndex];
        // ������� ����� ������ � �����������, ��������������� �����
        Instantiate(shotPrefab, firePointToUse.position, firePointToUse.rotation);
        // ������� � ��������� �����
        firePointIndex++;
        // ���� ��������� ����� �� ������� �������, ��������� � ��� ������
        if (firePointIndex >= firePoints.Length)
            firePointIndex = 0;
    }
}