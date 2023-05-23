
using System;
using UnityEngine;

public class DrawManager2D : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private Line linePrefab;
    public const float RESOLUTION = .1f;
    private Line _currencyLine;
    private void OnEnable()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector2 mousePos = _camera.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0)) _currencyLine = Instantiate(linePrefab, mousePos, Quaternion.identity);
        
        if (Input.GetMouseButton(0)) _currencyLine.SetPosition(mousePos);
    }
}
