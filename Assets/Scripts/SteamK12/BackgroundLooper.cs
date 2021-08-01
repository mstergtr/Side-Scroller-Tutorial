using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SteamK12.SpaceShooter
{
    public class BackgroundLooper : MonoBehaviour
    {
        public float scrollSpeed = 0.5f;
        public float xRepeatPoint = -3.0f;
        public float xResetPoint = 3.0f;

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
