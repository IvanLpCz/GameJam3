using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace bbook
{
    public class toIncrimination : MonoBehaviour
    {
        public cluesSave cluesave;
        public GameObject incriminationMenu, thisMenu;
        public void openIncrimination()
        {
            if (cluesave.canDecide)
            {
                thisMenu.SetActive(false);
                incriminationMenu.SetActive(true);
            }
        }
    }
}
