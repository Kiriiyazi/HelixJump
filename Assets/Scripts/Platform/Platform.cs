using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float _bounceForce;
    [SerializeField] private float _bounceRadius;

    public void Break()
    {
        PlatformSegment[] platformSegments = GetComponentsInChildren<PlatformSegment>();
        foreach (var segment in platformSegments)
        {
            segment.Bouns(_bounceRadius, transform.position, _bounceRadius);
        }
    }
}
