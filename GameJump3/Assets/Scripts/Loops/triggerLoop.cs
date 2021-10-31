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
        public AudioSource shootSource;
        public AudioClip shootSound;
        private bool haveShoot;
        private Scene actualScene;
        public void Start()
        {
            actualScene = SceneManager.GetActiveScene();
            haveShoot = false;
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
                timer = 0;
            }
            if (timer >= 9.3f && haveShoot == false)
            {
                shootSource.PlayOneShot(shootSound, 1f);
                haveShoot = true;
            }
        }
    }

}