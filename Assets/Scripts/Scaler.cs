using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    private void Update()
    {
        transform.localScale += Vector3.one * (_speedScale * Time.deltaTime);
    }
}
