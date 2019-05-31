
using UnityEngine;
//for menu : open tap after few sec
public class WaterTap : MonoBehaviour
{
    public bool isMainMenu;
    public GameObject water;
    float timeToSpawn = .03f;
    float spawnTime;
    public float timeToSpawnWater;
    manager GM;
    LineFactory lineFactory;
    public int instantiatedGoCount;
    public Vector2 particleFlowDirection;

    // Start is called before the first frame update
    void Start()
    {
        GM = FindObjectOfType<manager>();
        lineFactory = FindObjectOfType<LineFactory>();
    }

    // Update is called once per frame
    void Update()
    { // if (!GM.isStarted) return;
        if (!isMainMenu)
        {   if (!lineFactory.hasGameStarted) return;
                 }
        if (timeToSpawnWater <= 0) return;
        timeToSpawnWater -= Time.deltaTime;

        if (spawnTime + timeToSpawn < Time.time)
        {
            GameObject GO = Instantiate(water,
      new Vector2(Random.Range(transform.position.x - .1f, transform.position.x + .1f), transform.position.y)
      , Quaternion.identity) as GameObject;
            GO.tag = "Water";

            GO.GetComponent<Rigidbody2D>().AddForce(particleFlowDirection);
            spawnTime = Time.time;

        }
    }
}
