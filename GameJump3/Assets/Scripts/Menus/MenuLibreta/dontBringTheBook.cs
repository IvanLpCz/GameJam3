using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace bbook
{
    public class dontBringTheBook : MonoBehaviour
    {
        public Scene thisScene;
        public GameObject libro;

        private void Start()
        {
            thisScene = SceneManager.GetActiveScene();

            if (thisScene.name != "Level1")
            {
                libro.SetActive(false);
            }
        }
    }
}
