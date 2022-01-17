using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float speed = 5f;
        [SerializeField] GameObject bulletPrefab;
        [SerializeField] Transform firePoint;
        [SerializeField] Animator animator;
        private float xInput, yInput;

        void Update()
        {
            ProcessMovement();

            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }
        }

        private void ProcessMovement()
        {
            xInput = Input.GetAxis("Horizontal");
            yInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * xInput * speed * Time.deltaTime);
            transform.Translate(Vector3.up * yInput * speed * Time.deltaTime);

            animator.SetFloat("positionY", yInput);
        }
    }
}
