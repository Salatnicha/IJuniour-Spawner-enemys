using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[SerializeField] private Enemy _enemy;
	[SerializeField] private Target _target;

	public Enemy Enemy { get { return _enemy; } private set { _enemy = value; } }
	public Target Target { get { return _target; } private set { _target = value; } }
}
