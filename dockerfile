FROM mcr.microsoft.com/dotnet/aspnet:5.0
COPY ./out App/
WORKDIR /App
ENTRYPOINT ["dotnet", "asp-core-mvc-test.dll"]