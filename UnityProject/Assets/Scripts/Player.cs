using UnityEngine;
public class Player : MonoBehaviour
{
	[SerializeField]
	Rigidbody mRigidbody;
	[SerializeField]
	Transform mCameraHandleTarnsform;
	void Update()
	{
		if(mRigidbody != null)
		{
			var vec = Vector3.zero;
			vec.z = -Input.GetAxis("Horizontal");
			mRigidbody.AddTorque(vec, ForceMode.VelocityChange);
			mRigidbody.AddForce(vec, ForceMode.VelocityChange);
		}
		if(mCameraHandleTarnsform != null)
		{
			mCameraHandleTarnsform.position = transform.position;
		}
	}
	void OnCollisionEnter(Collision inCollision)
	{
		if(inCollision.gameObject.tag != "Not")
		{
			inCollision.gameObject.transform.SetParent(transform);
		}
	}
}
