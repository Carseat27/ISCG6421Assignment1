# ISCG6421Assignment1
This project requires the file 'NZESL.mbd'. 

Before running: 

1. Save 'NZESL.mbd' to C:\\Temp\
2. Go to DataModule.Designer.cs
3. Replace lines 64-65 with: this.ctnNZESL.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Temp\"";
4. Run the program.

Note:
Future versions will include the ability to set the connection string during runtime and save a default.
