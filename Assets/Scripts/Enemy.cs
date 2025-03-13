using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
	[SerializeField][Min(0)] private float _speed;

	private Rigidbody _rigidbody;
	private Vector2 _direction;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Vector3 movement = new Vector3(_direction.x, _rigidbody.linearVelocity.y, _direction.y).normalized * _speed;
		_rigidbody.linearVelocity = movement;
	}

	public void Initializate(Vector2 direction)
	{
		_direction = direction.normalized;
	}
}
