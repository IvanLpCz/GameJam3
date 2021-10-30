using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bbook
{
    public class toIncrimination : MonoBehaviour
    {
        public cluesSave cluesave;
        public GameObject incriminationMenu, thisMenu, cantIncriminateText;
        public void openIncrimination()
        {
            if (cluesave.canDecide)
            {
                thisMenu.SetActive(false);
                incriminationMenu.SetActive(true);
            }
            if (!cluesave.canDecide)
            {
                cantIncriminateText.SetActive(true);
                StartCoroutine(hideFailMessage());
            }
            IEnumerator hideFailMessage()
            {
                Debug.Log("hola");
                print(Time.time);
                yield return new WaitForSecondsRealtime(3);
                print(Time.time);
                cantIncriminateText.SetActive(false);              
            }
        }
        private void Update()
        {
            Debug.Log(Time.time);
        }
    }
}
