using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperCameraLogick : MonoBehaviour
{
    [Range(0f, 100f)] [SerializeField] private float SpeedUperControleler;
    [SerializeField] private Transform VeshineController, CameraController;
    private void LateUpdate()
    {
        Vector3 pos = VeshineController.position;
        CameraController.position = Vector3.Lerp(pos, new Vector3(pos.x, VeshineController.position.y, pos.z), SpeedUperControleler * Time.deltaTime);
    }
}
