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

-   Get data from API server – only for authenticated users.

-   Authorization should be done at API server.

-   The server and client should be independent (i.e. .net application and the
    client can be hosted on different servers).

Stumbled upon some projects but none of them were not as simple as “Hello World”
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

Scope
-----

Features
--------

Functional requirments
----------------------

Personnel requirments
---------------------

Reporting and quality assurance
-------------------------------

Delivery schedule
-----------------

Other requirments
-----------------

Assumptions
-----------

Limitations
-----------

Risk
----

Appendix
--------
