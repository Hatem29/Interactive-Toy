using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace popUpBox
{
    public class island : MonoBehaviour
    {
        List<BoxCollider> blocks;

        void Start()
        {
            blocks = this.GetComponentsInChildren<BoxCollider>().ToList();
            foreach (BoxCollider block in blocks)
            {
                block.GetComponent<Transform>().tag = Utility.Block;
                block.GetComponent<BoxCollider>().isTrigger = true;
                block.GetComponent<MeshRenderer>().enabled = false;


                //Light light;
                //block.TryGetComponent<Light>(out light);
                //if(light != null)
                //    light.enabled = true;
            }
        }
    }
}
