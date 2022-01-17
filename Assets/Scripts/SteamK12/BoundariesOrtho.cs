using UnityEngine;

//code found from here: https://pressstart.vip/tutorials/2018/06/28/41/keep-object-in-bounds.html
namespace SteamK12.SpaceShooter
{
    public class BoundariesOrtho : MonoBehaviour
    {
        [SerializeField] Camera mainCamera;
        private Vector2 screenBounds;
        private float objectWidth;
        private float objectHeight;

        // Use this for initialization
        void Start () 
        {
            screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
            objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
            objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2
        }

        void LateUpdate()
        {
            Vector3 viewPos = transform.position;
            viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
            transform.position = viewPos;
        }
    }
}
