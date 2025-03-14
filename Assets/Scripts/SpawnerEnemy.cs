using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
	[SerializeField] private SpawnPoint[] _points;
	[SerializeField][Min(0.01f)] private float _rate = 2;

	private void Start()
	{
		StartCoroutine(CreateEnemy());
	}

	private IEnumerator CreateEnemy()
	{
		var rateWait = new WaitForSeconds(_rate);

		bool isSpawn = true;

		while (isSpawn)
		{
			int randomPonint = Random.Range(0, _points.Length);
			SpawnPoint currentPoint = _points[randomPonint];
			Enemy enemy = Instantiate(currentPoint.Enemy, currentPoint.transform.position, Quaternion.identity);

			enemy.Initializate(currentPoint.Target);

			yield return rateWait;
		}
	}
}
