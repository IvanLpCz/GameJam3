using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace playerController
{
    public class CameraMovement : MonoBehaviour
    {
        public float horizontalSpeed = 100f;
        public float verticalSpeed = 100f;

        float h;
        float v;

        public void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            
        }
        public void Update()
        {
            h = Input.GetAxis("Mouse X") * horizontalSpeed * Time.deltaTime;
            v = Input.GetAxis("Mouse Y") * horizontalSpeed * Time.deltaTime;

            transform.Rotate(-v, h, 0);

            Quaternion rotation = Quaternion.Euler(90, 90, 0);
            Debug.Log("hi");    
        }
    }
}
