using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{
    
    public class SimpleScript : MonoBehaviour
    {

        public GameObject _player;

        private void OnTriggerEnter(GameObject other)
        {
            if(other.CompareTag("Finish"))
            {
                Debug.Log("asdhfouaewh");
            }
        }

        void Start()
        {
            
        }


        void Update()
        {
            OnTriggerEnter(_player);
        }

    }
}
