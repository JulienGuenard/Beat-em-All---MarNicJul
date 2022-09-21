using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    [SerializeField] private float _cameraOffset = -10f;

    [SerializeField] private float _cameraSpeed = 15f;

    
    private void LateUpdate()
    {
        
        Vector3 newPosition = Vector3.Lerp(transform.position, _target.position, _cameraSpeed * Time.deltaTime);

        newPosition.z = _cameraOffset;

        transform.position = newPosition;
    }
}
