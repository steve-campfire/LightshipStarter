using UnityEngine;

public class ChangeSelfMaterial : MonoBehaviour
{
    [SerializeField] private Material[] materials;

    private MeshRenderer _meshrenderer;
    private int _currentMat = 0;

    private void Start()
    {
        _meshrenderer = GetComponent<MeshRenderer>();
        EventOnClick.ButtonToggle += ToggleMaterial;
    }

    private void ToggleMaterial()
    {
        if (_meshrenderer)
        {
            _currentMat += 1;
            _currentMat %= materials.Length;
        
            Debug.Log("CurrentMat =>" + _currentMat);
            _meshrenderer.sharedMaterial = materials[_currentMat % materials.Length];
        }
    }
}
