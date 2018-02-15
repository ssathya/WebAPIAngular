Template project for .NET Core API provider and Angular client with Authentication.
===================================================================================

Summary
-------

There was a need to build an SPA application that uses Angular as the frontend
and .NET Core WEB API as the backend to provide API calls and of course provide
data only for authenticated users. Did little research online for any
project/documentation that would guide me build an application that would do the
following:

-   Authenticate user

-   Get data from API server â€“ only for authenticated users.

-   Authorization should be done at API server.

-   The server and client should be independent (i.e. .net application and the
    client can be hosted on different servers).

Stumbled upon some projects but none of them were not as simple as "Hello World!"
application. This project is a template project. All it does is allow the user
to log in and once authenticated it will reach the web API application and get a
simple JSON message. The application uses Auth0 to do identity management.

Objectives
----------

As mentioned above the template project should be a simple application that
should not have any features/libraries that will be redundant when using in
another project. To that extent, only minimal required libraries are included
for this project. The aim is once checked out/downloaded from the repository one
should be able to use the project from the get-go.

Background
----------

We are building an application to track security inventory and its performance.
The application will track the performance of securities and send a notification
to the account owners if specific actions need to be taken.

Account owners will update their inventory and other details from hand-held
devices or their computer. The server application needs to securely store user
information and process their inventory, and send a notification when needed.

As we are handling personally identifiable information (PII) it was decided to
use an architecture that distributes authentication, account ownerâ€™s personal
information and inventory in different applications. This architecture weights
that client, server, database, filesystem etc. placed on different platforms to
minimize relationship between account holder, inventory and other information by
unauthorized individuals.

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

-   Authentication systemâ€™s availability. There is a vendor dependency as the
    message from Auth0 (JWT) is used by downstream application to check if the
    user is authorized.

    -   This application may not be useful for other authentication vendors.

Limitations
-----------

n/a

Risk
----

n/a

Appendix
--------

n/a
