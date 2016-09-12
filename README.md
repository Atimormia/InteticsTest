# README #

### What is this repository for? ###

To automate everyday work of an administrator at a service station

### How to set up? ###

* To execute application a .NET Framework 4.5 and MS SQL Server LocalDB Express should be insalled on your computer.
* Copy folder InteticsTest/InteticsTest/InteticsTest/bin/Debug/ and execute .exe file

### How to use application? ###
## Creating new order ##
0. Click button "New order".
1. In opened window choose client:
1.1. Click button "Choose client"
1.2. In opened window you can try to find client by name and surname:
1.2.1 Enter name and surname
1.2.2 Click button "Find"
1.2.3 To show all data click button "Show all"
1.3. You can add client:
1.3.1 Input client data in the last row
1.3.2 Click button "Add" else data will not be saved
1.4 Select Row with client data and click button "Choose". Whindow will be closed
2. In previous window choose car:
2.1. Click button "Choose car"
2.2. In opened window will show cars list by choosen client
2.3. You can add, edit and delete rows
2.3. Select row and click button "Choose". Whindow will be closed
3. In previous window enter date, amount and status
4. Click button "Add Order"

## Client card ##
0. On main window click button "Client card"
1. In opened window you can do 1.2 and 1.3 from previous chapter
2. You can open related cars list by clicking the button "Related cars":
2.1 In opened window you can do 2.3 from previous chapter

## Orders by car ##
0. On main window click button "Orders by car"
1. In opened window you can find order:
1.1. Enter car VIN
1.2. Click button "Find"
1.3. To show all data click button "Show all"
2. You can add, edit (new order window will be opened) and delete rows:
2.1. Select row
2.2. Click action button

### TODO ###
* Factory model
* MessageBoxes on UI level
