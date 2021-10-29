using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace playerController
{
    public class changePlayerPlace : MonoBehaviour
    {
        public GameObject player, spot;
        private void OnMouseEnter()
        {
            print(name);
        }
        private void OnMouseDown()
        {
            player.transform.position = spot.transform.position;
            player.transform.rotation = spot.transform.rotation;
        }
    }
}
