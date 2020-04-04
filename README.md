# _Park Finder, Client Side_

#### By _**K. Wicz**_


## Description

_An ASP.NET MVC web application that allows users to utilize the [ParkFinder API](https://github.com/kwicz/ParkFinderClient.Solution)._

## Application Preview

![Landing Page Preview](/ParkFinderClient/wwwroot/img/preview.png)


## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).


### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/kwicz/ParkFinderClient.Solution
cd ParkFinderClient.Solution
```
### 3. Install all necessary packages and make sure the project will build
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd ParkFinderClient
dotnet restore
dotnet build
```

### 4. Create the database and tables
Enter the following to build your database and tables for the program:
```sh
dotnet ef migrations add Initial
dotnet ef database update
```

### 5. Launch the project in your browser
In your terminal, type:
```sh
dotnet watch run
```
Hold ```command``` while clicking the link in your local terminal to your local address, which should be:
```sh
http://127.0.0.1:5000
```

### 6. Download and Run the ParkFinder API
Navigate to ```https://github.com/kwicz/ParkFinder.Solution``` and follow the Setup Instructions.

Congratulations! The project is now ready to use.

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/ParkFinderClient.solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _RestSharp 106.6.10_
* _Newtonsoft.Json 12.0.2_
* _Razor 2.2.0_
* _[ParkFinder API](https://github.com/kwicz/ParkFinder.Solution)_
* _[Badlands Photography by Andreas Eckert](https://www.doi.gov/blog/10-things-you-didnt-know-about-badlands-national-park)_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K Wicz_**