using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
	[SerializeField][Min(0)] private float _speed = 5;

	private Rigidbody _rigidbody;
	private Target _target;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Vector3 direction = (_target.transform.position - transform.position).normalized;
		Vector3 movement = new Vector3(direction.x * _speed, _rigidbody.linearVelocity.y, direction.z * _speed);

		_rigidbody.linearVelocity = movement;
	}

	public void Initializate(Target target)
	{
		_target = target;
	}
}
