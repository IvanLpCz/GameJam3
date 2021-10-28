using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace loops
{
    public class dontDestroy : MonoBehaviour
    {
        private static bool loopExist;
        private bool realLoop;

        private void Awake()
        {
            if (!loopExist)
            {
                loopExist = true;
                realLoop = true;
                DontDestroyOnLoad(this.gameObject);
            }
            else if (loopExist && !realLoop)
            {
                Destroy(this);
            }
        }

    }
}
