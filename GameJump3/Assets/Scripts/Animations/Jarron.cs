using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using loops;

namespace animations
{
    public class Jarron : MonoBehaviour
    {
        public Animator breakAnimation;
        public BoxCollider boxcollider;
        public triggerLoop triggerloop;
        private bool isTriggered;
        public AudioSource jarron;
        public AudioClip jarronRoto;

        private void Start()
        {
            breakAnimation = GetComponent<Animator>();
            isTriggered = false;
        }
        private void Update()
        {
            if(triggerloop.timer >= 6f && !isTriggered)
            {
                breakAnimation.enabled = true;
                boxcollider.enabled = false;
                jarron.PlayOneShot(jarronRoto, 0.7f);
                isTriggered = true;
            }
        }


    }
}
