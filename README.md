
# _Pierre's Treats_

#### By _**Jeremy Martin**_

#### _A Webpage that displays available treats from Pierre's Bakery along with flavor tags to all users. Users who sign in can create new treats/flavor tags or edit/delete existing ones._

## Technologies Used

* C#
* MySQL
* MySQL Workbench
* Entity
* .NET 5.0

## Description

This web page will initially display a splash page were you can click on either a treat or flavor to see their details including the treats they are descriptors for (flavors) or the flavors that describe them (treats). There are also links to the list of treats or flavors with the ability to add treats/flavors from their respective list pages if you are signed in. On the list pages you can also click on a treat or flavor to go to their details page (just like from the splash page). In the details page there are links you can click to edit or delete the specific treat or flavor if you are signed in. The ability to remove a treat's pair with a flavor or vice versa is in their edit page. 

## Setup/Installation Requirements

### Getting Started

* Clone repo from GitHub using this link (https://github.com/JeremyM45/PierresTreats)

* Navigate to the PierresTreats.Solution folder in terminal
```
(Users/Username/Desktop/PierresTreats.Solution)
```
* cd into the PierresTreats folder
```
cd PierresTreats
```
* Add an appsettings.json file in the PierresTreats folder

* In the appsettings.json file add these lines of code with your MySQL password were [Your Password Here] is.

```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=jeremy_martin;uid=root;pwd=[Your Password Here];"
}
}
```

### Setting up database
#### Using Entity
* If you do not have Entity installed on your computer run this line in your terminal at the root directory
```
dotnet tool install --global dotnet-ef --version 5.0.1
```
* Then run these two lines in your terminal at the project folder level (../PierresTreats.Solution/PierresTreats)
```
dotnet ef migrations add Initial
dotnet ef database update
```
* Now the database should show up in your MySQL schemas
#### Not Using Entity
* Open MySQL Workbench and sign in

* Under the management tab in the Navigator click on Data Import/Restore

* Click the Import From Self Contained File radio button and input the path to jeremy_martin.sql file in PierresTreats.Solution folder

```
../PierresTreats.Solution/jeremy_martin.sql
```

* In the Default Schema to be Imported To section click the new button and name the schema jeremy_martin (you can name it something else if you change the database path in the appsettings.json file)

* Then click the Start Import button

* Once the schema has been imported refresh your Schemas list in the Navigator to see the new schema

### Restore and Run

* Type dotnet retore in terminal while in the PierresTreats folder
```
dotnet restore
```
* Then type dotnet run in the terminal while still in the PierresTreats folder
```
dotnet run
```

## Known Bugs

*  _If you delete a treat/flavor relationship in the edit treat/flavor page any changes you made in the text box field will be reset_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) _2022_  _Jeremy Martin_