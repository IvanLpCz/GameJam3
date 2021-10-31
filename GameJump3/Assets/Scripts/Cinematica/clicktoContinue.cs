using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace cinematica
{
    public class clicktoContinue : MonoBehaviour
    {
        public float timer = 0;
        public GameObject info;

        private void FixedUpdate()
        {
            timer += Time.deltaTime;

            if (timer >= 5)
            {
                info.SetActive(true);
            }
            if (Input.GetMouseButtonDown(0) && timer >= 5)
            {
                SceneManager.LoadScene("Level1");
            }
        }
    }
}
