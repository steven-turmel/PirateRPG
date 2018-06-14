using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {
    public Transform Player;
    public Vector3 Offset;

    void LateUpdate()
    {
        transform.position = Player.position + Offset;
    }
}
