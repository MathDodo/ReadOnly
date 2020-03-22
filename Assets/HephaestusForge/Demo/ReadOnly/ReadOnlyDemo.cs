using UnityEngine;

namespace HephaestusForge.ReadOnly
{
    public class ReadOnlyDemo : MonoBehaviour
    {
#pragma warning disable 0649

        [SerializeField]
        private int _test1;

        [SerializeField, ReadOnly]
        private int _test2 = 445;

#pragma warning restore 0649
    }
}