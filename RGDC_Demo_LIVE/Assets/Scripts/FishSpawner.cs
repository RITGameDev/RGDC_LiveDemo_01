using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour {

    public GameObject fish_prefab;

    public int fishToSpawn = 3;
    public float timeBetweenWaves = 2f;

    public Vector3 spawnLocation;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(SpawnFish());
	}
	


    private IEnumerator SpawnFish()
    {
        while(true)
        {
            for(int i = 0; i < fishToSpawn; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(spawnLocation.x, -spawnLocation.x), spawnLocation.y, 0f);
                Quaternion rotation = Quaternion.identity;
                // Spawn a fish
                Instantiate(fish_prefab, spawnPosition, rotation);
            }

            yield return new WaitForSeconds(timeBetweenWaves);
        }
    }
}
