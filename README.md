# ISCG6421Assignment1
This project requires the file 'NZESL.mbd'. 

Before running: 

1. Save 'NZESL.mdb' to your computer
2. Run the program

During 1st Run:
1. The program should fail to find 'connection.txt'.
2. You will see a pop-up saying the default connection location is set to 'C:\Temp'
3. If the file 'NZESL.mdb' does not exist in 'C:\Temp' you will be asked to choose a file.
4. Failure to select a file will result in the application not showing any data.

Alternatively, before running the program, you could create a file in the installation directory called 'connection.txt' and write the location in this file. For example, the text of the 'connection.txt' file could be 'C:\Users\User1\Documents\NZESL.mdb' (without the quotation marks). If the program cannot find the file there, you will be asked to choose another location during runtime. Note that the connection must contain 'NZESL.mdb' at the end.


Notes:

-You can change the connected file during run-time by selecting "Connect to Database" on the main form. This will cause the application to restart to load the new database file correctly. 
