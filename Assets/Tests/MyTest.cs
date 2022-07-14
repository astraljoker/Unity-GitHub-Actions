using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

// https://docs.unity3d.com/kr/2019.1/Manual/PlaymodeTestFramework.html
public class MyTest
{
    [Test]
    public void SuccessTest() 
    {
        Assert.IsTrue(true);
    }

    [Test]
    public void Failtest()
    {
        Assert.IsTrue(false);
    }
}
