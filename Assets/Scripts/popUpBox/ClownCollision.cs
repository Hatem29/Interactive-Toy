using popUpBox;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class ClownCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.transform.CompareTag(Utility.Block))
            return;

        MeshRenderer meshRenderer;
        other.TryGetComponent<MeshRenderer>(out meshRenderer);

        Light light;
        other.TryGetComponent<Light>(out light);

        if (transform.CompareTag(Utility.HappyClown))
        {
            if (meshRenderer != null)
                meshRenderer.enabled = true;

            if (light != null)
                light.enabled = true;
        }
        else if (transform.CompareTag(Utility.BadClown))
        {
            if (meshRenderer != null)
                meshRenderer.enabled = false;

            if (light != null)
                light.enabled = false;
        }
    }

}

