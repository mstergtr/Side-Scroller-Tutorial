using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class BackgroundLooper : MonoBehaviour
    {
        [SerializeField] float scrollSpeed = 0.5f;
        [SerializeField] float xRepeatPoint = -3.0f;
        [SerializeField] float xResetPoint = 3.0f;

        void Update()
        {
            Vector3 pos = transform.position;

            pos.x -= scrollSpeed * Time.deltaTime;

            if (pos.x <= xRepeatPoint)
            {
                pos.x = xResetPoint;
            }

            transform.position = pos;
        }
    }
}
