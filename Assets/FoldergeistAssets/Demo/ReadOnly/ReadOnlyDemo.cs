using FoldergeistAssets.ReadOnly;
using UnityEngine;

public class ReadOnlyDemo : MonoBehaviour
{
    [SerializeField]
    private int _test1;

    [SerializeField, ReadOnly]
    private int _test2 = 445;
}