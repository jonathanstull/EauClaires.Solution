## Specs

* As the salon owner, I need to be able to see a list of all stylists.
* As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
* As the salon owner, I need to add new stylists to our system when they are hired.
* As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

## Naming Conventions

Root directory: HairSalon.Solution
Production directory: HairSalon
Test directory: HairSalon.Tests
Namespaces:
  * Salon: Program and Startup .cs files
  * Salon.Models: all models
  * Salon.Controllers: all controllers
Models:
  * Stylist
    * Id
    * Name
    * Phone
    * Email
    * Address
    * StartDate
    * LeaseRate
  * Client
    * Id
    * StylistId
    * Name
    * Phone
    * Email
    * StartDate

