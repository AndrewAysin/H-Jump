using UnityEngine;

public class Controls : MonoBehaviour
{
    private Vector3 _previousMousePosition;
    public Transform level;
    [Range(0, 1)]
    public float _sens;
    

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            level.Rotate(0, -delta.x * _sens, 0);
        }
        _previousMousePosition = Input.mousePosition;
    }
}
