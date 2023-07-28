using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Transform[] layers;   // Array to store the background layers
    public float[] parallaxFactors;   // Array to store parallax factors for each layer
    public Transform cameraTransform; // Reference to the main camera
    public float smoothing = 1f;  // Smoothing factor for the parallax effect

    private Vector3 previousCameraPosition; // Store the previous position of the camera

    void Start()
    {
        previousCameraPosition = cameraTransform.position;
    }

    void Update()
    {
        // Calculate parallax movement for each layer
        for (int i = 0; i < layers.Length; i++)
        {
            float parallax = (previousCameraPosition.x - cameraTransform.position.x) * parallaxFactors[i];
            float backgroundTargetPosX = layers[i].position.x + parallax;
            Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, layers[i].position.y, layers[i].position.z);
            layers[i].position = Vector3.Lerp(layers[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
        }

        // Update the previous camera position
        previousCameraPosition = cameraTransform.position;
    }
}
