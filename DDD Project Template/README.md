# DDD Project Template
The Enterprise Application Template gives you a boilerplate solution template with 5 projects separated in solution folders based on SOLID principles.

+ 00 Documentation Layer 
  * The documentation layer is where you for instance can add SpeckFlow definitions or code map diagrams

* 10 Presentation Layer
..* The presentation layer is empty for you to add your user interface project (ie: WebApps, WCF apps, etc) 
* 20 Business Layer
  * The business layer has two projects. The concrete implementation of the business layer, and a Unit Test project for the business layer. 
* 30 Domain Layer
  * The domain layer folder has one project for interface definitions, entities and values. 
* 40 Data Layer
  * The data layer contains a single fake data layer project using the interfaces from the domain. 
* 50 Cross-Cutting Layer
  * Contains three example projects for helper projects that will be used across the layers, Data, Domain, business and Presentation. 
  * The Extentions project is for having a place to put extention methods for existing C# types. 
  * The ValueConverters is a utility library for casting objects from type a to b 
  * TestHelpers is a utility libirary for Unit Tests. 
* 60 Deployment Layer
  * Empty follder but if you are createing an Microsoft Azure solution this is where you place ei Azure Resource Group project for setting upp a deployment template 


The template has predefined references to the following NuGet packages
* Moq -version 4.0.10827 
* Should -version 1.1.20 
* structuremap -version 3.0.0.108 
* structuremap.automocking.moq -version 3.0.5.130 

The reason for using structuremap.automocking.moq version 3.0.5.130 and not latest version is that there is a bug/issue  that I've not yet understood and you should not upgrade that reference unless you know what you are doing. The TestHelper class is set up for MSTest so if you are using any other framework you will have to replace the testclass and testinitialiser decorations appropriate to your framework.

A big thank you to @digitaldias for eye openers and help!

## Requirements
You'll need Visual Studio 2015 (RC minimum) with Visual Studio 2015 (RC minimum) SDK installed to open the Visual Studio Extension project.

## Download
A compiled version can be found inside the Microsoft Visual Studio (2013 & 2015) Extensions and Updates menu. Do a search for "Enterprise Application Solution" or visit [Visual Studio Gallery]: https://visualstudiogallery.msdn.microsoft.com/74633fdf-0563-4c75-aca8-f69835e7f8ab to download 