dotnet new classlib -f net8.0 -o OnlinePetAdoptingSite/Repositories
cd OnlinePetAdoptingSite
dotnet sln OnlinePetAdoptingSite.sln list
dotnet sln OnlinePetAdoptingSite.sln add Repositories/
dotnet sln OnlinePetAdoptingSite.sln list
dotnet add OnlinePetAdoptingSite reference Repositories/

