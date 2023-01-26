using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationBlock : MonoBehaviour
{
    public GameObject Block;

    void Start()
    {
        StartCoroutine(BlockSpawner());
    }

    IEnumerator BlockSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-7f, -1.3f);
            GameObject newBlock = Instantiate(Block, new Vector3(4.5f, rand, 0), Quaternion.identity);
            Destroy(newBlock, 5);
        }
    }
}
