using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Object
{
    public class selecteableObject : MonoBehaviour
    {
        public Texture2D mousecursorIn;
        public CursorMode cursormode = CursorMode.Auto;
        public Vector2 hotspot = Vector2.zero;
        public GameObject inspeccionableObject;
        private void OnMouseOver()
        {
            Cursor.SetCursor(mousecursorIn, hotspot, cursormode);
            print(name);
        }
        private void OnMouseDown()
        {
            if (Time.timeScale != 0)
            {
                inspeccionableObject.SetActive(true);
            }
        }
        private void OnMouseExit()
        {
            Cursor.SetCursor(null, hotspot, cursormode);
        }
    }
}
