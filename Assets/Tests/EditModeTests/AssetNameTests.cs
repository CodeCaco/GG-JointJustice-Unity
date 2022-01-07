using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using TextDecoder.Parser;
using UnityEngine;
using UnityEngine.TestTools;

public class AssetNameTests
{
    [Test]
    public void ConvertAssetNameTests()
    {
        Assert.AreEqual("ThingWithSnakeCase",new AssetName("thing_with_snake_case").ToString());
        Assert.AreEqual("ThingWithSpaces",new AssetName("thing with spaces").ToString());
        Assert.AreEqual("ThingWithSpacesAndUnderscores",new AssetName("thing with_spaces and_underscores").ToString());
        Assert.AreEqual("ThingWithSpacesAndUnderscoresAndSomeCapitals",new AssetName("thing with_spaces and_underscores and Some Capitals").ToString());
    }
}
