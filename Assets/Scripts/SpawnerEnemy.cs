using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
	[SerializeField] private Enemy _enemyPrefab;
	[SerializeField] private SpawnPoint[] _points;
	[SerializeField] private Target[] _targets;
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

			int randomTarget = Random.Range(0, _targets.Length);
			enemy.Initializate(_targets[randomTarget]);

			yield return rateWait;
		}
	}
}
