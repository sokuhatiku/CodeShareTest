using NUnit.Framework;
using UnityEngine;

namespace Editor
{
    public class TestScript 
    {
        [Test]
        public void Test()
        {
            Debug.Log(Sokuhatiku.CodeShareTest.NetStandard.Class1.GetText());
        }
    }
}
