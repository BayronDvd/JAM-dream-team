using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Detection : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [Range(0, 1)] public float threshold;
    
    #if UNITY_EDITOR
    void OnDrawGizmos()
    {
        Vector3 _playerPosition = _playerTransform.position;
        Vector3 _triggerPosition = transform.position;
        Vector3 _playerLookDirection = _playerTransform.forward;
        Vector3 _lookDirection = transform.forward;

        Vector3 _differenceVector = _playerPosition - _triggerPosition;
        float lookness = Vector3.Dot( _lookDirection, _differenceVector.normalized);
        Debug.Log(lookness);
        bool isLooking = lookness >= threshold;

        

        

        //Handles.color = _inVision ? Color.green : Color.red;
        Handles.color = isLooking ? Color.green : Color.red;

        Handles.DrawLine(transform.position,  _differenceVector + transform.position);  
        Handles.DrawWireDisc(transform.position, Vector3.up, 4);
        Handles.color = Color.yellow;
        Handles.DrawLine(transform.position, transform.position + (4 * -transform.right));

    }
#endif

    public bool DetectionMechanic()
    {
        Vector3 _playerPosition = _playerTransform.position;
        Vector3 _triggerPosition = transform.position;
        Vector3 _playerLookDirection = _playerTransform.forward;
        Vector3 _lookDirection = transform.forward;

        Vector3 _differenceVector = _playerPosition - _triggerPosition;
        float lookness = Vector3.Dot( _lookDirection, _differenceVector.normalized);
        Debug.Log(lookness);
        return  lookness >= threshold;
    }
}
