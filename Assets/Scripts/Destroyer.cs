using UnityEngine;

public class Destroyer : MonoBehaviour
{
	private float _destroyThresholdY = -10f;

	private void Update()
	{
		if (transform.position.y < _destroyThresholdY)
		{
			Destroy(gameObject);
		}
	}
}
