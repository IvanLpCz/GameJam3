using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace bbook
{
    public class clueFind2 : MonoBehaviour
    {
        public cluesSave cluesave;
        public AudioSource player;
        public AudioClip writte;
        private void Start()
        {
            cluesave.t3 = true;
            player.PlayOneShot(writte, 0.7f);
        }
    }
}
