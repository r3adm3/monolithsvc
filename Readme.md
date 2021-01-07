# Monolith Service 
This service is a demonstration of moving from a monolithic code base to a more microservices based architecture. 

This is paired up with the repo: http://github.com/r3adm3/multiservice

## Compiling in Development

Clone the repo. Ensure .Net Core 3 is installed. 

```dotnetcore
dotnet run
```

Test should be able to be run using a browser, and going to http://localhost:5000

## Making a docker image

Included in the project is a Dockerfile which will create a docker image artifact, change into the source code directory and type:

```docker
docker build -t mysvc/monolith:v1 .
```

To run a container of this image:

```docker (production)
docker container run --name test_monolith -p 18080:80 mysvc/monolith:v1
```

```docker (development)
docker container run -e ASPNETCORE_ENVIRONMENT='Development' --rm --name test_monolith -p 18080:80 mysvc/monolithsvc:20
```
Test should be able to be run using a browser, and going to http://localhost:18080
