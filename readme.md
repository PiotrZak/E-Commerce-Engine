1. Running API via Docker:

    -> dotnet add package Microsoft.NET.Build.Containers --version 0.3.2
    -> dotnet publish --os linux --arch x64 /t:PublishContainer -c Release
    -> docker run --name dotnetcourse -p 8080:80 -d dotnetcourse:1.0.0

2. Checking docker-network

    -> docker network ls
    -> docker network inspect dotnetcourse_my_network

3. API & Database run

    docker-compose up