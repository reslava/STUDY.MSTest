# STUDY.MSTest

> Learn MSTest for testing purposes

<div align="center">

![.NET](https://img.shields.io/badge/.NET-512BD4?logo=dotnet&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?&logo=csharp&logoColor=white)
[![GitHub contributors](https://img.shields.io/github/contributors/reslava/STUDY.MSTest)](https://GitHub.com/reslava/STUDY.MSTest/graphs/contributors/) 
[![GitHub Stars](https://img.shields.io/github/stars/reslava/STUDY.MSTest)](https://github.com/reslava/STUDY.MSTest/stargazers) 
[![GitHub license](https://img.shields.io/github/license/reslava/STUDY.MSTest)](https://github.com/reslava/STUDY.MSTest/blob/master/LICENSE.txt)

</div>

## 📋 Table of Contents
- [Overview](#-overview)
- [Comparison between MSTest and xUnit](#-Comparison-between-MSTest-and-xUnit)
- [References](#-references)

## 🎯 Overview
- Create the MSTest project:
```shell
dotnet new mstest
```
this will add to the project the needed packages as MSTest.Framework

- Add a reference to the project you are going to test:
```shell
dotnet reference add ../PrimeService/PrimeService.csproj
```

- Create a class for testing with the decoration (attribute)

	**[TestClass]**

- Create a method for testing with the attribute:

	**[TestMethod]**

- In case you need input data add bellow as many attribtes:

	**[DataRow(imput1, imput2, ...)]**

	as you need with 1 or more imput data and match then to input parameters of the method

- Use the Assert method you need to accomplish the test:

	Assert.IsFalse(...)
	Assert.IsEqual(...)
	Assert.Contains(...)
	Assert.HasCount(...)

>TIP: We can run the test from the command line:
```shell
dotnet run --project TestsProjectName
```



## ✅ Comparison between MSTest and xUnit 
| Purpose | MSTest | xUnit |
|---------|---------|-------|
| **Test Class** | `[TestClass]` | No attribute needed (any public class) |
| **Test Method** | `[TestMethod]` | `[Fact]` |
| **Parameterized Test** | `[TestMethod]` with `[DataRow]` | `[Theory]` with `[InlineData]`, `[MemberData]`, or `[ClassData]` |
| **Inline Test Data** | `[DataRow(value1, value2)]` | `[InlineData(value1, value2)]` |
| **External Data Source** | `[DataSource]` | `[MemberData]` or `[ClassData]` |
| **Setup (Before Each Test)** | `[TestInitialize]` | Constructor |
| **Teardown (After Each Test)** | `[TestCleanup]` | `IDisposable.Dispose()` |
| **Setup (Before All Tests)** | `[ClassInitialize]` (static method) | `IClassFixture<T>` |
| **Teardown (After All Tests)** | `[ClassCleanup]` (static method) | `IClassFixture<T>` with disposal |
| **Ignore/Skip Test** | `[Ignore]` or `[Ignore("reason")]` | `[Fact(Skip = "reason")]` or `[Theory(Skip = "reason")]` |
| **Test Category/Trait** | `[TestCategory("CategoryName")]` | `[Trait("Category", "CategoryName")]` |
| **Expected Exception** | `[ExpectedException(typeof(Exception))]` | Use `Assert.Throws<T>()` (no attribute) |
| **Test Timeout** | `[Timeout(milliseconds)]` | `[Fact(Timeout = milliseconds)]` |
| **Assembly Setup/Teardown** | `[AssemblyInitialize]` / `[AssemblyCleanup]` | `ICollectionFixture<T>` or assembly fixtures |

**Key Differences:**

- **xUnit philosophy**: xUnit prefers constructor/dispose patterns over attributes for setup/teardown, promoting better object-oriented practices
- **Parameterized tests**: xUnit uses `[Theory]` as the base attribute, while MSTest uses `[DataTestMethod]`
- **Class marking**: MSTest requires `[TestClass]`, xUnit discovers any public class with test methods
- **Exception testing**: xUnit doesn't use attributes for expected exceptions, preferring assertion methods instead


## 📕 References
- [Unit testing C# with MSTest and .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)
- [Master The Basics of MSTest Like a PRO In Under 15 minutes!](https://youtu.be/lxedalYArto?si=xCI_Xtv46V7g7Rqg)

---

<div align="center">

**⭐ Star this repository if you find it useful!**

Made with ❤️ by [Rafa Eslava](https://github.com/reslava)

</div>