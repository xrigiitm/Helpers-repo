using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    [SerializeField] ARTrackedImageManager m_TrackedImageManager;
    [SerializeField] Transform objectToBePlaced;
    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {

            objectToBePlaced.parent = newImage.gameObject.transform;
            objectToBePlaced.transform.localPosition = new Vector3(0f, 0f, 0f);
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            objectToBePlaced.parent = newImage.gameObject.transform;
            objectToBePlaced.transform.localPosition = new Vector3(0f, 0f, 0f);
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }
}
