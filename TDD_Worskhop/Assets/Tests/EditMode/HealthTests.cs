using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthTests
{
    Health health;

    [SetUp]
    public void SetUp()
    {
        health = new Health();
        health.health = 100;
    }

    [TearDown]
    public void TearDown()
    {
        health.health = 0;
        health = null;
    }

    [Test]
    public void CanAddHealth()
    {
        health.Add(100);
        Assert.AreEqual(200, health.health);
    }

    [Test]
    public void CanRemoveHealth()
    {
        health.RemoveHealth(20);
        Assert.AreEqual()
    }

}