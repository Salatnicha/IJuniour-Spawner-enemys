using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
	[SerializeField] private Enemy _enemyPrefab;
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
			Enemy enemy = Instantiate(_enemyPrefab, _points[randomPonint].transform.position, Quaternion.identity);
			Vector2 randomDirection = Random.insideUnitCircle.normalized;
			enemy.Initializate(randomDirection);

			yield return rateWait;
		}
	}
}
