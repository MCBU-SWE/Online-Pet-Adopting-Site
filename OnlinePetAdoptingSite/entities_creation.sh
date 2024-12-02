dotnet new classlib -f net8.0 -o OnlinePetAdoptingSite/Entities
cd OnlinePetAdoptingSite
dotnet sln OnlinePetAdoptingSite.sln list
dotnet sln OnlinePetAdoptingSite.sln add Entities/
dotnet sln OnlinePetAdoptingSite.sln list
dotnet add OnlinePetAdoptingSite reference Entities/

