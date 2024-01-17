using UnityEngine;

/// <summary>
/// This script helps you show and object when a person
/// enters a region with a box collider.
/// The object will be hidden when the user exit the region
/// </summary>

[RequireComponent(typeof(BoxCollider))]
public class ShowSomethingWhenEnterRegion : MonoBehaviour
{
    public GameObject objectToHideAndShow;

    private void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if(meshRenderer != null)
        {
            meshRenderer.enabled = false;
        }

        BoxCollider collider = GetComponent<BoxCollider>();
        if(collider != null)
        {
            collider.isTrigger = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToHideAndShow.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        objectToHideAndShow.SetActive(false);
    }
}
