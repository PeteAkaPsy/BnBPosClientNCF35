files here should end with a type corresponding to the used language inside

e.g.:
- *.zpl for Zebra Programming Language or ZPL/ZPL2
- *.esc for Epsons PoS printer Language

most of the old printers that can accept/save files as templates have the old DOS naming limitations.
this means you can use only filenames with the 8.3 scheme basically limiting the filename to max 8 characters and the extension to max 3 characters
also the files for labelprinters (e.g. ZPL) should include the label size and use in their name.
e.g.:
- D3825.zpl where D stands for default and 3825 stands for 38mm width and 25mm height
- D3825_H.zpl where the H steands for Heading. this file contains informations about the person that gets the labels for sale
- D3825_T.zpl where the T stands for Template that doesn't contain data
- D3825_D.zpl where the D stands for Data that uses the T file for printing and contains a reference to the T file

Template files are basically prepared Forms that have variables/parameters that do not hold any data and are send to the printer on startup to asure that the file is present in the printer.
Data files specify the Template file for read in the beginning and tell the printer what to fill into to variables/parameters to print
