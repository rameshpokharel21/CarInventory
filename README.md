
#CarInventory
Car inventory management system.
It is part of Code:You 2024 January Software Development path.
It is very basic starting to my Capstone project.

For starting, I have used Blazor QuickGrid and QuickGrid EntityFrameworkAdapter
packages to work with database directly.I will add Repository and Service classes.

I have initial seeded database for now.

Added and modified CarInventoryAdd component, it is also using interactiveserver mode.

Modified Inventory from InputText to InputSelect for options.

Fixed Edit and Delete Features(basic).
Razor pages now using service layer(which uses repository and repository uses dbcontext);

I still need to add 1. bunit testing, 2. create reusable child component CarEntityForm that 
can be used as child component for both CarInventoryAdd and InventoryEdit  page components.
3. add other search criteria components: SearchByYear, SearchByModel, SearchByMaxPrice
4. error handling and display
