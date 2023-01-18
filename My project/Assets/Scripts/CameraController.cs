using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform target;

    private void Start()
    {
        instance = this;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y + 3f, target.position.z - 2f);
    }
}
