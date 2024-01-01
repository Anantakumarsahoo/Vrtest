using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ananta
{
    public class AnantaUtilies : MonoBehaviour
    {
        private AnantaUtilies instance;
        public AnantaUtilies Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnantaUtilies();
                }
                return instance;
            }
        }
    }
}