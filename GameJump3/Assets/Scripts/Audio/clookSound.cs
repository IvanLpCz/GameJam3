using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sound
{
    public class clookSound : MonoBehaviour
    {
        public AudioClip clock;
        public Transform reloj;
        public Vector3 offset;

        private void Start()
        {
            AudioSource.PlayClipAtPoint(clock, (reloj.position + offset));
        }
    }
}
