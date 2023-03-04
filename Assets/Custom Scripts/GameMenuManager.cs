using UnityEngine;
using UnityEngine.InputSystem;

namespace Custom_Scripts
{
    public class GameMenuManager : MonoBehaviour
    {
        private Transform _head;
        public float spawnDistance = 1f;
        public GameObject menu;
        public InputActionProperty showButton;

        //   private readonly Vector3 _headForward = _head.forward;
    
        // Update is called once per frame
        void Update()
        {
            if (showButton.action.WasPressedThisFrame())
            {
                menu.SetActive(!menu.activeSelf);
                menu.transform.position = _head.position + new Vector3(_head.forward.x, 0 , _head.forward.z).normalized * spawnDistance;
            }
        
            menu.transform.LookAt(new Vector3(_head.position.x, menu.transform.position.y, _head.forward.z));
            menu.transform.forward *= -1;
        }
    }
}
