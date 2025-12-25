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
	- Assert.IsFalse(...)
	- Assert.IsEqual(...)
	- Assert.Contains(...)
	- Assert.HasCount(...)
	- ...
	
## 📕 References
- [Unit testing C# with MSTest and .NET](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)

---

<div align="center">

**⭐ Star this repository if you find it useful!**

Made with ❤️ by [Rafa Eslava](https://github.com/reslava)

</div>