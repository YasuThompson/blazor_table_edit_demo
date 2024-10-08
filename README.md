# blazor_table_edit_demo

```
cd MovieTableEdit
```

```
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Components.QuickGrid
dotnet add package Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter
dotnet add package CsvHelper
```

### TODO list
- [ ] List or IQuieryable (how to store table)?
    - [x] (Suggestion for now) price, product dim tables use combinations of IQueryable and List, and category dimension tables use Lists. Queried rows are edited as IQueryable, and newly added rows are in a normal List. Category tables should use only normal Lists because numbers of dimension tables just increases. It might be more customizable not to use QuickGrid in this case. 
- [ ] To finish filters in the home page
    - [x] To make the first version
    - [ ] To rethink how to route paramters to table edit pages (string or integer?)
    - [x] To adjut filters, especially multi select filters
- [ ] To implement data upload to the database
    - [x] To make the first version 
    - [ ] To elaborate table edit processes 
        - [x] Add a function of saving table edit (preparing temporary tables)
        - [x] To open table edit page on a new tab
        - [ ] To give a warning when you browser back or close the tab
        - [ ] To display and edit table edit configurations from nav menu
- [ ] To improve table edit features
    - [ ] To add row add/delete features
        - [x] To add basic features
        - [x] To publish added/deleted/edited rows
        - [x] To isolate css 
        - [ ] To add the feature to all table types
    - [ ] To validate data type when editing
    - [x] To hover texts when you put on a cursor
    - [ ] To add search functions on each column
        - [x] Price filter
        - [x] Category filter
        - [x] Title name filter
        - [x] Multi select categorical column filter
        - [ ] To adjust an order of filtering
        - [ ] (Discussion) should table filtering implemeted as a get{} function or normal functions? 
    - [ ] To visualize edited rows
- [ ] To make it memory efficient
    - [ ] To apply and adjust "await" operators
    - [ ] To adjust lists or IQueryable to declare
    - [ ] To adjust timings to dispose db contexts
- [ ] To adjust schema
    - [ ] To implement ID handling when seeding data from csv (avoiding using csv helper)
    - [ ] To reconsider price table version data types (float or double?)
    - [ ] To reconsider dimension table id data types (int or char?)
- [ ] To implement state managers
    - [x] To implement a browser state manager
    - [ ] To implement a server-side state manager
- [ ] To implement config page (a life cycle of table edits)
    - [ ] To implement a template with browser state manager
    - [ ] To implement table version selection 
    - [ ] Disable access to some pages based on configuration
    - [ ] To implement the features above with a server-side state manager

- [ ] (Discussion) Should ProductTypeDim table be in the database or hardcoded?
- [ ] To add load messages white initializing components