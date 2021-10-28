using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace tests
{
    public class test : MonoBehaviour
    {
        public Button reload;
        private Scene actualScene;
        public void Start()
        {
            actualScene = SceneManager.GetActiveScene();
        }


        public void RestartButton()
        {
            SceneManager.LoadScene(actualScene.name);
            Time.timeScale = 1;
        }
    }
}
