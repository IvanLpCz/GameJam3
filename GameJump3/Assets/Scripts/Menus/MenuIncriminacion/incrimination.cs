using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace bbook
{
    public class incrimination : MonoBehaviour
    {
        public GameObject failMessage, fadeOut;
        public TMPro.TMP_Dropdown sospechosos, arma;
        public Button incriminationButton;
        private bool goccha, miss = false;

        public void getTheCulprit()
        {
            if (sospechosos.value == 1 && arma.value == 3)
            {
                goccha = true;
                miss = false;
            }
            else
            {
                miss = true;
            }

            if (goccha)
            {
                fadeOut.SetActive(true);
                StartCoroutine(WinScreen());
            }
            if (miss)
            {
                sospechosos.value = 0;
                arma.value = 0;
                failMessage.SetActive(true);
                StartCoroutine(hideFailMessage());
            }
        }
        IEnumerator hideFailMessage()
        {
            yield return new WaitForSecondsRealtime(3);
            failMessage.SetActive(false);
            miss = false;
        }
        IEnumerator WinScreen()
        {
            yield return new WaitForSecondsRealtime(2.5f);
            SceneManager.LoadScene("CreditosFinales");
        }



    }
}
