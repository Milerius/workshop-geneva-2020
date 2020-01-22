# Workshop part 0

For the first part of this workshop, it is simply a matter of properly configuring your project using the `dotnet` command line

## AtomicDex / MM2

- Please download the latest mm2 archive at this link: http://195.201.0.6/mm2/mm2-latest-Windows_NT.zip
- Unzip the folder
- Create a powershell script next to the mm2 executable (i named it launch.ps1) with the following content

```pwsh
 .\mm2.exe '{\"gui\": \"MM2GUI\", \"netid\":9999,\"passphrase\":\"Geneva2020Seed\",\"rpc_password\":\"your_passphrase_here\"}'
```

As shown here: https://developers.komodoplatform.com/basic-docs/atomicdex/atomicdex-tutorials/atomicdex-walkthrough.html#initiate-marketmaker-2-0 choose a password and a seed and replace it in your own script, remember the password.

- put the list of coins (file at the root of the repository) next to the mm2 executable.

You should have the following tree:

```                
.
├── mm2
│  ├── coins
│  ├── launch.ps1
│  ├── mm2-latest-Windows_NT.zip
│  ├── mm2.exe
│  ├── msvcp140.dll
│  ├── msvcr100.dll
│  ├── pthreadVC2.dll
│  └── vcruntime140.dll
├── Program.cs
├── README.md
└── WorkshopFirstPart.csproj
```

`dotnet build` and `dotnet run` should work, the last command should produce the following output:

```
PS C:\Users\romanszterg\RiderProjects\workshop-geneva-2020\AtomicDexWorkshop\WorkshopFirstPart> dotnet run
Hello World!
```

And now we are going to launch mm2, to do this we open the file explorer and launch powershell in the mm2 folder:






