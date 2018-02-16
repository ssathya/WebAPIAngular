.NET Core API provider and Angular client with Authentication.
==============================================================

Summary
-------

There was a need to build an SPA application with Angular frontend and .NET Core
WEB API as the backend. It was hard to find a template project or guide that
would do the following:

-   Authenticate user

-   Get data from API server â€“ only for authenticated users.

-   Authorization should be done at API server.

-   The server and client should be independent (i.e. .net application and the
    client can be hosted on different servers).

Did come across a couple of tutorials but none of them were not as simple as
"Hello World" application and hence this template project was built. This
application will allow the user to log in and once authenticated it will reach
the backend server. The backend server will again check the user authentication
with the authentication server; If valid user & client application with sends a
JSON message. The application uses Auth0 to do identity management.

Objectives
----------

As mentioned earlier this template project is simple and includes only libraries
that are needed to authenticate a user and get a JSON message from API provider.

Background
----------

When building an application that involves Personally Identifiable Information
(PII) it is normal practice to build a layered application. The planned
approach:

-   Use an external vendor to authenticate users.

-   The front-end will use the token (JWT) that is provided by authentication
    system while requesting data from API server.

-   Backend system will evaluate the token with the authentication provider and
    provide data that is owned by the authenticated user.

-   Backend system will not store information extracted from JWT and his/her's
    belongings on the same resource.

The above are the basic requirements. Most templates do not address PII issue
i.e. integrate backend, authentication, and frontend in one executable. Hence
this template project was built. The approach should strictly adhere to "single
responsibility" for each executable.

Scope
-----

This application has a minimalistic requirement. All that it does it
authenticates a user and if authenticated by the third-party vendor (Auth0) then
a message is obtained from the back-end server. No user authorization is done.

Features
--------

N/A for this application.

Functional requirements
-----------------------

-   Authenticate a user with a third party authentication system.

-   If authenticated use JWT provided by the authentication system to request
    API server system for a message.

-   API server checks if JWT is valid and if valid and client application is a
    valid client endpoint for the application send a JSON message; currently it
    sends any one of 6 hardcoded messages.

Personnel requirements
----------------------

n/a for this application.

Reporting and quality assurance
-------------------------------

n/a for this application.

Delivery schedule
-----------------

Completed.

Other requirements
------------------

n/a for this application.

Assumptions
-----------

The application assumes the following:

-   Authentication system's availability. There is a vendor dependency as the
    message from Auth0 (JWT) is used by the downstream application to check if
    the user is authorized.

    -   This application may not be used for other authentication vendors.

Limitations
-----------

n/a

Risk
----

n/a

Appendix
--------

n/a
