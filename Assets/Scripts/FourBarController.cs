using UnityEngine;

public class FourBarController : MonoBehaviour
{
    public Rigidbody RigidBody;
    public float DriveForce = 100;

    private void FixedUpdate()
    {
        var worldPoint = this.transform.TransformPoint(new Vector3(.45f, 0, 0));
        var worldForce = this.transform.TransformVector(new Vector3(0, DriveForce, 0));
        RigidBody.AddForceAtPosition(RigidBody.mass * worldForce, worldPoint);
    }
}
