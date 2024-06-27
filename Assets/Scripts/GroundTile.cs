
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    
    GroundSpawn groundSpawn;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstaclech = 0.2f;



    void Start()
    {
        groundSpawn = GameObject.FindAnyObjectByType<GroundSpawn>();

        SpawnObstacle();
        SpawnCoins();
    }



    private void OnTriggerExit(Collider other)
    {
        groundSpawn.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        GameObject obstacleToSpawn = obstaclePrefab;
        float random = Random.Range(0f,1f);
        if(random < tallObstaclech)
        {
            obstacleToSpawn = tallObstaclePrefab;
        }


        int ObstacleSpawn = Random.Range(2, 5);

        Transform spawnPoint = transform.GetChild(ObstacleSpawn).transform;

        Instantiate(obstacleToSpawn, spawnPoint.position, Quaternion.identity, transform);
    }

    public GameObject coinPrefab;

    void SpawnCoins()
    {
        int coinsSpawn = 10;
        for (int i = 0; i < coinsSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab, transform);
            temp.transform.position = RandomPoint(GetComponent<Collider>());
        }

        Vector3 RandomPoint (Collider collider)
        {
            Vector3 point = new Vector3(
                
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
                );
            if (point != collider.ClosestPoint(point))
            {
                point = RandomPoint(collider);
            }

            point.y = 1;
            return point;

        }

    }


}
