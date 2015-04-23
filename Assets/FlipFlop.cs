using UnityEngine;
using System.Collections;

public class FlipFlop : MonoBehaviour
{
    IEnumerator Start()
    {
        var r = GetComponent<Renderer>();

        while (true)
        {
            r.enabled = true;
            yield return null;

            r.enabled = false;
            yield return null;
        }
    }
}
