[![wc-title.jpg](https://iili.io/JWeGEB.png)](https://iili.io/JWeGEB.png)

### _Created by Tyler Bates_

## _Description_

Pierre's Vendor list is an interactive application that allows the user to upload a static list of vendors each having their own individual sub-lists of orders and details. Each order has additional details and the application dynamically stores and organizes all data while offering easy navigation throughout.


## _Setup/Installation Requirements_ 

1. Clone this projects repository into your local directory following [these](https://www.linode.com/docs/development/version-control/how-to-install-git-and-clone-a-github-repository/) instructions.

2. Open the now local project folder with [VSC](https://code.visualstudio.com/Download) or an equivalent

3. Download [.NET Core](https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows) then enter the following command in the terminal to confirm installation (2.2 or higher)
```sh
dotnet -- version
``` 
4. Still in the command line, enter
```sh
dotnet tool install -g 
dotnet-script
```
5. Download [ASP.NET Core](https://dotnet.microsoft.com/download)_ To enable live viewing on a local server

6. Open project, navigate to the containing folder of the project & Enter the following command to confirm build stability 

```sh
dotnet run build 
```

7. Within that same containing folder enter the following to open a live server w/auto updated viewing
```sh
dotnet watch run
``` 
8. If you want to run tests navigate to the .Tests containing folder and run

```sh
dotnet test
```
9. Enjoy

## _Technology Used_

## <a href="https://en.wikipedia.org/wiki/C_Sharp_%28programming_language%29">C#</a>
## <a href="https://en.wikipedia.org/wiki/.NET_Core">.NET Core</a>
## <a href="https://en.wikipedia.org/wiki/Visual_Studio_Unit_Testing_Framework">MSTest</a>

## _Specs_

|Behavior|Input|Output|
|-----|-----|-----|
|Pierre is greeted and given option to add a new Vendor|"Add new Vendor"|"5000/vendor/new"|
|Pierre is given additional option to view existing Vendors|"view vendors"|"5000/vendors/show"|
|Pierre populates the vendor details and form submission adds input data |"input"|"5000/vendors/{name}"|
|Program adds input vendor to list of vendors|"Dill Rye the Sandwich Guy"|"Dill Rye the Sandwich Guy"|
|Pierre is prompt to add orders to vendor|"Add new order"|"5000/vendors/{DillNyeTheSandwichGuy}/new"|
|Pierre populates the order details and form submission adds input data|"input"|"5000/vendors/{DillNyeTheSandwichGuy}/{Order}"|
|Program adds input order to list of orders of that vendor|"Planet Shaped Bread"|"5000/vendors/{DillNyeTheSandwichGuy}/{PlanetShapedBread}"|
|Pierre is given additional option to delete existing orders|"Delete Orders"|"5000/orders/delete"|
|Pierre is given additional option to delete existing Vendors|"Delete Vendors"|"5000/vendors/delete"|

## _Legal_

#### MIT License

### Copyright (c) 2020 Tyler Bates @ Epicodus

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.