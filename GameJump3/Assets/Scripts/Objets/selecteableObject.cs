using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Object
{
    public class selecteableObject : MonoBehaviour
    {
        public GameObject inspeccionableObject;
        private void OnMouseEnter()
        {
            print(name);
        }
        private void OnMouseDown()
        {
            inspeccionableObject.SetActive(true);
        }
        private void OnMouseExit()
        {

        }
    }
}
