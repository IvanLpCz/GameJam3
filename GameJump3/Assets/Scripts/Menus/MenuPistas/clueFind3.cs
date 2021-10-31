using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bbook
{
    public class clueFind3 : MonoBehaviour
    {
        public cluesSave cluesave;
        public AudioSource player;
        public AudioClip writte;
        private void Start()
        {
            cluesave.t4 = true;
            player.PlayOneShot(writte, 0.7f);
        }
    }
}
