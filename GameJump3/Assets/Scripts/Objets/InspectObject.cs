using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Object
{
    public class InspectObject : MonoBehaviour
    {
        private Vector3 lastPos, currenPos;
        private float rotationSpeed = -0.2f;

        private void Start()
        {
            lastPos = Input.mousePosition;
        }
        private void Update()
        {
            Time.timeScale = 0;

            if (Input.GetMouseButton(0))
            {
                currenPos = Input.mousePosition;
                Vector3 offset = currenPos - lastPos;
                transform.RotateAround(transform.position, Vector3.up, offset.x * rotationSpeed);
                lastPos = currenPos;
            }
            lastPos = Input.mousePosition;
        }
    }
}