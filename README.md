SimpleFileOrganiser
===================

C# GUI Tool to organise files in directories based on search terms.

The tool will take your files from the directories specfied, search for the added search terms and begin to find files matching. 

Tick the 'Output all to' checkbox to specify a directory to direct the files to - otherwise they will be sorted in their current 
directories.

Tick the '...And Sort into folders' checkbox to have the files be sorted into folders named by the search terms.

Tick the 'Folders containing' checkbox to include Folder names in directory searching.


Search terms automatically ignore case, and the following characters:
. - _

Files are marked once sorted to prevent IO errors occuring if they have already been moved.

License: MIT
Author: Christopher Gregori
