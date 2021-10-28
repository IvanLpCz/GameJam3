using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bbook
{
    public class openBook : MonoBehaviour
    {
        public Button openBookButton;
        public GameObject book;

        public void opentheBook()
        {
            Time.timeScale = 0;
            book.SetActive(true);
        }

    }
}
