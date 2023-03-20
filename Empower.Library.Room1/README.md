# Skyline.DataMiner.Empower.Library.Room1

## About

Empower Demo - Library that allows an order to be placed on DataMiner solutions.skyline.be.

This is done through HTTPS to a User Defined API on DataMiner.
It can only be done from a windows server that has the right security GUID configured using the following commands in powershell:

```
dotnet tool install --global Skyline.DataMiner.CICD.Tools.WinEncryptedKeys
WinEncryptedKeys --name SLC_EXTERNAL_DISPATCHER_KEY --value GUID
```

### About DataMiner

DataMiner is a transformational platform that provides vendor-independent control and monitoring of devices and services. Out of the box and by design, it addresses key challenges such as security, complexity, multi-cloud, and much more. It has a pronounced open architecture and powerful capabilities enabling users to evolve easily and continuously.

The foundation of DataMiner is its powerful and versatile data acquisition and control layer. With DataMiner, there are no restrictions to what data users can access. Data sources may reside on premises, in the cloud, or in a hybrid setup.

A unique catalog of 7000+ connectors already exist. In addition, you can leverage DataMiner Development Packages to build you own connectors (also known as "protocols" or "drivers").

> **Note**
> See also: [About DataMiner](https://aka.dataminer.services/about-dataminer).

### About Skyline Communications

At Skyline Communications, we deal in world-class solutions that are deployed by leading companies around the globe. Check out [our proven track record](https://aka.dataminer.services/about-skyline) and see how we make our customers' lives easier by empowering them to take their operations to the next level.


## Getting Started

``` csharp
var order = OrderFactory.CreateOrder("Order 1");
order.Dispatch("MyUser");
```
