using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class RayCaster : MonoBehaviour
    {
        public GameObject MouseRaycast(int layer, bool isException)
        {
            layer = isException ? ~layer : layer;
            RaycastHit hit;
            if(Physics.Raycast(Input.mousePosition, Vector3.forward, out hit, 100, layer))
            {
                return hit.rigidbody.gameObject;
            }
            else
            {
                return null;
            }
        }
        public GameObject MouseRaycast()
        {
            RaycastHit hit;
            if (Physics.Raycast(Input.mousePosition, Vector3.forward, out hit, 100))
            {
                return hit.rigidbody.gameObject;
            }
            else
            {
                return null;
            }
        }
    }
}