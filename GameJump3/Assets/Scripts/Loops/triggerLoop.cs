using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace loops
{
    public class triggerLoop : MonoBehaviour
    {
        public float timer = 0;
        private Scene actualScene;
        public void Start()
        {
            actualScene = SceneManager.GetActiveScene();
        }
        public void Update()
        {
            if(timer < 10)
            {
                timer += Time.deltaTime;
            }
            if (timer >=10)
            {
                SceneManager.LoadScene(actualScene.name);
            }
        }
    }

}