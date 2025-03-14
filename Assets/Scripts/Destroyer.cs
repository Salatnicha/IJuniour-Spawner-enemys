using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Destroyer : MonoBehaviour
{
	private void Awake()
	{
		if (GetComponent<Collider>().isTrigger == false)
		{
			Debug.LogWarning($"{gameObject.name}: trigger is not enabled");
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
	}
}
