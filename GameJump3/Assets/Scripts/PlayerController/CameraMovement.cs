using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace playerController
{
    public class CameraMovement : MonoBehaviour
    {
        public float mouseSensitivity = 100f;

        public Transform player;

        private float xRotation = 90f;
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        private void Update()
        {
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            float m_X = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

            player.Rotate(Vector3.up * m_X);
        }
    }
}
