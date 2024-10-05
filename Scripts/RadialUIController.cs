using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class RadialUIController : MonoBehaviour
{
    [Header("Settings")]
    public float radius = 100f; // Control the radius of the circle
    public float centerRadius = 50f; // Size of the center button or object
    public float childSize = 40f; // Size of each child element
    public float gap = 10f; // Gap between child elements
    public bool fullCircle = true; // Set to true for a full circle, false for segments
    [Range(0, 360)]
    public float segmentAngle = 180f; // For partial circle (half, quarter)
    [Range(0, 360)]
    public float rotationOffset = 0f; // Rotate the entire radial menu

    private List<RectTransform> childButtons = new List<RectTransform>();

    void Start()
    {
        UpdateRadialMenu();
    }

    void Update()
    {
        if (Application.isEditor)
        {
            UpdateRadialMenu();
        }
    }

    void UpdateRadialMenu()
    {
        // Collect all children RectTransforms
        childButtons.Clear();
        foreach (Transform child in transform)
        {
            RectTransform rectTransform = child.GetComponent<RectTransform>();
            if (rectTransform != null)
            {
                childButtons.Add(rectTransform);
            }
        }

        // Set center size
        RectTransform centerRect = GetComponent<RectTransform>();
        if (centerRect != null)
        {
            centerRect.sizeDelta = new Vector2(centerRadius, centerRadius);
        }

        // Calculate the angle between each child based on circle segment
        float angleStep = fullCircle ? 360f / childButtons.Count : segmentAngle / (childButtons.Count - 1);
        float startAngle = fullCircle ? 0f : -segmentAngle / 2;

        // Position each child in a radial layout with rotation offset
        for (int i = 0; i < childButtons.Count; i++)
        {
            RectTransform button = childButtons[i];
            float angle = startAngle + i * angleStep + rotationOffset;

            // Convert angle to radians 
            float angleRad = angle * Mathf.Deg2Rad;

            // Calculate position based on angle and radius
            float posX = Mathf.Cos(angleRad) * (radius + gap);
            float posY = Mathf.Sin(angleRad) * (radius + gap);

            // Update button position and size
            button.anchoredPosition = new Vector2(posX, posY);
            button.sizeDelta = new Vector2(childSize, childSize);
        }
    }
}
