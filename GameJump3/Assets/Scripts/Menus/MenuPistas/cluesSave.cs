using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bbook
{
    public class cluesSave : MonoBehaviour
    {
        public GameObject pista2, pista3, pista4, pista5, menu;
        public static bool prueba2, prueba3, prueba4, prueba5 = false;
        public bool t2, t3, t4, t5;
        public float timer = 0;

        private void Update()
        {
            timer += Time.deltaTime;
            if (menu.activeSelf)
            {
                if (prueba2)
                {
                    pista2.SetActive(true);
                }
                if (prueba3)
                {
                    pista3.SetActive(true);
                }
                if (prueba4)
                {
                    pista4.SetActive(true);
                }
                if (prueba5)
                {
                    pista5.SetActive(true);
                }
            }
            else if (!menu.activeSelf)
            {
                pista2.SetActive(false);
                pista3.SetActive(false);
                pista4.SetActive(false);
                pista5.SetActive(false);
            }
            if (t2)
            {
                prueba2 = true;
            }
            if (t3)
            {
                prueba3 = true;
            }
            if (t4)
            {
                prueba4 = true;
            }
            if (t5)
            {
                prueba5 = true;
            }
            //if(timer >= 3)
            //{
            //    prueba2 = true;
            //    prueba3 = true;
            //}
            Debug.Log(prueba2);
        }
    }
}
