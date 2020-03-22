using UnityEngine;

namespace HephaestusForge.ReadOnly
{
    /// <summary>
    /// Use this attribute to make a field readonly in the inspector, collections are affected a bit differently, the size is not readonly
    /// </summary>
    public class ReadOnlyAttribute : PropertyAttribute
    {
    }
}
