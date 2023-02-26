# RAA_Level2
README UPDATED 2/26/2023

HI!
Welcome to my Revit Architecture Academy - Level 2 -  Repository.		

Please don’t share/distribute/alter this github without author’s permission.

  


## Items in development:

We've been developing WPF - Windows Forms/Dialogue Boxes


Challenge 1: 


Create an add-in that will help you set up a Revit project using data from a CSV file. 
The add-in will launch a WPF form that prompts the user to select a CSV file as well as some other options.
After the user clicks "OK", the add-in will read the data from the CSV file and create the specified levels using the unit type the user selected. 
Once the levels are created, the add-in will create floor plans and ceiling plans if the user checked those options in the form. 
Once complete, the add-in will alert the user to how many levels and views were created.


Challenge 2: 


View Renumberer
When the user clicks the "Select" button, the form will close and prompt the user to select the viewports in order. 
When finished, the user will click the "Escape" key. The form will then re-open and display the Element Ids of the selected views in the ListBox. 
The user will then select the view start number using the combo box. 
Upon clicking OK, the add-in will renumber the views on the sheet in the order they were selected. 
Display a TaskDialog alerting the user how many views were renumbered. 


## Upcoming Questions:

Misc:
> Want to take PyRevit Patternmaker code and pull it into this world.
> 
> Want to use Icon8 icons 96x96
> 
> Bonus lessons: upgrade to 2023, use events to manipulate controls. 
> 
> Other items: tabs in forms.
> 
> Migrate campus tools to RAA page
> > pyRevit-Master\extensions\pyRevitTools.extension\pyRevit.tab\Modify.panel\edit1.stack\Patterns.splitpushbutton\Make Pattern.pushbutton
> >

## Other Goals/Questions:
Other Goals for toolbar:

Be able to load a file path once; have it save and register “yes I have an excel file path”

Be able to run through the excel file functions with these three buttons.
  *  Make Sheets
  *  Make Views
  *  Place Views on Sheets


Prior notes on other code issues:
> Right now, the script reads the whole excel, does all the flags in sequence 
> Sheets, Views, ViewsOnSheets.

Things that don’t work:
> Setting crop boxes – finding the scope box geometry and assigning views to those. 
> Have to manually set scope boxes after Views are Made, then run the “place on sheet”.

Elevations – 
> these view have been set up manually and then set to scope boxes; 
> then the put view on sheet portion works.

Placing by Location on sheet – 
> currently is center of box coordinates. 
> So – has to have manual query/inputs after a test page is made to figure out where it’s going to land on one sheet.
> Duplicate Plan Crop region for new RCP

Error checks
> If a view already exists with a name, it won’t make it/error handling is not specific.
> If a sheet already exists with a name, it won’t make it/error handling is not specific.
> Identifying when a view template doesn’t exist – kicks out the view creation process

Misc:
> Want to make a button to change a text line item in a key schedule
> Want to make a button to load families from a folder
> Want to make a page that places Legends, scale family, north family on a series of sheets in the same locations




**REFERENCE MATERIALS for a well-designed README file:

[README](https://www.makeareadme.com/)

[MARKDOWN CHEATSHEET](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet)

