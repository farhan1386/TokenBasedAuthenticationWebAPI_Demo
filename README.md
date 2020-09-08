# Token Based Authentication in Web API

## Introduction

The ASP.NET Web API is an ideal framework, provided by Microsoft that, to build Web API’s, i.e. HTTP based services on top of the .NET Framework. Once we develop the services using Web API then these services are going to be consumed by a broad range of clients, such as

* Browsers
* Mobile applications
* Desktop applications
* IOTs, etc.

The use of WEB API is increasing in a rapid manner. So as a developer you should know how to develop Web APIs. Only developing Web APIs is not enough if there is no security. So, it also very important for us as a developer to implement security for all types of clients (such as Browsers, Mobile Devices, Desktop applications, and IoTs) who are going to use our Web API services.

The most preferred approach nowadays to secure the Web API resources is by authenticating the users in Web API server by using the signed token (which contains enough information to identify a particular user) which needs to be sent to the server by the client with each and every request. This is called the Token-Based Authentication approach.

## How Token-Based Authentication work?

1-The user enters his credentials (i.e. the username and password) into the client (here client means the browser or mobile devices, etc).
2-The client then sends these credentials (i.e. username and password) to the Authorization Server.
3-Then the Authorization Server authenticates the client credentials (i.e. username and password) and generates and returns an access token. This Access Token contains enough information to identify a user and also contains the token expiry time.
4-The client application then includes the Access Token in the Authorization header of the HTTP request to access the restricted resources from the Resource Server until the token is expired.

## Add the following required references from NuGet packages into application

* Microsoft.Owin.Host.SystemWeb
* Microsoft.Owin.Security.OAuth
* Microsoft.Owin.Cors
* Newtonsoft.json

## Advantages of using Token Based Authentication in ASP.NET Web API

**Scalability of Servers**: The token which is sent to the server by the client is self-contained means it holds enough data to identify the user needed for authentication. As a result, you can add easily more servers to your web farm, there is no dependent on shared session stores.

**Loosely Coupling**: The client application is not tied or coupled with any specific authentication mechanism. The token is generated, validated and perform the authentication are done by the server only.

**Mobile-Friendly**:The Cookies and browsers like each other, but handling the cookies on native platforms like Android, iOS, Windows Phone is not an easy task. The token-based approach simplifies this a lot.
