using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Custom_Scripts
{
    public class FireBulletOnActivate : MonoBehaviour
    {
        public GameObject bullet;
        public Transform spawnPoint;
        public float fireSpeed = 20;
    
        // Start is called before the first frame update
        void Start()
        {
            var isGrabbable = GetComponent<XRGrabInteractable>();
            isGrabbable.activated.AddListener(FireBullet);
        }

        private void FireBullet(ActivateEventArgs args)
        {
            var spawnedBullet = Instantiate(bullet);
            spawnedBullet.transform.position = spawnPoint.position;
            spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
            Destroy(spawnedBullet,5);
        }
    }
}
